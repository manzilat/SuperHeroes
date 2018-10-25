using SuperHeroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroes.Controllers
{
    public class SuperHeroController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private int id;

        public ActionResult Index()
        {
           
            var superheroes = db.SuperHeroes;
            return View(superheroes);
        }
        [HttpGet]
        public ActionResult Edit(int id)

        {
            var superhero = db.SuperHeroes.Where(s => s.SuperHeroID == id).Single();
            return View();
        }
        public ActionResult Create()
        {
            SuperHero ListOfHero = new SuperHero();
            return View(ListOfHero);
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "SuperHeroName,AlterEgo,PrimarySuperHeroAbility,SecondarySuperHeroAbility,CatchPhrase")] SuperHero SuperHero)
        {

            db.SuperHeroes.Add(SuperHero);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpPost]

        public ActionResult Edit(SuperHero superHero)
        {
            var Superhero = db.SuperHeroes.Where(s => s.SuperHeroID == id).Single();
           

            return View("Index");
        }

      
        [HttpDelete]
        public ActionResult Delete(int id)
        {
             SuperHero Hero = db.SuperHeroes.Where(s => s.SuperHeroID == id).Single();
            db.SuperHeroes.Remove(Hero);
            return View("Index");
        }

        
        public ActionResult Details(int id)
        {
            SuperHero hero = db.SuperHeroes.Where(s => s.SuperHeroID == id).Single();
            return View(hero);
            
        }

    }

}