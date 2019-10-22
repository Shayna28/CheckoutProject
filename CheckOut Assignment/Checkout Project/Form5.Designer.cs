namespace Checkout_Project
{
    partial class OrderPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnUserPage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtOrders = new System.Windows.Forms.DataGridView();
            this.checkoutDataSet1 = new Checkout_Project.CheckoutDataSet1();
            this.checkoutDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUserPage
            // 
            this.btnUserPage.Location = new System.Drawing.Point(100,300);
            this.btnUserPage.Name = "btnUserPage";
            this.btnUserPage.Size = new System.Drawing.Size(75, 38);
            this.btnUserPage.TabIndex = 0;
            this.btnUserPage.Text = "Back to User Page";
            this.btnUserPage.UseVisualStyleBackColor = true;
            this.btnUserPage.Click += new System.EventHandler(this.btnUserPage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(200,300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtOrders
            // 
            this.dtOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtOrders.Location = new System.Drawing.Point(13, 48);
            this.dtOrders.Name = "dtOrders";
            this.dtOrders.Size = new System.Drawing.Size(500, 200);
            this.dtOrders.TabIndex = 2;
            
            // 

            // 
            // OrderPage
            // 
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.dtOrders);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUserPage);
            this.Name = "OrderPage";
            ((System.ComponentModel.ISupportInitialize)(this.dtOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckoutDataSet1 checkoutDataSet11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource checkoutDataSet11BindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUserPage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dtOrders;
        private System.Windows.Forms.BindingSource checkoutDataSet1BindingSource;
        private CheckoutDataSet1 checkoutDataSet1;
    }
}