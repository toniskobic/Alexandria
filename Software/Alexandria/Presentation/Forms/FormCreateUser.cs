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
    public partial class FormCreateUser : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormCreateUser()
        {
            _unitOfWork = new UnitOfWork(new AlexandriaContext());
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

            if (!ValidationService.AssertEmail(email) || !ValidationService.IsPhoneNumberValid(phoneNumber)
                || !ValidationService.AssertStringLength(firstname, 3) || !ValidationService.AssertStringLength(surname, 3)
                || !ValidationService.AssertStringLength(username, 3) || !ValidationService.AssertStringLength(password, 3))
            {
                MessageBox.Show("Invalid data!");
                return;
            }

            var user = await _unitOfWork.Users.GetAll().FirstOrDefaultAsync(u => u.UserName == username || u.EMail == email);
            if (user != null)
            {
                var message = user.UserName == username ?
                    (user.EMail == email ? "User with entered username and e-mail already exists!" : "Username taken!")
                    : "User with entered e-mail already exists!";
                MessageBox.Show(message);
            }

            var salt = UserManager.CreateSalt();
            var hash = UserManager.HashPasword(password, salt);

            User newUser = new User
            {
                FirstName = firstname,
                LastName = surname,
                UserName = username,
                PasswordHash = hash,
                PasswordSalt = salt,
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
            System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#10-create-user-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#10-create-user-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
