
namespace finTech
{
    partial class frmAdminMoney
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
            this.dgvWaitingForMoneyApproval = new System.Windows.Forms.DataGridView();
            this.lblMoneyConfirm = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.CMoneyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMoneyAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMoneyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingForMoneyApproval)).BeginInit();
            this.SuspendLayout();
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
            this.CMoneyAmount,
            this.CMoneyType});
            this.dgvWaitingForMoneyApproval.Location = new System.Drawing.Point(119, 111);
            this.dgvWaitingForMoneyApproval.Name = "dgvWaitingForMoneyApproval";
            this.dgvWaitingForMoneyApproval.Size = new System.Drawing.Size(544, 145);
            this.dgvWaitingForMoneyApproval.TabIndex = 39;
            // 
            // lblMoneyConfirm
            // 
            this.lblMoneyConfirm.AutoSize = true;
            this.lblMoneyConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMoneyConfirm.ForeColor = System.Drawing.Color.Navy;
            this.lblMoneyConfirm.Location = new System.Drawing.Point(280, 57);
            this.lblMoneyConfirm.Name = "lblMoneyConfirm";
            this.lblMoneyConfirm.Size = new System.Drawing.Size(233, 25);
            this.lblMoneyConfirm.TabIndex = 45;
            this.lblMoneyConfirm.Text = "Money Confirm Screen";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Navy;
            this.lblAdmin.Location = new System.Drawing.Point(327, 9);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(119, 39);
            this.lblAdmin.TabIndex = 44;
            this.lblAdmin.Text = "Admin";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm.Location = new System.Drawing.Point(314, 285);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(142, 39);
            this.btnConfirm.TabIndex = 47;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdmin.Location = new System.Drawing.Point(636, 336);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(136, 28);
            this.btnAdmin.TabIndex = 46;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.Maroon;
            this.btnHome.Location = new System.Drawing.Point(12, 336);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(136, 28);
            this.btnHome.TabIndex = 48;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            // CMoneyType
            // 
            this.CMoneyType.DataPropertyName = "MoneyType";
            this.CMoneyType.HeaderText = "MoneyType";
            this.CMoneyType.Name = "CMoneyType";
            // 
            // frmAdminMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(784, 376);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblMoneyConfirm);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.dgvWaitingForMoneyApproval);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdminMoney";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Money";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminMoney_FormClosed);
            this.Load += new System.EventHandler(this.frmAdminMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingForMoneyApproval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWaitingForMoneyApproval;
        private System.Windows.Forms.Label lblMoneyConfirm;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMoneyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMoneyAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMoneyType;
    }
}