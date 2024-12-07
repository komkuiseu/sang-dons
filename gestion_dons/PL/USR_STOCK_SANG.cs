using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_dons.PL
{
    public partial class USR_STOCK_SANG : UserControl
    {
        private static USR_STOCK_SANG stock;
        public static USR_STOCK_SANG Instance
        {
            get
            {
                if (stock == null)
                {
                    stock = new USR_STOCK_SANG();
                }
                return stock;
            }
        }
        public USR_STOCK_SANG()
        {
            InitializeComponent();
        }

        private void USR_STOCK_SANG_Load(object sender, EventArgs e)
        {

        }
    }
}
