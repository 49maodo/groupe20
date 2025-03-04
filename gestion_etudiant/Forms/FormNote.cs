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
    public partial class FormNote : Form
    {
        public FormNote()
        {
            InitializeComponent();
            loadEtudiants();
            loadMatieres();
            loadNotes();
        }

        private void FormNote_Load(object sender, EventArgs e)
        {
            deleteNote.Enabled = false;
            ModifNote.Enabled = false;
        }

        private void loadMatieres()
        {
            using (var db = new exameenEntities())
            {
                cmbMatieres.DataSource = db.Matieres.ToList();
                cmbMatieres.DisplayMember = "NomMatiere";
                cmbMatieres.ValueMember = "Id";
            }
        }
        private void loadEtudiants()
        {
            using (var db = new exameenEntities())
            {
                var etudiants = db.Etudiants
            .Select(e => new
            {
                e.Id,
                NomComplet = e.Prenom + " " + e.Nom
            })
            .ToList();

                cmbEtudiants.DataSource = etudiants;
                cmbEtudiants.DisplayMember = "NomComplet";
                cmbEtudiants.ValueMember = "Id";
            }
        }
        private void loadNotes()
        {
            using (var db = new exameenEntities())
            {
                var notes = db.Notes
                    .Select(n => new
                    {
                        n.Id,
                        Etudiant = n.Etudiants.Nom,
                        Matiere = n.Matieres.NomMatiere,
                        n.Note,

                    })
                    .ToList();

                dataGridView1.DataSource = notes;
            }
        }
        private void AddNote_Click(object sender, EventArgs e)
        {

            if (textNote.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }
            using (var db = new exameenEntities())
            {
                Notes note = new Notes();
                note.IdEtudiant = (int)cmbEtudiants.SelectedValue;
                note.IdMatiere = (int)cmbMatieres.SelectedValue;
                note.Note = int.Parse(textNote.Text);
                db.Notes.Add(note);
                db.SaveChanges();
            }
            MessageBox.Show("Note ajoutée avec succès");
            loadNotes();
        }

        private void ModifNote_Click(object sender, EventArgs e)
        {
            using (var db = new exameenEntities())
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                Notes note = db.Notes.FirstOrDefault(n => n.Id == id);
                note.IdEtudiant = (int)cmbEtudiants.SelectedValue;
                note.IdMatiere = (int)cmbMatieres.SelectedValue;
                note.Note = int.Parse(textNote.Text);
                db.SaveChanges();
            }
            loadNotes();
            MessageBox.Show("Note modifiée avec succès");
            deleteNote.Enabled = false;
            ModifNote.Enabled = false;
            AddNote.Enabled = true;
        }

        private void deleteNote_Click(object sender, EventArgs e)
        {
            using (var db = new exameenEntities())
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                Notes note = db.Notes.FirstOrDefault(n => n.Id == id);
                db.Notes.Remove(note);
                db.SaveChanges();
            }
            loadNotes();
            MessageBox.Show("Note supprimée avec succès");
            deleteNote.Enabled = false;
            ModifNote.Enabled = false;
            AddNote.Enabled = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteNote.Enabled = true;
            ModifNote.Enabled = true;
            AddNote.Enabled = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                cmbEtudiants.Text = row.Cells["Etudiant"].Value.ToString();
                cmbMatieres.Text = row.Cells["Matiere"].Value.ToString();
                textNote.Text = row.Cells["Note"].Value.ToString();

            }
        }
    }
}
