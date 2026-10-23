namespace Bai_1
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
            components = new System.ComponentModel.Container();
            lblMemberId = new Label();
            txtMemberId = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblPackage = new Label();
            cboPackage = new ComboBox();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblFee = new Label();
            btnAdd = new Button();
            txtFee = new TextBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            errProvider = new ErrorProvider(components);
            label1 = new Label();
            dgvMembers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // lblMemberId
            // 
            lblMemberId.AutoSize = true;
            lblMemberId.Location = new Point(36, 73);
            lblMemberId.Name = "lblMemberId";
            lblMemberId.Size = new Size(89, 20);
            lblMemberId.TabIndex = 0;
            lblMemberId.Text = "Mã hội viên:";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(184, 73);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(125, 27);
            txtMemberId.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(399, 73);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 20);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Họ và tên:";
            lblFullName.Click += lblFullName_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(520, 73);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 27);
            txtFullName.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(36, 126);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 20);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(184, 126);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 5;
            // 
            // lblPackage
            // 
            lblPackage.AutoSize = true;
            lblPackage.Location = new Point(36, 174);
            lblPackage.Name = "lblPackage";
            lblPackage.Size = new Size(61, 20);
            lblPackage.TabIndex = 6;
            lblPackage.Text = "Gói tập:";
            // 
            // cboPackage
            // 
            cboPackage.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPackage.FormattingEnabled = true;
            cboPackage.Location = new Point(184, 171);
            cboPackage.Name = "cboPackage";
            cboPackage.Size = new Size(151, 28);
            cboPackage.TabIndex = 7;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(399, 133);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(103, 20);
            lblStartDate.TabIndex = 8;
            lblStartDate.Text = "Ngày đăng ký:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(520, 126);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(231, 27);
            dtpStartDate.TabIndex = 9;
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.Location = new Point(399, 177);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(83, 20);
            lblFee.TabIndex = 10;
            lblFee.Text = "Phí dịch vụ:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(36, 215);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(520, 174);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(125, 27);
            txtFee.TabIndex = 12;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(220, 215);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 29);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Sửa thông tin";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(416, 215);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Xóa hội viên";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(622, 215);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(115, 29);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 9);
            label1.Name = "label1";
            label1.Size = new Size(451, 38);
            label1.TabIndex = 16;
            label1.Text = "QUẢN LÝ HỘI VIÊN PHÒNG GYM";
            // 
            // dgvMembers
            // 
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(4, 250);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(795, 196);
            dgvMembers.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMembers);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(txtFee);
            Controls.Add(btnAdd);
            Controls.Add(lblFee);
            Controls.Add(dtpStartDate);
            Controls.Add(lblStartDate);
            Controls.Add(cboPackage);
            Controls.Add(lblPackage);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(txtMemberId);
            Controls.Add(lblMemberId);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMemberId;
        private TextBox txtMemberId;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblPackage;
        private ComboBox cboPackage;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Label lblFee;
        private Button btnAdd;
        private TextBox txtFee;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private ErrorProvider errProvider;
        private Label label1;
        private DataGridView dgvMembers;
    }
}
