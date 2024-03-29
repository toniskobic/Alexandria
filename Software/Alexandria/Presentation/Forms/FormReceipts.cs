﻿using System;
using System.Windows.Forms;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Linq;
using Data;
using Data.Entities;
using Business.Interfaces;
using Business.Services;

namespace Presentation.Forms
{
    public partial class FormReceipts : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormReceipts()
        {
            _unitOfWork = new UnitOfWork(new AlexandriaContext());
            InitializeComponent();
        }

        private async void FormReceipts_Load(object sender, EventArgs e)
        {
            await RefreshReceiptsAsync();
        }

        private async Task RefreshReceiptsAsync()
        {
            receiptBindingSource.DataSource = await _unitOfWork.Receipts.GetAll()
                .Include(x => x.User)
                .Include(x => x.Employee)
                .ToListAsync();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#15-receipts");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#15-receipts");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ReceiptBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var receipt = receiptBindingSource.Current as Receipt;
            receiptItemBindingSource.DataSource = _unitOfWork.Receipts.GetAll()
                .Include(x => x.ReceiptItem)
                .FirstOrDefault(x => x.Id == receipt.Id)
                .ReceiptItem;
        }
    }
}
