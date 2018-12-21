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
        public string[] benod= new string[] {"LOL","NEE","LMAO" };
        public string[] ingre = new string[] {"ANDERS", "GEAARD","LOL"};
        List<string> stappen = new List<string>();
        List<string> ben = new List<string>();
        List<string> ing = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            foreach (string item in benod)
            {
                ben.Add(item);
            }
            foreach(string item in ingre)
            {
                ing.Add(item);
            }
            stappen.Add("LOL");
            stappen.Add("Jemoeder");
            Recept recept = new Recept(1, "Mike's Moeder", "Ze is Heel Dik", "COOKIT", @"C:\Iets\Video\", 0, "Low_Carb", ben,@"C:\Iets\iets" , ing, stappen);
            pdf.createPDF(recept);



            //string user = "username";
            //string pass = "wachtwoord1";

            //LogIn inlog = new LogIn(user, pass);

            //if (tbGebruikersNaam.Text != "" && tbWachtwoord.Text = "")
            //{
            //    inlog.IsLoggedIn(inlog.gebruikersnaam, inlog.wachtwoord);
            //}

        }

        private void pbZoek_Click(object sender, EventArgs e)
        {
            string zoekString = tbSearch.Text;

            if (zoekString != "")
            {
                DataTable searchedData = con.getSearchData(zoekString);

                dgvVoorbeeld.DataSource = searchedData;
            }
            else
            {
                MessageBox.Show("Zoekbalk leeg! Vul iets in.");
            }
        }
    }
}
