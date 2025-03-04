using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_etudiant.Utils
{
    public class ReleveNotesDTO
    {
        public int IdEtudiant { get; set; }       // ID de l'étudiant
        public string Matricule { get; set; }     // Matricule de l'étudiant
        public string NomEtudiant { get; set; }   // Nom de l'étudiant
        public string PrenomEtudiant { get; set; }// Prénom de l'étudiant
        public string Classe { get; set; }        // Classe de l'étudiant
        public string Matiere { get; set; }       // Matière concernée
        public float Note { get; set; }           // Note obtenue
    }
}
