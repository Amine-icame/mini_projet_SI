using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media;

namespace gstion_de_commande.formulairedossier
{
    private 
    
    public partial class form_ajouter_mmoifier_cli : Form
    {
        private const string ConnectionString = " Data Source = AMINEICAME\\SQLEXPRESS; Initial Catalog = gestion_de_commande; Integrated Security = True";
        SqlConnection Mycnx;
        public form_ajouter_mmoifier_cli()
        {
            InitializeComponent();
        }

        string testoblig()
        {
            if (textNOM.Text == "")
            {
                return "entrer le nom du client";
            }
            if (textPrenom.Text == "")
            {
                return "entrer le prenom du client";
            }
            if (textadrs.Text == "")
            {
                return "entrer l'adresse du client";
            }
            if (texttel.Text == "")
            {
                return "entrer le numero du client";
            }
            if (texville.Text == "")
            {
                return "entrer la ville du client";
            }
            else { return null; }
        }

        private void bntsort_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void texttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar<48 || e.KeyChar > 75)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void bntenreg_Click(object sender, EventArgs e, int _)
        {
            

            if (testoblig() != null)
            {
                MessageBox.Show(testoblig(),"obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            string nom = textNOM.Text;
            string prenom = textPrenom.Text;
            String adres = textadrs.Text;
            int tel = int.Parse(texttel.Text);
            String ville = texville.Text;
            Mycnx = new SqlConnection(ConnectionString);
            Mycnx.Open();

            SqlCommand MyComand = Mycnx.CreateCommand();
            MyComand.CommandText = "insert into etudiant values('" + nom + "','" + prenom + "'," + adres + "',"+tel+"',"+ville+")";
            MyComand.ExecuteNonQuery();
            Mycnx.Close();



        }
        
        private void bntactu_Click(object sender, EventArgs e)
        {
            textNOM.Text = "";
            textPrenom.Text = "";
            textadrs.Text = "";
            texttel.Text = "";
            texville.Text = "";
        }

        private void bntenreg_Click(object sender, EventArgs e)
        {

            if (testoblig() != null)
            {
                MessageBox.Show(testoblig(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string nom = textNOM.Text;
            string prenom = textPrenom.Text;
            String adres = textadrs.Text;
            int tel = int.Parse(texttel.Text);
            String ville = texville.Text;
            Mycnx = new SqlConnection(ConnectionString);
            Mycnx.Open();

            SqlCommand MyComand = Mycnx.CreateCommand();
            MyComand.CommandText = "insert into client values('" + nom + "','" + prenom + "'," + adres + "'," + tel + "'," + ville + ")";
            MyComand.ExecuteNonQuery();
            Mycnx.Close();
        }

        private void form_ajouter_mmoifier_cli_Load(object sender, EventArgs e)
        {

        }
    }
}
