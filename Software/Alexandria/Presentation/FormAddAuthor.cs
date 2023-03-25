using Business;
using Business.Services;
using Data.Model;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormAddAuthor : Form
    {
        private readonly UnitOfWork _unitOfWork;
        public FormAddAuthor()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;

            Author author = new Author(firstName, lastName);
            _unitOfWork.Authors.Add(author);
            _unitOfWork.Complete();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
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
