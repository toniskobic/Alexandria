using Bll.Enums;
using Bll.Services;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            var result = LoginResult.Null;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (ValidationService.IsNotEmpty(username) || ValidationService.IsNotEmpty(password)) 
            {
                result = UserManager.LogInUser(username, password);

                if (result != LoginResult.Succesful)
                {
                    textBoxPassword.Clear();
                    MessageBox.Show("Prijava neuspješna!");
                }
                else 
                {
                    FormMain form = new FormMain()
                    {
                        Owner = this
                    };

                    this.Hide();
                    form.ShowDialog();
                    UserManager.LogOut();
                    this.Show();

                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                }
            
            }

        }

  
    }
}
