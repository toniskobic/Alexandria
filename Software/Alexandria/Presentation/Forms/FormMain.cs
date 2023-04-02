using System;
using System.Windows.Forms;
using Business.Services;
using Data.Static;

namespace Presentation.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            if (UserManager.LoggedUser.Role.Name == Constants.ROLE_USER)
            {
                buttonUsers.Enabled = false;
            }
        }

        private void ButtonUsers_Click(object sender, EventArgs e)
        {
            FormUsers newForm = new FormUsers();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void ButtonLiterature_Click(object sender, EventArgs e)
        {
            FormLiteratures newForm = new FormLiteratures();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void ButtonLoans_Click(object sender, EventArgs e)
        {
            FormLoans newForm = new FormLoans();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#3-homepage");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#3-homepage");
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ButtonStatistics_Click(object sender, EventArgs e)
        {
            FormStatistics newForm = new FormStatistics();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
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
