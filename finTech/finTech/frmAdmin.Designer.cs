
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
            this.btnConfirmMoney = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvWaitingForMoneyApproval = new System.Windows.Forms.DataGridView();
            this.CMoneyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMoneyAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingForProductApproval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingForMoneyApproval)).BeginInit();
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
            this.dgvWaitingForProductApproval.Location = new System.Drawing.Point(25, 51);
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
            // btnConfirmMoney
            // 
            this.btnConfirmMoney.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfirmMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirmMoney.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirmMoney.Location = new System.Drawing.Point(628, 442);
            this.btnConfirmMoney.Name = "btnConfirmMoney";
            this.btnConfirmMoney.Size = new System.Drawing.Size(142, 39);
            this.btnConfirmMoney.TabIndex = 32;
            this.btnConfirmMoney.Text = "Confirm Money";
            this.btnConfirmMoney.UseVisualStyleBackColor = false;
            this.btnConfirmMoney.Click += new System.EventHandler(this.btnConfirmMoney_Click);
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
            this.btnHome.Location = new System.Drawing.Point(12, 475);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(136, 28);
            this.btnHome.TabIndex = 37;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dgvWaitingForMoneyApproval
            // 
            this.dgvWaitingForMoneyApproval.BackgroundColor = System.Drawing.Color.Peru;
            this.dgvWaitingForMoneyApproval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvWaitingForMoneyApproval.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvWaitingForMoneyApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWaitingForMoneyApproval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CMoneyID,
            this.CMUserID,
            this.CMName,
            this.CMoneyAmount});
            this.dgvWaitingForMoneyApproval.Location = new System.Drawing.Point(324, 281);
            this.dgvWaitingForMoneyApproval.Name = "dgvWaitingForMoneyApproval";
            this.dgvWaitingForMoneyApproval.Size = new System.Drawing.Size(446, 145);
            this.dgvWaitingForMoneyApproval.TabIndex = 38;
            // 
            // CMoneyID
            // 
            this.CMoneyID.DataPropertyName = "MoneyID";
            this.CMoneyID.HeaderText = "MoneyID";
            this.CMoneyID.Name = "CMoneyID";
            // 
            // CMUserID
            // 
            this.CMUserID.DataPropertyName = "UserID";
            this.CMUserID.HeaderText = "UserID";
            this.CMUserID.Name = "CMUserID";
            // 
            // CMName
            // 
            this.CMName.DataPropertyName = "Name";
            this.CMName.HeaderText = "Name";
            this.CMName.Name = "CMName";
            // 
            // CMoneyAmount
            // 
            this.CMoneyAmount.DataPropertyName = "MoneyAmount";
            this.CMoneyAmount.HeaderText = "MoneyAmount";
            this.CMoneyAmount.Name = "CMoneyAmount";
            // 
            // btnConfirmItem
            // 
            this.btnConfirmItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfirmItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirmItem.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirmItem.Location = new System.Drawing.Point(25, 266);
            this.btnConfirmItem.Name = "btnConfirmItem";
            this.btnConfirmItem.Size = new System.Drawing.Size(142, 39);
            this.btnConfirmItem.TabIndex = 39;
            this.btnConfirmItem.Text = "Confirm Item";
            this.btnConfirmItem.UseVisualStyleBackColor = false;
            this.btnConfirmItem.Click += new System.EventHandler(this.btnConfirmItem_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(782, 515);
            this.Controls.Add(this.btnConfirmItem);
            this.Controls.Add(this.dgvWaitingForMoneyApproval);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dgvWaitingForProductApproval);
            this.Controls.Add(this.btnConfirmMoney);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingForMoneyApproval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWaitingForProductApproval;
        private System.Windows.Forms.Button btnConfirmMoney;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUserItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemMoney;
        private System.Windows.Forms.DataGridView dgvWaitingForMoneyApproval;
        private System.Windows.Forms.Button btnConfirmItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMoneyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMoneyAmount;
    }
}