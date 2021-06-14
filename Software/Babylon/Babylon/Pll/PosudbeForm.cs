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
    public partial class PosudbeForm : Form
    {
        UnitOfWork UnitOfWork = new UnitOfWork(new AppDbContext());
        public PosudbeForm()
        {
            InitializeComponent();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            PrijavaForm prijavaForm = new PrijavaForm();
            this.Hide();
            prijavaForm.ShowDialog();
            this.Close();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            PocetnaForm pocetnaForm = new PocetnaForm();
            this.Hide();
            pocetnaForm.ShowDialog();
            this.Close();
        }

        private void PosudbeForm_Load(object sender, EventArgs e)
        {
            dataGridViewLiterature.DataSource = null;
            dataGridViewLiterature.DataSource = UnitOfWork.Literatures.GetAll();
            dataGridViewMembers.DataSource = null;
            dataGridViewMembers.DataSource = UnitOfWork.Users.GetAll();
        }

        private void btnLoanBook_Click(object sender, EventArgs e)
        {
            DateTime monthFromNow = new DateTime();
            monthFromNow = DateTime.Now.AddDays(30);
            Loan loan = new Loan(dataGridViewMembers.CurrentRow.DataBoundItem as User, DateTime.Now, monthFromNow);
            UnitOfWork.Loans.Add(loan);
            LoanItem loanItem = new LoanItem(loan, dataGridViewLiterature.CurrentRow.DataBoundItem as Literature);
            UnitOfWork.LoanItems.Add(loanItem);
            UnitOfWork.Complete();
        }
    }
}
