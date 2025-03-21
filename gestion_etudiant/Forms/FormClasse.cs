using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace gestion_etudiant.Forms
{
    public partial class FormClasse : Form
    {
        private exameenEntities db = new exameenEntities();
        private int selectedClassId = -1;

        public FormClasse()
        {
            InitializeComponent();
        }

        private void FormClasse_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            dataClasse.DataSource = null;
            dataClasse.DataSource = db.Classes.Select(cl => new ClasseDetails
            {
                Id = cl.Id,
                NomClasse = cl.NomClasse,
                NbEtudiants = cl.Etudiants.Count,
                NbProfesseurs = cl.Professeurs.Count
            }).ToList();
            formClear();
        }

        private void formClear()
        {
            txtNom.Clear();
            selectedClassId = -1;
            activeBtn();
        }
        private void activeBtn()
        {
            if (selectedClassId != -1)
            {
                BtnAdd.Enabled = false;
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                BtnAdd.Enabled = true;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }

        private void txtNom_Validating(object sender, CancelEventArgs e)
        {
            Utils.Validations.ValidateTextBox(errorProvider, txtNom,
                e,"le Champs Nom est requis");
        }

        private bool NomClasseExiste(int? idClasse = null)
        {
            string nomClasseNormalized = txtNom.Text.ToUpper().Trim();
            return db.Classes.Any(c => c.NomClasse.ToUpper().Trim() == nomClasseNormalized
                                           && (idClasse == null || c.Id != idClasse));
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (NomClasseExiste())
                {
                    MessageBox.Show("Ce nom de classe existe déjà !",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Classes cl = new Classes();
                cl.NomClasse = txtNom.Text.ToUpper().Trim();
                db.Classes.Add(cl);
                db.SaveChanges();
                refresh();
                MessageBox.Show("Classe ajoutée avec succès !", 
                    "Succès", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            formClear();
        }

        private void dataClasse_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataClasse.Rows[e.RowIndex];
                selectedClassId = Convert.ToInt32(row.Cells[0].Value);
                txtNom.Text = row.Cells[1].Value.ToString();
                activeBtn();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled)&& selectedClassId != -1)
            {
                if (NomClasseExiste(selectedClassId))
                {
                    MessageBox.Show("Ce nom de classe est déjà utilisé !",
                        "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Classes existingClass = db.Classes.Find(selectedClassId);

                if (existingClass != null)
                {
                    existingClass.NomClasse = txtNom.Text;
                    db.SaveChanges();
                    MessageBox.Show("Classe mise à jour avec succès !", 
                        "Succès", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Erreur : Classe introuvable.", 
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment " +
                    "supprimer cette classe ?", 
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Classes classToDelete = db.Classes.Find(selectedClassId);

                    if (classToDelete != null)
                    {
                        db.Classes.Remove(classToDelete);
                        db.SaveChanges();

                        MessageBox.Show("Classe supprimée avec succès !", 
                            "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("Erreur : Classe introuvable.", 
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
