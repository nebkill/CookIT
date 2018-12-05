using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT
{
    class User
    {
        private string naam { get; set; }
        private string achternaam { get; set; }
        private string email { get; set; }

        public User(string naam, string achternaam, string email)
        {
            this.naam = naam;
            this.achternaam = achternaam;
            this.email = email;
        }
    }
}
