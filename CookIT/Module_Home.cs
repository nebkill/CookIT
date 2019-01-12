using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CookIT
{
    public partial class Module_Home : UserControl
    {
        Manager mgr = new Manager();
        Panel panel = new Panel();
        Module_ReceptView receptView = new Module_ReceptView();
        Module_ReceptAdd receptAdd = new Module_ReceptAdd();
        public Module_Home(Panel mainFormPanel)
        {
            InitializeComponent();
            this.panel = mainFormPanel;
            DataFill();
            setLabelEvent();
        }

        public Module_Home()
        {
            InitializeComponent();
            DataFill();
            setLabelEvent();
        }

        public void DataFill()
        {
            
            DataTable receptGet = mgr.dtTopFour();

            lbCategoryTitle.Text = "Top 5 Recepten";
            try
            {
                if (receptGet != null)
                {
                    if (receptGet.Rows.Count < 0)
                    {
                        MessageBox.Show("Er zijn minder dan 4 recepten");
                    }
                    else
                    {
                        int count = 0;
                        int count2 = 0;
                        foreach (Label l in this.tlpCatRecepten.Controls.OfType<Label>())
                        {
                            l.Text = receptGet.Rows[count][1].ToString();
                            count++;
                            
                        }
                        foreach(PictureBox p in this.tlpCatRecepten.Controls.OfType<PictureBox>())
                        {
                            string file = receptGet.Rows[count2][10].ToString();

                            string filepath = Path.Combine(Environment.CurrentDirectory, @"..\..\Images\", file);

                            p.Image = Image.FromFile(filepath);
                            count2++;
                        }
                       
                        //for (int i = 0; i < 3; i++)
                        //{
                        //    string label = "lbTitle" + i;
                        //    lbTitle1.Text = receptGet.Rows[i][1].ToString();
                        //    lbTitle2.Text = receptGet.Rows[i][1].ToString();
                        //    lbTitle3.Text = receptGet.Rows[i][1].ToString();
                        //    lbTitle4.Text = receptGet.Rows[i][1].ToString();

                        //    string file = "Love_Heart_symbol_square.png";
                        //    string filepath = Path.Combine(Environment.CurrentDirectory, @"..\..\Images\", file);

                        //    pbRecept1.Image = Image.FromFile(filepath);
                        //}
                    }
                }
                else
                {
                    MessageBox.Show("Er zijn niet genoeg recepten");
                }
            }
            catch
            {
                MessageBox.Show("De rij kan niet in de database gevonden worden. Geen verbinding met de database. Voeg ip toe bij de domain eigenaar." +
                    "Als u niet de eigenaar bent, neem dan contact op met de eigenaar.");
            }
        }

        private void Module_Home_Load(object sender, EventArgs e)
        {
            //genReceptList();
        }
        public void setLabelEvent()
        {
            foreach (Label l in this.tlpCatRecepten.Controls.OfType<Label>())
            {
                l.Click += new EventHandler(label_Click);
            }
            //lbTitle1.Click += new EventHandler(label_Click);
            //lbTitle2.Click += new EventHandler(label_Click);
            //lbTitle3.Click += new EventHandler(label_Click);
            //lbTitle4.Click += new EventHandler(label_Click);

            //foreach (Control ct in this.tlpCatRecepten.Controls)
            //{
            //    if (ct is Label)
            //    {
            //        ((Label)ct).Click += new EventHandler(label_Click);
            //    }
            //}

        }
        
        public void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            //Module_ReceptView mrv = new Module_ReceptView();

            if (clickedLabel != null && (string)clickedLabel.Tag == "Recept")
            {
                //DataTable recepten = mgr.getRecepten();
                //Recept item = new Recept();
                string var = clickedLabel.Name;
                int choosenLabel = -1;

                switch (var)
                {
                    case "lbTitle1":
                        choosenLabel = 0;
                        break;

                    case "lbTitle2":
                        choosenLabel = 1;
                        break;

                    case "lbTitle3":
                        choosenLabel = 2;
                        break;

                    case "lbTitle4":
                        choosenLabel = 3;
                        break;

                }

                DataTable recepten = mgr.dtTopFour();
                Recept item = new Recept();

                if (choosenLabel < recepten.Rows.Count)
                {
                    List<string> ingr = recepten.Rows[choosenLabel][11].ToString().Split('*').ToList<string>();
                    List<string> stap = recepten.Rows[choosenLabel][12].ToString().Split('*').ToList<string>();
                    List<string> benod = recepten.Rows[choosenLabel][9].ToString().Split('*').ToList<string>();
                    item.id = (int)recepten.Rows[choosenLabel][0];
                    item.naam = recepten.Rows[choosenLabel][1].ToString();
                    item.desc = recepten.Rows[choosenLabel][2].ToString();
                    item.auteur = recepten.Rows[choosenLabel][3].ToString();
                    item.ingredienten = ingr;
                    item.stappen = stap;
                    item.benodigdheden = benod;
                    item.dieet = recepten.Rows[choosenLabel][8].ToString();
                    item.rating = (int)recepten.Rows[choosenLabel][5];
                    item.video = recepten.Rows[choosenLabel][4].ToString();
                    item.image = recepten.Rows[choosenLabel][10].ToString();


                    //for (int i = 0; i < recepten.Rows.Count; i++)
                    //{
                    //    if(recepten.Rows[i][1].ToString() == clickedLabel.Text)
                    //    {
                    //        List<string> ingr = recepten.Rows[i][11].ToString().Split('-').ToList<string>();
                    //        List<string> stap = recepten.Rows[i][12].ToString().Split('-').ToList<string>();
                    //        List<string> benod = recepten.Rows[i][9].ToString().Split(',').ToList<string>();
                    //        item.id = (int)recepten.Rows[i][0];
                    //        item.naam = recepten.Rows[i][1].ToString();
                    //        item.desc = recepten.Rows[i][2].ToString();
                    //        item.auteur = recepten.Rows[i][3].ToString();
                    //        item.ingredienten = ingr;
                    //        item.stappen = stap;
                    //        item.benodigdheden = benod;
                    //        item.dieet = recepten.Rows[i][8].ToString();
                    //        item.rating = (int)recepten.Rows[i][5];
                    //        item.video = recepten.Rows[i][4].ToString();
                    //        item.image = recepten.Rows[i][10].ToString();
                    //    }                    
                    //}
                    receptView.setRecept(item);

                    //var ViewPanel = new Module_ReceptView();
                    panel.Controls.Clear();
                    panel.Controls.Add(receptView);
                    receptView.BringToFront();
                }
                else
                {
                    MessageBox.Show("Dit recept bestaat niet");
                }
            }
        }
        public void setPanel(Panel panel)
        {
            this.panel = panel;
        }
        public void ReceptListGen()
        {
            int count = mgr.getRecepten().Rows.Count;
            //for(int i = 0; i < count; i++)
            //{
                
            //}
            TextBox[] textBox = new TextBox[count];
            Label[] label = new Label[count];

            for (int i = 0; i < count; i++)
            {
                textBox[i] = new TextBox();
                textBox[i].Name = "n" + i;
                textBox[i].Text = "n" + i;

                label[i] = new Label();
                label[i].Name = "n" + i;
                label[i].Text = "n" + i;
            }

            for (int i = 0; i < count; i++)
            {
                this.Controls.Add(textBox[i]);
                this.Controls.Add(label[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(receptAdd);
        }
        private void genReceptList()
        {
            //NEEDS TO BE FIXED!
            int count = mgr.getRecepten().Rows.Count;
            int x = 241;
            int y = 394;
            for (int i = 0; i < count; i++)
            {
                Label NewLabel = new Label();
                NewLabel.Name = mgr.getRecept(count).naam;
                NewLabel.Text = mgr.getRecept(count).naam;
                NewLabel.Tag = "Recept";
                NewLabel.Left = x;
                NewLabel.Top = y;
                this.Controls.Add(NewLabel);
                y += 20;
            }
        }
    }
}
