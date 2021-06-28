using Bll;
using Bll.Services;
using Dll.Model;
using System;
using System.Data;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pll
{
    public partial class FormStatistics : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public FormStatistics()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#16-statistika-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#16-statistika-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            var data = _unitOfWork.Loans.GetLoansCount();
            dataGridView1.DataSource = data;
            chartLoansCount.Series["Count"].Points.Clear();
            chartLoansCount.DataSource = data;
            //foreach (var item in data)
            //{
            //    chartLoansCount.Series["Kolicina"].Points.AddXY(item., item.Kolicina);
            //}
        }
    }
}
