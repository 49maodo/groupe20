using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_etudiant.Forms
{
    public partial class FormProfesseur : Form
    {
        public FormProfesseur()
        {
            InitializeComponent();
            loadProfs();
            ChargerMatiere();
            ChargerClasses();
        }
        private void loadProfs()
        {
            using (var db = new exameenEntities())
            {
                dataGridView1.DataSource = db.Professeurs
                    .Include("Matieres")
                    .ToList()
                    .Select(p => new
                    {
                        p.Id,
                        p.Nom,
                        p.Prenom,
                        p.Email,
                        p.Telephone,
                        Matieres = string.Join(", ", p.Matieres.Select(m => m.NomMatiere)),
                        Classe = string.Join(", ", p.Classes.Select(m => m.NomClasse)),
                    })
                    .ToList();
            }
        }
        private void ChargerMatiere()
        {
            using (var db = new exameenEntities())
            {
                cmbMat.DataSource = db.Matieres.ToList();
                cmbMat.DisplayMember = "NomMatiere";
                cmbMat.ValueMember = "Id";
            }
        }

        private void ChargerClasses()
        {
            using (var db = new exameenEntities())
            {
                cmbClasse.DataSource = db.Classes.ToList();
                cmbClasse.DisplayMember = "NomClasse";
                cmbClasse.ValueMember = "Id";
            }
        }
        private void addProf_Click(object sender, EventArgs e)
        {
            using (var db = new exameenEntities())
            {

                if (textNom.Text == "" || textPrenom.Text == "" || textEmail.Text == "" || textTel.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tous les champs");
                    return;
                }
                if (!Regex.IsMatch(textEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Adresse email invalide.");
                    return;
                }

                Professeurs prof = new Professeurs();
                prof.Nom = textNom.Text;
                prof.Prenom = textPrenom.Text;
                prof.Email = textEmail.Text;
                prof.Telephone = textTel.Text;
                db.Professeurs.Add(prof);
                db.SaveChanges();
                loadProfs();
            }
            MessageBox.Show("Professeur ajouté avec succès");
            loadProfs();
        }

        private void textTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAssocierCours_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && cmbMat.SelectedValue != null && cmbClasse.SelectedValue != null)
            {
                int idProf = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                int icClasse = (int)cmbClasse.SelectedValue;
                int idMatiere = (int)cmbMat.SelectedValue;

                using (var db = new exameenEntities())
                {
                    var professeur = db.Professeurs.Include("Matieres").Include("Classes").FirstOrDefault(p => p.Id == idProf);
                    var matiere = db.Matieres.FirstOrDefault(m => m.Id == idMatiere);
                    var classe = db.Classes.FirstOrDefault(c => c.Id == icClasse);

                    if (professeur != null && matiere != null && classe != null)
                    {

                        bool matièreExist = professeur.Matieres.Any(m => m.Id == idMatiere);
                        bool classeExist = professeur.Classes.Any(c => c.Id == icClasse);

                        if (!matièreExist && !classeExist)
                        {
                            professeur.Matieres.Add(matiere);
                            professeur.Classes.Add(classe);
                            db.SaveChanges();
                            MessageBox.Show("Matière et classe associées au professeur !");
                            loadProfs();
                        }
                        else
                        {
                            MessageBox.Show("Le professeur enseigne déjà cette matière ou appartient déjà à cette classe !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le professeur, la matière ou la classe sélectionnée est invalide !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un professeur, une matière et une classe.");
            }
        }
    }
}
