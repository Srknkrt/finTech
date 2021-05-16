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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private string connStr = @"Data Source=.\;Initial Catalog=finTech;Integrated Security=True";
        public int userID;
       
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            DgvItemUpdate();
            DgvMoneyUpdate();
        }

        private void btnConfirmMoney_Click(object sender, EventArgs e)
        {
            int CMUserID, CMoneyID;

            CMUserID = Convert.ToInt32(dgvWaitingForMoneyApproval.CurrentRow.Cells["CMUserID"].Value);
            CMoneyID = Convert.ToInt32(dgvWaitingForMoneyApproval.CurrentRow.Cells["CMoneyID"].Value);
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE tblMoneys SET MoneyAdminConfirm = 'True' WHERE UserID = '" + CMUserID + "' AND MoneyID = '" + CMoneyID + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            DgvMoneyUpdate();
        }

        private void btnConfirmItem_Click(object sender, EventArgs e)
        {
            int CUserID, CUserItemID;

            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();

            CUserID = Convert.ToInt32(dgvWaitingForProductApproval.CurrentRow.Cells["CUserID"].Value);
            CUserItemID = Convert.ToInt32(dgvWaitingForProductApproval.CurrentRow.Cells["CUserItemID"].Value);
            
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE tblUserItems SET ItemAdminConfirm = 'True' WHERE UserID = '" + CUserID + "' AND UserItemID = '" + CUserItemID + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            DgvItemUpdate();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome formHome = new frmHome();
            formHome.userID = this.userID;
            formHome.Show();
            this.Hide();
        }

        void DgvItemUpdate()
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT M.MoneyID, M.UserID, U.Name, M.MoneyAmount " +
                              "FROM tblMoneys M INNER JOIN tblUsers U ON M.UserID = U.UserID " +
                              "WHERE M.UserID = '" + this.userID + "' AND M.MoneyAdminConfirm = 'False'";
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            
            dgvWaitingForMoneyApproval.DataSource = dt;
            con.Close();
        }

        void DgvMoneyUpdate()
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT UI.UserItemID, UI.UserID, U.Name, UI.ItemID, I.ItemName, UI.ItemAmount, UI.ItemMoney " +
                              "FROM tblUserItems UI INNER JOIN tblUsers U ON UI.UserID = U.UserID " +
                                                   "INNER JOIN tblItems I ON UI.ItemID = I.ItemID " +
                              "WHERE UI.UserID = '" + this.userID + "' AND UI.ItemAdminConfirm = 'False'";
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);

            dgvWaitingForProductApproval.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
