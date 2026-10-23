namespace Bai_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFromDate = new Label();
            dtpFromDate = new DateTimePicker();
            lblToDate = new Label();
            dtpToDate = new DateTimePicker();
            lblBranch = new Label();
            cboBranch = new ComboBox();
            btnAnalyze = new Button();
            btnCancel = new Button();
            pgbLoading = new ProgressBar();
            lblProcessingStatus = new Label();
            dgvRevenueData = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRevenueData).BeginInit();
            SuspendLayout();
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Location = new Point(40, 54);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(65, 20);
            lblFromDate.TabIndex = 0;
            lblFromDate.Text = "Từ ngày:";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(123, 54);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(163, 27);
            dtpFromDate.TabIndex = 1;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Location = new Point(428, 54);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(75, 20);
            lblToDate.TabIndex = 2;
            lblToDate.Text = "Đến ngày:";
            // 
            // dtpToDate
            // 
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(509, 54);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(166, 27);
            dtpToDate.TabIndex = 3;
            // 
            // lblBranch
            // 
            lblBranch.AutoSize = true;
            lblBranch.Location = new Point(40, 105);
            lblBranch.Name = "lblBranch";
            lblBranch.Size = new Size(77, 20);
            lblBranch.TabIndex = 4;
            lblBranch.Text = "Chi nhánh:";
            // 
            // cboBranch
            // 
            cboBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBranch.FormattingEnabled = true;
            cboBranch.Location = new Point(123, 105);
            cboBranch.Name = "cboBranch";
            cboBranch.Size = new Size(151, 28);
            cboBranch.TabIndex = 5;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(313, 141);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(164, 29);
            btnAnalyze.TabIndex = 6;
            btnAnalyze.Text = "Thống kê doanh thu";
            btnAnalyze.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(511, 141);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(164, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy thao tác";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // pgbLoading
            // 
            pgbLoading.Location = new Point(176, 183);
            pgbLoading.Name = "pgbLoading";
            pgbLoading.Size = new Size(499, 20);
            pgbLoading.TabIndex = 8;
            // 
            // lblProcessingStatus
            // 
            lblProcessingStatus.AutoSize = true;
            lblProcessingStatus.Location = new Point(40, 183);
            lblProcessingStatus.Name = "lblProcessingStatus";
            lblProcessingStatus.Size = new Size(130, 20);
            lblProcessingStatus.TabIndex = 9;
            lblProcessingStatus.Text = "Sẵn sàng thống kê";
            // 
            // dgvRevenueData
            // 
            dgvRevenueData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevenueData.Location = new Point(1, 218);
            dgvRevenueData.Name = "dgvRevenueData";
            dgvRevenueData.RowHeadersWidth = 51;
            dgvRevenueData.Size = new Size(796, 231);
            dgvRevenueData.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 9);
            label1.Name = "label1";
            label1.Size = new Size(481, 31);
            label1.TabIndex = 11;
            label1.Text = "BẢNG ĐIỀU KHIỂN THỐNG KÊ DOANH THU";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvRevenueData);
            Controls.Add(lblProcessingStatus);
            Controls.Add(pgbLoading);
            Controls.Add(btnCancel);
            Controls.Add(btnAnalyze);
            Controls.Add(cboBranch);
            Controls.Add(lblBranch);
            Controls.Add(dtpToDate);
            Controls.Add(lblToDate);
            Controls.Add(dtpFromDate);
            Controls.Add(lblFromDate);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRevenueData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFromDate;
        private DateTimePicker dtpFromDate;
        private Label lblToDate;
        private DateTimePicker dtpToDate;
        private Label lblBranch;
        private ComboBox cboBranch;
        private Button btnAnalyze;
        private Button btnCancel;
        private ProgressBar pgbLoading;
        private Label lblProcessingStatus;
        private DataGridView dgvRevenueData;
        private Label label1;
    }
}
