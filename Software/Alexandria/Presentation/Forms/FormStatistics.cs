using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Threading.Tasks;
using Business.Interfaces;
using Data;
using Business.Services;

namespace Presentation.Forms
{
    public partial class FormStatistics : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormStatistics()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
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

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FormStatistics_Load(object sender, EventArgs e)
        {
            await RefreshUsersLoansCountAsync();
            await RefreshBooksLoansCountAsync();
            await RefreshAuthorsLoansCountAsync();
        }

        private async Task RefreshAuthorsLoansCountAsync()
        {
            var data = (await _unitOfWork.LoanItems.GetAll()
                .Include(li => li.Loan)
                .Include(li => li.Literature)
                .Include(li => li.Literature.Author)
                .ToListAsync())
                .GroupBy(x => x.Literature.AuthorName)
                .Select(x => new { ID = x.Key, Count = x.Count() })
                .ToList();
            chartAuthorsLoansCount.Series["Posudbe"].Points.Clear();
            chartAuthorsLoansCount.DataSource = data;
            foreach (var item in data)
            {
                chartAuthorsLoansCount.Series["Posudbe"].Points.AddXY(item.ID, item.Count);
            }
        }

        private async Task RefreshBooksLoansCountAsync()
        {
            var data = (await _unitOfWork.LoanItems.GetAll()
                .Include(li => li.Loan)
                .Include(li => li.Literature)
                .Include(li => li.Literature.Author)
                .ToListAsync())
                .GroupBy(x => x.LiteratureTitle)
                .Select(x => new { ID = x.Key, Count = x.Count() })
                .ToList();

            chartBooksLoansCount.Series["Posudbe"].Points.Clear();
            chartBooksLoansCount.DataSource = data;
            foreach (var item in data)
            {
                chartBooksLoansCount.Series["Posudbe"].Points.AddXY(item.ID, item.Count);
            }
        }

        private async Task RefreshUsersLoansCountAsync()
        {
            var data = (await _unitOfWork.Loans.GetAll()
                .Include(x => x.User)
                .Include(y => y.LoanItem)
                .ToListAsync())
                .GroupBy(x => x.Username)
                .Select(x => new { ID = x.Key, Count = x.Count() })
                .ToList();

            chartUsersLoansCount.Series["Posudbe"].Points.Clear();
            chartUsersLoansCount.Series["Posudbe"]["PointWidth"] = "0.4";
            chartUsersLoansCount.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chartUsersLoansCount.Series["Posudbe"].IsValueShownAsLabel = true;
            chartUsersLoansCount.DataSource = data;

            foreach (var item in data)
            {
                chartUsersLoansCount.Series["Posudbe"].Points.AddXY(item.ID, item.Count);
            }
        }
    }
}
