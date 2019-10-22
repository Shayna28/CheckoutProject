using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Checkout_Project
{
    public partial class PaymentPage : Form
    {
        public PaymentPage()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try{

                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Checkout;Integrated Security=True");
                String sql = "INSERT INTO Orders (OrderId,Amount,CardNumber,ExpiryDate,Cvv) VALUES (@OrderId,@Amount,@CardNumber,@ExpiryDate,@Cvv)";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Orderid", txtOrderId.Text);
                cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                cmd.Parameters.AddWithValue("@CardNumber", txtCardNumber.Text);
                cmd.Parameters.AddWithValue("@ExpiryDate", txtExpiryDate.Text);
                cmd.Parameters.AddWithValue("@Cvv", txtCvv.Text);
            
                int i = cmd.ExecuteNonQuery();

                con.Close();

                if (i != 0)
                {
                    MessageBox.Show("Data Saved");
                    System.Windows.Forms.Application.ExitThread();
                }
            }

            catch (Exception e)
            {
                 MessageBox.Show("Error");
                System.Windows.Forms.Application.ExitThread();
            }

        }
    }
}
