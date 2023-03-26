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
    public partial class FormCreateUser : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormCreateUser()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task RefreshRoles()
        {
            comboBoxRoles.DataSource = await _unitOfWork.Roles.GetAll().ToListAsync();
            comboBoxRoles.DisplayMember = "Name";
        }

        private async void ButtonCreate_Click(object sender, EventArgs e)
        {
            string firstname = this.textBoxName.Text;
            string surname = this.textBoxSurname.Text;
            string username = this.textBoxUserName.Text;
            string password = this.textBoxPassword.Text;
            string email = this.textBoxEmail.Text;
            string phoneNumber = this.textBoxPhoneNumber.Text;
            DateTime BirthDate = this.dateTimePickerBirthDate.Value;
            Role role = comboBoxRoles.SelectedItem as Role;

            if(!ValidationService.AssertEmail(email) || !ValidationService.IsPhoneNumberValid(phoneNumber)
                || !ValidationService.AssertStringLength(firstname, 3) || !ValidationService.AssertStringLength(surname, 3)
                || !ValidationService.AssertStringLength(password, 3))
            {
                MessageBox.Show("Unesite ispravne podatke");
                return;
            }

            User newUser = new User
            {
                FirstName = firstname,
                LastName = surname,
                UserName = username,
                Password = password,
                EMail = email,
                PhoneNumber = phoneNumber,
                DateOfBirth = BirthDate,
                Role = role
            };

            _unitOfWork.Users.Add(newUser);
            await _unitOfWork.DatabaseScope.SaveAsync();
            this.Close();
        }

        private async void FormCreateUser_Load(object sender, EventArgs e)
        {
            await RefreshRoles();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#10-kreiraj-korisnika-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#10-kreiraj-korisnika-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
