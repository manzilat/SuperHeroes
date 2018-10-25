﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeroes.Models
{
    public class SuperHero
    {
        public static bool IsValid { get; internal set; }
        [Key]
        public int SuperHeroID { get; set; }
        public string SuperHeroName { get; set; }
        public string AlterEgo { get; set; }
        public string PrimarySuperHeroAbility { get; set; }
        public string SecondarySuperHeroAbility { get; set; }
        public string Catchphrase { get; set; }

    }
}