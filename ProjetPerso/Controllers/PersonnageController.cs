using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetPerso.DAL;
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
            CreateEditePersonnageViewModel viewModel = new CreateEditePersonnageViewModel();

            viewModel.Personnages = db.GetPersonnage(ReturnID);

            return View("CreateEditePersonnage", viewModel);
        }

        // GET: Personnage/Create
        public ActionResult Create()
        {
            ViewData["Title"] = "Ajouter un Personnage";
            CreateEditePersonnageViewModel viewModel = new CreateEditePersonnageViewModel();
            return View("CreateEditePersonnage", viewModel);
        }

        // POST: Personnage/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateEditePersonnageViewModel model)
        {
            Console.WriteLine(model.Personnages);
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
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