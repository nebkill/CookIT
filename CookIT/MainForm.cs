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
        
        public MainForm()
        {
            InitializeComponent();
            stappen.Add("LOL");
            stappen.Add("Jemoeder");
            Recept recept = new Recept(1, "Mike's Moeder", "Ze is Heel Dik", "COOKIT", @"C:\Iets\Video\", 0, "Low_Carb", benod,@"C:\Iets\iets" , ingre, stappen);
            pdf.createPDF(recept);

        }
    }
}
