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
    public partial class KorisniciForm : Form
    {
        public KorisniciForm()
        {
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            FormCreateUser registracijaForm = new FormCreateUser();
            registracijaForm.ShowDialog();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            PocetnaForm pocetnaForm = new PocetnaForm();
            this.Hide();
            pocetnaForm.ShowDialog();
            this.Close();
        }

        private void btnClanovi_Click(object sender, EventArgs e)
        {
            ClanoviForm clanoviForm = new ClanoviForm();
            this.Hide();
            clanoviForm.ShowDialog();
            this.Close();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            PrijavaForm prijavaForm = new PrijavaForm();
            this.Hide();
            prijavaForm.ShowDialog();
            this.Close();
        }

        private void btnDodajClana_Click(object sender, EventArgs e)
        {
            DodajClanForm dodajClanForm= new DodajClanForm();
            dodajClanForm.ShowDialog();
        }
    }
}
