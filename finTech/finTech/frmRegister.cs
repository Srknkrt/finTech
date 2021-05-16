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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private string connStr = @"Data Source=.\;Initial Catalog=finTech;Integrated Security=True";
        private string cmmdStr = "INSERT INTO tblUsers (Name, " +
                                                           "Surname, " +
                                                           "UserName," +
                                                           "Password," +
                                                           "TCNumber," +
                                                           "PhoneNumber," +
                                                           "EMail," +
                                                           "Address)" +
                                                           "VALUES (@Name," +
                                                                   "@Surname," +
                                                                   "@UserName," +
                                                                   "@Password," +
                                                                   "@TCNumber," +
                                                                   "@PhoneNumber," +
                                                                   "@EMail," +
                                                                   "@Address)";

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(cmmdStr, con);
                cmd.Parameters.AddWithValue("Name", txbName.Text);
                cmd.Parameters.AddWithValue("Surname", txbSurname.Text);
                cmd.Parameters.AddWithValue("UserName", txbUserName.Text);
                cmd.Parameters.AddWithValue("Password", txbPassword.Text);
                cmd.Parameters.AddWithValue("TCNumber", txbTCNumber.Text);
                cmd.Parameters.AddWithValue("PhoneNumber", txbPhoneNumber.Text);
                cmd.Parameters.AddWithValue("EMail", txbEmail.Text);
                cmd.Parameters.AddWithValue("Address", txbAddress.Text);
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Login successful.");
                frmLogin formLogin = new frmLogin();
                formLogin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed.\nError:" + ex.Message);
                throw ex;
            }
        }
    }
}
