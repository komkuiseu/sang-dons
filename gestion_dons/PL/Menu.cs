using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_dons.PL
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(266,745);
            pnlParametre.Visible = false;
        }

        //private void btnFerme_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}


        //private void btnred_Click_1(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}

        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 745)
            {
                panel1.Size = new Size(65, 745);

            }
            else
            {
                panel1.Size = new Size(53, 43);
            }
        }

        private void btnDons_Click(object sender, EventArgs e)
        {
            pnuBut.Top = btnDons.Top;
            
            if (!pnlAffichage.Controls.Contains(USR_LIST_Dons.Instance))
            {
                pnlAffichage.Controls.Add(USR_LIST_Dons.Instance);
                USR_LIST_Dons.Instance.Dock = DockStyle.Fill;
                USR_LIST_Dons.Instance.BringToFront();
            }
            else
            {
                USR_LIST_Dons.Instance.BringToFront();
            }
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            pnuBut.Top = btnuser.Top;
            if (!pnlAffichage.Controls.Contains(USR_List_Utilisateur.Instance))
            {
                pnlAffichage.Controls.Add(USR_List_Utilisateur.Instance);
                USR_List_Utilisateur.Instance.Dock = DockStyle.Fill;
                USR_List_Utilisateur.Instance.BringToFront();
            }
            else
            {
                USR_List_Utilisateur.Instance.BringToFront();
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            pnuBut.Top = btnStock.Top;
            if (!pnlAffichage.Controls.Contains(USR_STOCK_SANG.Instance))
            {
                pnlAffichage.Controls.Add(USR_STOCK_SANG.Instance);
                USR_STOCK_SANG.Instance.Dock = DockStyle.Fill;
                USR_STOCK_SANG.Instance.BringToFront();
            }
            else
            {
                USR_LIST_BESOIN.Instance.BringToFront();
            }
        }

        private void btnNotiv_Click(object sender, EventArgs e)
        {
            pnuBut.Top = btnbesoin.Top;
            if (!pnlAffichage.Controls.Contains(USR_LIST_BESOIN.Instance))
            {
                pnlAffichage.Controls.Add(USR_LIST_BESOIN.Instance);
                USR_LIST_BESOIN.Instance.Dock = DockStyle.Fill;
                USR_LIST_BESOIN.Instance.BringToFront();
            }
            else
            {
                USR_LIST_BESOIN.Instance.BringToFront();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlParametre.Size = new Size(326, 244);
            pnlParametre.Visible = !pnlParametre.Visible;
        }



        private void btnFerme_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnred_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Connexion con = new Connexion();
            con.ShowDialog();
        }

        private void btnDecon_Click(object sender, EventArgs e)
        {

        }
    }
}
