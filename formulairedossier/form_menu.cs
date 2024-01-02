using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient ;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gstion_de_commande.formulairedossier
{
    public partial class form_menu : Form
    {
        SqlConnection Mycnx;
        public form_menu()
        {
            InitializeComponent();
            panel1.Size = new Size(229, 612);
            panelparam.Visible = false;
        }

       

        private void bntclient_Click(object sender, EventArgs e)
        {
            pnlbnt.Top = bntclient.Top;
            if (!pnlfiche.Controls.Contains(user_liste_client.Instance))
            {
                pnlfiche.Controls.Add(user_liste_client.Instance);
                user_liste_client.Instance.Dock = DockStyle.Fill;
                user_liste_client.Instance.BringToFront();
            }
            else
            {
                user_liste_client.Instance.BringToFront();
            }
        }
        
        private void bntprod_Click_1(object sender, EventArgs e)
        {
            pnlbnt.Top = bntprod.Top;
            if (!pnlfiche.Controls.Contains(User_liste_prod.Instance))
            {
                pnlfiche.Controls.Add(User_liste_prod.Instance);
                User_liste_prod.Instance.Dock = DockStyle.Fill;
                User_liste_prod.Instance.BringToFront();
            }
            else
            {
                User_liste_prod.Instance.BringToFront();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(panel1.Width== 229)
            {
                panel1.Size= new Size(82, 612);
            }
            else
            {
                panel1.Size = new Size(229, 612);
            }
        }
        
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


       

        private void bntcatg_Click(object sender, EventArgs e)
        {
            pnlbnt.Top = bntcatg.Top;
        }

        private void bntcomm_Click_1(object sender, EventArgs e)
        {
            pnlbnt.Top = bntcomm.Top;
        }

        private void bntutilise_Click(object sender, EventArgs e)
        {
            pnlbnt.Top = bntutilise.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void parametre_Click(object sender, EventArgs e)
        {
            panelparam.Size= new Size(340, 121);
            panelparam.Visible = !panelparam.Visible;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelparam.Size = new Size(340, 121);
            panelparam.Visible = !panelparam.Visible;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            Form_cnx formcnx = new Form_cnx(this);
            formcnx.ShowDialog();
        }

        private void form_menu_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
