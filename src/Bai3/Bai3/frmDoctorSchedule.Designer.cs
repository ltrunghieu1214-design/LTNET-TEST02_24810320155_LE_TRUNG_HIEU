namespace Bai3
{
    partial class frmDoctorSchedule
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
            this.dgvDoctorSchedule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoctorSchedule
            // 
            this.dgvDoctorSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoctorSchedule.Location = new System.Drawing.Point(0, 0);
            this.dgvDoctorSchedule.Name = "dgvDoctorSchedule";
            this.dgvDoctorSchedule.Size = new System.Drawing.Size(926, 490);
            this.dgvDoctorSchedule.TabIndex = 0;
            this.dgvDoctorSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctorSchedule_CellContentClick);
            // 
            // frmDoctorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 490);
            this.Controls.Add(this.dgvDoctorSchedule);
            this.Name = "frmDoctorSchedule";
            this.Text = "Lịch trực Bác sĩ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoctorSchedule;
    }
}