using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupMdiContainer();
        }

        #region Khởi tạo MDI Container & Cấu hình Hệ thống
        private void SetupMdiContainer()
        {
            this.Text = "Hệ Thống MDI Quản Lý Bệnh Viện & Truy Xuất Hồ Sơ Bệnh Án";
            this.IsMdiContainer = true; // Yêu cầu cốt lõi kiến trúc MDI
            this.WindowState = FormWindowState.Maximized;

            // Tự động liệt kê danh sách Form con đang mở dưới đáy menu Cửa sổ
            if (menuWindow != null)
            {
                this.MainMenuStrip.MdiWindowListItem = menuWindow;
            }

            // Cấu hình ban đầu cho StatusStrip
            lblDoctorDuty.Text = "Bác sĩ trực ban: BS. CKII Nguyễn Văn An | Khoa Cấp Cứu";
            lblSpring.Text = "";
            lblSpring.Spring = true; // Đẩy thanh tiến trình dạt sang góc phải
            prgStatus.Value = 100;
        }
        #endregion

        #region Yêu cầu nghiệp vụ 1: Quản lý Form con MDI (Ngăn chặn trùng lặp)
        /// <summary>
        /// Hàm tổng quát kiểm tra và kích hoạt Form con MDI:
        /// - Nếu Form đã mở: gọi Activate() để đưa lên trên cùng.
        /// - Nếu Form chưa mở: khởi tạo mới, gán MdiParent = this và gọi Show().
        /// </summary>
        private void OpenMdiChild<T>() where T : Form, new()
        {
            // Duyệt danh sách Form con đang mở trong MdiChildren
            Form existingForm = this.MdiChildren.FirstOrDefault(f => f is T);

            if (existingForm != null)
            {
                // Nếu Form đang bị thu nhỏ (Minimized) thì khôi phục kích thước bình thường
                if (existingForm.WindowState == FormWindowState.Minimized)
                {
                    existingForm.WindowState = FormWindowState.Normal;
                }
                // Đưa Form con đó lên trên cùng
                existingForm.Activate();
            }
            else
            {
                // Nếu chưa mở, tạo mới một Instance, gán MdiParent và hiển thị
                T newChild = new T();
                newChild.MdiParent = this;
                newChild.Show();
            }
        }

        private void menuPatientProfiles_Click(object sender, EventArgs e)
        {
            OpenMdiChild<frmPatientProfiles>();
        }

        private void menuDoctorSchedule_Click(object sender, EventArgs e)
        {
            OpenMdiChild<frmDoctorSchedule>();
        }

        private void menuDepartments_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Danh mục Khoa/Phòng đang được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Yêu cầu nghiệp vụ 2: Thao tác sắp xếp Cửa sổ (Cascade, Tile Horizontal, Tile Vertical)
        private void menuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void menuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }
        #endregion

        #region Các sự kiện Menu Hệ thống
        private void menuLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất phiên làm việc?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                // Đóng tất cả Form con đang mở
                menuCloseAll_Click(sender, e);
                MessageBox.Show("Đã đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void menuReload_Click(object sender, EventArgs e)
        {
            prgStatus.Value = 30;

            // Nạp lại hiển thị cho các Form con đang mở
            foreach (Form child in this.MdiChildren)
            {
                child.Refresh();
            }

            prgStatus.Value = 100;
            MessageBox.Show("Đã đồng bộ và nạp lại dữ liệu hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Các sự kiện phụ giữ lại tránh lỗi Designer
        private void Form1_Load(object sender, EventArgs e) { }
        private void menuSystem_Click(object sender, EventArgs e) { }
        private void menuManage_Click(object sender, EventArgs e) { }
        private void menuWindow_Click(object sender, EventArgs e) { }
        private void lblDoctorDuty_Click(object sender, EventArgs e) { }
        private void lblSpring_Click(object sender, EventArgs e) { }
        private void prgStatus_Click(object sender, EventArgs e) { }
        #endregion
    }
}