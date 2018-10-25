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
            var Superherolist = new List<SuperHero>
            {
                new SuperHero() { SuperHeroID = 1, SuperHeroName = "Clark Kent", AlterEgo = "SuperMan",PrimarySuperHeroAbility = "Super Senses",SecondarySuperHeroAbility="Super Speed" },
               new SuperHero() { SuperHeroID = 2, SuperHeroName = "Bruce Wayne ", AlterEgo = "BatMan", SecondarySuperHeroAbility = "Batman Immortal" },

            };
            var superheroes = db.SuperHeroes;
            return View(superheroes);
        }
        [HttpGet]
        public ActionResult Edit(int id)

        {
            var superhero = db.SuperHeroes.Where(s => s.SuperHeroID == id).Single();
            return View();
        }

        [HttpPost]

        public ActionResult Edit(SuperHero superHero)
        {
            var superhero = db.SuperHeroes.Where(s => s.SuperHeroID == id).Single();
            //var ID     = Request["SuperHeroID"];
            //var Name   = Request["SuperHeroName"];
            //var AlterEgo        = Request["AlterEgo"];
            //var Ability1 = Request["PrimarySuperHeroAbility"];
            //var Ability2 = Request["SecondarySuperHeroAbility"];
            //var Phrase = Request["Catchphrase"];

            return View("Index");
        }

        public ActionResult Create(SuperHero newHero)
        {
            SuperHero CreateSuperHero = new SuperHero();
            return View();
        }


        [HttpDelete]
        public ActionResult DeleteAction()
        {
            return View("Index");
        }

        [HttpHead]
        public ActionResult HeadAction()
        {
            return View("Index");
        }

        [HttpOptions]
        public ActionResult OptionsAction()
        {
            return View("Index");
        }

        [HttpPatch]
        public ActionResult PatchAction()
        {
            return View("Index");
        }
    }

}