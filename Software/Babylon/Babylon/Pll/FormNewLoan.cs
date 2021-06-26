﻿using Bll.Services;
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
    public partial class FormNewLoan : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public FormNewLoan()
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLoans_Load(object sender, EventArgs e)
        {
            RefreshLiteratures();
            RefreshUsers();
        }

        private void RefreshUsers()
        {
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = _unitOfWork.Users.GetAll();
        }

        private void RefreshLiteratures()
        {
            dataGridViewLiteratures.DataSource = null;
            dataGridViewLiteratures.DataSource = _unitOfWork.Literatures.GetAll();
        }

        private void btnLoanBook_Click(object sender, EventArgs e)
        {
            User user = dataGridViewUsers.CurrentRow.DataBoundItem as User;
            var literature = dataGridViewLiteratures.CurrentRow.DataBoundItem as Literature;
            Loan loan = new Loan(user, DateTime.Now, DateTime.Now.AddDays(30), true);
            //loan.User = user;
            //loan.DateFrom = DateTime.Now;
            //loan.DateTo = DateTime.Now.AddDays(30);

            loan.LoanItem.Add(new LoanItem
            {
                Literature = literature,
            });
            _unitOfWork.Loans.Add(loan);
            _unitOfWork.Complete();

            this.Close();
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
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#6-nova-posudba");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#6-nova-posudba");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
