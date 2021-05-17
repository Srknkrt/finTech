
namespace finTech
{
    partial class frmSales
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
            this.lblSales = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblItemAmount = new System.Windows.Forms.Label();
            this.txbItemAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.dgvMyProductForSale = new System.Windows.Forms.DataGridView();
            this.CItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblMyProductForSale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyProductForSale)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSales.ForeColor = System.Drawing.Color.Navy;
            this.lblSales.Location = new System.Drawing.Point(290, 34);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(108, 39);
            this.lblSales.TabIndex = 11;
            this.lblSales.Text = "Sales";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProduct.ForeColor = System.Drawing.Color.Navy;
            this.lblProduct.Location = new System.Drawing.Point(215, 100);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(76, 20);
            this.lblProduct.TabIndex = 10;
            this.lblProduct.Text = "Product:";
            // 
            // cmbProduct
            // 
            this.cmbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(297, 97);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(136, 28);
            this.cmbProduct.TabIndex = 1;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // lblItemAmount
            // 
            this.lblItemAmount.AutoSize = true;
            this.lblItemAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItemAmount.ForeColor = System.Drawing.Color.Navy;
            this.lblItemAmount.Location = new System.Drawing.Point(148, 131);
            this.lblItemAmount.Name = "lblItemAmount";
            this.lblItemAmount.Size = new System.Drawing.Size(143, 20);
            this.lblItemAmount.TabIndex = 28;
            this.lblItemAmount.Text = "Product Amount:";
            // 
            // txbItemAmount
            // 
            this.txbItemAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbItemAmount.Location = new System.Drawing.Point(297, 131);
            this.txbItemAmount.Name = "txbItemAmount";
            this.txbItemAmount.Size = new System.Drawing.Size(136, 26);
            this.txbItemAmount.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdd.Location = new System.Drawing.Point(297, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbPrice
            // 
            this.txbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbPrice.Location = new System.Drawing.Point(297, 163);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(136, 26);
            this.txbPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.ForeColor = System.Drawing.Color.Navy;
            this.lblPrice.Location = new System.Drawing.Point(237, 163);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 20);
            this.lblPrice.TabIndex = 32;
            this.lblPrice.Text = "Price:";
            // 
            // dgvMyProductForSale
            // 
            this.dgvMyProductForSale.BackgroundColor = System.Drawing.Color.Peru;
            this.dgvMyProductForSale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvMyProductForSale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvMyProductForSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyProductForSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CItemID,
            this.CItemName,
            this.CItemAmount,
            this.CItemMoney});
            this.dgvMyProductForSale.Location = new System.Drawing.Point(152, 284);
            this.dgvMyProductForSale.Name = "dgvMyProductForSale";
            this.dgvMyProductForSale.ReadOnly = true;
            this.dgvMyProductForSale.RowHeadersVisible = false;
            this.dgvMyProductForSale.Size = new System.Drawing.Size(403, 139);
            this.dgvMyProductForSale.TabIndex = 34;
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
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.Maroon;
            this.btnHome.Location = new System.Drawing.Point(12, 464);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(136, 28);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblMyProductForSale
            // 
            this.lblMyProductForSale.AutoSize = true;
            this.lblMyProductForSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMyProductForSale.ForeColor = System.Drawing.Color.Navy;
            this.lblMyProductForSale.Location = new System.Drawing.Point(148, 261);
            this.lblMyProductForSale.Name = "lblMyProductForSale";
            this.lblMyProductForSale.Size = new System.Drawing.Size(216, 20);
            this.lblMyProductForSale.TabIndex = 37;
            this.lblMyProductForSale.Text = "My products in the market";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(694, 504);
            this.Controls.Add(this.lblMyProductForSale);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dgvMyProductForSale);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbItemAmount);
            this.Controls.Add(this.lblItemAmount);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.lblProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSales";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSales_FormClosed);
            this.Load += new System.EventHandler(this.frmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyProductForSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblItemAmount;
        private System.Windows.Forms.TextBox txbItemAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.DataGridView dgvMyProductForSale;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemMoney;
        private System.Windows.Forms.Label lblMyProductForSale;
    }
}