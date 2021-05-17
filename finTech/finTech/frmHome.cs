using System;
using System.Windows.Forms;

namespace finTech
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        //Kullanicinin userID'si diger formlara aktarilmasi icin public olusturuldu.
        public int userID;
        //Kullanici admin ise true olan degiskeni olusturuldu.
        public bool adminLogin;

        private void frmHome_Load(object sender, EventArgs e)
        {
            //Kullanici admin ise btnAdmin gorunur oldu.
            if (adminLogin)
                btnAdmin.Visible = true;
            //Kullanici admin degil ise btnAdmin gorunmez oldu.
            else
                btnAdmin.Visible = false;
        }

        private void btnSellScreen_Click(object sender, EventArgs e)
        {
            //FormSales olusturuldu.
            frmSales formSales = new frmSales();
            //FormSales'e userID degeri gonderildi.
            formSales.userID = this.userID;
            //FormSales ekranina gecis yapildi.
            formSales.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //FormAdmin olusturuldu.
            frmAdmin formAdmin = new frmAdmin();
            //FormAdmin'e userID degeri gonderildi.
            formAdmin.userID = this.userID;
            //FormAdmin ekranina gecis yapildi.
            formAdmin.Show();
            this.Hide();
        }

        private void btnPurchaseScreen_Click(object sender, EventArgs e)
        {
            //FormReceiving olusturuldu.
            frmReceiving formReceiving = new frmReceiving();
            //FormReceiving'e userID degeri gonderildi.
            formReceiving.userID = this.userID;
            //FormAdmin ekranina gecis yapildi.
            formReceiving.Show();
            this.Hide();
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Cikis islemi saglandi.
            Application.Exit();
        }
    }
}
