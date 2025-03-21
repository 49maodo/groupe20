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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var context = new exameenEntities();
            var utilisateur = context.Utilisateurs.FirstOrDefault(u => u.NomUtilisateur == username);

            if (utilisateur == null)
            {
                MessageBox.Show("Utilisateur introuvable");
                return;
            }

            
            if (!BCrypt.Net.BCrypt.Verify(password, utilisateur.MotDePasse))
            {
                MessageBox.Show("Mot de passe incorrect.");
                return;
            }

            UserSession.Username = utilisateur.NomUtilisateur;
            UserSession.Role = utilisateur.Role;
            UserSession.Id = utilisateur.Id;

            MessageBox.Show("Connexion réussie");
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
           
        }

        private void voirPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !voirPassword.Checked;
        }
    }
}
