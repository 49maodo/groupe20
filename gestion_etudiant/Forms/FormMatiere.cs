using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_etudiant.Forms
{
    public partial class FormMatiere : Form
    {
        public FormMatiere()
        {
            InitializeComponent();
            loadMatieres();
            chargerMatCmb();
        }

        private void FormMatiere_Load(object sender, EventArgs e)
        {
            loadCours();

            
        }

       
        public void chargerMatCmb()
        {
            var db = new exameenEntities();

            var matieres = db.Matieres.ToList();
            cmbMat.DataSource = matieres;
            cmbMat.DisplayMember = "NomMatiere";
            cmbMat.ValueMember = "Id";
        }
        public void loadCours()
        {
            using (var db = new exameenEntities())
            {
                var cours = db.Cours.ToList();
                cmbCours.DataSource = cours;
                cmbCours.DisplayMember = "NomCours";
                cmbCours.ValueMember = "Id";
            }
        }
        public void loadMatieres()
        {
            exameenEntities db = new exameenEntities();
            dataGridView1.DataSource = null;
            var matieres = db.Matieres
                 .Include("Cours")
            .ToList()
            .Select(m => new
            {
                m.Id,
                m.NomMatiere,
                CoursAssocies = m.Cours.Any() ? string.Join(", ", m.Cours.Select(c => c.NomCours)) : "Aucun"
            })
            .ToList();
            dataGridView1.DataSource = matieres;

        }

        private void addMatiere_Click(object sender, EventArgs e)
        {
            if (textNom.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }
            using (var db = new exameenEntities())
            {
                Matieres matiere = new Matieres();
                matiere.NomMatiere = textNom.Text;
                db.Matieres.Add(matiere);
                db.SaveChanges();
            }
            MessageBox.Show("Matière ajoutée avec succès");
            loadMatieres();
            loadCours();
            chargerMatCmb();
        }

        private void btnAssocier_Click(object sender, EventArgs e)
        {
            using (var db = new exameenEntities())
            {
                int idMatiere = (int)cmbMat.SelectedValue;
                int idCours = (int)cmbCours.SelectedValue;
                Matieres matiere = db.Matieres.FirstOrDefault(m => m.Id == idMatiere);
                Cours cours = db.Cours.FirstOrDefault(c => c.Id == idCours);
                matiere.Cours.Add(cours);
                db.SaveChanges();
            }
            MessageBox.Show("Matière associée avec succès");
            loadMatieres();
            loadCours();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textNom.Text = row.Cells["NomMatiere"].Value.ToString();

                //on recupere le cours associé
                string coursAssocies = row.Cells["CoursAssocies"].Value.ToString();
                string[] cours = coursAssocies.Split(',');
                foreach (var item in cours)
                {
                    cmbCours.Text = item;
                }
                cmbCours.Text = coursAssocies;
                cmbMat.Enabled = false;

                btnAssocier.Enabled = false;

                DeleteMat.Enabled = true;
                ModifMat.Enabled = true;
                addMatiere.Enabled = false;
            }
        }
       
        private void ModifMat_Click(object sender, EventArgs e)
        {
            using(var db = new exameenEntities())
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                Matieres matiere = db.Matieres.FirstOrDefault(m => m.Id == id);
                matiere.NomMatiere = textNom.Text;
                db.SaveChanges();
            }
            MessageBox.Show("Matière modifiée avec succès");
            loadMatieres();
            chargerMatCmb();
            textNom.Text = "";
            DeleteMat.Enabled = false;
            ModifMat.Enabled = false;
            addMatiere.Enabled = true;
        }

        private void textNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DeleteMat_Click(object sender, EventArgs e)
        {
            using(var db = new exameenEntities())
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                Matieres matiere = db.Matieres
                    .Include("Cours")
                    .FirstOrDefault(m => m.Id == id);
                if (matiere != null)
                {
                    matiere.Cours.Clear();
                    db.SaveChanges();
                }
                db.Matieres.Remove(matiere);
                db.SaveChanges();
            }
            MessageBox.Show("Matière supprimée avec succès");
            loadMatieres();
            chargerMatCmb();
        }

        private void ModifAssoce_Click(object sender, EventArgs e)
        {
            using(var db = new exameenEntities())
            {
                int idMatiere = (int)cmbMat.SelectedValue;
                int idCours = (int)cmbCours.SelectedValue;
                Matieres matiere = db.Matieres.FirstOrDefault(m => m.Id == idMatiere);
                Cours cours = db.Cours.FirstOrDefault(c => c.Id == idCours);
                matiere.Cours.Add(cours);
                db.SaveChanges();
            }
            MessageBox.Show("Association modifiée avec succès");
            loadMatieres();
            loadCours();
            cmbMat.Enabled = true;
            btnAssocier.Enabled = true;
        }

        
    }
}
