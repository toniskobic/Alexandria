using Bll.Services;
using Bll;
using System;
using Dll.Model;
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
    public partial class FormUsers : Form
    {
        private readonly UnitOfWork _unitOfWork;


        public FormUsers()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            FormCreateUser registracijaForm = new FormCreateUser();
            registracijaForm.ShowDialog();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FormMain mainForm = new FormMain();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }


        private void btnOdjava_Click(object sender, EventArgs e)
        {
            FormLogin prijavaForm = new FormLogin();
            this.Hide();
            prijavaForm.ShowDialog();
            this.Close();
        }

        private void btnDodajClana_Click(object sender, EventArgs e)
        {
            FormCreateMembership newForm= new FormCreateMembership();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
            RefreshMemberships();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            RefreshUsers();
            RefreshMemberships();
        }

        private void RefreshUsers()
        {
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = _unitOfWork.Users.GetAll();
        }

        private void RefreshMemberships()
        {
            dataGridViewMemberships.DataSource = null;
            dataGridViewMemberships.DataSource = _unitOfWork.Memberships.GetAll();
        }

        private void btnAktDeakt_Click(object sender, EventArgs e)
        {
            User selectedUser = dataGridViewUsers.CurrentRow.DataBoundItem as User;
            if (selectedUser.Locked == true)
            {
                selectedUser.Locked = false;
            }
            else
            {
                selectedUser.Locked = true;
            }

            _unitOfWork.Users.Update(selectedUser, selectedUser.Id);
            _unitOfWork.Complete();

            RefreshUsers();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            User selectedUser = dataGridViewUsers.CurrentRow.DataBoundItem as User;
            _unitOfWork.Users.Delete(selectedUser);
            _unitOfWork.Complete();

            RefreshUsers();
        }
    }
}
