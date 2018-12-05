using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT
{
    class Recept
    {

        private string naam { get; set; }
        private string desc { get; set; }
        private string auteur { get; set; }
        private string video { get; set; }
        private string rating { get; set; }
        private string dieet { get; set; }
        private string[] benodigdheden { get; set; }
        private string image { get; set; }
        private string[] ingredienten { get; set; }
        List<string> stappen { get; set; }

        public Recept(string naam, string desc, string auteur, string video, string rating, string dieet, string[] benodigdheden, string image, string[] ingredienten, List<string> stappen)
        {
            this.naam = naam;
            this.desc = desc;
            this.auteur = auteur;
            this.video = video;
            this.rating = rating;
            this.dieet = dieet;
            this.benodigdheden = benodigdheden;
            this.image = image;
            this.ingredienten = ingredienten;
            this.stappen = stappen;
        }
    }
}
