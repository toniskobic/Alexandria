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
    public partial class FormAddCategory : Form
    {
        private readonly UnitOfWork _unitOfWork;
        public FormAddCategory()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string description = richTextBoxDescription.Text;

            Category category = new Category(name, description);
            _unitOfWork.Categories.Add(category);
            _unitOfWork.Complete();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
