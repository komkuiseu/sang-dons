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
    public partial class USR_LIST_BESOIN : UserControl
    {
        private static USR_LIST_BESOIN dons;
        //cree une instance de la classe user
        public static USR_LIST_BESOIN Instance
        {
            get
            {
                if (dons == null)
                {
                    dons = new USR_LIST_BESOIN();
                }
                return dons;
            }
        }
        public USR_LIST_BESOIN()
        {
            InitializeComponent();
        }

        private void USR_LIST_BESOIN_Load(object sender, EventArgs e)
        {

        }

        private void txtrecherche_Enter(object sender, EventArgs e)
        {

        }

        private void txtrecherche_Leave(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;
            }
        }

        private void btnajouterbesoin_Click(object sender, EventArgs e)
        {
            PL.AjouterModifierBesoin ajoub = new PL.AjouterModifierBesoin();
            ajoub.ShowDialog();
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            PL.AjouterModifierBesoin modif = new PL.AjouterModifierBesoin();
            modif.lbltitre.Text = "Modifier Besoin";
            modif.btnactu.Visible = false;
            modif.ShowDialog();
        }
    }
}
