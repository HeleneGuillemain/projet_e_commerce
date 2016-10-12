using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fil_rouge_evente.Metier
{
    public class CarteBancaire:MoyenPaiement
    {
        [Required(ErrorMessage ="Ce champ est obligatoire")]
        [Display(Name ="Nom du propiétaire")]
        public string NomProprietaire { get; set; }
        [Required(ErrorMessage ="Ce champ est obligatoire")]
        [Display(Name ="Numéro de la carte")]
        [Column("NumeroCarte",TypeName = "int")]
        public string NumeroCarte { get; set; }
        [Required(ErrorMessage ="Ce champ est obligatoire")]
        [Display(Name ="Date d'expiration")]
        public DateTime DateExpiration { get; set; }
    }
}