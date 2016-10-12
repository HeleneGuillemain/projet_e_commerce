using Fil_rouge_evente.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fil_rouge_evente.Models
{
    public class ClientModel
    {
        public int UtilisateurId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string Email { get; set; }
        public int Droit { get; set; }
        public virtual ICollection<AdresseClient> clientAdresses { get; set; }
        public int RoleId { get; set; }
        public string NumeroRue { get; set; }
        public string NomDeRue { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public int NumeroCarteFidelite { get; set; }
        public int NombrePoints { get; set; }
        public bool CompteActif { get; set; }
        public bool CompteASupprimer { get; set; }
        public enum Civilite { Mademoiselle, Madame, Monsieur };
        public Civilite civilite { get; set; }
        public enum TypeAdresse { Livraison, Facturation };
        public TypeAdresse typeadresse { get; set; }
    }
}