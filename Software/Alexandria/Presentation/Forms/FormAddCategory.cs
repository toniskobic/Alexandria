using System;
using System.Windows.Forms;
using Business.Interfaces;
using Business.Services;
using Data;
using Data.Entities;

namespace Presentation.Forms
{
    public partial class FormAddCategory : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormAddCategory()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string description = richTextBoxDescription.Text;

            Category category = new Category(name, description);
            _unitOfWork.Categories.Add(category);
            await _unitOfWork.DatabaseScope.SaveAsync();
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#7-dodaj-kategoriju-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#7-dodaj-kategoriju-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
