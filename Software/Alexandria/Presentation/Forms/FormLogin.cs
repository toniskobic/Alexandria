using System;
using System.Windows.Forms;
using Business.Enums;
using Business.Services;
using Data.Static;

namespace Presentation.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (ValidationService.IsNotEmpty(username) || ValidationService.IsNotEmpty(password))
            {
                LoginResult result = await UserManager.LogInUserAsync(username, password);

                if (result != LoginResult.Succesful)
                {
                    textBoxPassword.Clear();
                    MessageBox.Show("Login failed!");
                }
                else if (UserManager.LoggedUser.Role.Name != Constants.ROLE_MEMBER)
                {

                    FormMain form = new FormMain()
                    {
                        Owner = this
                    };

                    this.Hide();
                    form.ShowDialog();
                    UserManager.LogOut();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Login failed!");
                }

                textBoxUsername.Clear();
                textBoxPassword.Clear();
            }
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#2-prijava");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#2-prijava");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
