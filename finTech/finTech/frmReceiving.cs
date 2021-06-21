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
        private string cmmdStr = "INSERT INTO tblMoneys (UserID, MoneyAmount, MoneyType, MoneyAdminConfirm) " +
                                               "VALUES (@UserID,@MoneyAmount,@MoneyType,@MoneyAdminConfirm)";
        //Kullanicinin userID'si diger formlara aktarilmasi icin public olusturuldu.
        public int userID;
        //Form icinde kullanilacak gerekli degiskenler tanimlandi.
        private int itemID;
        private int moneyTotal;
        private int ItemMoney;
        private int UserItemID;
        private int BItemAmount;
        private string moneyType;

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
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();
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
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();
            //Sql baglantisi acildi.
            con.Open();
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
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
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();
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
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();
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
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();
            //Kullanicinin toplam parasini bulma komutu olusturuldu.
            cmd.CommandText = "SELECT SUM(M.MoneyAmount) AS 'MoneyTotal' FROM tblMoneys M " +
                              "WHERE M.UserID = '" + this.userID + "' AND M.MoneyAdminConfirm = 'True'";
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql baglantisi acildi.
            con.Open();
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
            lblMyMoneyAmount.Text = this.moneyTotal.ToString() + " TL"; 
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
            cmd.Parameters.AddWithValue("MoneyType", "TurkLirasi");
            cmd.Parameters.AddWithValue("MoneyAdminConfirm", 1);
            //Komut calistirildi.
            cmd.ExecuteNonQuery();
            //Sql'e baglanti kapatildi.
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Combobox'taki veriye gore moneyType degiskenini degistirme sorgulari yazildi.
            if (cmbMoney.Text == "TurkLirasi")
                moneyType = "TurkLirasi";
            else if (cmbMoney.Text == "Sterlin")
                moneyType = "Sterlin";
            else if (cmbMoney.Text == "IsvicreFranki")
                moneyType = "IsvicreFranki";
            else if (cmbMoney.Text == "Euro")
                moneyType = "Euro";

            //MoneyAdd fonksiyonu cagirildi.
            MoneyAdd(moneyType);
        }

        private void MoneyAdd(string moneyType)
        {
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();
            try
            {
                //Sql baglantisi acildi.
                con.Open();
                //Yeni para ekleme komutu olusturuldu.
                cmd.CommandText = "INSERT INTO tblMoneys (UserID, MoneyAmount, MoneyType, MoneyAdminConfirm) " +
                                                "VALUES (@userid,@money,@MoneyType,@Adminconfirm)";
                //Sql'e baglanti saglandi.
                cmd.Connection = con;
                //Sql de tutulan tblMoneys tablosuna bilgiler atandi.
                cmd.Parameters.AddWithValue("useriD", this.userID);
                cmd.Parameters.AddWithValue("money", txbMoneyAmount.Text);
                cmd.Parameters.AddWithValue("MoneyType", moneyType);
                cmd.Parameters.AddWithValue("Adminconfirm", 0);
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
            int itemAmountWanted;
            //Istenen urun miktari txbItemAmount'dan alindi ve degiskene atildi.
            itemAmountWanted = Convert.ToInt32(txbItemAmount.Text);

            //BuyFunc fonksiyonu cagirildi.
            BuyFunc(itemAmountWanted);
        }

        private void BuyFunc(int itemAmountWanted)
        {
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();
            //Satin alma ile ilgili degiskenler olusturuldu.
            int itemAmountTotal = 0, itemAmountMarket = 0;
            int userItemID = 0, sellerUserID = 0, itemMoney = 0;
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
            else if (txbSetPrice.Enabled == false)
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
                    cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount -= '" + (itemMoney * itemAmountWanted) * 101 / 100 + "' " +
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

                    string BuyOrSell = "Buy";
                    //Alici raporu olusturma fonksiyonu cagirildi.
                    GenerateReport(BuyOrSell, itemMoney);

                    itemAmountWanted -= itemAmountMarket;
                }
                //Eger istenen urun sayisi, marketteki en az fiyattaki urun sayisindan buyuk ise.
                else if (itemAmountWanted > itemAmountMarket)
                {
                    //Sql baglantisi acildi.
                    con.Open();
                    //Alicinin parasinin azalmasini saglayacak komut olusturuldu.
                    cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount -= '" + (itemMoney * itemAmountWanted) * 101 / 100 + "' " +
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
                    //Sql'e baglanti kapatildi.
                    con.Close();

                    string BuyOrSell = "Buy";
                    //Alici raporu olusturma fonksiyonu cagirildi.
                    GenerateReport(BuyOrSell, itemMoney);

                    itemAmountWanted -= itemAmountMarket;
                    //Alici istedigi kadar urunu alamadigi icin islemler tekrarlandi.(BuyFunc cagirilarak.)
                    BuyFunc(itemAmountWanted);
                }
                //Eger istenen urun sayisi, marketteki en az fiyattaki urun sayisina esit ise.
                else if (itemAmountWanted == itemAmountMarket)
                {
                    //Sql baglantisi acildi.
                    con.Open();
                    //Alicinin parasinin azalmasini saglayacak komut olusturuldu.
                    cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount -= '" + (itemMoney * itemAmountWanted) * 101 / 100 + "' " +
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

                    string BuyOrSell = "Buy";
                    //Alici raporu olusturma fonksiyonu cagirildi.
                    GenerateReport(BuyOrSell, itemMoney);

                    itemAmountWanted -= itemAmountMarket;
                }
            }

            bool control = false;
            int setPrice = 0, setItemAmount = 0;
            //Istek fiyat ve istek urun miktari degiskenlerine degerleri atandi.
            setPrice = Convert.ToInt32(txbSetPrice.Text);
            setItemAmount = Convert.ToInt32(txbItemAmount.Text);

            //Sql baglantisi acildi.
            con.Open();
            //Itemlari fiyatlarina gore kucukten buyuge dogru siralama komutu olusturuldu.
            cmd.CommandText = "SELECT UI.ItemMoney FROM tblUserItems UI " +
                              "WHERE UI.ItemID = '" + this.itemID + "' AND UI.ItemMoney = '" + setPrice + "' AND UI.ItemAdminConfirm = 'True' ";
            //Komut calistirildi ve veri okuyucuya esitlendi.
            dr = cmd.ExecuteReader();
            //Veri okuyucu true iken calisan kosul olusturuldu.
            if (dr.Read())
            {
                control = true;
            }
            //Sql'e baglanti kapatildi.
            con.Close();


            if(control)
            {
                return;
            }
            //Istek fiyat aktif ise calisan sorgu yazildi.
            else if (txbSetPrice.Enabled == true)
            {
                if(this.moneyTotal < (setPrice * setItemAmount) * 101 / 100)
                {
                    MessageBox.Show("Purchase failed!!!\nYou don't have enough balance.");
                }
                else
                {
                    con.Open();
                    //Rapor olusturma komutu yazildi.
                    cmd.CommandText = "INSERT INTO tblPurchaseRequests (UserID, ItemID, SetAmount, SetPrice)" +
                                                              "VALUES (@UserID,@ItemID,@SetAmount,@SetPrice)";
                    cmd.Parameters.AddWithValue("UserID", this.userID);
                    cmd.Parameters.AddWithValue("ItemID", this.itemID);
                    cmd.Parameters.AddWithValue("SetAmount", setItemAmount);
                    cmd.Parameters.AddWithValue("SetPrice", setPrice);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    //Istek fiyat ve item idsinden satici userID'sini bulan komut yazildi.
                    cmd.CommandText = "SELECT UI.UserID FROM tblUserItems UI " +
                                      "WHERE UI.ItemMoney = '" + setPrice + "' AND UI.ItemID = '" + this.itemID + "'";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        //Bulunan satici id'si degiskene atandi.
                        sellerUserID = Convert.ToInt32(dr["UserID"]);

                        //Urun miktari hesaplayan fonksiyon cagirildi.
                        itemAmountMarket = QuantityControl(sellerUserID);
                        //Rapor olusturma fonksiyonu cagirildi.
                        PurchaseRequest(sellerUserID, setItemAmount, itemAmountMarket);
                    }
                    else
                    {
                        MessageBox.Show("No product found for the price you requested.\n" +
                                        "Your purchase will take place when there are enough products in the market.");
                    }
                    con.Close();
                }
            }

            //DgvMyMoneyAmountUpdate fonksiyonu cagirildi.
            DgvMyMoneyAmountUpdate();
            //DgvProductUpdate fonksiyonu cagirildi.
            DgvProductUpdate();

        }

        private void GenerateReport(string BuyOrSell, int itemMoney)
        {
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            //Istek urun miktari degiskene atandi.
            BItemAmount = Convert.ToInt32(txbItemAmount.Text);
            
            con.Open();
            //Rapor olusturma komutu yazildi.
            cmd.CommandText = "INSERT INTO tblReports (UserID, ItemID, ItemAmount, ItemMoney, History, BuyOrSell) " +
                                             "VALUES (@UserID,@ItemID,@ItemAmount,@ItemMoney,@History,@BuyOrSell)";
            cmd.Parameters.AddWithValue("UserID", this.userID);
            cmd.Parameters.AddWithValue("ItemID", this.itemID);
            cmd.Parameters.AddWithValue("ItemAmount", BItemAmount);
            cmd.Parameters.AddWithValue("ItemMoney", itemMoney);
            cmd.Parameters.AddWithValue("History", DateTime.Now.ToString("M/d/yyyy"));
            cmd.Parameters.AddWithValue("BuyOrSell", BuyOrSell);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private int QuantityControl(int sellerUserID)
        {
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();

            int itemAmountMarket = 0;

            cmd.Connection = con;
            con.Open();
            //Satici id'si ve item id'sinden itemin parasini bulan komut yazildi.
            cmd.CommandText = "SELECT UI.ItemAmount, UI.ItemMoney, UI.UserItemID FROM tblUserItems UI " +
                              "WHERE UI.UserID = '" + sellerUserID + "' AND UI.ItemID = '" + this.itemID + "'";
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                //Bulunan veriler degiskenlere atandi.
                itemAmountMarket = Convert.ToInt32(dr["ItemAmount"]);
                this.ItemMoney = Convert.ToInt32(dr["ItemMoney"]);
                this.UserItemID = Convert.ToInt32(dr["UserItemID"]);
            }
            con.Close();

            return itemAmountMarket;
        }

        private void PurchaseRequest(int sellerUserID, int setItemAmount, int itemAmountMarket)
        {
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();

            int purchaseRequestID = 0;

            con.Open();
            cmd.Connection = con;
            //User id ve item id'den Istek urun id'sini bulan komut yazildi.
            cmd.CommandText = "SELECT PR.PurchaseRequestID FROM tblPurchaseRequests PR " +
                              "WHERE PR.UserID = '" + this.userID + "' AND PR.ItemID = '" + this.itemID + "'";
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                //Bulunan veri degiskene atandi.
                purchaseRequestID = Convert.ToInt32(dr["PurchaseRequestID"]);
            }
            con.Close();


            if (setItemAmount > itemAmountMarket)
            {
                MessageBox.Show("There are not as many products as you want in the market.\n" +
                                "Your purchase will take place when there are enough products in the market.");
            }
            else if (setItemAmount < itemAmountMarket)
            {
                con.Open();
                cmd.Connection = con;
                //Alicinin parasini azaltma komutu yazildi.
                cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount -= '" + (this.ItemMoney * setItemAmount) * 101 / 100 + "' " +
                                  "WHERE UserID = '" + this.userID + "'";
                cmd.ExecuteNonQuery();
                //Saticinin parasini arttirma komutu yazildi.
                cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount += '" + this.ItemMoney * setItemAmount + "' " +
                                  "WHERE UserID = '" + sellerUserID + "'";
                cmd.ExecuteNonQuery();
                //Saticinin urununu azaltma komutu yazildi.
                cmd.CommandText = "UPDATE tblUserItems SET ItemAmount -= '" + setItemAmount + "' " +
                                  "WHERE UserItemID = '" + this.UserItemID + "'";
                cmd.ExecuteNonQuery();
                //Alinacak listesinden silme komutu yazildi.
                cmd.CommandText = "DELETE FROM tblPurchaseRequests WHERE PurchaseRequestID = '" + purchaseRequestID + "'";
                cmd.ExecuteNonQuery();

                con.Close();

                string BuyOrSell = "Buy";
                //Alici raporu olusturma fonksiyonu cagirildi.
                GenerateReport(BuyOrSell,this.ItemMoney);

                setItemAmount -= itemAmountMarket;
            }
            else if(setItemAmount == itemAmountMarket)
            {
                con.Open();
                cmd.Connection = con;
                //Alicinin parasini azaltma komutu yazildi.
                cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount -= '" + (this.ItemMoney * setItemAmount) * 101 / 100 + "' " +
                                  "WHERE UserID = '" + this.userID + "'";
                cmd.ExecuteNonQuery();
                //Saticinin parasini arttirma komutu yazildi.
                cmd.CommandText = "UPDATE tblMoneys SET MoneyAmount += '" + this.ItemMoney * setItemAmount + "' " +
                                  "WHERE UserID = '" + sellerUserID + "'";
                cmd.ExecuteNonQuery();
                //Saticinin urununu silme komutu yazildi.
                cmd.CommandText = "DELETE FROM tblUserItems WHERE UserItemID = '" + this.UserItemID + "'";
                cmd.ExecuteNonQuery();
                //Alinacak listesinden silme komutu yazildi.
                cmd.CommandText = "DELETE FROM tblPurchaseRequests WHERE PurchaseRequestID = '" + purchaseRequestID + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                string BuyOrSell = "Buy";
                //Alici raporu olusturma fonksiyonu cagirildi.
                GenerateReport(BuyOrSell, this.ItemMoney);

                setItemAmount -= itemAmountMarket;
            }
        }

        private void chbSetPrice_CheckedChanged(object sender, EventArgs e)
        {
            //Istek fiyat tiklanmis mi tiklanmamis mi bulan sorgu yazildi.
            if (chbSetPrice.Checked == true)
                txbSetPrice.Enabled = true;
            else
                txbSetPrice.Enabled = false;
        }

        private void frmReceiving_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Cikis islemi saglandi.
            Application.Exit();
        }
    }
}
