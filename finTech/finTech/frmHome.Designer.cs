
namespace finTech
{
    partial class frmHome
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnSellScreen = new System.Windows.Forms.Button();
            this.btnPurchaseScreen = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogin.ForeColor = System.Drawing.Color.Navy;
            this.lblLogin.Location = new System.Drawing.Point(136, 34);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(426, 39);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "WELCOME TO FINTECH";
            // 
            // btnSellScreen
            // 
            this.btnSellScreen.BackColor = System.Drawing.SystemColors.Control;
            this.btnSellScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSellScreen.ForeColor = System.Drawing.Color.Maroon;
            this.btnSellScreen.Location = new System.Drawing.Point(51, 134);
            this.btnSellScreen.Name = "btnSellScreen";
            this.btnSellScreen.Size = new System.Drawing.Size(293, 168);
            this.btnSellScreen.TabIndex = 7;
            this.btnSellScreen.Text = "Sales Screen";
            this.btnSellScreen.UseVisualStyleBackColor = false;
            this.btnSellScreen.Click += new System.EventHandler(this.btnSellScreen_Click);
            // 
            // btnPurchaseScreen
            // 
            this.btnPurchaseScreen.BackColor = System.Drawing.SystemColors.Control;
            this.btnPurchaseScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPurchaseScreen.ForeColor = System.Drawing.Color.Maroon;
            this.btnPurchaseScreen.Location = new System.Drawing.Point(350, 134);
            this.btnPurchaseScreen.Name = "btnPurchaseScreen";
            this.btnPurchaseScreen.Size = new System.Drawing.Size(293, 168);
            this.btnPurchaseScreen.TabIndex = 8;
            this.btnPurchaseScreen.Text = "Receiving Screen";
            this.btnPurchaseScreen.UseVisualStyleBackColor = false;
            this.btnPurchaseScreen.Click += new System.EventHandler(this.btnPurchaseScreen_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdmin.Location = new System.Drawing.Point(51, 308);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(592, 50);
            this.btnAdmin.TabIndex = 9;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(694, 428);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnPurchaseScreen);
            this.Controls.Add(this.btnSellScreen);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnSellScreen;
        private System.Windows.Forms.Button btnPurchaseScreen;
        private System.Windows.Forms.Button btnAdmin;
    }
}