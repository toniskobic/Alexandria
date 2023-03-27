using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Business.Interfaces;
using Business.Services;
using Data;
using Data.Entities;

namespace Presentation.Forms
{
    public partial class FormLateLoansList : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormLateLoansList()
        {
            _unitOfWork = new UnitOfWork(new AlexandriaContext());
            InitializeComponent();

            if (!CheckIfSmtpSettingsAreLoaded())
            {
                buttonWarnUser.Enabled = false;
            }
        }

        private void LateLoansListForm_Load(object sender, EventArgs e)
        {
            dataGridViewLoans.DataSource = _unitOfWork.Loans.GetAll()
                .Include(x => x.User)
                .Include(y => y.LoanItem)
                .Where(l => (DateTime.Compare(l.DateTo, DateTime.Now) <= 0) && l.Finished != true).ToList();
        }

        private void ButtonWarnUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewLoans.CurrentRow.DataBoundItem is Loan selectedLoan)
            {
                var smtpClient = new SmtpClient(Properties.Settings.Default.SmtpClient)
                {
                    Port = Properties.Settings.Default.Port,
                    Credentials = new NetworkCredential(Properties.Settings.Default.Username, Properties.Settings.Default.Password),
                    EnableSsl = Properties.Settings.Default.EnableSsl,
                };

                double dueAmount = (DateTime.Now - selectedLoan.DateTo).TotalDays * 15;
                try
                {
                    smtpClient.Send(Properties.Settings.Default.Username,
                        selectedLoan.User.EMail,
                        "Alexandria Library Notice",
                        $"Dear {selectedLoan.User.FullName}," +
                        $"\n\nYou have unpaid debts.\n\nThe price of your unpaid loan is {dueAmount}." +
                        $"\n\nSincerely,\n\nAlexandria Library");
                    MessageBox.Show("User notified!");
                }
                catch (Exception)
                {
                    MessageBox.Show("User was not notified!");
                }
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

        private bool CheckIfSmtpSettingsAreLoaded()
        {
            return !string.IsNullOrEmpty(Properties.Settings.Default.SmtpClient)
                && !string.IsNullOrEmpty(Properties.Settings.Default.Username)
                && !string.IsNullOrEmpty(Properties.Settings.Default.Password)
                && Properties.Settings.Default.Port > 0
                && Properties.Settings.Default.Port < 65535;
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
