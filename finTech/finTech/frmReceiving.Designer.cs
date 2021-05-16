
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyMoneyAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReceiving
            // 
            this.lblReceiving.AutoSize = true;
            this.lblReceiving.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReceiving.ForeColor = System.Drawing.Color.Navy;
            this.lblReceiving.Location = new System.Drawing.Point(89, 35);
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
            this.dgvMyMoneyAmount.Location = new System.Drawing.Point(168, 191);
            this.dgvMyMoneyAmount.Name = "dgvMyMoneyAmount";
            this.dgvMyMoneyAmount.ReadOnly = true;
            this.dgvMyMoneyAmount.RowHeadersVisible = false;
            this.dgvMyMoneyAmount.Size = new System.Drawing.Size(110, 71);
            this.dgvMyMoneyAmount.TabIndex = 35;
            // 
            // CMoneyAmount
            // 
            this.CMoneyAmount.DataPropertyName = "MoneyAmount";
            this.CMoneyAmount.HeaderText = "MoneyAmount";
            this.CMoneyAmount.Name = "CMoneyAmount";
            this.CMoneyAmount.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdd.Location = new System.Drawing.Point(168, 147);
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
            this.txbMoneyAmount.Location = new System.Drawing.Point(168, 104);
            this.txbMoneyAmount.Name = "txbMoneyAmount";
            this.txbMoneyAmount.Size = new System.Drawing.Size(136, 26);
            this.txbMoneyAmount.TabIndex = 36;
            // 
            // lblMoneyAmount
            // 
            this.lblMoneyAmount.AutoSize = true;
            this.lblMoneyAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMoneyAmount.ForeColor = System.Drawing.Color.Navy;
            this.lblMoneyAmount.Location = new System.Drawing.Point(29, 104);
            this.lblMoneyAmount.Name = "lblMoneyAmount";
            this.lblMoneyAmount.Size = new System.Drawing.Size(133, 20);
            this.lblMoneyAmount.TabIndex = 37;
            this.lblMoneyAmount.Text = "Money Amount:";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.Maroon;
            this.btnHome.Location = new System.Drawing.Point(12, 304);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(136, 28);
            this.btnHome.TabIndex = 39;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmReceiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(370, 354);
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
            this.Load += new System.EventHandler(this.frmReceiving_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyMoneyAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceiving;
        private System.Windows.Forms.DataGridView dgvMyMoneyAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbMoneyAmount;
        private System.Windows.Forms.Label lblMoneyAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMoneyAmount;
        private System.Windows.Forms.Button btnHome;
    }
}