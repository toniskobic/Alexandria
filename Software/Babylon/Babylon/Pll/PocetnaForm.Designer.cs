
namespace Pll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnKnjizneGrade = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnPosudbe = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(162, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alexandria";
            // 
            // btnKnjizneGrade
            // 
            this.btnKnjizneGrade.Location = new System.Drawing.Point(52, 21);
            this.btnKnjizneGrade.Name = "btnKnjizneGrade";
            this.btnKnjizneGrade.Size = new System.Drawing.Size(97, 54);
            this.btnKnjizneGrade.TabIndex = 1;
            this.btnKnjizneGrade.Text = "Knjižne građe";
            this.btnKnjizneGrade.UseVisualStyleBackColor = true;
            this.btnKnjizneGrade.Click += new System.EventHandler(this.btnKnjizneGrade_Click);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.Location = new System.Drawing.Point(181, 21);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(97, 54);
            this.btnKorisnici.TabIndex = 2;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            // 
            // btnPosudbe
            // 
            this.btnPosudbe.Location = new System.Drawing.Point(52, 112);
            this.btnPosudbe.Name = "btnPosudbe";
            this.btnPosudbe.Size = new System.Drawing.Size(97, 54);
            this.btnPosudbe.TabIndex = 3;
            this.btnPosudbe.Text = "Posudbe";
            this.btnPosudbe.UseVisualStyleBackColor = true;
            this.btnPosudbe.Click += new System.EventHandler(this.btnPosudbe_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Location = new System.Drawing.Point(184, 112);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(97, 54);
            this.btnStatistika.TabIndex = 4;
            this.btnStatistika.Text = "Statistika Knjiga";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnKnjizneGrade);
            this.groupBox1.Controls.Add(this.btnPosudbe);
            this.groupBox1.Controls.Add(this.btnStatistika);
            this.groupBox1.Controls.Add(this.btnKorisnici);
            this.groupBox1.Location = new System.Drawing.Point(12, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 183);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(193, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Statistika Članova";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PocetnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PocetnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna stranica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PocetnaForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}