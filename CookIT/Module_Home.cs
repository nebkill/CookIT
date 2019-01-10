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
        Connect dbCon = new Connect();

        public Module_Home()
        {
            InitializeComponent();
            DataFill();
        }

        public void DataFill()
        {
            
            DataTable receptGet = dbCon.getTopTen();

            lbCategoryTitle.Text = "Top 5 Recepten";

            if (receptGet != null) {
                
                lbTitle1.Text = receptGet.Rows[0][2].ToString();
                lbTitle2.Text = receptGet.Rows[1][2].ToString();
                lbTitle3.Text = receptGet.Rows[1][2].ToString();
                lbTitle4.Text = receptGet.Rows[1][2].ToString();

                string file = "Love_Heart_symbol_square.png";
                string filepath = Path.Combine(Environment.CurrentDirectory, @"..\..\Images\", file);

                //pbRecept1.Show("C:\\Users\\mi_ke\\Source\\Repos\\CookIT\\CookIT\\Images\\Love_Heart_symbol_square.svg");
                pbRecept1.Image = Image.FromFile(filepath);

                //lvRating1.;
                 
            }
            else
            {
                MessageBox.Show("Er zijn niet genoeg recepten");
            }
        }
        public void ReceptListGen()
        {
            int count = dbCon.getRecepten().Rows.Count;
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
    }
}
