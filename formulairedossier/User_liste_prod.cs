using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gstion_de_commande.formulairedossier
{
    public partial class User_liste_prod : UserControl
    {
        
        private static User_liste_prod userprod;
        private gestion_de_commandeDataSet db;

        public static User_liste_prod Instance
        {
            get
            {
                if (userprod == null)
                {
                    userprod = new User_liste_prod();
                }
                return userprod;
            }
        }
        public User_liste_prod()
        {
            InitializeComponent();
            db = new gestion_de_commandeDataSet();
        }

        private void User_liste_prod_Load(object sender, EventArgs e)
        {

        }

        private void dvgclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
