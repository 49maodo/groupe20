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
    public partial class FormCour : Form
    {
        private exameenEntities db = new exameenEntities();
        private int selectedCourId = -1;
        public FormCour()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            dataCour.DataSource = null;
            dataCour.DataSource = db.Cours.ToList();
            formClear();
        }
        private void activeBtn()
        {
            if (selectedCourId != -1)
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

        private void formClear()
        {
            txtNom.Clear();
            txtDesc.Clear();
            selectedCourId = -1;
            activeBtn();
        }
        private void FormCour_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void txtNom_Validating(object sender, CancelEventArgs e)
        {
            Utils.Validations.ValidateTextBox(errorProvider, txtNom,
                e, "le Champs Nom est requis");
        }

        private void txtDesc_Validating(object sender, CancelEventArgs e)
        {
            Utils.Validations.ValidateTextBox(errorProvider, txtDesc,
                e, "le Champs Description est requis");
        }

        private bool CoursExiste(string nomCours, int? idCours = null)
        {
           return db.Cours.Any(c => c.NomCours.ToUpper().Trim() == nomCours.ToUpper().Trim() &&
                                          (idCours == null || c.Id != idCours));
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (CoursExiste(txtNom.Text.Trim()))
                {
                    MessageBox.Show("Ce cours existe déjà !", "Erreur", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Cours cs = new Cours();
                cs.NomCours = txtNom.Text.Trim().ToUpper();
                cs.Description = txtDesc.Text.Trim();
                db.Cours.Add(cs);
                db.SaveChanges();
                refresh();
                MessageBox.Show("Cours ajouté avec succès !", 
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            formClear();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && selectedCourId != -1)
            {
                if (CoursExiste(txtNom.Text.Trim().ToUpper(), selectedCourId)) 
                {
                    MessageBox.Show("Ce nom de cours est déjà utilisé !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Cours existingCours = db.Cours.Find(selectedCourId);
                if (existingCours != null) {
                    existingCours.NomCours = txtNom.Text.Trim().ToUpper();
                    existingCours.Description = txtDesc.Text.Trim();
                    db.SaveChanges();
                    MessageBox.Show("Cours mis à jour avec succès !", 
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Erreur : Cours introuvable.", 
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataCour_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataCour.Rows[e.RowIndex];
                selectedCourId = Convert.ToInt32(row.Cells[0].Value);
                txtNom.Text = row.Cells[1].Value.ToString();
                txtDesc.Text = row.Cells[2].Value.ToString();
                activeBtn();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && selectedCourId != -1)
            {

                DialogResult confirm = MessageBox.Show("Voulez-vous vraiment supprimer ce cours ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    Cours existingCours = db.Cours.Find(selectedCourId);
                    if (existingCours != null)
                    {
                        db.Cours.Remove(existingCours);
                        db.SaveChanges();
                        refresh();
                        MessageBox.Show("Cours supprimé avec succès !",
                            "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
