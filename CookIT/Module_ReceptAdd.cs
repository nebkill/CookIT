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
    public partial class Module_ReceptAdd : UserControl
    {
        Manager mg = new Manager();
        public Module_ReceptAdd()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            List<string> stapList = lbStap.Items.Cast<String>().ToList();
            List<string> ingrList = lbIng.Items.Cast<String>().ToList(); 
            List<string> benodList = lbBenod.Items.Cast<String>().ToList(); 
            Recept recept = new Recept(0, tbTitle.Text,tbDesc.Text,"CookItAdmin","//",0,comboBox1.Text,benodList,"//",ingrList,stapList);
            mg.insertRecept(recept);
        }

        private void Module_ReceptAdd_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            string listOption = tbIng.Text + " | " + tbIngHv.Text;
            lbIng.Items.Add(listOption);
            tbIng.Clear();
            tbIngHv.Clear();
        }

        private void btnAddBenod_Click(object sender, EventArgs e)
        {
            lbBenod.Items.Add(tbBenod);
            tbBenod.Clear();
        }

        private void btnAddStap_Click(object sender, EventArgs e)
        {
            lbStap.Items.Add(tbStap);
            tbStap.Clear();
        }
    }
}
