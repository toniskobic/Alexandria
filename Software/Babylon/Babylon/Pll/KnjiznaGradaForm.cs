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
    public partial class KnjiznaGradaForm : Form
    {
        public KnjiznaGradaForm()
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

        private void btnDodajKnjiznuGradu_Click(object sender, EventArgs e)
        {
            FormPickingIn form = new FormPickingIn();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void KnjiznaGradaForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            FormAddCategory form = new FormAddCategory();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            FormAddAuthor form = new FormAddAuthor();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
