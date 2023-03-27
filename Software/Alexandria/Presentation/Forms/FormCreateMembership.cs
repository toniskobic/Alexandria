using Business.Interfaces;
using Business.Services;
using Data;
using Data.Entities;
using System;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#11-kreiraj-%C4%8Dlanarinu-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#11-kreiraj-%C4%8Dlanarinu-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
