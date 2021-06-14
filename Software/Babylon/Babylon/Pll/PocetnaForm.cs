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
    public partial class PocetnaForm : Form
    {
        public PocetnaForm()
        {
            InitializeComponent();
            if (UserManager.LoggedUser.Role.RoleName == "user")
            {
                btnKorisnici.Enabled = false;
            }
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            KorisniciForm korisniciForm = new KorisniciForm();
            this.Hide();
            korisniciForm.ShowDialog();
            this.Close();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            PrijavaForm prijavaForm = new PrijavaForm();
            this.Hide();
            prijavaForm.ShowDialog();
            this.Close();
        }

        private void btnKnjizneGrade_Click(object sender, EventArgs e)
        {
            KnjiznaGradaForm knjiznaGradaForm = new KnjiznaGradaForm();
            this.Hide();
            knjiznaGradaForm.ShowDialog();
            this.Close();
        }


        private void btnPosudbe_Click(object sender, EventArgs e)
        {
            PosudbeForm posudbeForm = new PosudbeForm();
            this.Hide();
            posudbeForm.ShowDialog();
            this.Close();
        }

        private void PocetnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
