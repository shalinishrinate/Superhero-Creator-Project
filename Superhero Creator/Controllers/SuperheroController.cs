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
        ApplicationDbContext context;

        public SuperheroController()
        {
            context = new ApplicationDbContext();
        }

        // GET: Superhero
        public ActionResult Index()
        {
           var superheroes = context.Superheroes.ToList();
            //var allHeroes = 1;
            // getting the heroes
            // send them to view
            return View(superheroes);
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            Superhero superhero = new Superhero();
            superhero = context.Superheroes.Where(s => s.id == id).Select(s => s).SingleOrDefault();
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
                context.Superheroes.Add(superhero);
                context.SaveChanges();
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
            superhero = context.Superheroes.Where(s => s.id == id).FirstOrDefault();
            return View(superhero);
            
        }

        // POST: Superhero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here
                
               Superhero editedSuperhero = context.Superheroes.Where(s => s.id == id).FirstOrDefault();
                editedSuperhero.id = superhero.id;
                editedSuperhero.superheroName = superhero.superheroName;
                editedSuperhero.superheroAlterEgo = superhero.superheroAlterEgo;
                editedSuperhero.primarySuperheroAbility = superhero.primarySuperheroAbility;
                editedSuperhero.secondarySuperheroAbility = superhero.secondarySuperheroAbility;
                editedSuperhero.catchPhrase = superhero.catchPhrase;
                context.SaveChanges();
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
            Superhero superhero = new Superhero();
            superhero = context.Superheroes.Where(s => s.id == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: Superhero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                Superhero deleteSuperhero = context.Superheroes.Where(s => s.id == id).FirstOrDefault();
                context.Superheroes.Remove(deleteSuperhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
