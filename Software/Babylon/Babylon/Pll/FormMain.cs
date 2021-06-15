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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            if (UserManager.LoggedUser.Role.RoleName == "user")
            {
                btnKorisnici.Enabled = false;
            }
            
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            FormUsers korisniciForm = new FormUsers();
            this.Hide();
            korisniciForm.ShowDialog();
            this.Close();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            FormLogin prijavaForm = new FormLogin();
            this.Hide();
            prijavaForm.ShowDialog();
            this.Close();
        }

        private void btnKnjizneGrade_Click(object sender, EventArgs e)
        {
            FormLiteratures knjiznaGradaForm = new FormLiteratures();
            this.Hide();
            knjiznaGradaForm.ShowDialog();
            this.Close();
        }


        private void btnPosudbe_Click(object sender, EventArgs e)
        {
            FormLoans posudbeForm = new FormLoans();
            this.Hide();
            posudbeForm.ShowDialog();
            this.Close();
        }

        private void PocetnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
