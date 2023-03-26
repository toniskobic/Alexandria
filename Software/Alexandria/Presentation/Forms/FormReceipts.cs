using System;
using System.Windows.Forms;
using System.Data.Entity;
using System.Threading.Tasks;
using Data.Entities;
using Business.Interfaces;
using Data;
using Business.Services;

namespace Presentation.Forms
{
    public partial class FormReceipts : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormReceipts()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
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
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#15-ra%C4%8Duni-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#15-ra%C4%8Duni-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private async void ReceiptBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var receipt = receiptBindingSource.Current as Receipt;
            receiptItemBindingSource.DataSource = (await _unitOfWork.Receipts.GetAll()
                .Include(x => x.ReceiptItem)
                .FirstOrDefaultAsync(x => x.Id == receipt.Id))
                .ReceiptItem;
        }
    }
}
