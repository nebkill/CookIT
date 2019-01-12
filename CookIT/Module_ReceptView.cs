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
    public partial class Module_ReceptView : UserControl
    {
        Manager mg = new Manager();
        Recept rcpt = new Recept();
        public Module_ReceptView()
        {
            rcpt = null;
            InitializeComponent();

        }

        private void Module_ReceptView_Load(object sender, EventArgs e)
        {
            StringBuilder sbStappen = new StringBuilder();
            foreach (string item in rcpt.stappen)
            {
                if (item != "")
                {
                    sbStappen.Append("*").Append(item).Append("\n");
                }
            }
            lblStap.Text = sbStappen.ToString();
            StringBuilder sbBenodigdheden = new StringBuilder();
            foreach (string item in rcpt.benodigdheden)
            {
                sbBenodigdheden.Append("*").Append(item).Append("\n");
            }
            lblBenod.Text = sbBenodigdheden.ToString();
            StringBuilder sbIngredienten = new StringBuilder();
            foreach (string item in rcpt.ingredienten)
            {
                sbIngredienten.Append("*").Append(item).Append("\n");
            }
            lblIngr.Text = sbBenodigdheden.ToString();
            lblTitel.Text = rcpt.naam;
            lblDesc.Text = rcpt.desc;
            lblAuteur.Text += " " + rcpt.auteur;
        }
        public void setRecept(Recept rpt)
        {
            this.rcpt = rpt;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            mg.createPDF(rcpt);
        }
    }
}
