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
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Personnage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personnage/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
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
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}