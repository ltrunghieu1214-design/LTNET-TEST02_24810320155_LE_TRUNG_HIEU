using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bai3
{
    public partial class frmPatientProfiles : Form
    {
        // Danh sách lưu trữ dữ liệu bệnh nhân bằng BindingList
        private BindingList<PatientModel> _patientList = new BindingList<PatientModel>();

        public frmPatientProfiles()
        {
            InitializeComponent();
            SetupForm();
            InitSampleData();
        }

        #region Khởi tạo Giao diện & Cấu hình DataGridView bằng Code
        private void SetupForm()
        {
            this.Text = "Quản Lý Hồ Sơ Bệnh Án Bệnh Nhân - Patient Profiles";
            this.Width = 850;
            this.Height = 500;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Cấu hình DataGridView hoàn toàn bằng code (AutoGenerateColumns = false)
            dgvPatients.AutoGenerateColumns = false;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.MultiSelect = false;
            dgvPatients.ReadOnly = true;
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.RowHeadersVisible = false;
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Xóa và tạo thủ công các cột hiển thị
            dgvPatients.Columns.Clear();
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(PatientModel.PatientId),
                HeaderText = "Mã BN",
                FillWeight = 60
            });
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(PatientModel.FullName),
                HeaderText = "Họ và Tên",
                FillWeight = 120
            });
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(PatientModel.BirthYear),
                HeaderText = "Năm Sinh",
                FillWeight = 55
            });
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(PatientModel.Gender),
                HeaderText = "Giới Tính",
                FillWeight = 55
            });
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(PatientModel.Department),
                HeaderText = "Khoa Điều Trị",
                FillWeight = 100
            });
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(PatientModel.Diagnosis),
                HeaderText = "Chẩn Đoán Ban Đầu",
                FillWeight = 150
            });

            // Gán nguồn dữ liệu vào bảng
            dgvPatients.DataSource = _patientList;
        }

        private void InitSampleData()
        {
            _patientList.Add(new PatientModel
            {
                PatientId = "BN001",
                FullName = "Trần Văn Nam",
                BirthYear = 1985,
                Gender = "Nam",
                Department = "Khoa Cấp Cứu",
                Diagnosis = "Chấn thương phần mềm cẳng chân"
            });

            _patientList.Add(new PatientModel
            {
                PatientId = "BN002",
                FullName = "Nguyễn Thị Hương",
                BirthYear = 1992,
                Gender = "Nữ",
                Department = "Khoa Tim Mạch",
                Diagnosis = "Rối loạn nhịp tim nhanh kịch phát"
            });

            _patientList.Add(new PatientModel
            {
                PatientId = "BN003",
                FullName = "Lê Hoàng Phúc",
                BirthYear = 2005,
                Gender = "Nam",
                Department = "Khoa Tiêu Hóa",
                Diagnosis = "Viêm ruột thừa cấp giai đoạn sớm"
            });

            _patientList.Add(new PatientModel
            {
                PatientId = "BN004",
                FullName = "Đỗ Mỹ Linh",
                BirthYear = 1998,
                Gender = "Nữ",
                Department = "Khoa Tai - Mũi - Họng",
                Diagnosis = "Viêm amidan hốc mủ, sốt cao"
            });
        }
        #endregion

        #region Các sự kiện giao diện
        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Giữ lại để Designer không báo lỗi liên kết sự kiện
        }
        #endregion
    }

    #region Model Class: PatientModel
    public class PatientModel
    {
        public string PatientId { get; set; }
        public string FullName { get; set; }
        public int BirthYear { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string Diagnosis { get; set; }
    }
    #endregion
}