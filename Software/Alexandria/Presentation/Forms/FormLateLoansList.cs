using Business.Interfaces;
using Business.Services;
using Data;
using Data.Entities;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class FormLateLoansList : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormLateLoansList()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void LateLoansListForm_Load(object sender, EventArgs e)
        {
            dataGridViewLoans.DataSource =  _unitOfWork.Loans.GetAll()
                .Include(x => x.User)
                .Include(y => y.LoanItem)
                .Where(l => (DateTime.Compare(l.DateTo, DateTime.Now) <= 0) && l.Finished != true).ToList();
        }

        private void ButtonWarnUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewLoans.CurrentRow.DataBoundItem is Loan selectedLoan)
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

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
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
    }
}
