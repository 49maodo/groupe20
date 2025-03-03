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
        }

        private void FormMatiere_Load(object sender, EventArgs e)
        {
            loadCours();

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
    }
}
