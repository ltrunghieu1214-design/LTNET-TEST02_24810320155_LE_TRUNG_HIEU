using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bai3
{
    public partial class frmDoctorSchedule : Form
    {
        // Danh sách lưu trữ lịch trực bác sĩ bằng BindingList
        private BindingList<DoctorScheduleModel> _scheduleList = new BindingList<DoctorScheduleModel>();

        public frmDoctorSchedule()
        {
            InitializeComponent();
            SetupForm();
            InitSampleData();
        }

        #region Khởi tạo Giao diện & Cấu hình DataGridView bằng Code
        private void SetupForm()
        {
            this.Text = "Lịch Trực Ca Bác Sĩ & Chuyên Khoa - Doctor Schedule";
            this.Width = 850;
            this.Height = 500;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Cấu hình DataGridView hoàn toàn bằng code (AutoGenerateColumns = false)
            dgvDoctorSchedule.AutoGenerateColumns = false;
            dgvDoctorSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctorSchedule.MultiSelect = false;
            dgvDoctorSchedule.ReadOnly = true;
            dgvDoctorSchedule.AllowUserToAddRows = false;
            dgvDoctorSchedule.RowHeadersVisible = false;
            dgvDoctorSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Xóa và tạo thủ công các cột hiển thị
            dgvDoctorSchedule.Columns.Clear();
            dgvDoctorSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(DoctorScheduleModel.DoctorId),
                HeaderText = "Mã BS",
                FillWeight = 60
            });
            dgvDoctorSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(DoctorScheduleModel.DoctorName),
                HeaderText = "Tên Bác Sĩ",
                FillWeight = 125
            });
            dgvDoctorSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(DoctorScheduleModel.Specialty),
                HeaderText = "Chuyên Khoa",
                FillWeight = 110
            });
            dgvDoctorSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(DoctorScheduleModel.Shift),
                HeaderText = "Ca Trực",
                FillWeight = 85
            });
            dgvDoctorSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(DoctorScheduleModel.Room),
                HeaderText = "Phòng Trực",
                FillWeight = 75
            });
            dgvDoctorSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(DoctorScheduleModel.DutyDate),
                HeaderText = "Ngày Trực",
                FillWeight = 80
            });

            // Gán DataSource vào bảng
            dgvDoctorSchedule.DataSource = _scheduleList;
        }

        private void InitSampleData()
        {
            _scheduleList.Add(new DoctorScheduleModel
            {
                DoctorId = "BS01",
                DoctorName = "BS. CKII Nguyễn Văn An",
                Specialty = "Hồi sức cấp cứu",
                Shift = "Ca Đêm (18h - 06h)",
                Room = "P. Cấp cứu 1",
                DutyDate = DateTime.Today.ToString("dd/MM/yyyy")
            });

            _scheduleList.Add(new DoctorScheduleModel
            {
                DoctorId = "BS02",
                DoctorName = "ThS. BS Đặng Quỳnh Chi",
                Specialty = "Nội Tim Mạch",
                Shift = "Ca Ngày (06h - 18h)",
                Room = "P. Khám 204",
                DutyDate = DateTime.Today.ToString("dd/MM/yyyy")
            });

            _scheduleList.Add(new DoctorScheduleModel
            {
                DoctorId = "BS03",
                DoctorName = "BS. CKI Vũ Đình Trọng",
                Specialty = "Ngoại Tổng Quát",
                Shift = "Ca Đêm (18h - 06h)",
                Room = "P. Trực Ngoại",
                DutyDate = DateTime.Today.ToString("dd/MM/yyyy")
            });

            _scheduleList.Add(new DoctorScheduleModel
            {
                DoctorId = "BS04",
                DoctorName = "BS. Lê Thị Phương Thảo",
                Specialty = "Nhi Khoa",
                Shift = "Ca Ngày (06h - 18h)",
                Room = "P. Khám 102",
                DutyDate = DateTime.Today.AddDays(1).ToString("dd/MM/yyyy")
            });
        }
        #endregion

        #region Các sự kiện giao diện
        private void dgvDoctorSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Giữ lại để tránh lỗi liên kết Designer
        }
        #endregion
    }

    #region Model Class: DoctorScheduleModel
    public class DoctorScheduleModel
    {
        public string DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Specialty { get; set; }
        public string Shift { get; set; }
        public string Room { get; set; }
        public string DutyDate { get; set; }
    }
    #endregion
}