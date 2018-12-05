using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT
{
    class User
    {
        //Aanmaken fields en deze fields getters en setters geven
        private string naam { get; set; }
        private string achternaam { get; set; }
        private string email { get; set; }

        //Constructor
        public User(string naam, string achternaam, string email)
        {
            this.naam = naam;
            this.achternaam = achternaam;
            this.email = email;
        }
    }
}
