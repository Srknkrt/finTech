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
    public partial class frmReceiving : Form
    {
        public frmReceiving()
        {
            InitializeComponent();
        }
       
        private string connStr = @"Data Source=.\;Initial Catalog=finTech;Integrated Security=True";
        private string cmmdStr = "INSERT INTO tblMoneys (UserID," +
                                                        "MoneyAmount," +
                                                        "MoneyAdminConfirm) " +
                                                        "VALUES (@UserID," +
                                                                "@MoneyAmount," +
                                                                "@MoneyAdminConfirm)";
        public int userID;

        private void frmReceiving_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("SELECT M.MoneyAmount FROM tblMoneys M " +
                                            "WHERE M.UserID = '" + userID + "' AND M.MoneyAdminConfirm = 'True'", con);
            con.Open();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapt.Fill(ds);

            dgvMyMoneyAmount.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(cmmdStr, con);
                cmd.Parameters.AddWithValue("UserID", this.userID);
                cmd.Parameters.AddWithValue("MoneyAmount", txbMoneyAmount.Text);
                cmd.Parameters.AddWithValue("MoneyAdminConfirm", 0);
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

    }
}
