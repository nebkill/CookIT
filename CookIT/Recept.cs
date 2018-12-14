using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT
{
    class Recept
    {
        //Aanmaken fields en deze fields getters en setters geven
        public int id { get; set; }
        public string naam { get; set; }
        public string desc { get; set; }
        public string auteur { get; set; }
        public string video { get; set; }
        public int rating { get; set; }
        public string dieet { get; set; }
        public string[] benodigdheden { get; set; }
        public string image { get; set; }
        public string[] ingredienten { get; set; }
        public List<string> stappen { get; set; }

        //Constructor
        public Recept()
        {
            //empty recept;
        }
        public Recept(int id,string naam, string desc, string auteur, string video, int rating, string dieet, string[] benodigdheden, string image, string[] ingredienten, List<string> stappen)
        {
            this.id = id;
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
