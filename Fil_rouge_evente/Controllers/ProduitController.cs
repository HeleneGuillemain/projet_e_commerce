using Fil_rouge_evente.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fil_rouge_evente.Controllers
{
    public class ProduitController : Controller
    {
        IAdministrateur iadmin = new AdministrateurImpl();
        IUtilisateur iutilisateur = new UtilisateurImpl();
        // GET: Produit
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AjouterProduit()
        {
          
            if ((Session["UtilisateurId"] != null) && ((int)(Session["RoleId"]) == 2))
            {
                ViewBag.CatalogueId = new SelectList(iadmin.listerCatalogue(), "CatalogueId", "Nom");
                ViewBag.Message = "Ajouter un produit";
                return View();
            }
            else
            {
                return RedirectToAction("loginAdmin","Administrateur");
            }
        }

        [HttpPost]
        public ActionResult AjouterProduit(Produit p)
        {            
            iadmin.ajouterProduit(p);
            ViewBag.CatalogueId = new SelectList(iadmin.listerCatalogue(), "CatalogueId", "Nom");
            return RedirectToAction("ListerProduitsAdmin");
        }

        public ActionResult ListerProduitsAdmin()
        {
            
            if ((Session["UtilisateurId"] != null) && ((int)Session["RoleId"] == 2))
            {
                var res = iadmin.listerProduitCatalogue();
                ViewBag.Message = "Lister les produits";
                return View(res);
            }
            else
            {
                return RedirectToAction("loginAdmin", "Administrateur");
            }
        }

        public ActionResult ModifierProduit(int id)
        {
            var roleid = (int)(Session["RoleId"]);
            if ((Session["UtilisateurId"] != null) && (roleid == 2))
            {
                Produit p = iadmin.afficherProduit(id);
                ViewBag.CatalogueId = new SelectList(iadmin.listerCatalogue(), "CatalogueId", "Nom", p.CatalogueId);
                ViewBag.Message = "Modifier un produit";
                return View(p);
            }
            else
            {
                return RedirectToAction("loginAdmin", "Administrateur");
            }
        }

        [HttpPost]
        public ActionResult ModifierProduit(Produit p)
        {
            var res = iadmin.modifierProduit(p);

            return RedirectToAction("ListerProduitsAdmin");
        }

        public ActionResult SupprimerProduit(int id)
        {
            if (Convert.ToInt32(Session["RoleId"]) == 2)
            {
                iadmin.supprimerProduit(id);
                return RedirectToAction("ListerProduitsAdmin");
            }
            else
            {
                return RedirectToAction("loginAdmin", "Administrateur");
            }
        }

        public ActionResult RechercherProduitParNom()
        {
            if (Convert.ToInt32(Session["RoleId"]) == 2)
            {
                var res = iadmin.listerProduits();
                ViewBag.Message = "Rechercher produit";
                return View(res);
            }
            else
            {
                return RedirectToAction("loginAdmin", "Administrateur");
            }
        }

        [HttpPost]
        public ActionResult RechercherProduitParNom(string Nom)
        {
            var res = iadmin.rechercherProduitsByName(Nom);
            return View(res);
        }

        public ActionResult RechercherProduitParId()
        {
            if (Convert.ToInt32(Session["RoleId"]) == 2)
            {
                var res = iadmin.listerProduits();
                return View(res);
            }
            else
            {
                return RedirectToAction("loginAdmin", "Administrateur");
            }
        }

        [HttpPost]
        public ActionResult RechercherProduitParId(int id)
        {
            var res = iadmin.rechercherProduitById(id);
            return View(res);
        }

      
        public ActionResult AfficherProduit(int id)
        {
            if (Convert.ToInt32(Session["RoleId"]) == 2)
            {
                var res = iadmin.afficherProduit(id);
                ViewBag.Message = "Afficher un produit";
                return View(res);
            }
            else
            {
                return RedirectToAction("loginAdmin", "Administrateur");
            }
        }

        public ActionResult ajouterPromotion()
        {
            if (Convert.ToInt32(Session["RoleId"]) == 2)
            {
                return View();
            }
            else
            {
                return RedirectToAction("loginAdmin", "Administrateur");
            }
        }

        [HttpPost]
        public ActionResult ajouterPromotion(Promotion p, int id)
        {
            p.ProduitId = id;
            iadmin.creerPromotion(p);
            return RedirectToAction("afficherPromotionProduit");
        }

        public ActionResult supprimerPromotion(int PromotionId)
        {
            if (Convert.ToInt32(Session["RoleId"]) == 2)
            {
                iadmin.supprimerPromotion(PromotionId);
                return RedirectToAction("afficherPromotionProduit");
            }
            else
            {
                return RedirectToAction("loginAdmin", "Administrateur");
            }
        }

        public ActionResult afficherPromotionProduit()
        {
            if (Convert.ToInt32(Session["RoleId"]) == 2)
            {
            var res = iadmin.afficherPromotionProduit();
            return View(res);
            }
            else
            {
                return RedirectToAction("loginAdmin", "Administrateur");
            }
        }

        public ActionResult listerProduitUtilisateur()
        {
            var res = iutilisateur.listerProduits();
            ViewBag.Message = "Lister les produits";
            return View(res);
        }

        [HttpPost]
        public ActionResult listerProduitUtilisateur(string Nom)
        {
            var res = iadmin.rechercherProduitsByName(Nom);
            return View(res);
        }

        //public ActionResult afficherProduitUt(int id)
        //{

        //}
    }
}