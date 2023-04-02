using System;
using System.Windows.Forms;
using Business.Interfaces;
using Business.Services;
using Data;
using Data.Entities;

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
            System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#6-add-author-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#6-add-author-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
     
    }
}
