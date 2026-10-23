namespace bai5
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBTCPrice = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.dgvHistoryLog = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblLastUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSyncCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryLog)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(298, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(940, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GIÁM SÁT TỶ GIÁ BTC/USD";
            // 
            // lblBTCPrice
            // 
            this.lblBTCPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBTCPrice.ForeColor = System.Drawing.Color.Green;
            this.lblBTCPrice.Location = new System.Drawing.Point(20, 75);
            this.lblBTCPrice.Name = "lblBTCPrice";
            this.lblBTCPrice.Size = new System.Drawing.Size(940, 65);
            this.lblBTCPrice.TabIndex = 1;
            this.lblBTCPrice.Text = "lBTC/USD: 65000.00 $";
            this.lblBTCPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(300, 155);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(170, 40);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Bắt đầu giám sát";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(500, 155);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(170, 40);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Tạm dừng";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // dgvHistoryLog
            // 
            this.dgvHistoryLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistoryLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryLog.Location = new System.Drawing.Point(20, 220);
            this.dgvHistoryLog.MultiSelect = false;
            this.dgvHistoryLog.Name = "dgvHistoryLog";
            this.dgvHistoryLog.ReadOnly = true;
            this.dgvHistoryLog.RowHeadersWidth = 62;
            this.dgvHistoryLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgvHistoryLog.Size = new System.Drawing.Size(940, 330);
            this.dgvHistoryLog.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLastUpdate,
            this.lblSyncCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(978, 32);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(195, 25);
            this.lblLastUpdate.Text = "Cập nhật cuối: Chưa có";
            // 
            // lblSyncCount
            // 
            this.lblSyncCount.Name = "lblSyncCount";
            this.lblSyncCount.Size = new System.Drawing.Size(155, 25);
            this.lblSyncCount.Text = "Số lần đồng bộ: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 594);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvHistoryLog);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblBTCPrice);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÔ PHỎNG GIÁM SÁT TỶ GIÁ BTC/USD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryLog)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBTCPrice;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.DataGridView dgvHistoryLog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblLastUpdate;
        private System.Windows.Forms.ToolStripStatusLabel lblSyncCount;
    }
}

