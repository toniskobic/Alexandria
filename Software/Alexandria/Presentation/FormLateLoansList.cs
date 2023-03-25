using Business;
using Business.Services;
using Data.Model;
using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormLateLoansList : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public FormLateLoansList()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void LateLoansListForm_Load(object sender, EventArgs e)
        {
            dataGridViewLoans.DataSource = _unitOfWork.Loans.GetAllLoans().Where(l => (DateTime.Compare(l.DateTo, DateTime.Now) <= 0) && l.Finished != true).ToList();
        }

        private void buttonWarnUser_Click(object sender, EventArgs e)
        {
            Loan selectedLoan = dataGridViewLoans.CurrentRow.DataBoundItem as Loan;

            if (selectedLoan != null)
            {
                var smtpClient = new SmtpClient("***REMOVED***")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("***REMOVED***", "***REMOVED***"),
                    EnableSsl = true,
                };

                double dueAmount = (DateTime.Now - selectedLoan.DateTo).TotalDays * 15;

                smtpClient.Send("***REMOVED***", selectedLoan.User.EMail, "Opomena Knjižnica Alexandria", $"Poštovani imate nepodmirena dugovanja. Cijena vaše zakasnine iznosi {dueAmount} HRK.");

                MessageBox.Show("Korisnik upozoren");
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#14-zakasnine-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#14-zakasnine-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
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
    }
}
