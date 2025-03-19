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
    public partial class FormEtudiant : Form
    {
        public FormEtudiant()
        {
            InitializeComponent();
            //loadEtudiant();
        }

        private void FormEtudiant_Load_1(object sender, EventArgs e)
        {
            ChargerClasses();
            ChargerFiltreClasses();
            TrierEtudiants();
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

        public void loadEtudiant()
        {
            exameenEntities db = new exameenEntities();
            dataGridView1.DataSource = null;
            var etudiants = db.Etudiants
          .Select(e => new
          {
              e.Id,
              e.Matricule,
              e.Nom,
              e.Prenom,
              e.DateNaissance,
              e.Sexe,
              e.Adresse,
              e.Email,
              e.Telephone,
              Classe = e.Classes.NomClasse
          })
            .ToList();
            dataGridView1.DataSource = etudiants;

        }
        private string GenerateMatricule(string nom, int id)
        {
            return $"ETU{nom.ToUpper()}{id}";
        }
        private void ViderChamps()
        {
            textNom.Clear();
            textPrenom.Clear();
            dateNais.Value = DateTime.Now;
            textTel.Clear();
            cmbClasse.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            idEtudiantSelectionne = 0;
        }


        private void btnAddEtu_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Adresse email invalide.");
                return;
            }

            if (textTel.Text.Length != 9)
            {
                MessageBox.Show("Numéro de téléphone invalide.");
                return;
            }

            using (var db = new exameenEntities())
            {

                int nextId = db.Etudiants.Any() ? db.Etudiants.Max(n => n.Id) + 1 : 1;
                string matricule = GenerateMatricule(textNom.Text, nextId);

                Etudiants etudiant = new Etudiants
                {
                    Nom = textNom.Text,
                    Prenom = textPrenom.Text,
                    DateNaissance = dateNais.Value,
                    Adresse = textAdresse.Text,
                    Email = textEmail.Text,
                    Telephone = textTel.Text,
                    Sexe = radioButton1.Checked ? "M" : "F",
                    IdClasse = (int)cmbClasse.SelectedValue,
                    Matricule = matricule
                };

                db.Etudiants.Add(etudiant);
                db.SaveChanges();
            }

            MessageBox.Show("Étudiant ajouté avec succès !");
            loadEtudiant();
            ViderChamps();
        }

        private int idEtudiantSelectionne = 0;

       

        private void textTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUpdateEtu_Click(object sender, EventArgs e)
        {
            if (idEtudiantSelectionne == 0)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant !");
                return;
            }

            using (var db = new exameenEntities())
            {
                var etudiant = db.Etudiants.FirstOrDefault(m => m.Id == idEtudiantSelectionne);
                if (etudiant != null)
                {
                    etudiant.Nom = textNom.Text;
                    etudiant.Prenom = textPrenom.Text;
                    etudiant.DateNaissance = dateNais.Value;
                    etudiant.Telephone = textTel.Text;
                    etudiant.Adresse = textAdresse.Text;
                    etudiant.IdClasse = (int)cmbClasse.SelectedValue;
                    etudiant.Sexe = radioButton1.Checked ? "M" : "F";
                    etudiant.Matricule = GenerateMatricule(etudiant.Nom, etudiant.Id);

                    db.SaveChanges();
                }
            }

            MessageBox.Show("Étudiant modifié avec succès !");
            loadEtudiant();
            ViderChamps();
        }

        private void btnDeleteEtu_Click(object sender, EventArgs e)
        {
            if (idEtudiantSelectionne == 0)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant !");
                return;
            }

            DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cet étudiant ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var db = new exameenEntities())
                {
                    var etudiant = db.Etudiants.FirstOrDefault(s => s.Id == idEtudiantSelectionne);
                    if (etudiant != null)
                    {
                        db.Etudiants.Remove(etudiant);
                        db.SaveChanges();
                    }
                }

                MessageBox.Show("Étudiant supprimé !");
                loadEtudiant();
                ViderChamps();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idEtudiantSelectionne = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            }
        }

        private void ChargerFiltreClasses()
        {
            using (var db = new exameenEntities())
            {
                var classes = db.Classes.Select(c => new { c.Id, c.NomClasse }).ToList();
                classes.Insert(0, new { Id = 0, NomClasse = "Toutes les classes" });

                cmbFiltreClasse.DataSource = classes;
                cmbFiltreClasse.DisplayMember = "NomClasse";
                cmbFiltreClasse.ValueMember = "Id";
            }
        }
        private void ChargerEtudiantsParClasse()
        {
            using (var db = new exameenEntities())
            {
                int selectedClasseId = 0;

                if (cmbFiltreClasse.SelectedValue != null && int.TryParse(cmbFiltreClasse.SelectedValue.ToString(), out int classeId))
                {
                    selectedClasseId = classeId;
                }

                var query = db.Etudiants.AsQueryable();


                if (selectedClasseId != 0)
                {
                    query = query.Where(e => e.IdClasse == selectedClasseId);
                }

                dataGridView1.DataSource = query.Select(e => new
                {
                    e.Id,
                    e.Matricule,
                    e.Nom,
                    e.Prenom,
                    e.Sexe,
                    e.Adresse,
                    e.DateNaissance,
                    e.Telephone,
                    e.Email,
                    Classe = e.Classes.NomClasse

                }).ToList();
            }
        }

        private void cmbFiltreClasse_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbFiltreClasse.SelectedValue != null)
            {
                ChargerEtudiantsParClasse();
            }
        }

        private void TrierEtudiants()
        {
            using (var db = new exameenEntities())
            {
                var query = db.Etudiants.AsQueryable();

                string triSelectionne = cmbTri.SelectedItem as String;

                switch (triSelectionne)
                {
                    case "Nom":
                        query = query.OrderBy(e => e.Nom);
                        break;
                    case "Matricule":
                        query = query.OrderBy(e => e.Matricule);
                        break;
                    case "Résultats":
                        query = query.OrderByDescending(e => e.Notes.Average(n => n.Note));
                        break;
                }

                dataGridView1.DataSource = query.Select(e => new
                {
                    e.Id,
                    e.Matricule,
                    e.Nom,
                    e.Prenom,
                    e.Sexe,
                    e.Adresse,
                    e.DateNaissance,
                    e.Telephone,
                    e.Email,
                    Classe = e.Classes.NomClasse,
                    Moyenne = e.Notes.Average(n => n.Note)
                }).ToList();
            }
        }
        private void AfficherMeilleursEtudiantsParClasse()
        {
            using (var db = new exameenEntities())
            {
                var meilleursEtudiants = db.Etudiants
                    .Where(e => e.Notes.Any())
                    .GroupBy(e => e.IdClasse)
                    .Select(g => g.OrderByDescending(e => e.Notes.Average(n => n.Note))
                                  .FirstOrDefault())
                    .ToList();

                dataGridView1.DataSource = meilleursEtudiants.Select(e => new
                {
                    e.Id,
                    e.Matricule,
                    e.Nom,
                    e.Prenom,
                    e.Sexe,
                    e.Adresse,
                    e.DateNaissance,
                    e.Telephone,
                    e.Email,
                    Classe = e.Classes.NomClasse,
                    Moyenne = e.Notes.Average(n => n.Note)
                }).ToList();
            }
        }

        private void cmbTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTri.SelectedItem.ToString() == "Meilleurs etudiants")
            {
                AfficherMeilleursEtudiantsParClasse();
            }
            else
            {
                TrierEtudiants();
            }
        }

        private void RechercherEtudiants()
        {
            using (var db = new exameenEntities())
            {
                string searchText = txtRecherche.Text.Trim().ToLower();

                var query = db.Etudiants.AsQueryable();

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    query = query.Where(e =>
                        e.Nom.ToLower().Contains(searchText) ||
                        e.Matricule.ToLower().Contains(searchText) ||
                        e.Classes.NomClasse.ToLower().Contains(searchText));
                }

                dataGridView1.DataSource = query.Select(e => new
                {
                    e.Id,
                    e.Matricule,
                    e.Nom,
                    e.Prenom,
                    e.Sexe,
                    e.Adresse,
                    e.DateNaissance,
                    e.Telephone,
                    e.Email,
                    Classe = e.Classes.NomClasse
                }).ToList();
            }
        }

       

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idEtudiantSelectionne = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
                textMat.Text = dataGridView1.Rows[e.RowIndex].Cells["Matricule"].Value.ToString();
                textNom.Text = dataGridView1.Rows[e.RowIndex].Cells["Nom"].Value.ToString();
                textPrenom.Text = dataGridView1.Rows[e.RowIndex].Cells["Prenom"].Value.ToString();
                dateNais.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["DateNaissance"].Value;
                textTel.Text = dataGridView1.Rows[e.RowIndex].Cells["Telephone"].Value.ToString();
                textAdresse.Text = dataGridView1.Rows[e.RowIndex].Cells["Adresse"].Value.ToString();
                textEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                cmbClasse.Text = dataGridView1.Rows[e.RowIndex].Cells["Classe"].Value.ToString();
                string sexe = dataGridView1.Rows[e.RowIndex].Cells["Sexe"].Value.ToString();
                radioButton1.Checked = (sexe == "M");
                radioButton2.Checked = (sexe == "F");

            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            RechercherEtudiants();
        }

        
    }
}
