
namespace Pll
{
    partial class ClanoviForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClanoviForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.txtClanDo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatumZamrzavanja = new System.Windows.Forms.TextBox();
            this.btnZamOdm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatumOdmrzavanja = new System.Windows.Forms.TextBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnPrekidClanstva = new System.Windows.Forms.Button();
            this.pbProfilna = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilna)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 192);
            this.dataGridView1.TabIndex = 0;
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
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(194, 309);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(100, 33);
            this.btnAzuriraj.TabIndex = 12;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            // 
            // txtClanDo
            // 
            this.txtClanDo.Location = new System.Drawing.Point(194, 281);
            this.txtClanDo.Name = "txtClanDo";
            this.txtClanDo.Size = new System.Drawing.Size(100, 22);
            this.txtClanDo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Član do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Datum zamrzavanja:";
            // 
            // txtDatumZamrzavanja
            // 
            this.txtDatumZamrzavanja.Enabled = false;
            this.txtDatumZamrzavanja.Location = new System.Drawing.Point(465, 282);
            this.txtDatumZamrzavanja.Name = "txtDatumZamrzavanja";
            this.txtDatumZamrzavanja.Size = new System.Drawing.Size(100, 22);
            this.txtDatumZamrzavanja.TabIndex = 18;
            // 
            // btnZamOdm
            // 
            this.btnZamOdm.Location = new System.Drawing.Point(465, 337);
            this.btnZamOdm.Name = "btnZamOdm";
            this.btnZamOdm.Size = new System.Drawing.Size(100, 46);
            this.btnZamOdm.TabIndex = 17;
            this.btnZamOdm.Text = "Zamrzni  / Odmrzni";
            this.btnZamOdm.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Datum odmrzavanja:";
            // 
            // txtDatumOdmrzavanja
            // 
            this.txtDatumOdmrzavanja.Enabled = false;
            this.txtDatumOdmrzavanja.Location = new System.Drawing.Point(465, 309);
            this.txtDatumOdmrzavanja.Name = "txtDatumOdmrzavanja";
            this.txtDatumOdmrzavanja.Size = new System.Drawing.Size(100, 22);
            this.txtDatumOdmrzavanja.TabIndex = 20;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(723, 12);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(65, 36);
            this.btnOdjava.TabIndex = 22;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnPrekidClanstva
            // 
            this.btnPrekidClanstva.Location = new System.Drawing.Point(12, 281);
            this.btnPrekidClanstva.Name = "btnPrekidClanstva";
            this.btnPrekidClanstva.Size = new System.Drawing.Size(84, 45);
            this.btnPrekidClanstva.TabIndex = 23;
            this.btnPrekidClanstva.Text = "Prekid članstva";
            this.btnPrekidClanstva.UseVisualStyleBackColor = true;
            // 
            // pbProfilna
            // 
            this.pbProfilna.Location = new System.Drawing.Point(617, 70);
            this.pbProfilna.Name = "pbProfilna";
            this.pbProfilna.Size = new System.Drawing.Size(133, 116);
            this.pbProfilna.TabIndex = 24;
            this.pbProfilna.TabStop = false;
            // 
            // ClanoviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbProfilna);
            this.Controls.Add(this.btnPrekidClanstva);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatumOdmrzavanja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatumZamrzavanja);
            this.Controls.Add(this.btnZamOdm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClanDo);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClanoviForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Članovi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.TextBox txtClanDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatumZamrzavanja;
        private System.Windows.Forms.Button btnZamOdm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatumOdmrzavanja;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnPrekidClanstva;
        private System.Windows.Forms.PictureBox pbProfilna;
    }
}