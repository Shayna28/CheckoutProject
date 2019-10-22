using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Checkout_Project
{
    public partial class OrderPage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Checkout;Integrated Security=True");
        SqlDataAdapter adpt;
        DataTable dt;
        public OrderPage()
        {
            InitializeComponent();
            showdata();
        }

        private void btnUserPage_Click(object sender, EventArgs e)
        {
            new UserPage().Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        public void showdata()
        {
            adpt = new SqlDataAdapter("select * from Orders", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dtOrders.DataSource = dt;
        }


    }
    
}

