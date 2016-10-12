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

        public ActionResult AjouterMoyenPaiement()
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

        [HttpPost]
        public ActionResult AjouterMoyenPaiement(int typePaiement)
        {
            if (ModelState.IsValid)
            {
                switch (typePaiement)
                {
                    case 0:
                        return RedirectToAction("AjouterCarteBancaire");
                    case 1:
                        return RedirectToAction("AjouterCheque");
                    case 2:
                        return RedirectToAction("AjouterFacture");
                    case 3:
                        return RedirectToAction("AjouterVirement");
                    default:
                        return View();

                }
            }
            else
            {
                return View();
            }
        }

        public ActionResult AjouterCarteBancaire()
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

        [HttpPost]
        public ActionResult AjouterCarteBancaire(CarteBancaire cb)
        {
            if (ModelState.IsValid)
            {
                cb.UtilisateurId = Convert.ToInt32(Session["ClientId"]);
                idao.ajouterCarteBancaire(cb);
                return RedirectToAction("LoggedIn", "Client");
            }
            else
            {
                return View(cb);
            }

        }

        public ActionResult AjouterCheque()
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

        [HttpPost]
        public ActionResult AjouterCheque(Cheque c)
        {
            if (ModelState.IsValid)
            {
                c.UtilisateurId = Convert.ToInt32(Session["ClientId"]);
                idao.ajouterCheque(c);
                return RedirectToAction("LoggedIn", "Client");
            }
            else
            {
                return View(c);
            }

        }

        public ActionResult AjouterFacture()
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

        [HttpPost]
        public ActionResult AjouterFacture(Facture f)
        {
            if (ModelState.IsValid)
            {
                f.UtilisateurId = Convert.ToInt32(Session["ClientId"]);
                idao.ajouterFacture(f);
                return RedirectToAction("LoggedIn", "Client");
            }
            else
            {
                return View(f);
            }

        }

        public ActionResult AjouterVirement()
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

        [HttpPost]
        public ActionResult AjouterVirement(Virement v)
        {
            if (ModelState.IsValid)
            {
                v.UtilisateurId = Convert.ToInt32(Session["ClientId"]);
                idao.ajouterVirement(v);
                return RedirectToAction("LoggedIn", "Client");
            }
            else
            {
                return View(v);
            }

        }
    }
}