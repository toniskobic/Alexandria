﻿using System;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Interfaces;
using Business.Services;
using Data;
using Data.Entities;

namespace Presentation.Forms
{
    public partial class FormLiteratures : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormLiteratures()
        {
            _unitOfWork = new UnitOfWork(new AlexandriaContext());
            InitializeComponent();
        }

        private async void FormLiteratures_Load(object sender, EventArgs e)
        {
            await RefreshLiteraturesAsync();
            RefreshPickingOutButtonStatus();
        }

        private async Task RefreshLiteraturesAsync()
        {
            dataGridViewLiteratures.DataSource = null;
            dataGridViewLiteratures.DataSource = await _unitOfWork.Literatures.GetAll()
                .Include(u => u.Author)
                .Include(x => x.Category)
                .ToListAsync();
        }

        private void RefreshPickingOutButtonStatus()
        {
            buttonPickingOut.Enabled = dataGridViewLiteratures.CurrentRow?.DataBoundItem != null;
        }

        private void ButtonAddCategory_Click(object sender, EventArgs e)
        {
            FormAddCategory form = new FormAddCategory();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void ButtonAddAuthor_Click(object sender, EventArgs e)
        {
            FormAddAuthor form = new FormAddAuthor();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private async void ButtonPickingIn_Click(object sender, EventArgs e)
        {
            FormPickingIn form = new FormPickingIn();
            this.Hide();
            form.ShowDialog();
            this.Show();
            await RefreshLiteraturesAsync();
            RefreshPickingOutButtonStatus();
        }

        private async void ButtonPickingOut_Click(object sender, EventArgs e)
        {
            Literature selectedLiterature = dataGridViewLiteratures.CurrentRow.DataBoundItem as Literature;
            if (await _unitOfWork.IsLoanedAsync(selectedLiterature.Id))
            {
                MessageBox.Show("Literature is loaned!");
                return;
            }
            if (selectedLiterature != null)
            {

                PickingOut newPickingOut = new PickingOut
                {
                    Description = $"Withdrawn, ID = {selectedLiterature.Id}, Title = {selectedLiterature.Title}"
                };

                _unitOfWork.PickingOuts.Add(newPickingOut);
                _unitOfWork.Literatures.Delete(selectedLiterature);
                await _unitOfWork.DatabaseScope.SaveAsync();

                await RefreshLiteraturesAsync();
                RefreshPickingOutButtonStatus();
            }
        }

        private void ButtonPickings_Click(object sender, EventArgs e)
        {
            FormPickings form = new FormPickings();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#4-literatures-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#4-literatures-");
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
