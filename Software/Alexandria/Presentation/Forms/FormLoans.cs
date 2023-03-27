using System;
using System.Collections.Generic;
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
    public partial class FormLoans : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        private FormWindowState LastWindowState { get; set; } = FormWindowState.Minimized;

        public FormLoans()
        {
            _unitOfWork = new UnitOfWork(new AlexandriaContext());
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLoans_Load(object sender, EventArgs e)
        {
            RefreshLoans();
        }

        private void RefreshLoans()
        {
            loanBindingSource.DataSource = _unitOfWork.Loans.GetAll()
                .Include(x => x.User)
                .Include(y => y.LoanItem)
                .ToList();
        }

        private void ButtonNewLoan_Click(object sender, EventArgs e)
        {
            FormNewLoan newForm = new FormNewLoan();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
            RefreshLoans();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#12-posudbe-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#12-posudbe-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ButtonLateLoansList_Click(object sender, EventArgs e)
        {
            FormLateLoansList newForm = new FormLateLoansList();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private async void ButtonReturn_Click(object sender, EventArgs e)
        {
            Loan selectedLoan = dataGridViewLoans.CurrentRow.DataBoundItem as Loan;
            if (selectedLoan.Finished == false)
            {
                selectedLoan.Finished = true;

                await _unitOfWork.Loans.UpdateAsync(selectedLoan, selectedLoan.Id);
                await _unitOfWork.DatabaseScope.SaveAsync();

                if (DateTime.Compare(selectedLoan.DateTo, DateTime.Now) <= 0)
                {
                    User user = selectedLoan.User;
                    User employee = UserManager.LoggedUser;

                    Receipt receipt = new Receipt(user, employee);

                    double dueAmount = (DateTime.Now - selectedLoan.DateTo).TotalDays * 15;

                    receipt.ReceiptItem.Add(new ReceiptItem
                    {
                        Loan = selectedLoan,
                        Money = dueAmount
                    });

                    _unitOfWork.Receipts.Add(receipt);

                    MessageBox.Show("Literature returned and receipt issued.");
                }
                else
                {
                    MessageBox.Show("Literature returned.");
                }

                await _unitOfWork.DatabaseScope.SaveAsync();

                int literatureId = selectedLoan.LoanItem.First().LiteratureId;
                Loan reservation = null;

                List<LoanItem> loanItems = await _unitOfWork.LoanItems.GetAll()
                    .Include(li => li.Loan)
                    .Include(li => li.Literature)
                    .Include(li => li.Literature.Author)
                    .Where(x => x.Literature.Id == literatureId)
                    .ToListAsync();
                List<LoanItem> reservations = loanItems.Where(x => x.Loan.Started == false).ToList();
                LoanItem reservationItems = null;

                if (reservations.Count > 0)
                {
                    DateTime lowestDateTime;
                    if (reservations.Count > 1)
                    {
                        lowestDateTime = reservations.Min(x => x.Loan.DateFrom);
                    }
                    else
                    {
                        lowestDateTime = reservations.First().Loan.DateFrom;
                    }
                    reservationItems = reservations.Find(x => x.Loan.DateFrom == lowestDateTime);
                    reservation = reservationItems.Loan;
                }

                if (CheckIfSmtpSettingsAreLoaded() && reservation != null)
                {
                    var smtpClient = new SmtpClient(Properties.Settings.Default.SmtpClient)
                    {
                        Port = Properties.Settings.Default.Port,
                        Credentials = new NetworkCredential(Properties.Settings.Default.Username, Properties.Settings.Default.Password),
                        EnableSsl = Properties.Settings.Default.EnableSsl,
                    };

                    try
                    {
                        smtpClient.Send(Properties.Settings.Default.Username, reservation.User.EMail,
                            "Alexandria Library Reservation",
                            $"Dear {selectedLoan.User.FullName}," +
                            $"\n\nReserved literature {reservationItems.Literature.Title} is available for loan." +
                            $"\n\nSincerely,\n\nAlexandria Library");
                        MessageBox.Show($"User {reservation.User.UserName} was notified about available literature.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"User {reservation.User.UserName} was not notified about available literature.");
                    }
                }

                RefreshLoans();
            }
        }

        private void LoanBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var loan = loanBindingSource.Current as Loan;
            loanItemBindingSource.DataSource = _unitOfWork.Loans.GetAll()
                .Include(x => x.LoanItem.Select(lt => lt.Literature))
                .FirstOrDefault(x => x.Id == loan.Id).LoanItem;
        }

        private void ButtonReceipts_Click(object sender, EventArgs e)
        {
            FormReceipts newForm = new FormReceipts();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
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
