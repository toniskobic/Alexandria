
namespace Bll
{
    partial class KnjiznaGradaForm
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
            this.dgvKnjizneGrade = new System.Windows.Forms.DataGridView();
            this.btnDodajKnjiznuGradu = new System.Windows.Forms.Button();
            this.btnRazduzi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjizneGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKnjizneGrade
            // 
            this.dgvKnjizneGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjizneGrade.Location = new System.Drawing.Point(12, 123);
            this.dgvKnjizneGrade.Name = "dgvKnjizneGrade";
            this.dgvKnjizneGrade.RowHeadersWidth = 51;
            this.dgvKnjizneGrade.RowTemplate.Height = 24;
            this.dgvKnjizneGrade.Size = new System.Drawing.Size(616, 289);
            this.dgvKnjizneGrade.TabIndex = 0;
            // 
            // btnDodajKnjiznuGradu
            // 
            this.btnDodajKnjiznuGradu.Location = new System.Drawing.Point(702, 94);
            this.btnDodajKnjiznuGradu.Name = "btnDodajKnjiznuGradu";
            this.btnDodajKnjiznuGradu.Size = new System.Drawing.Size(86, 63);
            this.btnDodajKnjiznuGradu.TabIndex = 1;
            this.btnDodajKnjiznuGradu.Text = "Dodaj knjižnu građu";
            this.btnDodajKnjiznuGradu.UseVisualStyleBackColor = true;
            // 
            // btnRazduzi
            // 
            this.btnRazduzi.Location = new System.Drawing.Point(702, 163);
            this.btnRazduzi.Name = "btnRazduzi";
            this.btnRazduzi.Size = new System.Drawing.Size(85, 63);
            this.btnRazduzi.TabIndex = 2;
            this.btnRazduzi.Text = "Razduži knjižnu građu";
            this.btnRazduzi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Popis knjižnih građi:";
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(723, 19);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(65, 36);
            this.btnOdjava.TabIndex = 6;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 63);
            this.button1.TabIndex = 7;
            this.button1.Text = "Posudi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(15, 19);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(65, 36);
            this.btnNatrag.TabIndex = 12;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // KnjiznaGradaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRazduzi);
            this.Controls.Add(this.btnDodajKnjiznuGradu);
            this.Controls.Add(this.dgvKnjizneGrade);
            this.Name = "KnjiznaGradaForm";
            this.Text = "Knjižne građe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjizneGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKnjizneGrade;
        private System.Windows.Forms.Button btnDodajKnjiznuGradu;
        private System.Windows.Forms.Button btnRazduzi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNatrag;
    }
}