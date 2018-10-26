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
      

        public ActionResult Index()
        {
           
            var superheroes = db.SuperHeroes;
            return View(superheroes);
        }
        
        public ActionResult List()
        {
            return View(db.SuperHeroes.ToList());
        }
        [HttpGet]
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
        
        [HttpGet]
        public ActionResult Edit(int SuperHeroID)

        {
            var superhero = db.SuperHeroes.Where(s => s.SuperHeroID == SuperHeroID).Single();
            return View();
        }

        [HttpPost]
        public ActionResult Edit(SuperHero SuperHeroID)
        {
            var Superhero = db.SuperHeroes.Where(s => s.SuperHeroID == s.SuperHeroID).Single();
           

            return View("Index");
        }
      

        
        public ActionResult Delete(int SuperHeroID)
        {
             SuperHero SuperHero = db.SuperHeroes.Where(s => s.SuperHeroID == SuperHeroID).Single();
            db.SuperHeroes.Remove(SuperHero);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        
        public ActionResult Details(int SuperHeroID)
        {
            SuperHero hero = db.SuperHeroes.Where(s => s.SuperHeroID == SuperHeroID).Single();
            return View("Index");
            
        }



    }

}