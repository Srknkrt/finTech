
namespace finTech
{
    partial class frmAdmin
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
            this.dgvWaitingForProductApproval = new System.Windows.Forms.DataGridView();
            this.CUserItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnMoneyScreen = new System.Windows.Forms.Button();
            this.lblItemConfirm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingForProductApproval)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWaitingForProductApproval
            // 
            this.dgvWaitingForProductApproval.BackgroundColor = System.Drawing.Color.Peru;
            this.dgvWaitingForProductApproval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvWaitingForProductApproval.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvWaitingForProductApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWaitingForProductApproval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUserItemID,
            this.CUserID,
            this.CName,
            this.CItemID,
            this.CItemName,
            this.CItemAmount,
            this.CItemMoney});
            this.dgvWaitingForProductApproval.Location = new System.Drawing.Point(25, 96);
            this.dgvWaitingForProductApproval.Name = "dgvWaitingForProductApproval";
            this.dgvWaitingForProductApproval.Size = new System.Drawing.Size(745, 199);
            this.dgvWaitingForProductApproval.TabIndex = 33;
            // 
            // CUserItemID
            // 
            this.CUserItemID.DataPropertyName = "UserItemID";
            this.CUserItemID.HeaderText = "UserItemID";
            this.CUserItemID.Name = "CUserItemID";
            // 
            // CUserID
            // 
            this.CUserID.DataPropertyName = "UserID";
            this.CUserID.HeaderText = "UserID";
            this.CUserID.Name = "CUserID";
            // 
            // CName
            // 
            this.CName.DataPropertyName = "Name";
            this.CName.HeaderText = "Name";
            this.CName.Name = "CName";
            // 
            // CItemID
            // 
            this.CItemID.DataPropertyName = "ItemID";
            this.CItemID.HeaderText = "ItemID";
            this.CItemID.Name = "CItemID";
            // 
            // CItemName
            // 
            this.CItemName.DataPropertyName = "ItemName";
            this.CItemName.HeaderText = "ItemName";
            this.CItemName.Name = "CItemName";
            // 
            // CItemAmount
            // 
            this.CItemAmount.DataPropertyName = "ItemAmount";
            this.CItemAmount.HeaderText = "ItemAmount";
            this.CItemAmount.Name = "CItemAmount";
            // 
            // CItemMoney
            // 
            this.CItemMoney.DataPropertyName = "ItemMoney";
            this.CItemMoney.HeaderText = "ItemMoney";
            this.CItemMoney.Name = "CItemMoney";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Navy;
            this.lblAdmin.Location = new System.Drawing.Point(318, 9);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(119, 39);
            this.lblAdmin.TabIndex = 31;
            this.lblAdmin.Text = "Admin";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.Maroon;
            this.btnHome.Location = new System.Drawing.Point(12, 378);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(136, 28);
            this.btnHome.TabIndex = 37;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm.Location = new System.Drawing.Point(310, 318);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(142, 39);
            this.btnConfirm.TabIndex = 39;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnMoneyScreen
            // 
            this.btnMoneyScreen.BackColor = System.Drawing.SystemColors.Control;
            this.btnMoneyScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMoneyScreen.ForeColor = System.Drawing.Color.Maroon;
            this.btnMoneyScreen.Location = new System.Drawing.Point(608, 352);
            this.btnMoneyScreen.Name = "btnMoneyScreen";
            this.btnMoneyScreen.Size = new System.Drawing.Size(162, 54);
            this.btnMoneyScreen.TabIndex = 42;
            this.btnMoneyScreen.Text = "Money Confirm Screen";
            this.btnMoneyScreen.UseVisualStyleBackColor = false;
            this.btnMoneyScreen.Click += new System.EventHandler(this.btnMoneyScreen_Click);
            // 
            // lblItemConfirm
            // 
            this.lblItemConfirm.AutoSize = true;
            this.lblItemConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItemConfirm.ForeColor = System.Drawing.Color.Navy;
            this.lblItemConfirm.Location = new System.Drawing.Point(271, 57);
            this.lblItemConfirm.Name = "lblItemConfirm";
            this.lblItemConfirm.Size = new System.Drawing.Size(209, 25);
            this.lblItemConfirm.TabIndex = 43;
            this.lblItemConfirm.Text = "Item Confirm Screen";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(782, 423);
            this.Controls.Add(this.lblItemConfirm);
            this.Controls.Add(this.btnMoneyScreen);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dgvWaitingForProductApproval);
            this.Controls.Add(this.lblAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdmin_FormClosed);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingForProductApproval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWaitingForProductApproval;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUserItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemMoney;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnMoneyScreen;
        private System.Windows.Forms.Label lblItemConfirm;
    }
}