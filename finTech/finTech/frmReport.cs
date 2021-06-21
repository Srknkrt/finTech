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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace finTech
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        //Kullanicinin userID'si diger formlara aktarilmasi icin public olusturuldu.
        public int userID;
        //Form icinde kullanilacak gerekli degiskenler tanimlandi.
        private DateTime reportStartDate;
        private DateTime reportEndDate;

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            //Rapor olusturma fonksiyonu cagirildi.
            GenerateReport();
        }

        private void btnListReport_Click(object sender, EventArgs e)
        {
            //Sql'e yeni baglanti kuruldu.
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=finTech;Integrated Security=True");
            //Sql'e yeni komut olusturuldu.
            SqlCommand cmd = new SqlCommand();
            //Veri ekleme islemini doldurmak icin adapter olusturuldu.
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //Veri ekleme islemi icin ds olusturuldu.
            DataSet ds = new DataSet();

            //Rapor olusturma komutu yazildi.
            cmd.CommandText = "SELECT ReportID, UserID, ItemID, ItemAmount, ItemMoney, History, BuyOrSell " +
                              "FROM tblReports WHERE UserID = '" + this.userID + "' AND " +
                              "History BETWEEN '" + this.reportStartDate.ToString("MM/dd/yyyy") + "' AND '" + this.reportEndDate.ToString("MM/dd/yyyy") + "'";
            //Sql'e baglanti saglandi.
            cmd.Connection = con;
            //Sql baglantisi acildi.
            con.Open();
            //Veriler eklendi.
            adapt.Fill(ds);
            //Eklenen veriler ekrana bastirildi.
            dgvReports.DataSource = ds.Tables[0];
            //Sql'e baglanti kapatildi.
            con.Close();
        }

        private void GenerateReport()
        {
            //Excele rapor olusturuldu.
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;

            for (int x = 0; x < dgvReports.SelectedRows.Count; x++)
            {
                for (int j = 0; j < dgvReports.SelectedRows[x].Cells.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dgvReports.SelectedRows[x].Cells[j].Value == null ? "" : dgvReports.SelectedRows[x].Cells[j].Value;
                }
                StartRow++;
            }
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

        private void mcdReportTime_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Formda CDR'dan tarih sectikce guncellenen ve ilgili degiskene atanan kodlar yazildi.
            this.reportStartDate = Convert.ToDateTime(e.Start.ToLongDateString());
            this.reportEndDate = Convert.ToDateTime(e.End.ToLongDateString());
        }

        private void frmReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Cikis islemi saglandi.
            System.Windows.Forms.Application.Exit();
        }
    }
}
