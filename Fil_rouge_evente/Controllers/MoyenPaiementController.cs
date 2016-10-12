using Fil_rouge_evente.Dao;
using Fil_rouge_evente.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fil_rouge_evente.Controllers
{
    public class MoyenPaiementController : Controller
    {
        // GET: MoyenPaiement
        IDAO idao = new DAOImpl();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ajouterMoyenPaiement()
        {
            if (Convert.ToInt32(Session["RoleId"]) == 1)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Connexion", "Client");
            }
        }

        
        
    }
}