using Bll;
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
    public partial class KnjiznaGradaForm : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public KnjiznaGradaForm()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            PrijavaForm prijavaForm = new PrijavaForm();
            this.Hide();
            prijavaForm.ShowDialog();
            this.Close();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            PocetnaForm pocetnaForm = new PocetnaForm();
            this.Hide();
            pocetnaForm.ShowDialog();
            this.Close();
        }

        private void btnDodajKnjiznuGradu_Click(object sender, EventArgs e)
        {
            FormPickingIn form = new FormPickingIn();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void KnjiznaGradaForm_Load(object sender, EventArgs e)
        {
            dgvKnjizneGrade.DataSource = _unitOfWork.Literatures.GetAll();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            FormAddCategory form = new FormAddCategory();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            FormAddAuthor form = new FormAddAuthor();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnRazduzi_Click(object sender, EventArgs e)
        {
            Literature selectedLiterature = dgvKnjizneGrade.CurrentRow.DataBoundItem as Literature;
            if(_unitOfWork.Literatures.IsLoaned(selectedLiterature.Id))
            {
                MessageBox.Show("Knjiga je posuđena!");
                return;
            }
            if(selectedLiterature != null)
            {
                PickingOutItem newPickingOutItem = new PickingOutItem {
                    Literature = selectedLiterature
                };

                PickingOut newPickingOut = new PickingOut { 
                    PickingOutItem = new List<PickingOutItem>{ newPickingOutItem }
                };

                _unitOfWork.PickingOuts.Add(newPickingOut);
                _unitOfWork.Literatures.Delete(selectedLiterature);
                _unitOfWork.Complete();

                dgvKnjizneGrade.DataSource = null;
                dgvKnjizneGrade.DataSource = _unitOfWork.Literatures.GetAll();

            }
        }
    }
}
