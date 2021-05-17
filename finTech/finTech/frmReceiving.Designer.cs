
namespace finTech
{
    partial class frmReceiving
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
            this.lblReceiving = new System.Windows.Forms.Label();
            this.dgvMyMoneyAmount = new System.Windows.Forms.DataGridView();
            this.CMoneyAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbMoneyAmount = new System.Windows.Forms.TextBox();
            this.lblMoneyAmount = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txbItemAmount = new System.Windows.Forms.TextBox();
            this.lblItemAmount = new System.Windows.Forms.Label();
            this.lblProductMarket = new System.Windows.Forms.Label();
            this.dgvProductMarket = new System.Windows.Forms.DataGridView();
            this.CUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyMoneyAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductMarket)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReceiving
            // 
            this.lblReceiving.AutoSize = true;
            this.lblReceiving.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReceiving.ForeColor = System.Drawing.Color.Navy;
            this.lblReceiving.Location = new System.Drawing.Point(310, 9);
            this.lblReceiving.Name = "lblReceiving";
            this.lblReceiving.Size = new System.Drawing.Size(177, 39);
            this.lblReceiving.TabIndex = 12;
            this.lblReceiving.Text = "Receiving";
            // 
            // dgvMyMoneyAmount
            // 
            this.dgvMyMoneyAmount.BackgroundColor = System.Drawing.Color.Peru;
            this.dgvMyMoneyAmount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvMyMoneyAmount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvMyMoneyAmount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyMoneyAmount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CMoneyAmount});
            this.dgvMyMoneyAmount.Location = new System.Drawing.Point(12, 208);
            this.dgvMyMoneyAmount.Name = "dgvMyMoneyAmount";
            this.dgvMyMoneyAmount.ReadOnly = true;
            this.dgvMyMoneyAmount.RowHeadersVisible = false;
            this.dgvMyMoneyAmount.Size = new System.Drawing.Size(136, 71);
            this.dgvMyMoneyAmount.TabIndex = 35;
            // 
            // CMoneyAmount
            // 
            this.CMoneyAmount.DataPropertyName = "MoneyTotal";
            this.CMoneyAmount.HeaderText = "MoneyAmount";
            this.CMoneyAmount.Name = "CMoneyAmount";
            this.CMoneyAmount.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdd.Location = new System.Drawing.Point(12, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 28);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbMoneyAmount
            // 
            this.txbMoneyAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbMoneyAmount.Location = new System.Drawing.Point(12, 121);
            this.txbMoneyAmount.Name = "txbMoneyAmount";
            this.txbMoneyAmount.Size = new System.Drawing.Size(136, 26);
            this.txbMoneyAmount.TabIndex = 36;
            // 
            // lblMoneyAmount
            // 
            this.lblMoneyAmount.AutoSize = true;
            this.lblMoneyAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMoneyAmount.ForeColor = System.Drawing.Color.Navy;
            this.lblMoneyAmount.Location = new System.Drawing.Point(15, 87);
            this.lblMoneyAmount.Name = "lblMoneyAmount";
            this.lblMoneyAmount.Size = new System.Drawing.Size(128, 20);
            this.lblMoneyAmount.TabIndex = 37;
            this.lblMoneyAmount.Text = "Money Amount";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.Maroon;
            this.btnHome.Location = new System.Drawing.Point(12, 483);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(136, 28);
            this.btnHome.TabIndex = 39;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(253, 357);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(136, 28);
            this.cmbProduct.TabIndex = 41;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProduct.ForeColor = System.Drawing.Color.Navy;
            this.lblProduct.Location = new System.Drawing.Point(172, 360);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(76, 20);
            this.lblProduct.TabIndex = 40;
            this.lblProduct.Text = "Product:";
            // 
            // txbItemAmount
            // 
            this.txbItemAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbItemAmount.Location = new System.Drawing.Point(544, 357);
            this.txbItemAmount.Name = "txbItemAmount";
            this.txbItemAmount.Size = new System.Drawing.Size(136, 26);
            this.txbItemAmount.TabIndex = 42;
            // 
            // lblItemAmount
            // 
            this.lblItemAmount.AutoSize = true;
            this.lblItemAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItemAmount.ForeColor = System.Drawing.Color.Navy;
            this.lblItemAmount.Location = new System.Drawing.Point(395, 360);
            this.lblItemAmount.Name = "lblItemAmount";
            this.lblItemAmount.Size = new System.Drawing.Size(143, 20);
            this.lblItemAmount.TabIndex = 43;
            this.lblItemAmount.Text = "Product Amount:";
            // 
            // lblProductMarket
            // 
            this.lblProductMarket.AutoSize = true;
            this.lblProductMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductMarket.ForeColor = System.Drawing.Color.Navy;
            this.lblProductMarket.Location = new System.Drawing.Point(172, 87);
            this.lblProductMarket.Name = "lblProductMarket";
            this.lblProductMarket.Size = new System.Drawing.Size(196, 20);
            this.lblProductMarket.TabIndex = 45;
            this.lblProductMarket.Text = "Products on the market";
            // 
            // dgvProductMarket
            // 
            this.dgvProductMarket.BackgroundColor = System.Drawing.Color.Peru;
            this.dgvProductMarket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvProductMarket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvProductMarket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductMarket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUserID,
            this.CName,
            this.CItemID,
            this.CItemName,
            this.CItemAmount,
            this.CItemMoney});
            this.dgvProductMarket.Location = new System.Drawing.Point(176, 121);
            this.dgvProductMarket.Name = "dgvProductMarket";
            this.dgvProductMarket.ReadOnly = true;
            this.dgvProductMarket.RowHeadersVisible = false;
            this.dgvProductMarket.Size = new System.Drawing.Size(603, 214);
            this.dgvProductMarket.TabIndex = 44;
            // 
            // CUserID
            // 
            this.CUserID.DataPropertyName = "UserID";
            this.CUserID.HeaderText = "UserID";
            this.CUserID.Name = "CUserID";
            this.CUserID.ReadOnly = true;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "Name";
            this.CName.HeaderText = "Name";
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            // 
            // CItemID
            // 
            this.CItemID.DataPropertyName = "ItemID";
            this.CItemID.HeaderText = "ItemID";
            this.CItemID.Name = "CItemID";
            this.CItemID.ReadOnly = true;
            // 
            // CItemName
            // 
            this.CItemName.DataPropertyName = "ItemName";
            this.CItemName.HeaderText = "ItemName";
            this.CItemName.Name = "CItemName";
            this.CItemName.ReadOnly = true;
            // 
            // CItemAmount
            // 
            this.CItemAmount.DataPropertyName = "ItemAmount";
            this.CItemAmount.HeaderText = "ItemAmount";
            this.CItemAmount.Name = "CItemAmount";
            this.CItemAmount.ReadOnly = true;
            // 
            // CItemMoney
            // 
            this.CItemMoney.DataPropertyName = "ItemMoney";
            this.CItemMoney.HeaderText = "ItemMoney";
            this.CItemMoney.Name = "CItemMoney";
            this.CItemMoney.ReadOnly = true;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuy.ForeColor = System.Drawing.Color.Maroon;
            this.btnBuy.Location = new System.Drawing.Point(384, 401);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(136, 28);
            this.btnBuy.TabIndex = 46;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // frmReceiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(799, 523);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lblProductMarket);
            this.Controls.Add(this.dgvProductMarket);
            this.Controls.Add(this.txbItemAmount);
            this.Controls.Add(this.lblItemAmount);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbMoneyAmount);
            this.Controls.Add(this.lblMoneyAmount);
            this.Controls.Add(this.dgvMyMoneyAmount);
            this.Controls.Add(this.lblReceiving);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReceiving";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receiving";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReceiving_FormClosed);
            this.Load += new System.EventHandler(this.frmReceiving_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyMoneyAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductMarket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceiving;
        private System.Windows.Forms.DataGridView dgvMyMoneyAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbMoneyAmount;
        private System.Windows.Forms.Label lblMoneyAmount;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txbItemAmount;
        private System.Windows.Forms.Label lblItemAmount;
        private System.Windows.Forms.Label lblProductMarket;
        private System.Windows.Forms.DataGridView dgvProductMarket;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemMoney;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMoneyAmount;
    }
}