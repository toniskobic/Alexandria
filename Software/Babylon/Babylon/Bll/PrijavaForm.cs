using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bll
{
    public partial class PrijavaForm : Form
    {
        public PrijavaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AppDbContext dbContext = new AppDbContext();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            //Sredit provjeru
            PocetnaForm pocetnaForm = new PocetnaForm();
            this.Hide();
            pocetnaForm.ShowDialog();
            this.Close();
        }

        private void labelZaboravljena_Click_1(object sender, EventArgs e)
        {
            ZaboravljenaForm zaboravljenaForm = new ZaboravljenaForm();
            this.Hide();
            zaboravljenaForm.ShowDialog();
            this.Close();
        }
    }
}
