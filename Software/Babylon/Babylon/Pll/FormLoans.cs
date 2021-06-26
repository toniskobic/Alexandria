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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void FormLoans_Load(object sender, EventArgs e)
        {
            RefreshLoans();
        }

        private void RefreshLoans()
        {
            dataGridViewLoans.DataSource = null;
            dataGridViewLoans.DataSource = _unitOfWork.Loans.GetAllLoans();
        }

        private void buttonNewLoan_Click(object sender, EventArgs e)
        {
            FormNewLoan newForm = new FormNewLoan();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
            RefreshLoans();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#13-posudbe-");

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#13-posudbe-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
