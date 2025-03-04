using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HarfBuzzSharp;

namespace gestion_etudiant.Forms
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            loadUsers();
            ModifUser.Enabled = false;
            DeleteUser.Enabled = false;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }
        public void loadUsers()
        {
            using (var db = new exameenEntities())
            {
                var users = db.Utilisateurs
                    .Select(u => new
                    {
                        u.Id,
                        u.NomUtilisateur,
                        
                        u.Telephone,
                        u.Role
                    })
                    .ToList();
                dataGridView1.DataSource = users;
            }
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "" || textMotDePasse.Text == "" || textTel.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }
            if (string.IsNullOrEmpty(cmbRole.SelectedItem.ToString()))
            {
                MessageBox.Show("Veuillez sélectionner un rôle valide");
                return;
            }
            try
            {
                using (var db = new exameenEntities())
                {

                    var verifUser = db.Utilisateurs
                        .FirstOrDefault(u => u.NomUtilisateur == textUsername.Text);

                    if (verifUser != null)
                    {
                        MessageBox.Show("Le nom d'utilisateur existe déjà.");
                        return;
                    }


                    string hashage = BCrypt.Net.BCrypt.HashPassword(textMotDePasse.Text);

                    Utilisateurs user = new Utilisateurs
                    {
                        NomUtilisateur = textUsername.Text,
                        MotDePasse = hashage,
                        Telephone = textTel.Text,
                        Role = cmbRole.SelectedItem.ToString()
                    };

                    db.Utilisateurs.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("Utilisateur ajouté avec succès");


                    textUsername.Text = "";
                    textMotDePasse.Text = "";
                    textTel.Text = "";
                }
                loadUsers();
                ModifUser.Enabled = false;
                DeleteUser.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de l'utilisateur: {ex.Message}");
            }
        }

        private void ModifUser_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new exameenEntities())
                {
                    int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                    var user = db.Utilisateurs.Find(id);
                    if (user != null)
                    {

                        var verifUser = db.Utilisateurs
                            .FirstOrDefault(u => u.NomUtilisateur == textUsername.Text && u.Id != id);
                        if (verifUser != null)
                        {
                            MessageBox.Show("Le nom d'utilisateur existe déjà.");
                            return;
                        }


                        user.NomUtilisateur = textUsername.Text;
                        user.Telephone = textTel.Text;
                        user.Role = cmbRole.SelectedItem.ToString();


                        if (textMotDePasse.Text != null)
                        {

                            string hashage = BCrypt.Net.BCrypt.HashPassword(textMotDePasse.Text);
                            user.MotDePasse = hashage;
                        }

                        db.SaveChanges();
                        MessageBox.Show("Utilisateur modifié avec succès");


                        Reset();
                    }
                }



                loadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification de l'utilisateur: {ex.Message}");
            }
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            using (var db = new exameenEntities())
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var user = db.Utilisateurs.Find(id);
                db.Utilisateurs.Remove(user);
                db.SaveChanges();

                Reset();
            }
            loadUsers();
            MessageBox.Show("Utilisateur supprimé avec succès");
        }

        public void Reset()
        {

            textUsername.Text = "";
            textMotDePasse.Text = "";
            textTel.Text = "";
            cmbRole.SelectedIndex = -1;
            AddUser.Enabled = true;
            ModifUser.Enabled = false;
            DeleteUser.Enabled = false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void textTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textUsername.Text = row.Cells["NomUtilisateur"].Value.ToString();
                textTel.Text = row.Cells["Telephone"].Value.ToString();
                cmbRole.SelectedItem = row.Cells["Role"].Value.ToString();

                AddUser.Enabled = false;
                ModifUser.Enabled = true;
                DeleteUser.Enabled = true;
            }
        }
    }
}
