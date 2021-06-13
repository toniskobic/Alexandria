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
    public partial class DodajClanForm : Form
    {
        private readonly UnitOfWork _unitOfWork;
        public DodajClanForm()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            KorisniciForm korisniciForm= new KorisniciForm();
            this.Hide();
            korisniciForm.ShowDialog();
            this.Close();
        }

        private void btnRegistrirajSe_Click(object sender, EventArgs e)
        {
            _unitOfWork.Users.Add(new User());
            _unitOfWork.Complete();
        }
    }
}
