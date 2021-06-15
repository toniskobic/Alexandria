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

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            FormLogin prijavaForm = new FormLogin();
            this.Hide();
            prijavaForm.ShowDialog();
            this.Close();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FormMain pocetnaForm = new FormMain();
            this.Hide();
            pocetnaForm.ShowDialog();
            this.Close();
        }

        private void PosudbeForm_Load(object sender, EventArgs e)
        {
            dataGridViewLiterature.DataSource = null;
            dataGridViewLiterature.DataSource = _unitOfWork.Literatures.GetAll();
            dataGridViewMembers.DataSource = null;
            dataGridViewMembers.DataSource = _unitOfWork.Users.GetAll();
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

        private void btnVrati_Click(object sender, EventArgs e)
        {

        }
    }
}
