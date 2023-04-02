using System;
using System.Windows.Forms;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Linq;
using Business.Interfaces;
using Business.Services;
using Data;
using Data.Entities;

namespace Presentation.Forms
{
    public partial class FormPickings : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormPickings()
        {
            _unitOfWork = new UnitOfWork(new AlexandriaContext());
            InitializeComponent();
        }

        private async void FormPickings_Load(object sender, EventArgs e)
        {
            await RefreshPickingsInAsync();
            await RefreshPickingsOutAsync();
        }

        private async Task RefreshPickingsOutAsync()
        {
            dataGridViewPickingsOut.DataSource = null;
            dataGridViewPickingsOut.DataSource = await _unitOfWork.PickingOuts.GetAll().ToListAsync();
        }

        private async Task RefreshPickingsInAsync()
        {
            pickingInBindingSource.DataSource = await _unitOfWork.PickingIns.GetAll()
                .Include(u => u.PickingInItem)
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
            System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#8-pickings-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/tskobic/Alexandria/wiki/User-Manual#8-pickings-");
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void PickingInBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var pickingIn = pickingInBindingSource.Current as PickingIn;
            var pickingInItem = _unitOfWork.PickingIns.GetAll()
                .Include(u => u.PickingInItem.Select(pi => pi.Literature))
                .FirstOrDefault(p => p.Id == pickingIn.Id).PickingInItem;
            pickingInItemBindingSource.DataSource = pickingInItem;
        }
    }
}
