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
    public partial class USR_List_Utilisateur : UserControl
    {
        private static USR_List_Utilisateur user;
        //cree une instance de la classe user
        public static USR_List_Utilisateur Instance
        {
            get
            {
                if (user == null)
                {
                    user = new USR_List_Utilisateur();
                }
                return user;
            }
        }
        public USR_List_Utilisateur()
        {
            InitializeComponent();
        }

        private void USR_List_Utilisateur_Load(object sender, EventArgs e)
        {

        }

        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;
            }
        }

        private void USR_List_Utilisateur_Load_1(object sender, EventArgs e)
        {
            //exemple d ajout

            dgbuser.Rows.Add();
            dgbuser.Rows[0].Cells[1].Value = "kom";
            dgbuser.Rows[0].Cells[2].Value = "elie";
            dgbuser.Rows[0].Cells[3].Value = "komsantos@gmail.com";
            dgbuser.Rows[0].Cells[4].Value = "655555555";

        }

        private void btnajouteruser_Click(object sender, EventArgs e)
        {
            PL.AjoutModifierUser frmuser = new AjoutModifierUser();
            frmuser.ShowDialog();
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            PL.AjoutModifierUser ajoutModifierUser = new PL.AjoutModifierUser();
            ajoutModifierUser.lbltitre.Text = "Modifier l 'utilisateur";
            ajoutModifierUser.btnactu.Visible = false;
            ajoutModifierUser.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtrecherche_Leave(object sender, EventArgs e)
        {

        }
    }
}
