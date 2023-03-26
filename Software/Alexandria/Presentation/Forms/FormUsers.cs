using System;
using System.Windows.Forms;
using Data.Entities;
using Data;
using System.Data.Entity;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.Services;

namespace Presentation.Forms
{
    public partial class FormUsers : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormUsers()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private async void ButtonCreate_Click(object sender, EventArgs e)
        {
            FormCreateUser form = new FormCreateUser();
            this.Hide();
            form.ShowDialog();
            this.Show();
            await RefreshUsersAsync();
            await RefreshMembershipsAsync();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ButtonCreateMembership_Click(object sender, EventArgs e)
        {
            FormCreateMembership newForm = new FormCreateMembership();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
            await RefreshUsersAsync();
            await RefreshMembershipsAsync();
        }

        private async void FormUsers_Load(object sender, EventArgs e)
        {
            await RefreshUsersAsync();
            await RefreshMembershipsAsync();
        }

        private async Task RefreshUsersAsync()
        {
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = await _unitOfWork.Users.GetAll()
                .Include(u => u.Role)
                .Include(x => x.Membership)
                .ToListAsync();
        }

        private async Task RefreshMembershipsAsync()
        {
            dataGridViewMemberships.DataSource = null;
            dataGridViewMemberships.DataSource = await _unitOfWork.Memberships.GetAll().ToListAsync();
        }

        private async void ButtonActivateDeactivate_Click(object sender, EventArgs e)
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

            await _unitOfWork.Users.UpdateAsync(selectedUser, selectedUser.Id);
            await _unitOfWork.DatabaseScope.SaveAsync();

            await RefreshUsersAsync();
        }

        private async void ButtonDeleteUser_Click(object sender, EventArgs e)
        {
            User selectedUser = dataGridViewUsers.CurrentRow.DataBoundItem as User;
            _unitOfWork.Users.Delete(selectedUser);
            await _unitOfWork.DatabaseScope.SaveAsync();

            await RefreshUsersAsync();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#9-korisnici-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#9-korisnici-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            UserManager.LogOut();

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "FormLogin")
                {
                    Application.OpenForms[i].Close();
                }
                else
                {
                    Application.OpenForms[i].Show();
                }

            }
        }
    }
}
