using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_etudiant
{
    public partial class FormOTPValidation : Form
    {
        private int userId;
     
        public FormOTPValidation(int idUtilisateur)
        {
            InitializeComponent();
            userId = idUtilisateur;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string codeSaisi = txtOTP.Text.Trim();

            using (var context = new exameenEntities())
            {
                var otp = context.OTPCodes
                    .Where(o => o.IdUtilisateur == userId && o.Code == codeSaisi && o.DateExpiration > DateTime.Now)
                    .FirstOrDefault();

                if (otp == null)
                {
                    MessageBox.Show("Code OTP invalide ou expiré.");
                    return;
                }

               
                context.OTPCodes.Remove(otp);
                context.SaveChanges();

                MessageBox.Show("Connexion validée avec succès.");
                this.Close();
            }
        }
    }
}
