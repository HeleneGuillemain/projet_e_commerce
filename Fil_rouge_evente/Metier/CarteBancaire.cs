using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fil_rouge_evente.Metier
{
    public class CarteBancaire:MoyenPaiement
    {
        public string NomProprietaire { get; set; }
        public string NumeroCompte { get; set; }
        public DateTime DateExpiration { get; set; }
    }
}