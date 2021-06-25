
namespace Pll
{
    partial class FormLiteratures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLiteratures));
            this.dataGridViewLiteratures = new System.Windows.Forms.DataGridView();
            this.buttonPickingIn = new System.Windows.Forms.Button();
            this.buttonPickingOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiteratures)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLiteratures
            // 
            this.dataGridViewLiteratures.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewLiteratures.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dataGridViewLiteratures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLiteratures.Location = new System.Drawing.Point(15, 154);
            this.dataGridViewLiteratures.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewLiteratures.Name = "dataGridViewLiteratures";
            this.dataGridViewLiteratures.RowHeadersWidth = 51;
            this.dataGridViewLiteratures.RowTemplate.Height = 24;
            this.dataGridViewLiteratures.Size = new System.Drawing.Size(770, 361);
            this.dataGridViewLiteratures.TabIndex = 0;
            // 
            // buttonPickingIn
            // 
            this.buttonPickingIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPickingIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonPickingIn.FlatAppearance.BorderSize = 0;
            this.buttonPickingIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPickingIn.ForeColor = System.Drawing.Color.LightGray;
            this.buttonPickingIn.Location = new System.Drawing.Point(824, 154);
            this.buttonPickingIn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPickingIn.Name = "buttonPickingIn";
            this.buttonPickingIn.Size = new System.Drawing.Size(161, 79);
            this.buttonPickingIn.TabIndex = 1;
            this.buttonPickingIn.Text = "Dodaj knjižnu građu";
            this.buttonPickingIn.UseVisualStyleBackColor = false;
            this.buttonPickingIn.Click += new System.EventHandler(this.buttonPickingIn_Click);
            // 
            // buttonPickingOut
            // 
            this.buttonPickingOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPickingOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonPickingOut.FlatAppearance.BorderSize = 0;
            this.buttonPickingOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPickingOut.ForeColor = System.Drawing.Color.LightGray;
            this.buttonPickingOut.Location = new System.Drawing.Point(825, 270);
            this.buttonPickingOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPickingOut.Name = "buttonPickingOut";
            this.buttonPickingOut.Size = new System.Drawing.Size(160, 79);
            this.buttonPickingOut.TabIndex = 2;
            this.buttonPickingOut.Text = "Razduži knjižnu građu";
            this.buttonPickingOut.UseVisualStyleBackColor = false;
            this.buttonPickingOut.Click += new System.EventHandler(this.buttonPickingOut_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(15, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Popis knjižne građe:";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.ForeColor = System.Drawing.Color.LightGray;
            this.buttonLogOut.Location = new System.Drawing.Point(904, 24);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(81, 45);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "Odjava";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.LightGray;
            this.buttonClose.Location = new System.Drawing.Point(19, 24);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(81, 45);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Natrag";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonAddCategory.FlatAppearance.BorderSize = 0;
            this.buttonAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCategory.ForeColor = System.Drawing.Color.LightGray;
            this.buttonAddCategory.Location = new System.Drawing.Point(312, 24);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(152, 69);
            this.buttonAddCategory.TabIndex = 13;
            this.buttonAddCategory.Text = "Dodaj kategoriju";
            this.buttonAddCategory.UseVisualStyleBackColor = false;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonAddAuthor.FlatAppearance.BorderSize = 0;
            this.buttonAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAuthor.ForeColor = System.Drawing.Color.LightGray;
            this.buttonAddAuthor.Location = new System.Drawing.Point(164, 24);
            this.buttonAddAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(126, 69);
            this.buttonAddAuthor.TabIndex = 14;
            this.buttonAddAuthor.Text = "Dodaj autora";
            this.buttonAddAuthor.UseVisualStyleBackColor = false;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.ForeColor = System.Drawing.Color.LightGray;
            this.buttonHelp.Location = new System.Drawing.Point(19, 564);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(138, 51);
            this.buttonHelp.TabIndex = 15;
            this.buttonHelp.Text = "Pomoć";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormLiteratures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPickingOut);
            this.Controls.Add(this.buttonPickingIn);
            this.Controls.Add(this.dataGridViewLiteratures);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1018, 677);
            this.Name = "FormLiteratures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knjižna građa";
            this.Load += new System.EventHandler(this.FormLiteratures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiteratures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLiteratures;
        private System.Windows.Forms.Button buttonPickingIn;
        private System.Windows.Forms.Button buttonPickingOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Button buttonHelp;
    }
}