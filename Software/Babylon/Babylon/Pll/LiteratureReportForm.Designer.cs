
namespace Pll
{
    partial class LiteratureReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.LiteratureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AppContextDataSet = new Pll.AppContextDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LoanItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoanItemTableAdapter = new Pll.AppContextDataSetTableAdapters.LoanItemTableAdapter();
            this.LiteratureTableAdapter = new Pll.AppContextDataSetTableAdapters.LiteratureTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LiteratureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoanItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LiteratureBindingSource
            // 
            this.LiteratureBindingSource.DataMember = "Literature";
            this.LiteratureBindingSource.DataSource = this.AppContextDataSet;
            // 
            // AppContextDataSet
            // 
            this.AppContextDataSet.DataSetName = "AppContextDataSet";
            this.AppContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LiteratureBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pll.LiteratureReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // LoanItemBindingSource
            // 
            this.LoanItemBindingSource.DataMember = "LoanItem";
            this.LoanItemBindingSource.DataSource = this.AppContextDataSet;
            // 
            // LoanItemTableAdapter
            // 
            this.LoanItemTableAdapter.ClearBeforeFill = true;
            // 
            // LiteratureTableAdapter
            // 
            this.LiteratureTableAdapter.ClearBeforeFill = true;
            // 
            // LiteratureReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LiteratureReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LiteratureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoanItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LoanItemBindingSource;
        private AppContextDataSet AppContextDataSet;
        private AppContextDataSetTableAdapters.LoanItemTableAdapter LoanItemTableAdapter;
        private System.Windows.Forms.BindingSource LiteratureBindingSource;
        private AppContextDataSetTableAdapters.LiteratureTableAdapter LiteratureTableAdapter;
    }
}