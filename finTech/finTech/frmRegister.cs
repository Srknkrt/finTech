using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace finTech
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        //Kullanicinin userID'si diger formlara aktarilmasi icin public olusturuldu.
        public int userID;
        //Sql veritabanina bağlanti saglama stringi.
        private string connStr = @"Data Source=.\;Initial Catalog=finTech;Integrated Security=True";
        //Sql'e sorgu yazma stringi.
        private string cmmdStr = "INSERT INTO tblUsers (Name, Surname, UserName, Password," +
                                                       "TCNumber, PhoneNumber, EMail, Address)" +
                                               "VALUES (@Name,@Surname,@UserName,@Password," +
                                                      "@TCNumber,@PhoneNumber,@EMail,@Address)";

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {   
                //Sql'e yeni baglanti kuruldu.
                SqlConnection con = new SqlConnection(connStr);
                //Sql'e yeni komut olusturuldu.
                SqlCommand cmd = new SqlCommand(cmmdStr, con);
                //Veriyi okuyucu olusturuldu.
                SqlDataReader dr;
                //Sql baglantisi acildi.
                con.Open();
                //Sql de tutulan tblUsers tablosuna bilgiler atandi.
                cmd.Parameters.AddWithValue("Name", txbName.Text);
                cmd.Parameters.AddWithValue("Surname", txbSurname.Text);
                cmd.Parameters.AddWithValue("UserName", txbUserName.Text);
                cmd.Parameters.AddWithValue("Password", txbPassword.Text);
                cmd.Parameters.AddWithValue("TCNumber", txbTCNumber.Text);
                cmd.Parameters.AddWithValue("PhoneNumber", txbPhoneNumber.Text);
                cmd.Parameters.AddWithValue("EMail", txbEmail.Text);
                cmd.Parameters.AddWithValue("Address", txbAddress.Text);
                //Komut calistirildi.
                cmd.ExecuteNonQuery();
                //Sql'e baglanti kapatildi.
                con.Close();
                //Sql baglantisi acildi.
                con.Open();
                //UserID bulma komutu olusturuldu.
                cmd.CommandText = "SELECT U.UserID FROM tblUsers U " +
                                  "WHERE U.UserName = '" + txbUserName.Text + "' AND U.Password = '" + txbPassword.Text + "'";
                //Komut calistirildi ve veri okuyucuya esitlendi.
                dr = cmd.ExecuteReader();
                //Veri okuyucu true iken calisan kosul olusturuldu.
                if (dr.Read())
                {
                    //Kullanicinin userID'si kayit edildi.
                    this.userID = Convert.ToInt32(dr["UserID"]);
                }
                //Sql'e baglanti kapatildi.
                con.Close();
                //Sql baglantisi acildi.
                con.Open();
                //tblUserTypes tablosuna yeni kullanicinin verileri aktarma komutu olusturuldu.
                cmd.CommandText = "INSERT INTO tblUserTypes (UserTypesID, UserTypeName, UserID)" +
                                                   "VALUES (@UserTypesID,@UserTypeName,@UserID)";
                //Sql de tutulan tblUserTypes tablosuna bilgiler atandi.
                cmd.Parameters.AddWithValue("UserTypesID", "2");
                cmd.Parameters.AddWithValue("UserTypeName", "User");
                cmd.Parameters.AddWithValue("UserID", this.userID);
                //Komut calistirildi.
                cmd.ExecuteNonQuery();
                //Sql'e baglanti kapatildi.
                con.Close();
                MessageBox.Show("Register successful.");
                //Kayit islemi basari ile gerceklesti ve login ekranina gecis yapildi.
                frmLogin formLogin = new frmLogin();
                //Kullanicinin userID'si formLogin'e gonderildi.
                formLogin.userID = this.userID;
                formLogin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                //Sql'e veri aktariminda sorun ile karsilasilirsa ekrana geri bildirim verildi.
                MessageBox.Show("Register failed.\nError:" + ex.Message);
                throw ex;
            }
        }

        private void frmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Cikis islemi saglandi.
            Application.Exit();
        }
    }
}
