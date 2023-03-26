using Business.Interfaces;
using Business.Services;
using Data;
using Data.Entities;
using System;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class FormAddAuthor : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormAddAuthor()
        {
            _unitOfWork = new UnitOfWork(new AlexandriaContext());
            InitializeComponent();
        }

        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;

            Author author = new Author(firstName, lastName);
            _unitOfWork.Authors.Add(author);
            await _unitOfWork.DatabaseScope.SaveAsync();
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#6-dodaj-autora-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#6-dodaj-autora-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
     
    }
}
