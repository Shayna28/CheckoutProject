namespace Checkout_Project
{
    partial class WelcomePage
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
            this.btnLoginPage = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoginPage
            // 
            this.btnLoginPage.Location = new System.Drawing.Point(137, 149);
            this.btnLoginPage.Name = "btnLoginPage";
            this.btnLoginPage.Size = new System.Drawing.Size(75, 23);
            this.btnLoginPage.TabIndex = 0;
            this.btnLoginPage.Text = "LOGIN";
            this.btnLoginPage.UseVisualStyleBackColor = true;
            this.btnLoginPage.Click += new System.EventHandler(this.btnLoginPage_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(80, 37);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(199, 45);
            this.Welcome.TabIndex = 1;
            this.Welcome.Text = "WELCOME";
            // 
            // WelcomePage
            // 
            this.ClientSize = new System.Drawing.Size(345, 306);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.btnLoginPage);
            this.Name = "WelcomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLoginForm;
        private System.Windows.Forms.Button btnLoginPage;
        private System.Windows.Forms.Label Welcome;
    }
}

