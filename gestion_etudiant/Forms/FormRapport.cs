using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_etudiant.Rapport;

namespace gestion_etudiant.Forms
{
    public partial class FormRapport : Form
    {
        public FormRapport()
        {
            InitializeComponent();
            ChargerClasses(cmbFiltreClasse);
            ChargerClasses(cmbClasse);
            btnRapport.Enabled = false;
            btnRapportClass.Enabled = false;
        }
        private void ChargerClasses(ComboBox cmb)
        {
            using (var db = new exameenEntities())
            {
                var classes = db.Classes.Select(c => new { c.Id, c.NomClasse }).ToList();
                classes.Insert(0, new { Id = 0, NomClasse = "Toutes les classes" });

                cmb.DataSource = classes;
                cmb.DisplayMember = "NomClasse";
                cmb.ValueMember = "Id";
            }
        }


        private void FormRapport_Load(object sender, EventArgs e)
        {

        }
        private void ChargerEtudiantsParClasse(DataGridView dt, ComboBox cmb)
        {
            using (var db = new exameenEntities())
            {
                int selectedClasseId = 0;

                if (cmb.SelectedValue != null && int.TryParse(cmb.SelectedValue.ToString(), out int classeId))
                {
                    selectedClasseId = classeId;
                }

                var query = db.Etudiants.AsQueryable();


                if (selectedClasseId != 0)
                {
                    query = query.Where(e => e.IdClasse == selectedClasseId);
                }

                dt.DataSource = query.Select(e => new
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

        private void cmbClasse_TextChanged(object sender, EventArgs e)
        {
            if (cmbFiltreClasse.SelectedValue != null)
            {
                ChargerEtudiantsParClasse(dataGridView1, cmbFiltreClasse);
                txtId.Clear();
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

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            RechercherEtudiants();
            txtId.Clear();
            txtMat.Clear();
            txtMat.Clear();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Récupérer l'ID de l'étudiant sélectionné
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int idEtudiant = Convert.ToInt32(row.Cells[0].Value);
                txtMat.Text = row.Cells[1].Value.ToString();
                txtId.Text = idEtudiant.ToString();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                btnRapport.Enabled = false;
            }
            else
            {
                btnRapport.Enabled = true;
            }
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {
            int idEtudiant = Convert.ToInt32(txtId.Text);
            FormPrint formPrint = new FormPrint();
            formPrint.ReleveNote(idEtudiant);
            formPrint.ShowDialog();
        }

        private void cmbClasse_TextChanged_1(object sender, EventArgs e)
        {
            if (cmbClasse.SelectedValue != null)
            {
                ChargerEtudiantsParClasse(dataGridView2, cmbClasse);
                if (cmbClasse.SelectedIndex != 0)
                {
                    btnRapportClass.Enabled = true;
                }
                else
                {
                    btnRapportClass.Enabled = false;
                }
            }
        }

        private void btnRapportClass_Click(object sender, EventArgs e)
        {
            int idClasse = Convert.ToInt32(cmbClasse.SelectedValue);
            FormPrint formPrint = new FormPrint();
            formPrint.ReleveEtudiantParClasse(idClasse);
            formPrint.ShowDialog();
        }
    }
}
