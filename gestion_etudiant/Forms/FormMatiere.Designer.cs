namespace gestion_etudiant.Forms
{
    partial class FormMatiere
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ModifAssoce = new System.Windows.Forms.Button();
            this.btnAssocier = new System.Windows.Forms.Button();
            this.cmbMat = new System.Windows.Forms.ComboBox();
            this.cmbCours = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DeleteMat = new System.Windows.Forms.Button();
            this.ModifMat = new System.Windows.Forms.Button();
            this.addMatiere = new System.Windows.Forms.Button();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ModifAssoce);
            this.groupBox1.Controls.Add(this.btnAssocier);
            this.groupBox1.Controls.Add(this.cmbMat);
            this.groupBox1.Controls.Add(this.cmbCours);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(238, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion Matiere";
            // 
            // ModifAssoce
            // 
            this.ModifAssoce.Location = new System.Drawing.Point(132, 365);
            this.ModifAssoce.Name = "ModifAssoce";
            this.ModifAssoce.Size = new System.Drawing.Size(75, 23);
            this.ModifAssoce.TabIndex = 12;
            this.ModifAssoce.Text = "Modif";
            this.ModifAssoce.UseVisualStyleBackColor = true;
            this.ModifAssoce.Click += new System.EventHandler(this.ModifAssoce_Click);
            // 
            // btnAssocier
            // 
            this.btnAssocier.Location = new System.Drawing.Point(13, 365);
            this.btnAssocier.Name = "btnAssocier";
            this.btnAssocier.Size = new System.Drawing.Size(75, 23);
            this.btnAssocier.TabIndex = 11;
            this.btnAssocier.Text = "Associer";
            this.btnAssocier.UseVisualStyleBackColor = true;
            this.btnAssocier.Click += new System.EventHandler(this.btnAssocier_Click);
            // 
            // cmbMat
            // 
            this.cmbMat.FormattingEnabled = true;
            this.cmbMat.Location = new System.Drawing.Point(10, 321);
            this.cmbMat.Name = "cmbMat";
            this.cmbMat.Size = new System.Drawing.Size(121, 21);
            this.cmbMat.TabIndex = 10;
            // 
            // cmbCours
            // 
            this.cmbCours.FormattingEnabled = true;
            this.cmbCours.Location = new System.Drawing.Point(8, 277);
            this.cmbCours.Name = "cmbCours";
            this.cmbCours.Size = new System.Drawing.Size(121, 21);
            this.cmbCours.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Association";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DeleteMat);
            this.panel3.Controls.Add(this.ModifMat);
            this.panel3.Controls.Add(this.addMatiere);
            this.panel3.Controls.Add(this.textNom);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8);
            this.panel3.Size = new System.Drawing.Size(234, 206);
            this.panel3.TabIndex = 0;
            // 
            // DeleteMat
            // 
            this.DeleteMat.Location = new System.Drawing.Point(49, 128);
            this.DeleteMat.Name = "DeleteMat";
            this.DeleteMat.Size = new System.Drawing.Size(75, 23);
            this.DeleteMat.TabIndex = 7;
            this.DeleteMat.Text = "Supprimer";
            this.DeleteMat.UseVisualStyleBackColor = true;
            this.DeleteMat.Click += new System.EventHandler(this.DeleteMat_Click);
            // 
            // ModifMat
            // 
            this.ModifMat.Location = new System.Drawing.Point(90, 72);
            this.ModifMat.Name = "ModifMat";
            this.ModifMat.Size = new System.Drawing.Size(75, 23);
            this.ModifMat.TabIndex = 6;
            this.ModifMat.Text = "Modifier";
            this.ModifMat.UseVisualStyleBackColor = true;
            this.ModifMat.Click += new System.EventHandler(this.ModifMat_Click);
            // 
            // addMatiere
            // 
            this.addMatiere.Location = new System.Drawing.Point(8, 72);
            this.addMatiere.Name = "addMatiere";
            this.addMatiere.Size = new System.Drawing.Size(75, 23);
            this.addMatiere.TabIndex = 5;
            this.addMatiere.Text = "Ajouter";
            this.addMatiere.UseVisualStyleBackColor = true;
            this.addMatiere.Click += new System.EventHandler(this.addMatiere_Click);
            // 
            // textNom
            // 
            this.textNom.Dock = System.Windows.Forms.DockStyle.Top;
            this.textNom.Location = new System.Drawing.Point(8, 21);
            this.textNom.Margin = new System.Windows.Forms.Padding(2);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(218, 20);
            this.textNom.TabIndex = 1;
            this.textNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNom_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Matiere";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(238, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 67);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(238, 67);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 388);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(634, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // FormMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMatiere";
            this.Text = "FormMatiere";
            this.Load += new System.EventHandler(this.FormMatiere_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addMatiere;
        private System.Windows.Forms.Button btnAssocier;
        private System.Windows.Forms.ComboBox cmbMat;
        private System.Windows.Forms.ComboBox cmbCours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteMat;
        private System.Windows.Forms.Button ModifMat;
        private System.Windows.Forms.Button ModifAssoce;
    }
}