using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace finTech
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //Sql veritabanina bağlanti saglama stringi.
        private string connStr = @"Data Source=.\;Initial Catalog=finTech;Integrated Security=True";
        //Kullanicinin userID'si diger formlara aktarilmasi icin public olusturuldu.
        public int userID;

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(connStr);
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();
            //FormHome olusturuldu.
            frmHome formHome = new frmHome();
            //Veriyi okuyucu olusturuldu.
            SqlDataReader dr;
            //Sql baglantisi acildi.
            con.Open();
            //Sql ile baglanti saglandi.
            cmd.Connection = con;
            //Kullanicinin girdigi verilerin sql de olup olmadigini bulma komutu yazildi.
            cmd.CommandText = "SELECT  U.UserID, UT.UserTypeName " +
                              "FROM tblUsers U INNER JOIN tblUserTypes UT ON U.UserID = UT.UserID " +
                              "WHERE U.UserName = '" + txbUserName.Text + "' AND U.Password = '" + txbPassword.Text + "'";
            //Komut calistirildi ve veri okuyucuya esitlendi.
            dr = cmd.ExecuteReader();
            //Veri okuyucu true iken calisan kosul olusturuldu.
            if (dr.Read())
            {
                MessageBox.Show("Logging into your account.");
                //Kullanicinin userID'si kayit edildi.
                this.userID = Convert.ToInt32(dr["UserID"]);
                //Kullanicinin userID'si formHome'a gonderildi.
                formHome.userID = this.userID;
                //Kullanici eger Admin ise formHome'a adminLogin true degeri gonderildi.
                if (dr["UserTypeName"].ToString() == "Admin")
                    formHome.adminLogin = true;
                //Islem basarili oldugu icin formHome'a gecis yapildi.
                formHome.Show();
                this.Hide();
            }
            else
            {
                //Islem basarisiz oldugu icin ekrana bildirimi atildi.
                MessageBox.Show("Check your username and password.");
            }
            //Sql'e baglanti kapatildi.
            con.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //formRegister olusturuldu.
            frmRegister formRegister = new frmRegister();
            //Kayit ekranina gecis yapildi.
            formRegister.Show();
            this.Hide();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Cikis islemi saglandi.
            Application.Exit();
        }
    }
}
