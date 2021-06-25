using Bll.Services;
using Bll;
using Dll.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pll
{
    public partial class FormLoans : Form
    {
        private readonly UnitOfWork _unitOfWork;
        public FormLoans()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
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

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PosudbeForm_Load(object sender, EventArgs e)
        {
            dataGridViewLiterature.DataSource = null;
            dataGridViewLiterature.DataSource = _unitOfWork.Literatures.GetAll();
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = _unitOfWork.Users.GetAll();
        }

        private void btnLoanBook_Click(object sender, EventArgs e)
        {
            User user = dataGridViewLiterature.CurrentRow.DataBoundItem as User;
            var literature = dataGridViewLiterature.CurrentRow.DataBoundItem as Literature;
            Loan loan = new Loan();
            loan.User = user;
            loan.DateFrom = DateTime.Now;
            loan.DateTo = DateTime.Now.AddDays(30);

            loan.LoanItem.Add(new LoanItem
            {
                Literature = literature,
            });
            _unitOfWork.Loans.Add(loan);
            _unitOfWork.Complete();
        }

        private void buttonLateLoansList_Click(object sender, EventArgs e)
        {
            FormLateLoansList newForm = new FormLateLoansList();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#6-posudbe");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#6-posudbe");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
