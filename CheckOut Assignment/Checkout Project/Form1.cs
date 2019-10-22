using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkout_Project
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }


        private void btnLoginPage_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            Hide();
        }
    }
}
