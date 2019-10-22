using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Checkout_Project
{
    public partial class LoginPage : Form
    {
        SqlConnection con = new SqlConnection();
        public LoginPage()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Checkout;Integrated Security=True";
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Checkout;Integrated Security=True");
            con.Open();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new WelcomePage().Show();
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Checkout;Integrated Security=True";
            con.Open();

            string username = txtUserName.Text;
            string userpassword = txtPassword.Text;

            SqlCommand cmd = new SqlCommand("select username,userpassword from users where username='" + txtUserName.Text + "'and userpassword='" + txtPassword.Text + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                new UserPage().Show();
                Hide();
                
            }
            else
            {
                MessageBox.Show("Invalid Login please check username or password");
            }
            con.Close();

        }


    }
}
