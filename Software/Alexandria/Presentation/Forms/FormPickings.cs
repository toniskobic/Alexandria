using System;
using Data.Entities;
using System.Windows.Forms;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Linq;
using Business.Interfaces;
using Business.Services;
using Data;

namespace Presentation.Forms
{
    public partial class FormPickings : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormPickings()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private async void FormPickings_Load(object sender, EventArgs e)
        {
            textBoxLiteratureTitle.ReadOnly = true;
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
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#8-primke-i-otpremnice-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#8-primke-i-otpremnice-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void PickingInBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var pickingIn = pickingInBindingSource.Current as PickingIn;
            var pickingInItem = _unitOfWork.PickingIns.GetAll()
                .Include(u => u.PickingInItem)
                .FirstOrDefault(p => p.Id == pickingIn.Id).PickingInItem;
            pickingInItemBindingSource.DataSource = pickingInItem;
        }

        private async void DataGridViewPickingInItems_SelectionChanged(object sender, EventArgs e)
        {
            int literatureId = 0;
            if (dataGridViewPickingInItems.Rows.Count > 0)
            {
                literatureId = (int)dataGridViewPickingInItems.CurrentRow.Cells[1].Value;
            }
            if (literatureId != 0)
            {
                textBoxLiteratureTitle.Text = (await _unitOfWork.Literatures.GetAsync(literatureId)).Title;
            }
        }
    }
}
