using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace finTech
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        //Kullanicinin userID'si diger formlara aktarilmasi icin public olusturuldu.
        public int userID;
        //Sql'e yeni baglanti kuruldu.
        SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
        //Sql'e yeni komut olusturuldu.
        SqlCommand cmd = new SqlCommand();
        
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            //DgvItemUpdate fonksiyonu cagirildi.
            DgvItemUpdate();
            //DgvMoneyUpdate fonksiyonu cagirildi.
            DgvMoneyUpdate();
        }

        private void btnConfirmMoney_Click(object sender, EventArgs e)
        {
            //Dgv'den alinan verileri tutmak icin degiskenler olusturuldu.
            int CMUserID, CMoneyID;
            //Degiskenlere formda secilen veriler aktarildi.
            CMUserID = Convert.ToInt32(dgvWaitingForMoneyApproval.CurrentRow.Cells["CMUserID"].Value);
            CMoneyID = Convert.ToInt32(dgvWaitingForMoneyApproval.CurrentRow.Cells["CMoneyID"].Value);
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql baglantisi acildi.
            con.Open();
            //Admin onayi verme komutu olusturuldu.
            cmd.CommandText = "UPDATE tblMoneys SET MoneyAdminConfirm = 'True' " +
                              "WHERE UserID = '" + CMUserID + "' AND MoneyID = '" + CMoneyID + "'";
            //Komut calistirildi.
            cmd.ExecuteNonQuery();
            //Sql'e baglanti kapatildi.
            con.Close();
            //DgvMoneyUpdate fonksiyonu cagirildi.
            DgvMoneyUpdate();
        }

        private void btnConfirmItem_Click(object sender, EventArgs e)
        {
            //Dgv'den alinan verileri tutmak icin degiskenler olusturuldu.
            int CUserID, CUserItemID;
            //Degiskenlere formda secilen veriler aktarildi.
            CUserID = Convert.ToInt32(dgvWaitingForProductApproval.CurrentRow.Cells["CUserID"].Value);
            CUserItemID = Convert.ToInt32(dgvWaitingForProductApproval.CurrentRow.Cells["CUserItemID"].Value);
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql baglantisi acildi.
            con.Open();
            //Admin onayi verme komutu olusturuldu.
            cmd.CommandText = "UPDATE tblUserItems SET ItemAdminConfirm = 'True' " +
                              "WHERE UserID = '" + CUserID + "' AND UserItemID = '" + CUserItemID + "'";
            //Komut calistirildi.
            cmd.ExecuteNonQuery();
            //Sql'e baglanti kapatildi.
            con.Close();
            //DgvItemUpdate fonksiyonu cagirildi.
            DgvItemUpdate();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //GoHome fonksiyonu cagirildi.
            GoHome();
        }

        private void DgvItemUpdate()
        {
            //Veri ekleme islemini doldurmak icin adapter olusturuldu.
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //Veri ekleme islemi icin ds olusturuldu.
            DataSet ds = new DataSet();
            //tblUserItems tablosundaki verileri cekme komutu olusturuldu.
            cmd.CommandText = "SELECT UI.UserItemID, UI.UserID, U.Name, UI.ItemID, I.ItemName, UI.ItemAmount, UI.ItemMoney " +
                              "FROM tblUserItems UI INNER JOIN tblUsers U ON UI.UserID = U.UserID " +
                                                   "INNER JOIN tblItems I ON UI.ItemID = I.ItemID " +
                              "WHERE UI.ItemAdminConfirm = 'False'";
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql baglantisi acildi.
            con.Open();
            //Veriler eklendi.
            adapt.Fill(ds);
            //Eklenen veriler ekrana bastirildi.
            dgvWaitingForProductApproval.DataSource = ds.Tables[0];
            //Sql'e baglanti kapatildi.
            con.Close();
        }

        private void DgvMoneyUpdate()
        {
            //Veri ekleme islemini doldurmak icin adapter olusturuldu.
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //Veri ekleme islemi icin ds olusturuldu.
            DataSet ds = new DataSet();
            //tblMoneys tablosundaki verileri cekme komutu olusturuldu.
            cmd.CommandText = "SELECT M.MoneyID, M.UserID, U.Name, M.MoneyAmount " +
                             "FROM tblMoneys M INNER JOIN tblUsers U ON M.UserID = U.UserID " +
                             "WHERE M.MoneyAdminConfirm = 'False'";
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql baglantisi acildi.
            con.Open();
            //Veriler eklendi.
            adapt.Fill(ds);
            //Eklenen veriler ekrana bastirildi.
            dgvWaitingForMoneyApproval.DataSource = ds.Tables[0];
            //Sql'e baglanti kapatildi.
            con.Close();
        }

        private void GoHome()
        {
            //FormHome olusturuldu.
            frmHome formHome = new frmHome();
            //Veriyi okuyucu olusturuldu.
            SqlDataReader dr;
            //Kullanicinin admin tipinde olup olmadigini bulan komut yazildi.
            cmd.CommandText = "SELECT UserTypeName FROM tblUserTypes " +
                              "WHERE UserID = '" + this.userID + "' AND UserTypeName = 'Admin'";
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql baglantisi acildi.
            con.Open();
            //Komut calistirildi ve veri okuyucuya esitlendi.
            dr = cmd.ExecuteReader();
            //Veri okuyucu true iken calisan kosul olusturuldu.
            if (dr.Read())
                formHome.adminLogin = true;
            //Sql'e baglanti kapatildi.
            con.Close();
            //Kullanicinin userID'si formHome'a gonderildi.
            formHome.userID = this.userID;
            //FormHome'a gecis yapildi.
            formHome.Show();
            this.Hide();
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Cikis islemi saglandi.
            Application.Exit();
        }
    }
}
