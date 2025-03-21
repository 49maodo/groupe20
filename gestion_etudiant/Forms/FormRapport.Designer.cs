namespace gestion_etudiant.Forms
{
    partial class FormRapport
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFiltreClasse = new System.Windows.Forms.ComboBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.btnRapport = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRapportClass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTopEtu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTop = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(592, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Relevés de notes d’un étudiant";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(588, 258);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtId);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtRecherche);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.cmbFiltreClasse);
            this.flowLayoutPanel1.Controls.Add(this.txtMat);
            this.flowLayoutPanel1.Controls.Add(this.btnRapport);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(588, 78);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtId.Location = new System.Drawing.Point(8, 9);
            this.txtId.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(61, 20);
            this.txtId.TabIndex = 7;
            this.txtId.Visible = false;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(85, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(134, 8);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(133, 20);
            this.txtRecherche.TabIndex = 1;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(283, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Classe";
            // 
            // cmbFiltreClasse
            // 
            this.cmbFiltreClasse.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbFiltreClasse.FormattingEnabled = true;
            this.cmbFiltreClasse.Location = new System.Drawing.Point(341, 8);
            this.cmbFiltreClasse.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cmbFiltreClasse.Name = "cmbFiltreClasse";
            this.cmbFiltreClasse.Size = new System.Drawing.Size(133, 21);
            this.cmbFiltreClasse.TabIndex = 3;
            this.cmbFiltreClasse.TextChanged += new System.EventHandler(this.cmbClasse_TextChanged);
            // 
            // txtMat
            // 
            this.txtMat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMat.Location = new System.Drawing.Point(8, 47);
            this.txtMat.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtMat.Name = "txtMat";
            this.txtMat.ReadOnly = true;
            this.txtMat.Size = new System.Drawing.Size(125, 20);
            this.txtMat.TabIndex = 8;
            // 
            // btnRapport
            // 
            this.btnRapport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRapport.Location = new System.Drawing.Point(149, 45);
            this.btnRapport.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnRapport.Name = "btnRapport";
            this.btnRapport.Size = new System.Drawing.Size(145, 22);
            this.btnRapport.TabIndex = 4;
            this.btnRapport.Text = "Generer Rapport";
            this.btnRapport.UseVisualStyleBackColor = true;
            this.btnRapport.Click += new System.EventHandler(this.btnRapport_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(592, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Liste des étudiants par classe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(2, 61);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(588, 277);
            this.dataGridView2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRapportClass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbClasse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 59);
            this.panel1.TabIndex = 0;
            // 
            // btnRapportClass
            // 
            this.btnRapportClass.Location = new System.Drawing.Point(429, 19);
            this.btnRapportClass.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnRapportClass.Name = "btnRapportClass";
            this.btnRapportClass.Size = new System.Drawing.Size(130, 22);
            this.btnRapportClass.TabIndex = 6;
            this.btnRapportClass.Text = "Generer Rapport";
            this.btnRapportClass.UseVisualStyleBackColor = true;
            this.btnRapportClass.Click += new System.EventHandler(this.btnRapportClass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Classe";
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Location = new System.Drawing.Point(67, 19);
            this.cmbClasse.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(158, 21);
            this.cmbClasse.TabIndex = 5;
            this.cmbClasse.TextChanged += new System.EventHandler(this.cmbClasse_TextChanged_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(592, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Liste des meilleurs étudiants par classe";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(2, 61);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(588, 277);
            this.dataGridView3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTopEtu);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbTop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 59);
            this.panel2.TabIndex = 1;
            // 
            // btnTopEtu
            // 
            this.btnTopEtu.Location = new System.Drawing.Point(436, 19);
            this.btnTopEtu.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnTopEtu.Name = "btnTopEtu";
            this.btnTopEtu.Size = new System.Drawing.Size(130, 22);
            this.btnTopEtu.TabIndex = 6;
            this.btnTopEtu.Text = "Generer Rapport";
            this.btnTopEtu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Classe";
            // 
            // cmbTop
            // 
            this.cmbTop.FormattingEnabled = true;
            this.cmbTop.Items.AddRange(new object[] {
            "Meilleurs etudiants"});
            this.cmbTop.Location = new System.Drawing.Point(67, 19);
            this.cmbTop.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cmbTop.Name = "cmbTop";
            this.cmbTop.Size = new System.Drawing.Size(146, 21);
            this.cmbTop.TabIndex = 5;
            this.cmbTop.SelectedIndexChanged += new System.EventHandler(this.cmbTop_SelectedIndexChanged);
            // 
            // FormRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormRapport";
            this.Text = "FormRapport";
            this.Load += new System.EventHandler(this.FormRapport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFiltreClasse;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.Button btnRapport;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTop;
        private System.Windows.Forms.Button btnRapportClass;
        private System.Windows.Forms.Button btnTopEtu;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtMat;
    }
}