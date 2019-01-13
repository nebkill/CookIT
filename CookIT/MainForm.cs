using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

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

        Connect con = new Connect();
        LogHandler er = new LogHandler();

        //Anything Else
        PDFHandler pdf = new PDFHandler();
        List<string> ingr = new List<string>();
        List<string> ben = new List<string>();
        List<string> stap = new List<string>();


        //Constructor

        public MainForm()
        {
            Recept recept = new Recept(0, "Hullo", "Hello something \n something \n", "Micha Janssen", "", 0, "Low Carb", ben, "", ingr, stap);
            InitializeComponent();
            er.createDirectory();
            er.CreateLogFile();
            //pdf.createPDF(recept);



        //    string user = "username";
        //    string pass = "wachtwoord1";

        //    LogIn inlog = new LogIn(user, pass);

        //    if (tbGebruikersNaam.Text != "" && tbWachtwoord.Text = "")
        //    {
        //    if (inlog.IsLoggedIn(inlog.gebruikersnaam, inlog.wachtwoord))
        //    {
        //            //Kijk trello voor de bijbehorende linkjes
        //            HttpCookie myCookie = new HttpCookie("UserSettings");
        //            myCookie.Value = "nl";
        //            myCookie.Expires = DateTime.Now.AddDays(1d);
        //            Response.Cookies.Add(myCookie);
        //    }

        //}

    }

        private void pbZoek_Click(object sender, EventArgs e)
        {
            //string zoekString = tbSearch.Text;

            //if (zoekString != "")
            //{
            //    DataTable searchedData = con.getSearchData(zoekString);

            //    dgvVoorbeeld.DataSource = searchedData;
            //}
            //else
            //{
            //    MessageBox.Show("Zoekbalk leeg! Vul iets in.");
            //}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            home.setPanel(this.pLoadPanel);
            //var myControl = new Module_Home(this.pLoadPanel);
            pLoadPanel.Controls.Add(home);
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            home.genReceptList();
            pLoadPanel.Controls.Clear();
            pLoadPanel.Controls.Add(home);
        }
    }
}
