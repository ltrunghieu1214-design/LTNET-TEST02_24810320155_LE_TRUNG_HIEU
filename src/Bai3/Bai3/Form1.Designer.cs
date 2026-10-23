namespace Bai3
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReload = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPatientProfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoctorSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDepartments = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblDoctorDuty = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.prgStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem,
            this.menuManage,
            this.menuWindow});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.MdiWindowListItem = this.menuWindow;
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(919, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogout,
            this.menuReload,
            this.menuExit});
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(69, 20);
            this.menuSystem.Text = "Hệ thống";
            this.menuSystem.Click += new System.EventHandler(this.menuSystem_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(180, 22);
            this.menuLogout.Text = "Đăng xuất";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // menuReload
            // 
            this.menuReload.Name = "menuReload";
            this.menuReload.Size = new System.Drawing.Size(180, 22);
            this.menuReload.Text = "Nạp lại dữ liệu";
            this.menuReload.Click += new System.EventHandler(this.menuReload_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(180, 22);
            this.menuExit.Text = "Thoát";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuManage
            // 
            this.menuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPatientProfiles,
            this.menuDoctorSchedule,
            this.menuDepartments});
            this.menuManage.Name = "menuManage";
            this.menuManage.Size = new System.Drawing.Size(60, 20);
            this.menuManage.Text = "Quản lý";
            this.menuManage.Click += new System.EventHandler(this.menuManage_Click);
            // 
            // menuPatientProfiles
            // 
            this.menuPatientProfiles.Name = "menuPatientProfiles";
            this.menuPatientProfiles.Size = new System.Drawing.Size(199, 22);
            this.menuPatientProfiles.Text = "Hồ sơ Bệnh nhân";
            this.menuPatientProfiles.Click += new System.EventHandler(this.menuPatientProfiles_Click);
            // 
            // menuDoctorSchedule
            // 
            this.menuDoctorSchedule.Name = "menuDoctorSchedule";
            this.menuDoctorSchedule.Size = new System.Drawing.Size(199, 22);
            this.menuDoctorSchedule.Text = "Lịch trực Bác sĩ";
            this.menuDoctorSchedule.Click += new System.EventHandler(this.menuDoctorSchedule_Click);
            // 
            // menuDepartments
            // 
            this.menuDepartments.Name = "menuDepartments";
            this.menuDepartments.Size = new System.Drawing.Size(199, 22);
            this.menuDepartments.Text = "Danh mục Khoa/Phòng";
            this.menuDepartments.Click += new System.EventHandler(this.menuDepartments_Click);
            // 
            // menuWindow
            // 
            this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCascade,
            this.menuTileHorizontal,
            this.menuTileVertical,
            this.menuCloseAll});
            this.menuWindow.Name = "menuWindow";
            this.menuWindow.Size = new System.Drawing.Size(55, 20);
            this.menuWindow.Text = "Cửa sổ";
            this.menuWindow.Click += new System.EventHandler(this.menuWindow_Click);
            // 
            // menuCascade
            // 
            this.menuCascade.Name = "menuCascade";
            this.menuCascade.Size = new System.Drawing.Size(241, 22);
            this.menuCascade.Text = "Sắp xếp Xếp tầng (Cascade)";
            this.menuCascade.Click += new System.EventHandler(this.menuCascade_Click);
            // 
            // menuTileHorizontal
            // 
            this.menuTileHorizontal.Name = "menuTileHorizontal";
            this.menuTileHorizontal.Size = new System.Drawing.Size(241, 22);
            this.menuTileHorizontal.Text = "Sắp xếp Ngang (Tile Horizontal)";
            this.menuTileHorizontal.Click += new System.EventHandler(this.menuTileHorizontal_Click);
            // 
            // menuTileVertical
            // 
            this.menuTileVertical.Name = "menuTileVertical";
            this.menuTileVertical.Size = new System.Drawing.Size(241, 22);
            this.menuTileVertical.Text = "Sắp xếp Dọc (Tile Vertical)";
            this.menuTileVertical.Click += new System.EventHandler(this.menuTileVertical_Click);
            // 
            // menuCloseAll
            // 
            this.menuCloseAll.Name = "menuCloseAll";
            this.menuCloseAll.Size = new System.Drawing.Size(241, 22);
            this.menuCloseAll.Text = "Đóng tất cả";
            this.menuCloseAll.Click += new System.EventHandler(this.menuCloseAll_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDoctorDuty,
            this.lblSpring,
            this.prgStatus});
            this.statusStripMain.Location = new System.Drawing.Point(0, 442);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(919, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // lblDoctorDuty
            // 
            this.lblDoctorDuty.Name = "lblDoctorDuty";
            this.lblDoctorDuty.Size = new System.Drawing.Size(215, 17);
            this.lblDoctorDuty.Text = "Bác sĩ trực ban: BS. CKII Nguyễn Văn An";
            this.lblDoctorDuty.Click += new System.EventHandler(this.lblDoctorDuty_Click);
            // 
            // lblSpring
            // 
            this.lblSpring.Name = "lblSpring";
            this.lblSpring.Size = new System.Drawing.Size(506, 17);
            this.lblSpring.Spring = true;
            this.lblSpring.Click += new System.EventHandler(this.lblSpring_Click);
            // 
            // prgStatus
            // 
            this.prgStatus.Name = "prgStatus";
            this.prgStatus.Size = new System.Drawing.Size(150, 16);
            this.prgStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgStatus.Value = 100;
            this.prgStatus.Click += new System.EventHandler(this.prgStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 464);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "Form1";
            this.Text = "QUẢN LÝ BỆNH VIỆN & TRUY XUẤT HỒ SƠ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuReload;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuManage;
        private System.Windows.Forms.ToolStripMenuItem menuPatientProfiles;
        private System.Windows.Forms.ToolStripMenuItem menuDoctorSchedule;
        private System.Windows.Forms.ToolStripMenuItem menuDepartments;
        private System.Windows.Forms.ToolStripMenuItem menuWindow;
        private System.Windows.Forms.ToolStripMenuItem menuCascade;
        private System.Windows.Forms.ToolStripMenuItem menuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuTileVertical;
        private System.Windows.Forms.ToolStripMenuItem menuCloseAll;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblDoctorDuty;
        private System.Windows.Forms.ToolStripStatusLabel lblSpring;
        private System.Windows.Forms.ToolStripProgressBar prgStatus;
    }
}

