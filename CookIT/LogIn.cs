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
        public string gebruikersnaam { get; set; }
        public string wachtwoord { get; set; }
        public string email { get; set; }
        public string voorNaam { get; set; }
        public string achterNaam { get; set; }
        public int rol { get; set; }

        public LogIn(string gebruikersnaam, string wachtwoord, string email, string voorNaam, string achterNaam, int rol)
        {
            this.gebruikersnaam = gebruikersnaam;
            this.wachtwoord = wachtwoord;
            this.email = email;
            this.voorNaam = voorNaam;
            this.achterNaam = achterNaam;
            this.rol = rol;
        }
        
        //validate string 
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
        //validate integer 
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
        //clear user inputs 
        private void ClearTexts(string user, string pass)
        {
            user = String.Empty;
            pass = String.Empty;
        }
        //method to check if eligible to be logged in 
        internal bool IsLoggedIn(string user, string pass)
        {
            //check user name empty 
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Enter the user name!");
                return false;

            }
            //check user name is valid type 
            else if (StringValidator(user) == true)
            {
                MessageBox.Show("Enter only text here");
                ClearTexts(user, pass);
                return false;
            }
            //check user name is correct 
            else
            {
                if (gebruikersnaam != user)
                {
                    MessageBox.Show("User name is incorrect!");
                    ClearTexts(user, pass);
                    return false;
                }
                //check password is empty 
                else
                {
                    if (string.IsNullOrEmpty(pass))
                    {
                        MessageBox.Show("Enter the passowrd!");
                        return false;
                    }
                    //check password is valid 
                    else if (IntegerValidator(pass) == true)
                    {
                        MessageBox.Show("Enter only integer here");
                        return false;
                    }
                    //check password is correct 
                    else if (wachtwoord != pass)
                    {
                        MessageBox.Show("Password is incorrect");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}
