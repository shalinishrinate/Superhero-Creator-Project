using Superhero_Creator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superhero_Creator.Controllers
{
    public class SuperheroController : Controller
    {
        ApplicationDbContext db;

        public SuperheroController()
        {
            db = new ApplicationDbContext();
        }

        // GET: Superhero
        public ActionResult Index()
        {
            List<Superhero> superheroes = db.Superheroes.ToList();
            //var allHeroes = 1;
            // getting the heroes
            // send them to view
            return View(superheroes);
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Superhero/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Superhero/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                db.Superheroes.Add(superhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Edit/5
        public ActionResult Edit(int id)
        {
            Superhero superhero = new Superhero();
            superhero = db.Superheroes.Where(s => s.id == id).Select(s => s).SingleOrDefault();
            return View(superhero);
            
        }

        // POST: Superhero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                ApplicationDbContext db = new ApplicationDbContext();
               // var Superhero = db.Superheroes.Where(s => s);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Superhero/Delete/5
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
