
namespace Bll
{
    partial class KorisniciForm
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
            this.btnOdjava = new System.Windows.Forms.Button();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnAktDeakt = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.dgvZakasnina = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClanovi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDodajClana = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakasnina)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(1037, 12);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(65, 36);
            this.btnOdjava.TabIndex = 6;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(12, 92);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.RowHeadersWidth = 51;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.Size = new System.Drawing.Size(776, 221);
            this.dgvKorisnici.TabIndex = 7;
            // 
            // btnAktDeakt
            // 
            this.btnAktDeakt.Location = new System.Drawing.Point(317, 332);
            this.btnAktDeakt.Name = "btnAktDeakt";
            this.btnAktDeakt.Size = new System.Drawing.Size(97, 43);
            this.btnAktDeakt.TabIndex = 8;
            this.btnAktDeakt.Text = "Aktiviraj / Deaktviraj";
            this.btnAktDeakt.UseVisualStyleBackColor = true;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(205, 332);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(97, 43);
            this.btnKreiraj.TabIndex = 9;
            this.btnKreiraj.Text = "Kreiraj korisnika";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(65, 36);
            this.btnNatrag.TabIndex = 10;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // dgvZakasnina
            // 
            this.dgvZakasnina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZakasnina.Location = new System.Drawing.Point(794, 91);
            this.dgvZakasnina.Name = "dgvZakasnina";
            this.dgvZakasnina.RowHeadersWidth = 51;
            this.dgvZakasnina.RowTemplate.Height = 24;
            this.dgvZakasnina.Size = new System.Drawing.Size(275, 221);
            this.dgvZakasnina.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Korisnici";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(791, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Zakasnina";
            // 
            // btnClanovi
            // 
            this.btnClanovi.Location = new System.Drawing.Point(16, 381);
            this.btnClanovi.Name = "btnClanovi";
            this.btnClanovi.Size = new System.Drawing.Size(97, 43);
            this.btnClanovi.TabIndex = 14;
            this.btnClanovi.Text = "Pregled Članova";
            this.btnClanovi.UseVisualStyleBackColor = true;
            this.btnClanovi.Click += new System.EventHandler(this.btnClanovi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 43);
            this.button1.TabIndex = 15;
            this.button1.Text = "Obriši korisnika";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDodajClana
            // 
            this.btnDodajClana.Location = new System.Drawing.Point(16, 332);
            this.btnDodajClana.Name = "btnDodajClana";
            this.btnDodajClana.Size = new System.Drawing.Size(97, 43);
            this.btnDodajClana.TabIndex = 16;
            this.btnDodajClana.Text = "Dodaj člana";
            this.btnDodajClana.UseVisualStyleBackColor = true;
            this.btnDodajClana.Click += new System.EventHandler(this.btnDodajClana_Click);
            // 
            // KorisniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 450);
            this.Controls.Add(this.btnDodajClana);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClanovi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvZakasnina);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.btnAktDeakt);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.btnOdjava);
            this.Name = "KorisniciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisnici";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakasnina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnAktDeakt;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.DataGridView dgvZakasnina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClanovi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDodajClana;
    }
}