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
    public partial class user_liste_client : UserControl
    {
        private static user_liste_client userclent;
        private gestion_de_commandeDataSet db;

        public static user_liste_client Instance
        {
            get
            {
                if(userclent== null)
                {
                    userclent = new user_liste_client();
                }
                return userclent;
            }
        }
        public user_liste_client()
        {
            InitializeComponent();
            db = new gestion_de_commandeDataSet();
            txtrecherche.Enabled = false;
        }

        public void actualiserdatagrid()
        {
            dvgclient.Rows.Clear();
            foreach(var S in db.client)
            {
                dvgclient.Rows.Add(false, S.num_client, S.nom_client,S.prenom_client,S.adresse,S.tel_client,S.paye_client) ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formulairedossier.form_ajouter_mmoifier_cli frmcli = new form_ajouter_mmoifier_cli();
            frmcli.ShowDialog();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;
            }
        }

        
        private void user_liste_client_Load(object sender, EventArgs e)
        {
            actualiserdatagrid();
        }

        private void dvgclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formulairedossier.form_ajouter_mmoifier_cli frmmod = new form_ajouter_mmoifier_cli();
            frmmod.labtitre.Text = "modifier client";
            frmmod.bntactu.Visible = false;
            frmmod.ShowDialog();

        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new gestion_de_commandeDataSet();
            var listerecherche = db.client.ToList();
            if (txtrecherche.Text != "")
            {
                switch (comborech.Text)
                {
                    case "Nom":
                        listerecherche = listerecherche.Where(s => s.nom_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Prenom":
                        listerecherche = listerecherche.Where(s => s.prenom_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Adress":
                        listerecherche = listerecherche.Where(s => s.adresse.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "telephone":
                        listerecherche = listerecherche.Where(s => s.tel_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Pays":
                        listerecherche = listerecherche.Where(s => s.paye_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                }
            }
            dvgclient.Rows.Clear();
            foreach(var l in listerecherche)
            {
                dvgclient.Rows.Add(false, l.num_client, l.nom_client, l.prenom_client, l.adresse, l.tel_client, l.paye_client);
            }
        }

        private void comborech_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtrecherche.Enabled = true;
            txtrecherche.Text = "";
        }
    }
}
