using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_etudiant.Utils;

namespace gestion_etudiant.Forms
{
    public partial class FormRapport : Form
    {
        public FormRapport()
        {
            InitializeComponent();
            ChargerClasses();
            dataGridView1.DataSource = GetReleveNotes(1);
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

        

        private void FormRapport_Load(object sender, EventArgs e)
        {

        }
        public List<ReleveNotesDTO> GetReleveNotes(int idEtudiant)
        {
            using (var db = new exameenEntities())
            {
                var result = (from n in db.Notes
                              join e in db.Etudiants on n.IdEtudiant equals e.Id
                              join m in db.Matieres on n.IdMatiere equals m.Id
                              join c in db.Classes on e.IdClasse equals c.Id
                              where e.Id == idEtudiant
                              select new ReleveNotesDTO
                              {
                                  IdEtudiant = e.Id,
                                  Matricule = e.Matricule,
                                  NomEtudiant = e.Nom,
                                  PrenomEtudiant = e.Prenom,
                                  Classe = c.NomClasse,
                                  Matiere = m.NomMatiere,
                                  Note = (float)n.Note
                              }).ToList();
                return result;
            }
        }

        private void cmbClasse_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
