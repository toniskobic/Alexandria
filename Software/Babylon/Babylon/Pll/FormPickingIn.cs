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
    public partial class FormPickingIn : Form
    {
        private readonly UnitOfWork _unitOfWork;
        private PickingIn NewPickingIn = new PickingIn();

        public FormPickingIn()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void buttonAddLiterature_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            Author selectedAuthor = comboBoxAuthor.SelectedItem as Author;
            Category selectedCategory = comboBoxCategory.SelectedItem as Category;
            Literature literature = new Literature(title, selectedCategory, selectedAuthor);
            var newLiterature = _unitOfWork.Literatures.Add(literature);
            _unitOfWork.Complete();

            NewPickingIn.PickingInItem.Add(new PickingInItem
               {
                    Literature = newLiterature
               });

            RefreshDataGrid();
        }

        private void RefreshAuthors()
        {
            comboBoxAuthor.DataSource = _unitOfWork.Authors.GetAll();
            comboBoxAuthor.DisplayMember = "FullName";
        }

        private void RefreshCategories()
        {
            comboBoxCategory.DataSource = _unitOfWork.Categories.GetAll();
            comboBoxCategory.DisplayMember = "Name";
        }

        public void RefreshDataGrid()
        {
            dataGridViewPickingInItem.DataSource = null;
            dataGridViewPickingInItem.DataSource = NewPickingIn.PickingInItem;
        }

        private void FormPickingIn_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
            RefreshAuthors();
            RefreshCategories();
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            _unitOfWork.PickingIns.Add(NewPickingIn);
            _unitOfWork.Complete();
            this.Close();
        }
    }
}
