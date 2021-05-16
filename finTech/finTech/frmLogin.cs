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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private string connStr = @"Data Source=.\;Initial Catalog=finTech;Integrated Security=True";
        public int userID;

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            frmHome formHome = new frmHome();
            SqlDataReader dr;

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT U.UserID FROM tblUsers U WHERE U.UserName = '" + 
                                                                    txbUserName.Text + "'";
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                this.userID = Convert.ToInt32(dr["UserID"]);
                formHome.userID = this.userID;
            }
            con.Close();

            con.Open();
            cmd.CommandText = "SELECT * from tblUsers U WHERE U.UserName = '" + 
                                                             txbUserName.Text + "' AND" +
                                                            " U.Password = '" + 
                                                             txbPassword.Text + "'";
            dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                MessageBox.Show("Logging into your account.");
                
                formHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check your username and password.");
            }
            con.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister formRegister = new frmRegister();
            formRegister.Show();
            this.Hide();
        }
    }
}
