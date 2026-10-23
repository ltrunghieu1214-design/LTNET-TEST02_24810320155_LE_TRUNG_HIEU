using System.ComponentModel;
using System.Text.RegularExpressions;
namespace Bai_1
{
    public partial class Form1 : Form
    {
        private BindingList<MemberModel> members = new();
        private BindingSource source = new();

        private int nextId = 1;

        private string GenerateMemberId()
        {
            return $"HV{nextId++:000}";
        }
        private void SetupGrid()
        {
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.Columns.Clear();

            dgvMembers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.MultiSelect = false;
            dgvMembers.ReadOnly = true;
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã HV",
                DataPropertyName = "MemberId"
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên hội viên",
                DataPropertyName = "FullName"
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "SĐT",
                DataPropertyName = "Phone"
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Gói tập",
                DataPropertyName = "Package"
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ngày ĐK",
                DataPropertyName = "StartDate",
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Phí dịch vụ",
                DataPropertyName = "Fee",
                DefaultCellStyle = { Format = "N0" }
            });

            source.DataSource = members;
            dgvMembers.DataSource = source;
        }
        public Form1()
        {
            InitializeComponent();

            cboPackage.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPackage.Items.AddRange(new object[] {
            "Theo tháng", "6 tháng", "1 năm"
            });
            cboPackage.SelectedIndex = 0;

            SetupGrid();

        }
        private bool ValidateInput()
        {
            errProvider.Clear();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                !Regex.IsMatch(txtFullName.Text.Trim(),
                               @"^[\p{L}\p{M}]+(?:\s+[\p{L}\p{M}]+)*$"))
            {
                errProvider.SetError(txtFullName,
                    "Tên không được trống hoặc chứa ký tự đặc biệt.");
                valid = false;
            }

            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^\d{10}$"))
            {
                errProvider.SetError(txtPhone,
                    "Số điện thoại phải gồm đúng 10 chữ số.");
                valid = false;
            }

            if (!decimal.TryParse(txtFee.Text, out decimal fee)
                || fee <= 0 || fee != decimal.Truncate(fee))
            {
                errProvider.SetError(txtFee,
                    "Phí phải là số nguyên dương.");
                valid = false;
            }

            return valid;
        }
        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var member = new MemberModel
            {
                MemberId = GenerateMemberId(),
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Package = cboPackage.Text,
                StartDate = dtpStartDate.Value.Date,
                Fee = decimal.Parse(txtFee.Text)
            };

            members.Add(member);
            source.Position = members.Count - 1;
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtMemberId.Clear();
            txtFullName.Clear();
            txtPhone.Clear();
            txtFee.Clear();
            cboPackage.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Today;
            errProvider.Clear();
        }
        private void dgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (source.Current is not MemberModel m) return;

            txtMemberId.Text = m.MemberId;
            txtFullName.Text = m.FullName;
            txtPhone.Text = m.Phone;
            cboPackage.SelectedItem = m.Package;
            dtpStartDate.Value = m.StartDate;
            txtFee.Text = m.Fee.ToString("0");
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (source.Current is not MemberModel m) return;

            var result = MessageBox.Show(
                $"Bạn có chắc muốn xóa hội viên {m.FullName}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                members.Remove(m);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputs();
            dgvMembers.ClearSelection();
            source.Position = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (source.Current is not MemberModel m) return;
            if (!ValidateInput()) return;

            m.FullName = txtFullName.Text.Trim();
            m.Phone = txtPhone.Text.Trim();
            m.Package = cboPackage.Text;
            m.StartDate = dtpStartDate.Value.Date;
            m.Fee = decimal.Parse(txtFee.Text);

            source.ResetCurrentItem();
        }
    }
}
