using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using gestion_etudiant.Rapport;

namespace gestion_etudiant.Forms
{
    public partial class FormPrint : Form
    {
        private ReportDocument reportDocument;

        public FormPrint()
        {
            InitializeComponent();
            reportDocument = new ReportDocument();
        }

        private void FormPrint_Load(object sender, EventArgs e)
        {

        }
        public void ReleveNote(int idEtudiant)
        {
            string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReleveNote.rpt");

            if (!File.Exists(reportPath))
            {
                MessageBox.Show("Fichier introuvable ! Vérifiez le chemin : " + reportPath, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ReportDocument report = new ReportDocument();
            report.Load(reportPath);
            report.SetParameterValue("IdEtudiant", idEtudiant);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.RefreshReport();
        }
        public void ReleveEtudiantParClasse(int idClasse)
        {
            string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RapportEtuClasse.rpt");

            if (!File.Exists(reportPath))
            {
                MessageBox.Show("Fichier introuvable ! Vérifiez le chemin : " + reportPath, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ReportDocument report = new ReportDocument();
            report.Load(reportPath);
            report.SetParameterValue("idClasse", idClasse);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.RefreshReport();
        }
        private DataTable GetMeilleursEtudiants(int idClasse)
        {
            using (var db = new exameenEntities())
            {
                var meilleursEtudiants = db.Notes
                .Where(n => n.Etudiants.IdClasse == idClasse)
                .GroupBy(n => new { n.IdEtudiant, n.Etudiants.Nom, n.Etudiants.Prenom })
                .Select(g => new
                {
                    IdEtudiant = g.Key.IdEtudiant,
                    Nom = g.Key.Nom,
                    Prénom = g.Key.Prenom,
                    Moyenne = g.Average(n => n.Note)
                })
                .OrderByDescending(e => e.Moyenne)
                .Take(5)
                .ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("IdEtudiant", typeof(int));
                dt.Columns.Add("Nom", typeof(string));
                dt.Columns.Add("Prénom", typeof(string));
                dt.Columns.Add("Moyenne", typeof(float));

                foreach (var etudiant in meilleursEtudiants)
                {
                    dt.Rows.Add(etudiant.IdEtudiant, etudiant.Nom, etudiant.Prénom, etudiant.Moyenne);
                }

                return dt;
            }
        }

        // liste des meilleurs etudiants par classe
        private void MeilleursEtudiantsParClasse(int idClasse)
        {
            string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MeilleursEtudiants.rpt");
            if (!File.Exists(reportPath))
            {
                MessageBox.Show("Fichier introuvable ! Vérifiez le chemin : " + reportPath, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ReportDocument report = new ReportDocument();
            report.Load(reportPath);
            report.SetParameterValue("idClasse", idClasse);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.RefreshReport();
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}