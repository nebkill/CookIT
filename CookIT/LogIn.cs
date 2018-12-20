using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace CookIT
{
    class LogIn
    {
        //aanmaken van variabelen en objecten
        Manager mg = new Manager();
        public string gebruikersnaam { get; set; }
        public string wachtwoord { get; set; }
        public string email { get; set; }
        public string voorNaam { get; set; }
        public string achterNaam { get; set; }
        public int rol { get; set; }
        //constructor
        public LogIn(string gebruikersnaam, string wachtwoord, string email, string voorNaam, string achterNaam, int rol)
        {
            this.gebruikersnaam = gebruikersnaam;
            this.wachtwoord = wachtwoord;
            this.email = email;
            this.voorNaam = voorNaam;
            this.achterNaam = achterNaam;
            this.rol = rol;
        }
        //log in constructor
        public LogIn(string gebruikersnaam, string wachtwoord)
        {
            this.gebruikersnaam = gebruikersnaam;
            this.wachtwoord = wachtwoord;
        }
        //string valideren
        private bool StringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //integer valideren 
        private bool IntegerValidator(string input)
        {
            string pattern = "[^0-9]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //haal ingevulde strings leeg 
        private void ClearTexts(string user, string pass)
        {
            user = String.Empty;
            pass = String.Empty;
        }
        
        //log in methode 
        internal bool IsLoggedIn(string user, string pass)
        {
          

            //checken of gebruikersnaam leeg is  
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Enter the user name!");
                return false;

            }

            //checken of gebruikersnaam correct is
            else
            {
                for (int i = 0; i < mg.getUsers().Rows.Count; i++)
                {

                    if (user != mg.getUsers().Rows[i][1].ToString())
                    {
                        MessageBox.Show("User name is incorrect!");
                        ClearTexts(user, pass);
                        return false;
                    }

                    //checken of wachtwoord leeg is 
                    else
                    {
                        if (string.IsNullOrEmpty(pass))
                        {
                            MessageBox.Show("Enter the passowrd!");
                            return false;
                        }

                        //checken of wachtwoord correct is 
                        else if (pass != mg.getUsers().Rows[i][2].ToString()) 
                        {
                            MessageBox.Show("Password is incorrect");
                            return false;
                        }
                        
                    }
                }
                return true;
            }
        }
    }
}
