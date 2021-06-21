using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace finTech
{
    public partial class frmAdminMoney : Form
    {
        public frmAdminMoney()
        {
            InitializeComponent();
        }
        //Kullanicinin userID'si diger formlara aktarilmasi icin public olusturuldu.
        public int userID;
        //Sql'e yeni baglanti kuruldu.
        SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
        //Sql'e yeni komut olusturuldu.
        SqlCommand cmd = new SqlCommand();

        private void frmAdminMoney_Load(object sender, EventArgs e)
        {
            //DgvMoneyUpdate fonksiyonu cagirildi.
            DgvMoneyUpdate();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Dgv'den alinan verileri tutmak icin degiskenler olusturuldu.
            int CMUserID, CMoneyID;
            int CMoneyAmount;
            string CMoneyType;
            int moneyAmount;
            //Degiskenlere formda secilen veriler aktarildi.
            CMUserID = Convert.ToInt32(dgvWaitingForMoneyApproval.CurrentRow.Cells["CMUserID"].Value);
            CMoneyID = Convert.ToInt32(dgvWaitingForMoneyApproval.CurrentRow.Cells["CMoneyID"].Value);
            CMoneyAmount = Convert.ToInt32(dgvWaitingForMoneyApproval.CurrentRow.Cells["CMoneyAmount"].Value);
            CMoneyType = dgvWaitingForMoneyApproval.CurrentRow.Cells["CMoneyType"].Value.ToString();

            //Farkli doviz kurlari icin para hesabi yapan fonksiyon cagirildi.
            moneyAmount = CalculateMoney(CMoneyAmount, CMoneyType);

            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql baglantisi acildi.
            con.Open();
            //Admin onayi verme komutu olusturuldu.
            cmd.CommandText = "UPDATE tblMoneys SET MoneyAdminConfirm = 'True' , MoneyAmount = '" + moneyAmount + "'" +
                              "WHERE UserID = '" + CMUserID + "' AND MoneyID = '" + CMoneyID + "'";
            //Komut calistirildi.
            cmd.ExecuteNonQuery();
            //Sql'e baglanti kapatildi.
            con.Close();
            //DgvMoneyUpdate fonksiyonu cagirildi.
            DgvMoneyUpdate();
        }

        private int CalculateMoney(int CMoneyAmount, string CMoneyType)
        {
            //Kurlar sitesi degiskene atandi.
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            XmlDocument xmlDocument = new XmlDocument();

            xmlDocument.Load(today);

            //Gerekli para tipleri siteden cekildi.
            decimal GBP = Convert.ToDecimal(xmlDocument.SelectSingleNode("Tarih_Date/Currency [@Kod = 'GBP']/BanknoteBuying").InnerText);
            decimal CHF = Convert.ToDecimal(xmlDocument.SelectSingleNode("Tarih_Date/Currency [@Kod = 'CHF']/BanknoteBuying").InnerText);
            decimal EUR = Convert.ToDecimal(xmlDocument.SelectSingleNode("Tarih_Date/Currency [@Kod = 'USD']/BanknoteBuying").InnerText);

            //Cekilen paralar int tipine donusturuldu.
            GBP /= 10000;
            CHF /= 10000;
            EUR /= 10000;

            GBP %= 100;
            CHF %= 100;
            EUR %= 100;

            //Gerekli sorgularla para miktari degiskenlere atandi.
            if (CMoneyType == "Sterlin")
            {
                CMoneyAmount *= Convert.ToInt32(GBP);
            }
            else if (CMoneyType == "IsvicreFranki")
            {
                CMoneyAmount *= Convert.ToInt32(CHF);
            }
            else if (CMoneyType == "Euro")
            {
                CMoneyAmount *= Convert.ToInt32(EUR);
            }

            return CMoneyAmount;
        }

        private void DgvMoneyUpdate()
        {
            //Veri ekleme islemini doldurmak icin adapter olusturuldu.
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //Veri ekleme islemi icin ds olusturuldu.
            DataSet ds = new DataSet();
            //tblMoneys tablosundaki verileri cekme komutu olusturuldu.
            cmd.CommandText = "SELECT M.MoneyID, M.UserID, U.Name, M.MoneyAmount, M.MoneyType " +
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            //GoHome fonksiyonuna gidildi.
            GoHome();
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //GoAdmin fonkisyonuna gidildi.
            GoAdmin();
        }

        private void GoAdmin()
        {
            //FormHome olusturuldu.
            frmAdmin formAdmin = new frmAdmin();
            //Kullanicinin userID'si formHome'a gonderildi.
            formAdmin.userID = this.userID;
            //FormHome'a gecis yapildi.
            formAdmin.Show();
            this.Hide();
        }

        private void frmAdminMoney_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Cikis islemi saglandi.
            Application.Exit();
        }
    }
}
