
namespace Pll
{
    partial class FormLateLoansList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLateLoansList));
            this.dataGridViewLoans = new System.Windows.Forms.DataGridView();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonWarnUser = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dateFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLoans
            // 
            this.dataGridViewLoans.AutoGenerateColumns = false;
            this.dataGridViewLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateFromDataGridViewTextBoxColumn,
            this.dateToDataGridViewTextBoxColumn});
            this.dataGridViewLoans.DataSource = this.loanBindingSource;
            this.dataGridViewLoans.Location = new System.Drawing.Point(45, 58);
            this.dataGridViewLoans.Name = "dataGridViewLoans";
            this.dataGridViewLoans.RowHeadersWidth = 51;
            this.dataGridViewLoans.RowTemplate.Height = 24;
            this.dataGridViewLoans.Size = new System.Drawing.Size(462, 328);
            this.dataGridViewLoans.TabIndex = 0;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataSource = typeof(Dll.Model.Loan);
            // 
            // buttonWarnUser
            // 
            this.buttonWarnUser.Location = new System.Drawing.Point(575, 197);
            this.buttonWarnUser.Name = "buttonWarnUser";
            this.buttonWarnUser.Size = new System.Drawing.Size(157, 52);
            this.buttonWarnUser.TabIndex = 1;
            this.buttonWarnUser.Text = "Upozori korisnika";
            this.buttonWarnUser.UseVisualStyleBackColor = true;
            this.buttonWarnUser.Click += new System.EventHandler(this.buttonWarnUser_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 26);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Natrag";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dateFromDataGridViewTextBoxColumn
            // 
            this.dateFromDataGridViewTextBoxColumn.DataPropertyName = "DateFrom";
            this.dateFromDataGridViewTextBoxColumn.HeaderText = "Datum od";
            this.dateFromDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateFromDataGridViewTextBoxColumn.Name = "dateFromDataGridViewTextBoxColumn";
            this.dateFromDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateToDataGridViewTextBoxColumn
            // 
            this.dateToDataGridViewTextBoxColumn.DataPropertyName = "DateTo";
            this.dateToDataGridViewTextBoxColumn.HeaderText = "Date do";
            this.dateToDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateToDataGridViewTextBoxColumn.Name = "dateToDataGridViewTextBoxColumn";
            this.dateToDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormLateLoansList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonWarnUser);
            this.Controls.Add(this.dataGridViewLoans);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLateLoansList";
            this.Text = "Zakasnine";
            this.Load += new System.EventHandler(this.LateLoansListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLoans;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private System.Windows.Forms.Button buttonWarnUser;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateToDataGridViewTextBoxColumn;
    }
}