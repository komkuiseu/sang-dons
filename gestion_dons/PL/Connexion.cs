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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }
        string testObligatoire()
        {
            if(txtnom.Text=="" || txtnom.Text == "Nom d' utilisateur")// si le nom d utilisateur est vide ou contient le placeholder
            {
                return "Entrer votre nom ou usename";
            }

            if (txtpass.Text == "" || txtpass.Text == "Password")
            {
                return "Entrer votre mot de passe";
            }
            //si l utilisateur est entré son nom et son mot de passe 
            return null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFerme_Click(object sender, EventArgs e)
        {
            //quitter le formulaire de connection
            this.Close();
        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            if (txtnom.Text == "Nom d' utilisateur")
            {
                txtnom.Text = "";
                txtnom.ForeColor = Color.WhiteSmoke; //changer la couleur du textbox
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.WhiteSmoke; //changer la couleur du textbox
            }
        }

        private void txtnom_Leave(object sender, EventArgs e)
        {
            if (txtnom.Text == "")
            {
                txtnom.Text = "Nom d' utilisateur";
                txtnom.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
                txtpass.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (testObligatoire() == null)
            {
                MessageBox.Show("valide");
            }
            else
            {
                MessageBox.Show(testObligatoire(),"obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
