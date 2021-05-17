using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace finTech
{
    public partial class frmReceiving : Form
    {
        public frmReceiving()
        {
            InitializeComponent();
        }
        //Sql'e sorgu yazma stringi.
        private string cmmdStr = "INSERT INTO tblMoneys (UserID, MoneyAmount, MoneyAdminConfirm) " +
                                                "VALUES (@UserID,@MoneyAmount,@MoneyAdminConfirm)";
        //Kullanicinin userID'si diger formlara aktarilmasi icin public olusturuldu.
        public int userID;
        //Alma isleminde itemin id'si tutulmasi icin degisken olusturuldu.
        private int itemID;
        //Kullanicinin toplam parasi degiskende tutuldu.
        private int moneyTotal;
        //Sql'e yeni baglanti kuruldu.
        SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
        //Sql'e yeni komut olusturuldu.
        SqlCommand cmd = new SqlCommand();
        //Veriyi okuyucu olusturuldu.
        SqlDataReader dr;

        private void frmReceiving_Load(object sender, EventArgs e)
        {
            //ProductUpdate fonksiyonu ile ürün bilgileri ekrana gosterildi.
            ProductUpdate();
            //DgvMoneyUpdate fonksiyonu cagirildi.
            DgvMyMoneyAmountUpdate();
            //DgvProductUpdate fonksiyonu cagirildi.
            DgvProductUpdate();
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
        }

        private void DgvProductUpdate()
        {
            //Sql baglantisi acildi.
            con.Open();
            //Kullanici pazardaki tum urunleri bulma komutu olusturuldu.
            cmd.CommandText = "SELECT U.UserID, U.Name, I.ItemID, I.ItemName, UI.ItemAmount, UI.ItemMoney " +
                              "FROM tblUserItems UI INNER JOIN tblUsers U ON UI.UserID=U.UserID " +
                                                   "INNER JOIN tblItems I ON UI.ItemID=I.ItemID " +
                              "WHERE UI.ItemAdminConfirm = 'True'";
            //Veri ekleme islemini doldurmak icin adapter olusturuldu.
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //Veri ekleme islemi icin ds olusturuldu.
            DataSet ds = new DataSet();
            //Veriler eklendi.
            adapt.Fill(ds);
            //Eklenen veriler ekrana bastirildi.
            dgvProductMarket.DataSource = ds.Tables[0];
            //Sql'e baglanti kapatildi.
            con.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //GoHome fonksiyonu cagirildi.
            GoHome();
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
            //Sql baglantisi acildi.
            con.Open();
            //Secilen urune gore dgv'deki urunleri o urune gore listeleme komutu olusturuldu.
            cmd.CommandText = "SELECT U.UserID, U.Name, I.ItemID, I.ItemName, UI.ItemAmount, UI.ItemMoney " +
                              "FROM tblUserItems UI INNER JOIN tblUsers U ON UI.UserID=U.UserID " +
                                                   "INNER JOIN tblItems I ON UI.ItemID=I.ItemID " +
                              "WHERE UI.ItemID = '" + this.itemID + "' AND UI.ItemAdminConfirm = 'True'";
            //Veri ekleme islemini doldurmak icin adapter olusturuldu.
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //Veri ekleme islemi icin ds olusturuldu.
            DataSet ds = new DataSet();
            //Veriler eklendi.
            adapt.Fill(ds);
            //Eklenen veriler ekrana bastirildi.
            dgvProductMarket.DataSource = ds.Tables[0];
            //Sql'e baglanti kapatildi.
            con.Close();
        }

        private void DgvMyMoneyAmountUpdate()
        {
            //Kullanicinin toplam parasini bulma komutu olusturuldu.
            cmd.CommandText = "SELECT SUM(M.MoneyAmount) AS 'MoneyTotal' FROM tblMoneys M " +
                              "WHERE M.UserID = '" + this.userID + "' AND M.MoneyAdminConfirm = 'True'";
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Veri ekleme islemini doldurmak icin adapter olusturuldu.
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //Veri ekleme islemi icin ds olusturuldu.
            DataSet ds = new DataSet();
            //Sql baglantisi acildi.
            con.Open();
            //Veriler eklendi.
            adapt.Fill(ds);
            //Komut calistirildi ve veri okuyucuya esitlendi.
            dr = cmd.ExecuteReader();
            //Veri okuyucu true iken calisan dongu olusturuldu.
            while (dr.Read())
            {
                //Toplam para degiskene atandi.
                if(dr["MoneyTotal"].ToString() == "")
                    this.moneyTotal = 0;
                else
                    this.moneyTotal = Convert.ToInt32(dr["MoneyTotal"]);
            }
            //Eklenen veriler ekrana bastirildi.
            dgvMyMoneyAmount.DataSource = ds.Tables[0];
            //Sql'e baglanti kapatildi.
            con.Close();
            //Sql baglantisi acildi.
            con.Open();
            //Toplanan para degiskene atandiktan sonra kalan paralari silme komutu olusturuldu.
            cmd.CommandText = "DELETE FROM tblMoneys WHERE UserID = '" + this.userID + "' AND MoneyAdminConfirm = 'True'";
            //Komut calistirildi.
            cmd.ExecuteNonQuery();
            //Sql'e baglanti kapatildi.
            con.Close();
            //Sql baglantisi acildi.
            con.Open();
            //Yeni para ekleme komutu olusturuldu.
            cmd.CommandText = cmmdStr;
            //Sql de tutulan tblMoneys tablosuna bilgiler atandi.
            cmd.Parameters.AddWithValue("UserID", this.userID);
            cmd.Parameters.AddWithValue("MoneyAmount", this.moneyTotal);
            cmd.Parameters.AddWithValue("MoneyAdminConfirm", 1);
            //Komut calistirildi.
            cmd.ExecuteNonQuery();
            //Sql'e baglanti kapatildi.
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MoneyAdd fonksiyonu cagirildi.
            MoneyAdd();
        }

        private void MoneyAdd()
        {
            try
            {
                //Yeni para ekleme komutu olusturuldu.
                cmd.CommandText = cmmdStr;
                //Sql'e baglanti saglandi.
                cmd.Connection = con;
                //Sql baglantisi acildi.
                con.Open();
                //Sql de tutulan tblMoneys tablosuna bilgiler atandi.
                cmd.Parameters.AddWithValue("UserID", this.userID);
                cmd.Parameters.AddWithValue("MoneyAmount", txbMoneyAmount.Text);
                cmd.Parameters.AddWithValue("MoneyAdminConfirm", 0);
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

        private void btnBuy_Click(object sender, EventArgs e)
        {
            //BuyFunc fonksiyonu cagirildi.
            BuyFunc();
        }

        private void BuyFunc()
        {
            //Satin alma ile ilgili degiskenler olusturuldu.
            int itemAmountTotal = 0, itemAmountMarket = 0, itemAmountWanted;
            int userItemID = 0, sellerUserID = 0, itemMoney = 0;
            //Istenen urun miktari txbItemAmount'dan alindi ve degiskene atildi.
            itemAmountWanted = Convert.ToInt32(txbItemAmount.Text);
            //Sql baglantisi acildi.
            con.Open();
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Toplam urun miktari hesaplama komutu olusturuldu.
            cmd.CommandText = "SELECT SUM(UI.ItemAmount) AS 'ItemAmountTotal' FROM tblUserItems UI " +
                              "WHERE UI.ItemID = '" + this.itemID + "' AND UI.ItemAdminConfirm = 'True'";
            //Komut calistirildi ve veri okuyucuya esitlendi.
            dr = cmd.ExecuteReader();
            //Veri okuyucu true iken calisan dongu olusturuldu.
            while (dr.Read())
            {
                //Toplam Urun degiskene atandi.
                if (dr["ItemAmountTotal"].ToString() == "")
                {
                    itemAmountTotal = 0;
                }
                else
                {
                    itemAmountTotal = Convert.ToInt32(dr["ItemAmountTotal"]);
                }
            }
            //Sql'e baglanti kapatildi.
            con.Close();
            //Eger istenen urun toplamdaki tum o urunlerden fazla ise hata mesaji verildi.
            if (itemAmountTotal < itemAmountWanted)
            {
                MessageBox.Show("Sorry, there are not as many products as you want on the market.");
            }
            //Istenen urun miktari toplamdakinden az ise buradan devam edildi.
            else
            {
                //Sql baglantisi acildi.
                con.Open();
                //Itemlari fiyatlarina gore kucukten buyuge dogru siralama komutu olusturuldu.
                cmd.CommandText = "SELECT UI.UserItemID, UI.ItemAmount, UI.ItemMoney, UI.UserID " +
                                  "FROM tblUserItems UI " +
                                  "WHERE UI.ItemID = '" + this.itemID + "' AND UI.ItemAdminConfirm = 'True' " +
                                  "ORDER BY UI.ItemMoney ASC";
                //Komut calistirildi ve veri okuyucuya esitlendi.
                dr = cmd.ExecuteReader();
                //Veri okuyucu true iken calisan kosul olusturuldu.
                if (dr.Read())
                {
                    //Veriler degiskenlere atildi.
                    itemAmountMarket = Convert.ToInt32(dr["ItemAmount"]);
                    userItemID = Convert.ToInt32(dr["UserItemID"]);
                    sellerUserID = Convert.ToInt32(dr["UserID"]);
                    itemMoney = Convert.ToInt32(dr["ItemMoney"]);
                }
                //Sql'e baglanti kapatildi.
                con.Close();
                //Eger istenen urun sayisi, marketteki en az fiyattaki urun sayisindan kucuk ise.
                if (itemAmountWanted < itemAmountMarket)
                {
                    //Sql baglantisi acildi.
                    con.Open();
                    //Alicinin parasinin azalmasini saglayacak komut olusturuldu.
                    cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount -= '" + itemMoney * itemAmountWanted + "' " +
                                      "WHERE UserID = '" + this.userID + "'";
                    //Komut calistirildi.
                    cmd.ExecuteNonQuery();
                    //Saticinin parasinin artmasini saglayacak komut olusturuldu.
                    cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount += '" + itemMoney * itemAmountWanted + "' " +
                                      "WHERE UserID = '" + sellerUserID + "'";
                    //Komut calistirildi.
                    cmd.ExecuteNonQuery();
                    //Saticinin urununun azalmasini saglayacak komut olusturuldu.
                    cmd.CommandText = "UPDATE tblUserItems SET ItemAmount -= '" + itemAmountWanted + "' " +
                                      "WHERE UserItemID = '" + userItemID + "'";
                    //Komut calistirildi.
                    cmd.ExecuteNonQuery();
                    //Sql'e baglanti kapatildi.
                    con.Close();
                }
                //Eger istenen urun sayisi, marketteki en az fiyattaki urun sayisindan buyuk ise.
                else if (itemAmountWanted >= itemAmountMarket)
                {
                    //Sql baglantisi acildi.
                    con.Open();
                    //Alicinin parasinin azalmasini saglayacak komut olusturuldu.
                    cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount -= '" + itemMoney * itemAmountMarket + "' " +
                                      "WHERE UserID = '" + this.userID + "'";
                    //Komut calistirildi.
                    cmd.ExecuteNonQuery();
                    //Saticinin parasinin artmasini saglayacak komut olusturuldu.
                    cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount += '" + itemMoney * itemAmountMarket + "' " +
                                      "WHERE UserID = '" + sellerUserID + "'";
                    //Komut calistirildi.
                    cmd.ExecuteNonQuery();
                    //Saticinin urununun azalmasini saglayacak komut olusturuldu.
                    cmd.CommandText = "DELETE FROM tblUserItems WHERE UserItemID = '" + userItemID + "'";
                    //Komut calistirildi.
                    cmd.ExecuteNonQuery();
                    //Alici istedigi kadar urunu alamadigi icin islemler tekrarlandi.(BuyFunc cagirilarak.)
                    BuyFunc();
                    //Sql'e baglanti kapatildi.
                    con.Close();
                }
                //Eger istenen urun sayisi, marketteki en az fiyattaki urun sayisina esit ise.
                else if (itemAmountWanted == itemAmountMarket)
                {
                    //Sql baglantisi acildi.
                    con.Open();
                    //Alicinin parasinin azalmasini saglayacak komut olusturuldu.
                    cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount -= '" + itemMoney * itemAmountWanted + "' " +
                                      "WHERE UserID = '" + this.userID + "'";
                    //Komut calistirildi.
                    cmd.ExecuteNonQuery();
                    //Saticinin parasinin artmasini saglayacak komut olusturuldu.
                    cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount += '" + itemMoney * itemAmountWanted + "' " +
                                      "WHERE UserID = '" + sellerUserID + "'";
                    //Komut calistirildi.
                    cmd.ExecuteNonQuery();
                    //Saticinin urununun azalmasini saglayacak komut olusturuldu.
                    cmd.CommandText = "DELETE FROM tblUserItems WHERE UserItemID = '" + userItemID + "'";
                    //Komut calistirildi.
                    cmd.ExecuteNonQuery();
                    //Sql'e baglanti kapatildi.
                    con.Close();
                }
            }
            //DgvMyMoneyAmountUpdate fonksiyonu cagirildi.
            DgvMyMoneyAmountUpdate();
            //DgvProductUpdate fonksiyonu cagirildi.
            DgvProductUpdate();
        }

        private void frmReceiving_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Cikis islemi saglandi.
            Application.Exit();
        }
    }
}
