namespace Checkout_Project
{
    partial class UserPage
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
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(53, 58);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(153, 87);
            this.btnPayment.TabIndex = 0;
            this.btnPayment.Text = "Make Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(331, 59);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(151, 86);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "View Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 212);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnPayment);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnOrders;
    }
}