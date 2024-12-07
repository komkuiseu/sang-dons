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
    public partial class USR_LIST_Dons : UserControl
    {
        private static USR_LIST_Dons dons;
        //cree une instance de la classe user
        public static USR_LIST_Dons Instance
        {
            get
            {
                if (dons == null)
                {
                    dons = new USR_LIST_Dons();
                }
                return dons;
            }
        }


        public USR_LIST_Dons()
        {
            InitializeComponent();
        }

        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;
            }
        }

        private void txtrecherche_Leave(object sender, EventArgs e)
        {

        }

        private void btnajouterdons_Click(object sender, EventArgs e)
        {
            PL.AjoutModifierDons ajou = new PL.AjoutModifierDons();
            ajou.ShowDialog();
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            PL.AjoutModifierDons modif = new PL.AjoutModifierDons();
            modif.lbltitre.Text = "Modifier Dons";
            modif.btnactu.Visible = false;
            modif.ShowDialog();
        }
    }

}
