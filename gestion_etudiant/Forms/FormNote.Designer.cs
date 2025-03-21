namespace gestion_etudiant.Forms
{
    partial class FormNote
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
            this.deleteNote = new System.Windows.Forms.Button();
            this.ModifNote = new System.Windows.Forms.Button();
            this.AddNote = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEtudiants = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMatieres = new System.Windows.Forms.ComboBox();
            this.textNote = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteNote);
            this.groupBox1.Controls.Add(this.ModifNote);
            this.groupBox1.Controls.Add(this.AddNote);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(220, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // deleteNote
            // 
            this.deleteNote.Location = new System.Drawing.Point(12, 368);
            this.deleteNote.Name = "deleteNote";
            this.deleteNote.Size = new System.Drawing.Size(75, 23);
            this.deleteNote.TabIndex = 12;
            this.deleteNote.Text = "Supprimer";
            this.deleteNote.UseVisualStyleBackColor = true;
            this.deleteNote.Click += new System.EventHandler(this.deleteNote_Click);
            // 
            // ModifNote
            // 
            this.ModifNote.Location = new System.Drawing.Point(98, 326);
            this.ModifNote.Name = "ModifNote";
            this.ModifNote.Size = new System.Drawing.Size(75, 23);
            this.ModifNote.TabIndex = 11;
            this.ModifNote.Text = "Modifier";
            this.ModifNote.UseVisualStyleBackColor = true;
            this.ModifNote.Click += new System.EventHandler(this.ModifNote_Click);
            // 
            // AddNote
            // 
            this.AddNote.Location = new System.Drawing.Point(6, 326);
            this.AddNote.Name = "AddNote";
            this.AddNote.Size = new System.Drawing.Size(75, 23);
            this.AddNote.TabIndex = 10;
            this.AddNote.Text = "Ajouter";
            this.AddNote.UseVisualStyleBackColor = true;
            this.AddNote.Click += new System.EventHandler(this.AddNote_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbEtudiants);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbMatieres);
            this.panel2.Controls.Add(this.textNote);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(216, 288);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Etudiant";
            // 
            // cmbEtudiants
            // 
            this.cmbEtudiants.FormattingEnabled = true;
            this.cmbEtudiants.Location = new System.Drawing.Point(10, 127);
            this.cmbEtudiants.Name = "cmbEtudiants";
            this.cmbEtudiants.Size = new System.Drawing.Size(121, 21);
            this.cmbEtudiants.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Matiere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Note";
            // 
            // cmbMatieres
            // 
            this.cmbMatieres.FormattingEnabled = true;
            this.cmbMatieres.Location = new System.Drawing.Point(10, 65);
            this.cmbMatieres.Name = "cmbMatieres";
            this.cmbMatieres.Size = new System.Drawing.Size(121, 21);
            this.cmbMatieres.TabIndex = 11;
            // 
            // textNote
            // 
            this.textNote.Location = new System.Drawing.Point(10, 187);
            this.textNote.Multiline = true;
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(121, 28);
            this.textNote.TabIndex = 13;
            this.textNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNote_KeyPress);
            this.textNote.Validating += new System.ComponentModel.CancelEventHandler(this.textNote_Validating);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 72);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(241, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(451, 294);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // FormNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1003, 507);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormNote";
            this.Text = "FormNote";
            this.Load += new System.EventHandler(this.FormNote_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteNote;
        private System.Windows.Forms.Button ModifNote;
        private System.Windows.Forms.Button AddNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEtudiants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMatieres;
        private System.Windows.Forms.TextBox textNote;
    }
}