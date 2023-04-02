using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Threading.Tasks;
using AForge.Video.DirectShow;
using ZXing;
using Business.Interfaces;
using Business.Services;
using Data;
using Data.Entities;

namespace Presentation.Forms
{
    public partial class FormNewLoan : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private VideoCaptureDevice videoCaptureDevice;
        private FilterInfoCollection filterInfoCollection;

        public FormNewLoan()
        {
            _unitOfWork = new UnitOfWork(new AlexandriaContext());
            InitializeComponent();
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            UserManager.LogOut();

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "FormLogin")
                {
                    Application.OpenForms[i].Close();
                }
                else
                {
                    Application.OpenForms[i].Show();
                }
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FormLoans_Load(object sender, EventArgs e)
        {
            await RefreshLiteraturesAsync();
            await RefreshMembershipsAsync();
        }

        private async Task RefreshMembershipsAsync()
        {
            dataGridViewMemberships.DataSource = null;
            dataGridViewMemberships.DataSource = await _unitOfWork.Memberships.GetAll()
                .Include(u => u.User)
                .Where(x => (DateTime.Compare(x.DateTo, DateTime.Now) > 0))
                .ToListAsync();
        }

        private async Task RefreshLiteraturesAsync()
        {
            dataGridViewLiteratures.DataSource = null;
            dataGridViewLiteratures.DataSource = await _unitOfWork.Literatures.GetAll()
                .Include(u => u.Author)
                .Include(x => x.Category)
                .ToListAsync();
        }

        private async void ButtonLoanBook_Click(object sender, EventArgs e)
        {
            Membership membership = dataGridViewMemberships.CurrentRow.DataBoundItem as Membership;
            User user = membership.User;

            var literature = dataGridViewLiteratures.CurrentRow.DataBoundItem as Literature;
            await LoanABookAsync(user, literature);
            this.Close();
        }

        private void ButtonLateLoansList_Click(object sender, EventArgs e)
        {
            FormLateLoansList newForm = new FormLateLoansList();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#13-new-loan-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#13-new-loan-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ButtonScanMember_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice == null || !videoCaptureDevice.IsRunning)
            {
                TurnOnCamera();
            }
        }
        public void TurnOnCamera()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (filterInfoCollection.Count > 0)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
            }
        }
        private async void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Membership member;
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var readerResult = reader.Decode(bitmap);

            if (readerResult != null)
            {
                videoCaptureDevice.SignalToStop();
                if (int.TryParse(readerResult.ToString(), out int memberID))
                {
                    member = await _unitOfWork.Memberships.GetAsync(memberID);

                    if (member != null)
                    {
                        User user = member.User;

                        var literature = dataGridViewLiteratures.CurrentRow.DataBoundItem as Literature;
                        await LoanABookAsync(user, literature);
                        MessageBox.Show("Iskaznica je skenirana");
                    }
                }
            }
        }
        private async Task LoanABookAsync(User user, Literature literature)
        {
            bool started = true;
            if (await _unitOfWork.IsLoanedAsync(literature.Id))
            {
                started = false;
            }
            Loan loan = new Loan(user, DateTime.Now, DateTime.Now.AddDays(30), started, false);

            loan.LoanItem.Add(new LoanItem
            {
                Literature = literature,
            });
            _unitOfWork.Loans.Add(loan);
            await _unitOfWork.DatabaseScope.SaveAsync();
        }

        private void FormNewLoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
            }
        }
    }
}
