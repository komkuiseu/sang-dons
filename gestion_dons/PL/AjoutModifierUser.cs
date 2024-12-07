using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace gestion_dons.PL
{
    public partial class AjoutModifierUser : Form
    {
        public AjoutModifierUser()
        {
            InitializeComponent();
        }
        string champObigatoire()
        {
            if (txtnom.Text == "" || txtnom.Text == "Nom")
            {
                return "entrer votre nom";

            }
            if (txtprenom.Text == "" || txtprenom.Text == "Prenom")
            {
                return "entrer votre nom";
            }
            if (txtemail.Text == "" || txtemail.Text == "Email")
            {
                return "entrer votre email";
            }
            if (txtage.Text == "" || txtage.Text == "Age du sejet")
            {
                return "entrer votre age";
            }
            if (txttel.Text == "" || txttel.Text == "Telephone")
            {
                return "entrer votre telephone";
            }
            if (txtville.Text == "" || txtville.Text == "Ville")
            {
                return "entrer votre ville";
            }

            //if (txtdate.Text == "" || txtdate.Text == "Date d' inscription")
            //{
            //    return "entrer la date";
            //}

            //verifier email valide
            if (txtemail.Text != "" || txtemail.Text != "Email")
            {
                try
                {
                    new MailAddress(txtemail.Text);//verifier si email valide ou non
                }
                catch (Exception ex)
                {
                    return "Email inalide";
                }
            }
            return null;
        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            if (txtnom.Text == "" || txtnom.Text == "Nom")
            {
                txtnom.Text = "";
                txtnom.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtprenom_Enter(object sender, EventArgs e)
        {
            if (txtprenom.Text == "" || txtprenom.Text == "Prenom")
            {
                txtprenom.Text = "";
                txtprenom.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtville_Enter(object sender, EventArgs e)
        {
            if (txtville.Text == "" || txtville.Text == "Ville")
            {
                txtville.Text = "";
                txtville.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "" || txtemail.Text == "Email")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtdate_Enter(object sender, EventArgs e)
        {
            if (txtdate.Text == "" || txtdate.Text == "Date d' inscription")
            {
                txtdate.Text = "";
                txtdate.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtage_Enter(object sender, EventArgs e)
        {
            if (txtage.Text == "" || txtage.Text == "Age du sujet")
            {
                txtage.Text = "";
                txtage.ForeColor = Color.WhiteSmoke;
            }
        }

        private void AjoutModifierUser_Load(object sender, EventArgs e)
        {

        }

        private void btnFerme_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txttel_Enter(object sender, EventArgs e)
        {
            if (txttel.Text == "" || txttel.Text == "Telephone")
            {
                txttel.Text = "";
                txttel.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (champObigatoire() != null)
            {
                MessageBox.Show(champObigatoire(), " Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnactu_Click(object sender, EventArgs e)
        {
            txtnom.Text = "Nom";txtnom.ForeColor = Color.Silver;
            txtprenom.Text = "Prenom";txtprenom.ForeColor = Color.Silver;
            txtemail.Text = "Email";txtemail.ForeColor = Color.Silver;
            txtville.Text = "Ville";txtville.ForeColor = Color.Silver;
            txttel.Text = "Telephone";txttel.ForeColor = Color.Silver;
            txtage.Text = "Age";txtage.ForeColor = Color.Silver;
            txtdate.Text = "Date d' inscription";txtdate.ForeColor = Color.Silver;
        }
    }
}
