
namespace Pll
{
    partial class FormLoans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoans));
            this.dataGridViewLiterature = new System.Windows.Forms.DataGridView();
            this.btnVrati = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.btnLoanBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLateLoansList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiterature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLiterature
            // 
            this.dataGridViewLiterature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLiterature.Location = new System.Drawing.Point(12, 81);
            this.dataGridViewLiterature.Name = "dataGridViewLiterature";
            this.dataGridViewLiterature.RowHeadersWidth = 51;
            this.dataGridViewLiterature.RowTemplate.Height = 24;
            this.dataGridViewLiterature.Size = new System.Drawing.Size(506, 374);
            this.dataGridViewLiterature.TabIndex = 0;
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(12, 492);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(86, 39);
            this.btnVrati.TabIndex = 1;
            this.btnVrati.Text = "Vrati";
            this.btnVrati.UseVisualStyleBackColor = true;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(723, 12);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(65, 36);
            this.btnOdjava.TabIndex = 6;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(65, 36);
            this.btnNatrag.TabIndex = 11;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Location = new System.Drawing.Point(598, 81);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.RowHeadersWidth = 51;
            this.dataGridViewMembers.RowTemplate.Height = 24;
            this.dataGridViewMembers.Size = new System.Drawing.Size(506, 374);
            this.dataGridViewMembers.TabIndex = 12;
            // 
            // btnLoanBook
            // 
            this.btnLoanBook.Location = new System.Drawing.Point(116, 492);
            this.btnLoanBook.Name = "btnLoanBook";
            this.btnLoanBook.Size = new System.Drawing.Size(86, 39);
            this.btnLoanBook.TabIndex = 13;
            this.btnLoanBook.Text = "Posudi";
            this.btnLoanBook.UseVisualStyleBackColor = true;
            this.btnLoanBook.Click += new System.EventHandler(this.btnLoanBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 15;
            // 
            // buttonLateLoansList
            // 
            this.buttonLateLoansList.Location = new System.Drawing.Point(230, 492);
            this.buttonLateLoansList.Name = "buttonLateLoansList";
            this.buttonLateLoansList.Size = new System.Drawing.Size(93, 39);
            this.buttonLateLoansList.TabIndex = 16;
            this.buttonLateLoansList.Text = "Zakasnine";
            this.buttonLateLoansList.UseVisualStyleBackColor = true;
            this.buttonLateLoansList.Click += new System.EventHandler(this.buttonLateLoansList_Click);
            // 
            // FormLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 543);
            this.Controls.Add(this.buttonLateLoansList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoanBook);
            this.Controls.Add(this.dataGridViewMembers);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.dataGridViewLiterature);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLoans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posudbe";
            this.Load += new System.EventHandler(this.PosudbeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiterature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLiterature;
        private System.Windows.Forms.Button btnVrati;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
        private System.Windows.Forms.Button btnLoanBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLateLoansList;
    }
}