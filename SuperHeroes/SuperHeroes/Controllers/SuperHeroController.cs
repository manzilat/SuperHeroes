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
            var Superherolist = new List<SuperHero>
            {
                new SuperHero() { SuperHeroID = 1, SuperHeroName = "Clark Kent", AlterEgo = "SuperMan",PrimarySuperHeroAbility = "Super Senses",SecondarySuperHeroAbility="Super Speed" },
               new SuperHero() { SuperHeroID = 2, SuperHeroName = "Bruce Wayne ", AlterEgo = "BatMan", SecondarySuperHeroAbility = "Batman Immortal" },

            };
            var superheroes = db.SuperHeroes;
            return View(superheroes);
        }
        [HttpGet]
        public ActionResult Edit()

        {
            var id = Request.QueryString["id"];
            return View("index");
        }

        [HttpPost]

        public ActionResult Edit(int id, string name,string alterEgo, string ability1, string ability2,string phrase)
        {
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
            if (SuperHero.IsValid)
            {
                db.SuperHeroes.Add(newHero);
                db.SaveChanges();
                return View("List", db.SuperHeroes.ToList());
            }
            else
            {
                return View("List", db.SuperHeroes.ToList());
            }
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