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
    public partial class FormCreateMembership : Form
    {
        private readonly UnitOfWork _unitOfWork;
        public FormCreateMembership()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            User selectedUser = comboBoxUsers.SelectedItem as User;
            Membership existingMembership = _unitOfWork.Memberships.Find(x => x.User.Id == selectedUser.Id);

            if (existingMembership == null || (existingMembership != null && DateTime.Compare(existingMembership.DateFrom, DateTime.Now) > 0))
            {
                Membership newMembership = new Membership
                {
                    User = selectedUser
                };

                _unitOfWork.Memberships.Add(newMembership);
                _unitOfWork.Complete();
            }
            else 
            {
                MessageBox.Show("Članarina već postoji za odabranog korisnika!");
            }
            this.Close();
        }

        private void FormCreateMembership_Load(object sender, EventArgs e)
        {
            RefreshUsers();
        }

        private void RefreshUsers()
        {
            comboBoxUsers.DataSource = null;
            comboBoxUsers.DataSource = _unitOfWork.Users.GetAll();

            comboBoxUsers.DisplayMember = "FullName";

        }
    }
}
