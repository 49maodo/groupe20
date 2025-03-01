using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView.WinForms;
using gestion_etudiant.Utils;
using LiveChartsCore.SkiaSharpView.SKCharts;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using gestion_etudiant.Forms;

namespace gestion_etudiant
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        private FontAwesome.Sharp.IconButton currentButton;
        public Form1()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(UserSession.Username))
            {
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();
                if (string.IsNullOrEmpty(UserSession.Username))
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                    txtUsername.Text = UserSession.Username;
                }
            }
        }

        private void OpenChildForm(Form childform, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            ActivateButton(btnSender);
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.pnDestop.Controls.Add(childform);
            this.pnDestop.Tag = childform;
            childform.BringToFront();
            childform.BackColor = Color.LightBlue;
            childform.Show();
            ibtnHome.Visible = true;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null) {
                if(currentButton != (FontAwesome.Sharp.IconButton)btnSender)
                {
                    DisableButton();
                    currentButton = (FontAwesome.Sharp.IconButton)btnSender;
                    currentButton.BackColor = Color.DarkOrange;
                    //currentButton.ForeColor = Color.White;
                    //currentButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(FontAwesome.Sharp.IconButton))
                {
                    previousBtn.BackColor = Color.Teal;
                    //previousBtn.ForeColor = Color.White;
                    //previousBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x200; // Désactive le bouton de fermeture (X)
                return cp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ibtnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUser(), sender);
        }

        private void ibtnClasse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormClasse(), sender);
        }

        private void ibtnEtudiant_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEtudiant(), sender);
        }

        private void ibtnHome_Click(object sender, EventArgs e)
        {
            if(activeForm != null) { activeForm.Close(); }
            DisableButton();
            ibtnHome.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void cartesianChart1_Load(object sender, EventArgs e)
        {

        }

        private void motionCanvas1_Load(object sender, EventArgs e)
        {

        }

        private void pieChart1_Load(object sender, EventArgs e)
        {

        }
    }
}
