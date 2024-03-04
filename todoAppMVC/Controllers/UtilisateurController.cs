using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using todoAppMVC.Models;

namespace todoAppMVC.Controllers
{
    public class UtilisateurController : Controller
    {
        // GET: Utilisateur
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignIn(Utilisateur utilisateur)
        {
            DbConnexion.AjouterUtilisateur(utilisateur);
            return RedirectToRoute("Login");
        }

        public ActionResult Login(Utilisateur utilisateur )
        {
            
            if (DbConnexion.VerifierUtilisateur(utilisateur))
            {
                Session["username"] = utilisateur.NonUtilisateur;
                return Content($"<h1>Bonjour {utilisateur.NonUtilisateur}</h1>");
            }              
            else
            {
                return Content($"<h1>Erreur, Authentification échouée</h1>");
            }
                
        }
        // GET: Utilisateur/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Utilisateur/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Utilisateur/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Utilisateur/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Utilisateur/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Utilisateur/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Utilisateur/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
