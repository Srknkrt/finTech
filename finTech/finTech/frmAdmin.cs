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
        //Form icinde kullanilacak gerekli degiskenler tanimlandi.
        private int SUserID;
        private int SUserItemID;
        private int SItemMoney;
        private int SItemAmount;
        private int SItemID;
        private int itemAmount;
        private int buyerID;

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            //DgvItemUpdate fonksiyonu cagirildi.
            DgvItemUpdate();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();
            //Veriyi okuyucu olusturuldu.
            SqlDataReader dr;
            
            //Degiskenlere formda secilen veriler aktarildi.
            this.SUserID = Convert.ToInt32(dgvWaitingForProductApproval.CurrentRow.Cells["CUserID"].Value);
            this.SUserItemID = Convert.ToInt32(dgvWaitingForProductApproval.CurrentRow.Cells["CUserItemID"].Value);
            this.SItemMoney = Convert.ToInt32(dgvWaitingForProductApproval.CurrentRow.Cells["CItemMoney"].Value);
            this.SItemAmount = Convert.ToInt32(dgvWaitingForProductApproval.CurrentRow.Cells["CItemAmount"].Value);
            this.SItemID = Convert.ToInt32(dgvWaitingForProductApproval.CurrentRow.Cells["CItemID"].Value);

            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql baglantisi acildi.
            con.Open();
            //Admin onayi verme komutu olusturuldu.
            cmd.CommandText = "UPDATE tblUserItems SET ItemAdminConfirm = 'True' " +
                              "WHERE UserID = '" + this.SUserID + "' AND UserItemID = '" + this.SUserItemID + "'";
            //Komut calistirildi.
            cmd.ExecuteNonQuery();
            //Sql'e baglanti kapatildi.
            con.Close();

            string BuyOrSell = "Sell";

            con.Open();
            //Satici userID'sinden UserItemID bulan komut yazildi.
            cmd.CommandText = "SELECT UI.UserItemID FROM tblUserItems UI WHERE UI.UserID = '" + this.SUserID + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //Bulunan UserItemID SUserItemID degiskenine atandi.
                this.SUserItemID = Convert.ToInt32(dr["UserItemID"]);
                //Rapor olusturma fonksiyonu cagirildi.
                GenerateReport(BuyOrSell, this.SUserID, this.SItemAmount);
            }
            con.Close();

            int purchaseRequestID = 0;

            con.Open();
            //Saticinin ItemID'sinden alicinin verilerine ulasma komutu yazildi.
            cmd.CommandText = "SELECT PR.PurchaseRequestID, PR.UserID, PR.SetAmount FROM tblPurchaseRequests PR " +
                              "WHERE PR.ItemID = '" + this.SItemID + "' AND PR.SetPrice = '" + this.SItemMoney + "'";
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                purchaseRequestID = Convert.ToInt32(dr["PurchaseRequestID"]);
                this.buyerID = Convert.ToInt32(dr["UserID"]);
                this.itemAmount = Convert.ToInt32(dr["SetAmount"]);
                //Satin alma fonksiyonu cagirildi.
                BuyFunc(purchaseRequestID);
            }
            con.Close();

            //DgvItemUpdate fonksiyonu cagirildi.
            DgvItemUpdate();
        }

        private void GenerateReport(string BuyOrSell, int UserID, int itemAmount)
        {
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            con.Open();
            //Rapor olusturma komutu yazildi.
            cmd.CommandText = "INSERT INTO tblReports (UserID, ItemID, ItemAmount, ItemMoney, History, BuyOrSell) " +
                                             "VALUES (@UserID,@ItemID,@ItemAmount,@ItemMoney,@History,@BuyOrSell)";
            cmd.Parameters.AddWithValue("UserID", UserID);
            cmd.Parameters.AddWithValue("ItemID", this.SItemID);
            cmd.Parameters.AddWithValue("ItemAmount", itemAmount);
            cmd.Parameters.AddWithValue("ItemMoney", this.SItemMoney);
            cmd.Parameters.AddWithValue("History", DateTime.Now.ToString("M/d/yyyy"));
            cmd.Parameters.AddWithValue("BuyOrSell", BuyOrSell);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void BuyFunc(int purchaseRequestID)
        {
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();
            //Veriyi okuyucu olusturuldu.

            if(this.itemAmount < this.SItemAmount)
            {
                con.Open();
                cmd.Connection = con;
                //Alicinin parasini azaltma komutu yazildi.
                cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount -= '" + (this.SItemMoney * this.itemAmount) * 101 / 100 + "' " +
                                  "WHERE UserID = '" + this.buyerID + "'";
                cmd.ExecuteNonQuery();
                //Saticinin parasini arttirma komutu yazildi.
                cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount += '" + this.SItemMoney * this.itemAmount + "' " +
                                  "WHERE UserID = '" + this.SUserID + "'";
                cmd.ExecuteNonQuery();
                //Saticinin urununu azaltma komutu yazildi.
                cmd.CommandText = "UPDATE tblUserItems SET ItemAmount -= '" + this.itemAmount + "' " +
                                  "WHERE UserItemID = '" + this.SUserItemID + "'";
                cmd.ExecuteNonQuery();
                //Alinacak listesinden silme komutu yazildi.
                cmd.CommandText = "DELETE FROM tblPurchaseRequests WHERE PurchaseRequestID = '" + purchaseRequestID + "'";
                cmd.ExecuteNonQuery();

                con.Close();

                string BuyOrSell = "Buy";
                //Alici raporu olusturma fonksiyonu cagirildi.
                GenerateReport(BuyOrSell, this.buyerID, this.itemAmount);

                this.itemAmount -= this.SItemAmount;
            }
            else if (this.itemAmount == this.SItemAmount)
            {
                con.Open();
                cmd.Connection = con;
                //Alicinin parasini azaltma komutu yazildi.
                cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount -= '" + (this.SItemMoney * this.itemAmount) * 101 / 100 + "' " +
                                  "WHERE UserID = '" + this.buyerID + "'";
                cmd.ExecuteNonQuery();
                //Saticinin parasini arttirma komutu yazildi.
                cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount += '" + this.SItemMoney * this.itemAmount + "' " +
                                  "WHERE UserID = '" + this.SUserID + "'";
                cmd.ExecuteNonQuery();
                //Saticinin urununu silme komutu yazildi.
                cmd.CommandText = "DELETE FROM tblUserItems WHERE UserItemID = '" + this.SUserItemID + "'";
                cmd.ExecuteNonQuery();
                //Alinacak listesinden silme komutu yazildi.
                cmd.CommandText = "DELETE FROM tblPurchaseRequests WHERE PurchaseRequestID = '" + purchaseRequestID + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                string BuyOrSell = "Buy";
                //Alici raporu olusturma fonksiyonu cagirildi.
                GenerateReport(BuyOrSell, this.buyerID, this.itemAmount);

                this.itemAmount -= this.SItemAmount;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //GoHome fonksiyonu cagirildi.
            GoHome();
        }

        private void btnMoneyScreen_Click(object sender, EventArgs e)
        {
            GoAdminConfirm();
        }

        private void DgvItemUpdate()
        {
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();
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

        private void GoHome()
        {
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();
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

        private void GoAdminConfirm()
        {
            //FormHome olusturuldu.
            frmAdminMoney formAdminMoney = new frmAdminMoney();
            //Kullanicinin userID'si formHome'a gonderildi.
            formAdminMoney.userID = this.userID;
            //FormHome'a gecis yapildi.
            formAdminMoney.Show();
            this.Hide();
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Cikis islemi saglandi.
            Application.Exit();
        }
    }
}
