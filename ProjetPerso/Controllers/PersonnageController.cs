using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetPerso.DAL;
using ProjetPerso.DataBase;
using ProjetPerso.Models.Personnages;

namespace ProjetPerso.Controllers
{
    public class PersonnageController : Controller
    {
        DB db = new DB();
        // GET: Personnage
        public ActionResult Index()
        {
            IndexViewModel ViewModel = new IndexViewModel(); 
            ViewModel.Personnages = db.GetAllPersonnages();
            
            return View(ViewModel);
        }

        // GET: Personnage/Details/5
        public ActionResult Details(int ReturnID)
        {
            ViewData["Title"] = "Modifier un Personnage";
            ViewBag.action = "Modifier";
            CreateEditePersonnageViewModel viewModel = new CreateEditePersonnageViewModel();

            viewModel.Personnages = db.GetPersonnage(ReturnID);
            viewModel.Nouveau = false;

            return View("CreateEditePersonnage", viewModel);
        }

        // GET: Personnage/Create
        public ActionResult Create()
        {
            ViewData["Title"] = "Ajouter un Personnage";
            ViewBag.action = "Ajouter";
            CreateEditePersonnageViewModel viewModel = new CreateEditePersonnageViewModel();
            viewModel.Nouveau = true;
            return View("CreateEditePersonnage", viewModel);
        }

        // POST: Personnage/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePerso()
        {
            Personnage Perso = new Personnage();

            Perso.ID = Int32.Parse(Request.Form["Personnages.ID"]);
            Perso.Joueur = Request.Form["Personnages.Joueur"];
            Perso.Nom = Request.Form["Personnages.Nom"];
            Perso.Pernoms = Request.Form["Personnages.Pernoms"];
            Perso.Age = Int32.Parse(Request.Form["Personnages.Age"]);
            Perso.Dexteriter = Int32.Parse(Request.Form["Personnages.Dexteriter"]);
            Perso.Charisme = Int32.Parse(Request.Form["Personnages.Charisme"]);
            Perso.Perseption = Int32.Parse(Request.Form["Personnages.Perseption"]);
            Perso.Constitution = Int32.Parse(Request.Form["Personnages.Constitution"]);
            Perso.Force = Int32.Parse(Request.Form["Personnages.Force"]);
            Perso.Agiliter = Int32.Parse(Request.Form["Personnages.Agiliter"]);
            Perso.Vie = Int32.Parse(Request.Form["Personnages.Vie"]);
            Perso.Note = Request.Form["Personnages.Note"];
            if (Boolean.Parse(Request.Form["Nouveau"]))
            {
                db.CreatPersonnage(Perso);

                IndexViewModel ViewModel = new IndexViewModel();
                ViewModel.Personnages = db.GetAllPersonnages();

                return View("Index", ViewModel);
            }
            else
            {
                db.UpdatePersonnage(Perso);

                IndexViewModel ViewModel = new IndexViewModel();
                ViewModel.Personnages = db.GetAllPersonnages();

                return View("Index", ViewModel);
            }
        }

        /* GET: Personnage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Personnage/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/

        // GET: Personnage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Personnage/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int ReturnID, IndexViewModel viewModel)
        {
            try
            {
                // TODO: Add delete logic here
                db.DeletePersonnage(ReturnID);

                IndexViewModel ViewModel = new IndexViewModel();
                ViewModel.Personnages = db.GetAllPersonnages();
                
                return View("Index",ViewModel);
            }
            catch
            {
                return View();
            }
        }
    }
}