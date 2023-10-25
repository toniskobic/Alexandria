
namespace Presentation.Forms
{
    partial class FormReceipts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceipts));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewReceipts = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfIssueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewLoanItems = new System.Windows.Forms.DataGridView();
            this.loanIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.LightGray;
            this.buttonClose.Location = new System.Drawing.Point(13, 13);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(81, 45);
            this.buttonClose.TabIndex = 25;
            this.buttonClose.Text = "Back";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.ForeColor = System.Drawing.Color.LightGray;
            this.buttonLogOut.Location = new System.Drawing.Point(780, 13);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(81, 45);
            this.buttonLogOut.TabIndex = 26;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.ButtonLogOut_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.ForeColor = System.Drawing.Color.LightGray;
            this.buttonHelp.Location = new System.Drawing.Point(13, 693);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(138, 51);
            this.buttonHelp.TabIndex = 28;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(390, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 32);
            this.label4.TabIndex = 29;
            this.label4.Text = "Receipts";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Receipts:";
            // 
            // dataGridViewReceipts
            // 
            this.dataGridViewReceipts.AllowUserToAddRows = false;
            this.dataGridViewReceipts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewReceipts.AutoGenerateColumns = false;
            this.dataGridViewReceipts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dataGridViewReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateOfIssueDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn});
            this.dataGridViewReceipts.DataSource = this.receiptBindingSource;
            this.dataGridViewReceipts.Location = new System.Drawing.Point(14, 131);
            this.dataGridViewReceipts.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewReceipts.Name = "dataGridViewReceipts";
            this.dataGridViewReceipts.ReadOnly = true;
            this.dataGridViewReceipts.RowHeadersWidth = 51;
            this.dataGridViewReceipts.RowTemplate.Height = 24;
            this.dataGridViewReceipts.Size = new System.Drawing.Size(838, 257);
            this.dataGridViewReceipts.TabIndex = 30;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfIssueDataGridViewTextBoxColumn
            // 
            this.dateOfIssueDataGridViewTextBoxColumn.DataPropertyName = "DateOfIssue";
            this.dateOfIssueDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateOfIssueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfIssueDataGridViewTextBoxColumn.Name = "dateOfIssueDataGridViewTextBoxColumn";
            this.dateOfIssueDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfIssueDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataSource = typeof(Data.Entities.Receipt);
            this.receiptBindingSource.CurrentChanged += new System.EventHandler(this.ReceiptBindingSource_CurrentChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(9, 416);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Loan items:";
            // 
            // dataGridViewLoanItems
            // 
            this.dataGridViewLoanItems.AllowUserToAddRows = false;
            this.dataGridViewLoanItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewLoanItems.AutoGenerateColumns = false;
            this.dataGridViewLoanItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dataGridViewLoanItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoanItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanIdDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn});
            this.dataGridViewLoanItems.DataSource = this.receiptItemBindingSource;
            this.dataGridViewLoanItems.Location = new System.Drawing.Point(13, 458);
            this.dataGridViewLoanItems.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewLoanItems.Name = "dataGridViewLoanItems";
            this.dataGridViewLoanItems.ReadOnly = true;
            this.dataGridViewLoanItems.RowHeadersWidth = 51;
            this.dataGridViewLoanItems.RowTemplate.Height = 24;
            this.dataGridViewLoanItems.Size = new System.Drawing.Size(838, 198);
            this.dataGridViewLoanItems.TabIndex = 32;
            // 
            // loanIdDataGridViewTextBoxColumn
            // 
            this.loanIdDataGridViewTextBoxColumn.DataPropertyName = "Loan_Id";
            this.loanIdDataGridViewTextBoxColumn.HeaderText = "Loan ID";
            this.loanIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loanIdDataGridViewTextBoxColumn.Name = "loanIdDataGridViewTextBoxColumn";
            this.loanIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.loanIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.moneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.moneyDataGridViewTextBoxColumn.Width = 125;
            // 
            // receiptItemBindingSource
            // 
            this.receiptItemBindingSource.DataSource = typeof(Data.Entities.ReceiptItem);
            // 
            // FormReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(874, 757);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewLoanItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewReceipts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormReceipts";
            this.Text = "Receipts";
            this.Load += new System.EventHandler(this.FormReceipts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewReceipts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewLoanItems;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private System.Windows.Forms.BindingSource receiptItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
    }
}