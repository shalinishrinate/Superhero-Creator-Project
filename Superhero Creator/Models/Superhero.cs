using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Superhero_Creator.Models
{
    public class Superhero
    {
        [Key]
        public int id { get; set; }
        public string superheroName { get; set; }
        public string superheroAlterEgo { get; set; }
        public string primarySuperheroAbility { get; set; }
        public string secondarySuperheroAbility { get; set; }
        public string catchPhrase { get; set; }
    }
}