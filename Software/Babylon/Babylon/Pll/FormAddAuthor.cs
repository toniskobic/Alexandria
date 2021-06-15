using Bll;
using Bll.Enums;
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
    }
}
