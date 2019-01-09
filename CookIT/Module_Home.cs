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

            if (receptGet != null) {
                
                lbTitle1.Text = receptGet.Rows[0][2].ToString();
                lbTitle2.Text = receptGet.Rows[1][2].ToString();
                lbTitle3.Text = receptGet.Rows[2][2].ToString();
                lbTitle4.Text = receptGet.Rows[2][2].ToString();

            }
            else
            {
                MessageBox.Show("Er zijn niet genoeg recepten");
            }
        }
    }
}
