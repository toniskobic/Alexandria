using Bll;
using Bll.Services;
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
    public partial class FormCreateUser : Form
    {
        private readonly UnitOfWork _unitOfWork;
        public FormCreateUser()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrirajSe_Click(object sender, EventArgs e)
        {
            string username = this.textBoxName.Text;
            string surname = this.textBoxSurname.Text;
            string password = this.textBoxPassword.Text;
            string email = this.textBoxEmail.Text;
            string phoneNumber = this.textBoxPhoneNumber.Text;
            DateTime BirthDate = this.dateTimePickerBirthDate.Value;

            if(!ValidationService.AssertEmail(email) || !ValidationService.IsPhoneNumberValid(phoneNumber)
                || !ValidationService.AssertStringLenght(username, 3) || !ValidationService.AssertStringLenght(surname, 3)
                || !ValidationService.AssertStringLenght(password, 3))
            {
                MessageBox.Show("Unesite ispravne podatke");
                return;
            }

            User newUser = new User
            {
                FirstName = username,
                LastName = surname,
                Password = password,
                EMail = email,
                PhoneNumber = phoneNumber,
                DateOfBirth = BirthDate
            };

            _unitOfWork.Users.Add(newUser);
            _unitOfWork.Complete();
            this.Close();
        }
    }
}
