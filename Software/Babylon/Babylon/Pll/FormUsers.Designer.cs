
namespace Pll
{
    partial class FormUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.btnOdjava = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.btnAktDeakt = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.dataGridViewMemberships = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.membershipBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.membershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membershipBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.membershipBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberships)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource2)).BeginInit();
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
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(566, 221);
            this.dataGridViewUsers.TabIndex = 7;
            // 
            // btnAktDeakt
            // 
            this.btnAktDeakt.Location = new System.Drawing.Point(16, 327);
            this.btnAktDeakt.Name = "btnAktDeakt";
            this.btnAktDeakt.Size = new System.Drawing.Size(119, 57);
            this.btnAktDeakt.TabIndex = 8;
            this.btnAktDeakt.Text = "Aktiviraj / Deaktviraj";
            this.btnAktDeakt.UseVisualStyleBackColor = true;
            this.btnAktDeakt.Click += new System.EventHandler(this.btnAktDeakt_Click);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(158, 327);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(116, 57);
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
            // dataGridViewMemberships
            // 
            this.dataGridViewMemberships.AutoGenerateColumns = false;
            this.dataGridViewMemberships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMemberships.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.dateFromDataGridViewTextBoxColumn,
            this.dateToDataGridViewTextBoxColumn});
            this.dataGridViewMemberships.DataSource = this.membershipBindingSource3;
            this.dataGridViewMemberships.Location = new System.Drawing.Point(624, 92);
            this.dataGridViewMemberships.Name = "dataGridViewMemberships";
            this.dataGridViewMemberships.RowHeadersWidth = 51;
            this.dataGridViewMemberships.RowTemplate.Height = 24;
            this.dataGridViewMemberships.Size = new System.Drawing.Size(459, 221);
            this.dataGridViewMemberships.TabIndex = 11;
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
            this.label2.Location = new System.Drawing.Point(621, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Članarine";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(301, 327);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(114, 57);
            this.buttonDeleteUser.TabIndex = 15;
            this.buttonDeleteUser.Text = "Obriši korisnika";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.Location = new System.Drawing.Point(624, 327);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(127, 57);
            this.buttonAddMember.TabIndex = 16;
            this.buttonAddMember.Text = "Kreiraj članarinu";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            this.buttonAddMember.Click += new System.EventHandler(this.btnDodajClana_Click);
            // 
            // membershipBindingSource3
            // 
            this.membershipBindingSource3.DataSource = typeof(Dll.Model.Membership);
            // 
            // membershipBindingSource
            // 
            this.membershipBindingSource.DataSource = typeof(Dll.Model.Membership);
            // 
            // membershipBindingSource1
            // 
            this.membershipBindingSource1.DataSource = typeof(Dll.Model.Membership);
            // 
            // membershipBindingSource2
            // 
            this.membershipBindingSource2.DataSource = typeof(Dll.Model.Membership);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 125;
            // 
            // dateFromDataGridViewTextBoxColumn
            // 
            this.dateFromDataGridViewTextBoxColumn.DataPropertyName = "DateFrom";
            this.dateFromDataGridViewTextBoxColumn.HeaderText = "DateFrom";
            this.dateFromDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateFromDataGridViewTextBoxColumn.Name = "dateFromDataGridViewTextBoxColumn";
            this.dateFromDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateToDataGridViewTextBoxColumn
            // 
            this.dateToDataGridViewTextBoxColumn.DataPropertyName = "DateTo";
            this.dateToDataGridViewTextBoxColumn.HeaderText = "DateTo";
            this.dateToDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateToDataGridViewTextBoxColumn.Name = "dateToDataGridViewTextBoxColumn";
            this.dateToDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 450);
            this.Controls.Add(this.buttonAddMember);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMemberships);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.btnAktDeakt);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.btnOdjava);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberships)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button btnAktDeakt;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.DataGridView dataGridViewMemberships;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.BindingSource membershipBindingSource;
        private System.Windows.Forms.BindingSource membershipBindingSource1;
        private System.Windows.Forms.BindingSource membershipBindingSource3;
        private System.Windows.Forms.BindingSource membershipBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateToDataGridViewTextBoxColumn;
    }
}