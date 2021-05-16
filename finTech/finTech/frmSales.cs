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

namespace finTech
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }
        
        private string connStr = @"Data Source=.\;Initial Catalog=finTech;Integrated Security=True";
        private string cmmdStr = "INSERT INTO tblUserItems (UserID," +
                                                           "ItemID," +
                                                           "ItemAmount," +
                                                           "ItemMoney," +
                                                           "ItemAdminConfirm) " +
                                                           "VALUES (@UserID," +
                                                                   "@ItemID," +
                                                                   "@ItemAmount," +
                                                                   "@ItemMoney," +
                                                                   "@ItemAdminConfirm)";
        public int userID;
        public int itemID;

        private void frmSales_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("SELECT I.ItemName FROM tblItems I", con);
            SqlDataReader dr;

            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbProduct.Items.Add(dr["ItemName"]);
            }
            con.Close();

            con.Open();
            cmd.CommandText = "SELECT UI.ItemID, I.ItemName, UI.ItemAmount, UI.ItemMoney " +
                             "FROM tblUserItems UI INNER JOIN tblItems I ON UI.ItemID = I.ItemID " +
                             "WHERE UI.UserID = '" + userID + "' AND UI.ItemAdminConfirm = 'True'";
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapt.Fill(ds);

            dgvMyProductForSale.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(cmmdStr, con);
                cmd.Parameters.AddWithValue("UserID", this.userID);
                cmd.Parameters.AddWithValue("ItemID", this.itemID);
                cmd.Parameters.AddWithValue("ItemAmount", Convert.ToInt32(txbItemAmount.Text));
                cmd.Parameters.AddWithValue("ItemMoney", Convert.ToInt32(txbPrice.Text));
                cmd.Parameters.AddWithValue("ItemAdminConfirm", 0);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Add successful.\nApproval is pending.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed.\nError:" + ex.Message);
                throw ex;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome formHome = new frmHome();
            formHome.userID = this.userID;
            formHome.Show();
            this.Hide();
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT I.ItemID FROM tblItems I WHERE I.ItemName = '" +
                                                                     cmbProduct.Text + "'";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                this.itemID = Convert.ToInt32(dr["ItemID"]);
            }
            con.Close();
        }
    }
}
