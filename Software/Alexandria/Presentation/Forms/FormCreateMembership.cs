using System;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Interfaces;
using Business.Services;
using Data;
using Data.Entities;

namespace Presentation.Forms
{
    public partial class FormCreateMembership : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormCreateMembership()
        {
            _unitOfWork = new UnitOfWork(new AlexandriaContext());
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ButtonCreate_Click(object sender, EventArgs e)
        {
            User selectedUser = comboBoxUsers.SelectedItem as User;
            Membership existingMembership = await _unitOfWork.Memberships.FindAsync(x => x.User.Id == selectedUser.Id);

            if (existingMembership == null || (existingMembership != null && (DateTime.Compare(existingMembership.DateTo, DateTime.Now) <= 0)))
            {
                Membership newMembership = new Membership
                {
                    User = selectedUser
                };

                _unitOfWork.Memberships.Add(newMembership);

                await _unitOfWork.DatabaseScope.SaveAsync();
            }
            else
            {
                MessageBox.Show("Membership already exists for the selected user!");
            }
            this.Close();
        }

        private async void FormCreateMembership_Load(object sender, EventArgs e)
        {
            await RefreshUsers();
        }

        private async Task RefreshUsers()
        {
            comboBoxUsers.DataSource = null;
            comboBoxUsers.DataSource = await _unitOfWork.Users.GetAll().ToListAsync();

            comboBoxUsers.DisplayMember = "UserName";
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#11-create-membership-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#11-create-membership-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
