﻿using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.Entity;
using Business.Interfaces;
using Data;
using Data.Entities;
using Business.Services;

namespace Presentation.Forms
{
    public partial class FormPickingIn : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly PickingIn _newPickingIn = new PickingIn();

        public FormPickingIn()
        {
            _unitOfWork = new UnitOfWork(new AlexandriaContext());
            InitializeComponent();
        }

        private void ButtonAddLiterature_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            Author selectedAuthor = comboBoxAuthor.SelectedItem as Author;
            Category selectedCategory = comboBoxCategory.SelectedItem as Category;
            Literature literature = new Literature(title, selectedCategory, selectedAuthor);
            var newLiterature = _unitOfWork.Literatures.Add(literature);

            _newPickingIn.PickingInItem.Add(new PickingInItem
            {
                Literature = newLiterature
            });

            RefreshDataGrid();
        }

        private async Task RefreshAuthorsAsync()
        {
            comboBoxAuthor.DataSource = await _unitOfWork.Authors.GetAll().ToListAsync();
            comboBoxAuthor.DisplayMember = "FullName";
        }

        private async Task RefreshCategoriesAsync()
        {
            comboBoxCategory.DataSource = await _unitOfWork.Categories.GetAll().ToListAsync();
            comboBoxCategory.DisplayMember = "Name";
        }

        public void RefreshDataGrid()
        {
            dataGridViewPickingInItem.DataSource = null;
            dataGridViewPickingInItem.DataSource = _newPickingIn.PickingInItem;
        }

        private async void FormPickingIn_Load(object sender, EventArgs e)
        {
            //RefreshDataGrid();
            await RefreshAuthorsAsync();
            await RefreshCategoriesAsync();
        }

        private async void ButtonCreate_Click(object sender, EventArgs e)
        {
            _unitOfWork.PickingIns.Add(_newPickingIn);
            await _unitOfWork.DatabaseScope.SaveAsync();
            this.Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#5-add-literature-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#5-add-literature-");
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            UserManager.LogOut();

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "FormLogin")
                {
                    Application.OpenForms[i].Close();
                }
                else
                {
                    Application.OpenForms[i].Show();
                }
            }
        }
    }
}
