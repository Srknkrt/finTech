using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace finTech
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }
        //Sql'e sorgu yazma stringi.
        private string cmmdStr = "INSERT INTO tblUserItems (UserID, ItemID, ItemAmount," +
                                                           "ItemMoney, ItemAdminConfirm) " +
                                                   "VALUES (@UserID,@ItemID,@ItemAmount," +
                                                           "@ItemMoney,@ItemAdminConfirm)";
        //Kullanicinin userID'si diger formlara aktarilmasi icin public olusturuldu.
        public int userID;
        //Satma isleminde itemin id'si tutulmasi icin degisken olusturuldu.
        private int itemID;
        //Sql'e yeni baglanti kuruldu.
        SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
        //Sql'e yeni komut olusturuldu.
        SqlCommand cmd = new SqlCommand();
        //Veriyi okuyucu olusturuldu.
        SqlDataReader dr;

        private void frmSales_Load(object sender, EventArgs e)
        {
            //ProductUpdate fonksiyonu ile ürün bilgileri ekrana gosterildi.
            ProductUpdate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //tblUserItems tablosunu dolduracak komut yazildi.
                cmd.CommandText = cmmdStr;
                //Sql'e baglanti saglandi.
                cmd.Connection = con;
                //Sql de tutulan tblUserItems tablosuna bilgiler atandi.
                cmd.Parameters.AddWithValue("UserID", this.userID);
                cmd.Parameters.AddWithValue("ItemID", this.itemID);
                cmd.Parameters.AddWithValue("ItemAmount", Convert.ToInt32(txbItemAmount.Text));
                cmd.Parameters.AddWithValue("ItemMoney", Convert.ToInt32(txbPrice.Text));
                cmd.Parameters.AddWithValue("ItemAdminConfirm", 0);
                //Sql baglantisi acildi.
                con.Open();
                //Komut calistirildi.
                cmd.ExecuteNonQuery();
                //Sql'e baglanti kapatildi.
                con.Close();
                MessageBox.Show("Add successful.\nApproval is pending.");
            }
            catch (Exception ex)
            {
                //Sql'e veri aktariminda sorun ile karsilasilirsa ekrana geri bildirim verildi.
                MessageBox.Show("Add failed.\nError:" + ex.Message);
                throw ex;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //GoHome fonksiyonu cagirildi.
            GoHome();
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Secilen urune gore itemID bulma komutu olusturuldu.
            cmd.CommandText = "SELECT I.ItemID FROM tblItems I WHERE I.ItemName = '" +
                                                                    cmbProduct.Text + "'";
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql baglantisi acildi.
            con.Open();
            //Komut calistirildi ve veri okuyucuya esitlendi.
            dr = cmd.ExecuteReader();
            //Veri okuyucu true iken calisan dongu olusturuldu.
            while (dr.Read())
            {
                //cmbProduct'ta veriyi degistikce gozuken verinin itemID bilgisi degiskende tutuldu.
                this.itemID = Convert.ToInt32(dr["ItemID"]);
            }
            //Sql'e baglanti kapatildi.
            con.Close();
        }

        private void ProductUpdate()
        {
            //ItemName bulma komutu olusturuldu.
            cmd.CommandText = "SELECT I.ItemName FROM tblItems I";
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql baglantisi acildi.
            con.Open();
            //Komut calistirildi ve veri okuyucuya esitlendi.
            dr = cmd.ExecuteReader();
            //Veri okuyucu true iken calisan dongu olusturuldu.
            while (dr.Read())
            {
                //ItemName verileri cmbProduct'a yazildi.
                cmbProduct.Items.Add(dr["ItemName"]);
            }
            //Sql'e baglanti kapatildi.
            con.Close();

            //Sql baglantisi acildi.
            con.Open();
            //UserID'den kullanicinin pazardaki kendi urunlerini bulma komutu yazildi.
            cmd.CommandText = "SELECT UI.ItemID, I.ItemName, UI.ItemAmount, UI.ItemMoney " +
                              "FROM tblUserItems UI INNER JOIN tblItems I ON UI.ItemID = I.ItemID " +
                              "WHERE UI.UserID = '" + this.userID + "' AND UI.ItemAdminConfirm = 'True'";
            //Veri ekleme islemini doldurmak icin adapter olusturuldu.
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //Veri ekleme islemi icin ds olusturuldu.
            DataSet ds = new DataSet();
            //Veriler eklendi.
            adapt.Fill(ds);
            //Eklenen veriler ekrana bastirildi.
            dgvMyProductForSale.DataSource = ds.Tables[0];
            //Sql'e baglanti kapatildi.
            con.Close();
        }

        private void GoHome()
        {
            //FormHome olusturuldu.
            frmHome formHome = new frmHome();
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

        private void frmSales_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Cikis islemi saglandi.
            Application.Exit();
        }
    }
}
