
namespace Bll
{
    partial class PocetnaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnKnjizneGrade = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnPosudbe = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(157, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alexandria";
            // 
            // btnKnjizneGrade
            // 
            this.btnKnjizneGrade.Location = new System.Drawing.Point(103, 135);
            this.btnKnjizneGrade.Name = "btnKnjizneGrade";
            this.btnKnjizneGrade.Size = new System.Drawing.Size(97, 54);
            this.btnKnjizneGrade.TabIndex = 1;
            this.btnKnjizneGrade.Text = "Knjižne građe";
            this.btnKnjizneGrade.UseVisualStyleBackColor = true;
            this.btnKnjizneGrade.Click += new System.EventHandler(this.btnKnjizneGrade_Click);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.Location = new System.Drawing.Point(249, 135);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(97, 54);
            this.btnKorisnici.TabIndex = 2;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            // 
            // btnPosudbe
            // 
            this.btnPosudbe.Location = new System.Drawing.Point(103, 226);
            this.btnPosudbe.Name = "btnPosudbe";
            this.btnPosudbe.Size = new System.Drawing.Size(97, 54);
            this.btnPosudbe.TabIndex = 3;
            this.btnPosudbe.Text = "Posudbe";
            this.btnPosudbe.UseVisualStyleBackColor = true;
            this.btnPosudbe.Click += new System.EventHandler(this.btnPosudbe_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Location = new System.Drawing.Point(249, 226);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(97, 54);
            this.btnStatistika.TabIndex = 4;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(400, 12);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(65, 36);
            this.btnOdjava.TabIndex = 5;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // PocetnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnPosudbe);
            this.Controls.Add(this.btnKorisnici);
            this.Controls.Add(this.btnKnjizneGrade);
            this.Controls.Add(this.label1);
            this.Name = "PocetnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna stranica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKnjizneGrade;
        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnPosudbe;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Button btnOdjava;
    }
}