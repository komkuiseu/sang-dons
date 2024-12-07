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
    public partial class AjoutModifierDons : Form
    {
        public AjoutModifierDons()
        {
            InitializeComponent();
        }

        private void txtqte_Leave(object sender, EventArgs e)
        {
            if (txtqte.Text == "Quantité")
            {
                txtqte.Text = "";
                txtqte.ForeColor = Color.Black;
            }

        }

        private void txtgrp_Leave(object sender, EventArgs e)
        {
            if (txtgrp.Text == "groupe sanguin")
            {
                txtgrp.Text = "";
                txtgrp.ForeColor = Color.Black;
            }
        }

        private void btnFerme_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnactu_Click(object sender, EventArgs e)
        {

        }

        private void txtqte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        string obligatoire()
        {
            if (txtqte.Text == "")
            {
                return "entrez la quantite";
            }
            if (txtdatee.Text == "")
            {
                return "entrez la date";
            }
            if (txtgrp.Text == "")
            {
                return "entrez lz groupe sanguin";
            }
            if (cmbnom.Text == "")
            {
                return "selectionnez un nom";
            }
            if (cmblieu.Text == "")
            {
                return "selectionnez un lieu";
            }
            return null;
        }
        private void AjoutModifierDons_Load(object sender, EventArgs e)
        {
           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (obligatoire() != null)
            {
                MessageBox.Show(obligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
