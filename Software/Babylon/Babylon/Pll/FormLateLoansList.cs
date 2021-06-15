using Bll;
using Bll.Services;
using Dll.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pll
{
    public partial class FormLateLoansList : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public FormLateLoansList()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void LateLoansListForm_Load(object sender, EventArgs e)
        {
            dataGridViewLoans.DataSource = _unitOfWork.Loans.GetAll().Where(l => DateTime.Compare(l.DateTo, DateTime.Now) <= 0).ToList();
        }
        private void buttonWarnUser_Click(object sender, EventArgs e)
        {
            Loan selectedLoan = dataGridViewLoans.CurrentRow.DataBoundItem as Loan;

            if (selectedLoan != null)
            {
                var smtpClient = new SmtpClient("***REMOVED***")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("***REMOVED***", "***REMOVED***"),
                    EnableSsl = true,
                };

                double dueAmount = (selectedLoan.DateTo - DateTime.Now).TotalDays * 15;


                smtpClient.Send("***REMOVED***", selectedLoan.User.EMail, "Opomena Knjižnica Alexandria", $"Poštovani imate nepodmirena dugovanja. Cijena vašeg mangupstva iznosi {dueAmount}");
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
