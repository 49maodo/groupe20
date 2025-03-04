namespace gestion_etudiant.Forms
{
    partial class FormEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEtudiant));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDeleteEtu = new System.Windows.Forms.Button();
            this.btnUpdateEtu = new System.Windows.Forms.Button();
            this.btnAddEtu = new System.Windows.Forms.Button();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textAdresse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dateNais = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textMat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbTri = new System.Windows.Forms.ComboBox();
            this.cmbFiltreClasse = new System.Windows.Forms.ComboBox();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FormEtudiant";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.cmbClasse);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textTel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textAdresse);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateNais);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textPrenom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textNom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textMat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(205, 516);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion Etudiant";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteEtu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateEtu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddEtu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 389);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(201, 81);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(102, 46);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 32);
            this.button4.TabIndex = 25;
            this.button4.Text = "Ajouter";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEtu
            // 
            this.btnDeleteEtu.Location = new System.Drawing.Point(2, 46);
            this.btnDeleteEtu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteEtu.Name = "btnDeleteEtu";
            this.btnDeleteEtu.Size = new System.Drawing.Size(90, 32);
            this.btnDeleteEtu.TabIndex = 24;
            this.btnDeleteEtu.Text = "Supprimer";
            this.btnDeleteEtu.UseVisualStyleBackColor = true;
            this.btnDeleteEtu.Click += new System.EventHandler(this.btnDeleteEtu_Click);
            // 
            // btnUpdateEtu
            // 
            this.btnUpdateEtu.Location = new System.Drawing.Point(102, 10);
            this.btnUpdateEtu.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateEtu.Name = "btnUpdateEtu";
            this.btnUpdateEtu.Size = new System.Drawing.Size(90, 32);
            this.btnUpdateEtu.TabIndex = 23;
            this.btnUpdateEtu.Text = "Modifier";
            this.btnUpdateEtu.UseVisualStyleBackColor = true;
            this.btnUpdateEtu.Click += new System.EventHandler(this.btnUpdateEtu_Click);
            // 
            // btnAddEtu
            // 
            this.btnAddEtu.Location = new System.Drawing.Point(2, 10);
            this.btnAddEtu.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEtu.Name = "btnAddEtu";
            this.btnAddEtu.Size = new System.Drawing.Size(90, 32);
            this.btnAddEtu.TabIndex = 22;
            this.btnAddEtu.Text = "Ajouter";
            this.btnAddEtu.UseVisualStyleBackColor = true;
            this.btnAddEtu.Click += new System.EventHandler(this.btnAddEtu_Click);
            // 
            // cmbClasse
            // 
            this.cmbClasse.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Location = new System.Drawing.Point(2, 368);
            this.cmbClasse.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(201, 21);
            this.cmbClasse.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(2, 347);
            this.label10.Margin = new System.Windows.Forms.Padding(8);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label10.Size = new System.Drawing.Size(38, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "Classe";
            // 
            // textEmail
            // 
            this.textEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.textEmail.Location = new System.Drawing.Point(2, 327);
            this.textEmail.Margin = new System.Windows.Forms.Padding(8);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(201, 20);
            this.textEmail.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(2, 306);
            this.label9.Margin = new System.Windows.Forms.Padding(8);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label9.Size = new System.Drawing.Size(32, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Email";
            // 
            // textTel
            // 
            this.textTel.Dock = System.Windows.Forms.DockStyle.Top;
            this.textTel.Location = new System.Drawing.Point(2, 286);
            this.textTel.Margin = new System.Windows.Forms.Padding(8);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(201, 20);
            this.textTel.TabIndex = 16;
            this.textTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTel_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(2, 265);
            this.label8.Margin = new System.Windows.Forms.Padding(8);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Telephone";
            // 
            // textAdresse
            // 
            this.textAdresse.Dock = System.Windows.Forms.DockStyle.Top;
            this.textAdresse.Location = new System.Drawing.Point(2, 245);
            this.textAdresse.Margin = new System.Windows.Forms.Padding(8);
            this.textAdresse.Name = "textAdresse";
            this.textAdresse.Size = new System.Drawing.Size(201, 20);
            this.textAdresse.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(2, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(8);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Adresse";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 200);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 24);
            this.panel1.TabIndex = 12;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 6);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Homme";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(110, 6);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Femme";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(2, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(8);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Matricule";
            // 
            // dateNais
            // 
            this.dateNais.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateNais.Location = new System.Drawing.Point(2, 159);
            this.dateNais.Margin = new System.Windows.Forms.Padding(2);
            this.dateNais.Name = "dateNais";
            this.dateNais.Size = new System.Drawing.Size(201, 20);
            this.dateNais.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(2, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(8);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Date de naissance";
            // 
            // textPrenom
            // 
            this.textPrenom.Dock = System.Windows.Forms.DockStyle.Top;
            this.textPrenom.Location = new System.Drawing.Point(2, 118);
            this.textPrenom.Margin = new System.Windows.Forms.Padding(8);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(201, 20);
            this.textPrenom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(2, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(8);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prenom";
            // 
            // textNom
            // 
            this.textNom.Dock = System.Windows.Forms.DockStyle.Top;
            this.textNom.Location = new System.Drawing.Point(2, 77);
            this.textNom.Margin = new System.Windows.Forms.Padding(8);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(201, 20);
            this.textNom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(2, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label3.Size = new System.Drawing.Size(29, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom";
            // 
            // textMat
            // 
            this.textMat.Dock = System.Windows.Forms.DockStyle.Top;
            this.textMat.Location = new System.Drawing.Point(2, 36);
            this.textMat.Margin = new System.Windows.Forms.Padding(8);
            this.textMat.Name = "textMat";
            this.textMat.ReadOnly = true;
            this.textMat.Size = new System.Drawing.Size(201, 20);
            this.textMat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(2, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricule";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbTri);
            this.panel2.Controls.Add(this.cmbFiltreClasse);
            this.panel2.Controls.Add(this.txtRecherche);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(205, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(8);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(664, 75);
            this.panel2.TabIndex = 2;
            // 
            // cmbTri
            // 
            this.cmbTri.FormattingEnabled = true;
            this.cmbTri.Items.AddRange(new object[] {
            "Nom",
            "Matricule",
            "Résultats"});
            this.cmbTri.Location = new System.Drawing.Point(359, 36);
            this.cmbTri.Name = "cmbTri";
            this.cmbTri.Size = new System.Drawing.Size(121, 21);
            this.cmbTri.TabIndex = 37;
            this.cmbTri.SelectedIndexChanged += new System.EventHandler(this.cmbTri_SelectedIndexChanged);
            // 
            // cmbFiltreClasse
            // 
            this.cmbFiltreClasse.FormattingEnabled = true;
            this.cmbFiltreClasse.Location = new System.Drawing.Point(210, 35);
            this.cmbFiltreClasse.Name = "cmbFiltreClasse";
            this.cmbFiltreClasse.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltreClasse.TabIndex = 36;
            this.cmbFiltreClasse.SelectedIndexChanged += new System.EventHandler(this.cmbFiltreClasse_SelectedIndexChanged);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(21, 33);
            this.txtRecherche.Multiline = true;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(148, 24);
            this.txtRecherche.TabIndex = 34;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(205, 75);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 441);
            this.panel3.TabIndex = 3;
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
            this.dataGridView1.Size = new System.Drawing.Size(664, 441);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // FormEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 516);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEtudiant";
            this.Text = resources.GetString("$this.Text");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEtudiant_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateNais;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textAdresse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDeleteEtu;
        private System.Windows.Forms.Button btnUpdateEtu;
        private System.Windows.Forms.Button btnAddEtu;
        private System.Windows.Forms.ComboBox cmbTri;
        private System.Windows.Forms.ComboBox cmbFiltreClasse;
        private System.Windows.Forms.TextBox txtRecherche;
    }
}