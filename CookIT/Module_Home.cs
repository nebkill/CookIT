using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookIT
{
    public partial class Module_Home : UserControl
    {
        Manager mgr = new Manager();
        Panel panel = new Panel();
        public Module_Home()
        {
            InitializeComponent();
            DataFill();
            setLabelEvent();
        }

        public void DataFill()
        {
            
            DataTable receptGet = mgr.getTopTen();

            lbCategoryTitle.Text = "Top 5 Recepten";

            if (receptGet != null) {
                
                lbTitle1.Text = receptGet.Rows[0][2].ToString();
                lbTitle2.Text = receptGet.Rows[1][2].ToString();
                lbTitle3.Text = receptGet.Rows[1][2].ToString();
                lbTitle4.Text = receptGet.Rows[1][2].ToString();

                string filepath = Environment.CurrentDirectory + "..\\..\\";

                //pbRecept1.Show("C:\\Users\\mi_ke\\Source\\Repos\\CookIT\\CookIT\\Images\\Love_Heart_symbol_square.svg");
                //pbRecept1.Image = Image.FromFile();
                /*"C:\\Users\\mi_ke\\Source\\Repos\\CookIT\\CookIT\\Images\\Love_Heart_symbol_square.png"*/
            }
            else
            {
                MessageBox.Show("Er zijn niet genoeg recepten");
            }
        }

        private void Module_Home_Load(object sender, EventArgs e)
        {
            //nthing
        }
        public void setLabelEvent()
        {
            foreach(Label l in this.Controls.OfType<Label>())
            {
                l.Click += new EventHandler(label_Click);
            }

        }
        
        public void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            Module_ReceptView mrv = new Module_ReceptView();
            if(clickedLabel != null && (string)clickedLabel.Tag == "Recept")
            {
                DataTable recepten = mgr.getRecepten();
                Recept item = new Recept();
                for (int i = 0; i < recepten.Rows.Count; i++)
                {
                    if(recepten.Rows[i][1].ToString() == clickedLabel.Text)
                    {
                        List<string> ingr = recepten.Rows[i][11].ToString().Split('-').ToList<string>();
                        List<string> stap = recepten.Rows[i][12].ToString().Split('-').ToList<string>();
                        List<string> benod = recepten.Rows[i][9].ToString().Split(',').ToList<string>();
                        item.id = (int)recepten.Rows[i][0];
                        item.naam = recepten.Rows[i][1].ToString();
                        item.desc = recepten.Rows[i][2].ToString();
                        item.auteur = recepten.Rows[i][3].ToString();
                        item.ingredienten = ingr;
                        item.stappen = stap;
                        item.benodigdheden = benod;
                        item.dieet = recepten.Rows[i][8].ToString();
                        item.rating = (int)recepten.Rows[i][5];
                        item.video = recepten.Rows[i][4].ToString();
                        item.image = recepten.Rows[i][10].ToString();
                    }                    
                }
                mrv.setRecept(item);
                var ViewPanel = new Module_ReceptView();
                panel.Controls.Add(ViewPanel);
            }
        }
        public void setPanel(Panel panel)
        {
            this.panel = panel;
        }
    }
}
