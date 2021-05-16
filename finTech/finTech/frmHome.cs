using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finTech
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        public int userID;

        private void frmHome_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSellScreen_Click(object sender, EventArgs e)
        {
            frmSales formSales = new frmSales();
            formSales.userID = this.userID;
            formSales.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin formAdmin = new frmAdmin();
            formAdmin.userID = this.userID;
            formAdmin.Show();
            this.Hide();
        }

        private void btnPurchaseScreen_Click(object sender, EventArgs e)
        {
            frmReceiving formReceiving = new frmReceiving();
            formReceiving.userID = this.userID;
            formReceiving.Show();
            this.Hide();
        }
    }
}
