
namespace finTech
{
    partial class frmReport
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
            this.lblReport = new System.Windows.Forms.Label();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.CReportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.History = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyOrSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.mcdReportTime = new System.Windows.Forms.MonthCalendar();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnListReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReport.ForeColor = System.Drawing.Color.Navy;
            this.lblReport.Location = new System.Drawing.Point(322, 18);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(125, 39);
            this.lblReport.TabIndex = 32;
            this.lblReport.Text = "Report";
            // 
            // dgvReports
            // 
            this.dgvReports.BackgroundColor = System.Drawing.Color.Peru;
            this.dgvReports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CReportID,
            this.CUserID,
            this.CItemID,
            this.CItemAmount,
            this.CItemMoney,
            this.History,
            this.BuyOrSell});
            this.dgvReports.Location = new System.Drawing.Point(48, 295);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.Size = new System.Drawing.Size(780, 199);
            this.dgvReports.TabIndex = 34;
            // 
            // CReportID
            // 
            this.CReportID.DataPropertyName = "ReportID";
            this.CReportID.HeaderText = "ReportID";
            this.CReportID.Name = "CReportID";
            // 
            // CUserID
            // 
            this.CUserID.DataPropertyName = "UserID";
            this.CUserID.HeaderText = "UserID";
            this.CUserID.Name = "CUserID";
            // 
            // CItemID
            // 
            this.CItemID.DataPropertyName = "ItemID";
            this.CItemID.HeaderText = "ItemID";
            this.CItemID.Name = "CItemID";
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
            // History
            // 
            this.History.DataPropertyName = "History";
            this.History.HeaderText = "History";
            this.History.Name = "History";
            // 
            // BuyOrSell
            // 
            this.BuyOrSell.DataPropertyName = "BuyOrSell";
            this.BuyOrSell.HeaderText = "BuyOrSell";
            this.BuyOrSell.Name = "BuyOrSell";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.Maroon;
            this.btnGenerateReport.Location = new System.Drawing.Point(476, 204);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(205, 55);
            this.btnGenerateReport.TabIndex = 36;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // mcdReportTime
            // 
            this.mcdReportTime.Location = new System.Drawing.Point(192, 97);
            this.mcdReportTime.Name = "mcdReportTime";
            this.mcdReportTime.TabIndex = 37;
            this.mcdReportTime.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcdReportTime_DateChanged);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.Maroon;
            this.btnHome.Location = new System.Drawing.Point(12, 515);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(136, 28);
            this.btnHome.TabIndex = 38;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnListReport
            // 
            this.btnListReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnListReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListReport.ForeColor = System.Drawing.Color.Maroon;
            this.btnListReport.Location = new System.Drawing.Point(476, 97);
            this.btnListReport.Name = "btnListReport";
            this.btnListReport.Size = new System.Drawing.Size(205, 55);
            this.btnListReport.TabIndex = 39;
            this.btnListReport.Text = "List Report";
            this.btnListReport.UseVisualStyleBackColor = false;
            this.btnListReport.Click += new System.EventHandler(this.btnListReport_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(853, 555);
            this.Controls.Add(this.btnListReport);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.mcdReportTime);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.lblReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReport_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn CReportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn History;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyOrSell;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.MonthCalendar mcdReportTime;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnListReport;
    }
}