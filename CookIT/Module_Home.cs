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
    }
}
