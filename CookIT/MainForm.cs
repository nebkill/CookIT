using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookIT
{
    public partial class MainForm : Form
    {
        //Aanmaken van alle objecten en fields
        Module_tray tray = new Module_tray();
        Module_ReceptList recept = new Module_ReceptList();
        Module_Home home = new Module_Home();
        Module_LogReg logReg = new Module_LogReg();
        Module_ReceptView rView = new Module_ReceptView();
        Module_ReceptAdd rAdd = new Module_ReceptAdd();
        Module_Search search = new Module_Search();
        Panel panel;
        Connect con = new Connect();
        PDFHandler pdf = new PDFHandler();
        //Constructor
        
        public MainForm()
        {
            InitializeComponent();

            //string user = "username";
            //string pass = "wachtwoord1";

            //LogIn inlog = new LogIn(user, pass);

            //if (tbGebruikersNaam.Text != "" && tbWachtwoord.Text = "")
            //{
            //    inlog.IsLoggedIn(inlog.gebruikersnaam, inlog.wachtwoord);
            //}

        }
    }
}
