using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gstion_de_commande.formulairedossier
{
    
    public partial class Form_cnx : Form
    {
        SqlConnection Mycnx;
        private Form formmunue;

        public Form_cnx(Form formmunue)
        {
            InitializeComponent();
            this.formmunue = formmunue;
        }

       

        private void bntquiter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void Form_cnx_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                form_menu formmenu = new form_menu();
                
                formmenu.Show();
         
        }
    }
}
