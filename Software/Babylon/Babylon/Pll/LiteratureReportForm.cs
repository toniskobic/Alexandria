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
    public partial class LiteratureReportForm : Form
    {
        public LiteratureReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AppContextDataSet.Literature' table. You can move, or remove it, as needed.
            this.LiteratureTableAdapter.Fill(this.AppContextDataSet.Literature);
            // TODO: This line of code loads data into the 'AppContextDataSet.LoanItem' table. You can move, or remove it, as needed.
            this.LoanItemTableAdapter.Fill(this.AppContextDataSet.LoanItem);

            this.reportViewer1.RefreshReport();
        }
    }
}
