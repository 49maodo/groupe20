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
using ClosedXML.Excel;
using gestion_etudiant.Rapport;
using iTextSharp.text.pdf;
using iTextSharp.text;

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
        private void AfficherMeilleursEtudiantsParClasse()
        {
            using (var db = new exameenEntities())
            {
                var meilleursEtudiants = db.Etudiants
                    .Where(e => e.Notes.Any())
                    .GroupBy(e => e.IdClasse)
                    .Select(g => g.OrderByDescending(e => e.Notes.Average(n => n.Note))
                                  .FirstOrDefault())
                    .ToList();

                dataGridView3.DataSource = meilleursEtudiants.Select(e => new
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
                    Classe = e.Classes.NomClasse,
                    Moyenne = e.Notes.Average(n => n.Note)
                }).ToList();
            }
        }
        private void cmbTop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTop.SelectedItem.ToString() == "Meilleurs etudiants")
            {
                AfficherMeilleursEtudiantsParClasse();
            }
        }
        private void ExportToPDF()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files (*.pdf)|*.pdf";
            sfd.FileName = "Meilleurs_Etudiants.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                doc.Open();

                PdfPTable table = new PdfPTable(dataGridView3.Columns.Count);
                foreach (DataGridViewColumn column in dataGridView3.Columns)
                {
                    table.AddCell(new Phrase(column.HeaderText));
                }

                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(cell.Value?.ToString() ?? "");
                    }
                }

                doc.Add(table);
                doc.Close();

                MessageBox.Show("Exportation PDF réussie !");
            }
        }

        private void ExportToExcel()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
            sfd.FileName = "Meilleurs_Etudiants.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Meilleurs Etudiants");

                    for (int i = 0; i < dataGridView3.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dataGridView3.Columns[i].HeaderText;
                    }

                    for (int i = 0; i < dataGridView3.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView3.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = dataGridView3.Rows[i].Cells[j].Value?.ToString() ?? "";
                        }
                    }

                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Exportation Excel réussie !");
                }
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            ExportToPDF();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
    }
}
