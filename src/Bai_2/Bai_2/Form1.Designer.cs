namespace Bai_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuMain = new MenuStrip();
            toolMain = new ToolStrip();
            statusMain = new StatusStrip();
            lblBookId = new Label();
            txtBookId = new TextBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            lblAuthor = new Label();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblCover = new Label();
            picBookCover = new PictureBox();
            btnLoadCover = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            dgvBooks = new DataGridView();
            lblTotalBooks = new ToolStripStatusLabel();
            lblTotalValue = new ToolStripStatusLabel();
            lblCurrentTime = new ToolStripStatusLabel();
            mnuOpenCsv = new ToolStripMenuItem();
            mởFileCSVToolStripMenuItem = new ToolStripMenuItem();
            mnuSaveCsv = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            mnuAdd = new ToolStripMenuItem();
            mnuDelete = new ToolStripMenuItem();
            mnuSearch = new ToolStripMenuItem();
            tsbOpen = new ToolStripButton();
            tsbSave = new ToolStripButton();
            tsbAdd = new ToolStripButton();
            menuMain.SuspendLayout();
            toolMain.SuspendLayout();
            statusMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBookCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.ImageScalingSize = new Size(20, 20);
            menuMain.Items.AddRange(new ToolStripItem[] { mnuOpenCsv, editToolStripMenuItem });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(800, 28);
            menuMain.TabIndex = 0;
            menuMain.Text = "menuStrip1";
            // 
            // toolMain
            // 
            toolMain.ImageScalingSize = new Size(20, 20);
            toolMain.Items.AddRange(new ToolStripItem[] { tsbOpen, tsbSave, tsbAdd });
            toolMain.Location = new Point(0, 28);
            toolMain.Name = "toolMain";
            toolMain.Size = new Size(800, 27);
            toolMain.TabIndex = 1;
            toolMain.Text = "toolStrip1";
            // 
            // statusMain
            // 
            statusMain.ImageScalingSize = new Size(20, 20);
            statusMain.Items.AddRange(new ToolStripItem[] { lblTotalBooks, lblTotalValue, lblCurrentTime });
            statusMain.Location = new Point(0, 424);
            statusMain.Name = "statusMain";
            statusMain.Size = new Size(800, 26);
            statusMain.TabIndex = 2;
            statusMain.Text = "statusStrip1";
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Location = new Point(80, 55);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(66, 20);
            lblBookId.TabIndex = 3;
            lblBookId.Text = "Mã sách:";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(217, 55);
            txtBookId.Name = "txtBookId";
            txtBookId.ReadOnly = true;
            txtBookId.Size = new Size(125, 27);
            txtBookId.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(80, 91);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(68, 20);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Tên sách:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(217, 92);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 6;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(217, 128);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 8;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(83, 132);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(58, 20);
            lblAuthor.TabIndex = 7;
            lblAuthor.Text = "Tác giả:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(83, 173);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(65, 20);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Đơn giá:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(217, 170);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 10;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(80, 214);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 11;
            lblQuantity.Text = "Số lượng:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(217, 207);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 12;
            // 
            // lblCover
            // 
            lblCover.AutoSize = true;
            lblCover.Location = new Point(433, 58);
            lblCover.Name = "lblCover";
            lblCover.Size = new Size(63, 20);
            lblCover.TabIndex = 13;
            lblCover.Text = "Ảnh bìa:";
            // 
            // picBookCover
            // 
            picBookCover.BorderStyle = BorderStyle.FixedSingle;
            picBookCover.Location = new Point(537, 55);
            picBookCover.Name = "picBookCover";
            picBookCover.Size = new Size(199, 108);
            picBookCover.SizeMode = PictureBoxSizeMode.Zoom;
            picBookCover.TabIndex = 14;
            picBookCover.TabStop = false;
            // 
            // btnLoadCover
            // 
            btnLoadCover.Location = new Point(422, 173);
            btnLoadCover.Name = "btnLoadCover";
            btnLoadCover.Size = new Size(94, 29);
            btnLoadCover.TabIndex = 15;
            btnLoadCover.Text = "Tải ảnh bìa";
            btnLoadCover.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(560, 169);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Thêm sách";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(683, 173);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Sửa sách";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(480, 206);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Xóa sách";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(610, 206);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(0, 241);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(800, 184);
            dgvBooks.TabIndex = 20;
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(110, 20);
            lblTotalBooks.Text = "Tổng số sách: 0";
            // 
            // lblTotalValue
            // 
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(101, 20);
            lblTotalValue.Text = "Tổng giá trị: 0";
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(74, 20);
            lblCurrentTime.Text = "Thời gian:";
            // 
            // mnuOpenCsv
            // 
            mnuOpenCsv.DropDownItems.AddRange(new ToolStripItem[] { mởFileCSVToolStripMenuItem, mnuSaveCsv, mnuExit });
            mnuOpenCsv.Name = "mnuOpenCsv";
            mnuOpenCsv.Size = new Size(46, 24);
            mnuOpenCsv.Text = "File";
            // 
            // mởFileCSVToolStripMenuItem
            // 
            mởFileCSVToolStripMenuItem.Name = "mởFileCSVToolStripMenuItem";
            mởFileCSVToolStripMenuItem.Size = new Size(224, 26);
            mởFileCSVToolStripMenuItem.Text = "Mở file CSV";
            // 
            // mnuSaveCsv
            // 
            mnuSaveCsv.Name = "mnuSaveCsv";
            mnuSaveCsv.Size = new Size(224, 26);
            mnuSaveCsv.Text = "Lưu file CSV";
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(224, 26);
            mnuExit.Text = "Thoát";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuAdd, mnuDelete, mnuSearch });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // mnuAdd
            // 
            mnuAdd.Name = "mnuAdd";
            mnuAdd.Size = new Size(224, 26);
            mnuAdd.Text = "Thêm";
            mnuAdd.Click += mnuAdd_Click;
            // 
            // mnuDelete
            // 
            mnuDelete.Name = "mnuDelete";
            mnuDelete.Size = new Size(224, 26);
            mnuDelete.Text = "Xóa";
            // 
            // mnuSearch
            // 
            mnuSearch.Name = "mnuSearch";
            mnuSearch.Size = new Size(224, 26);
            mnuSearch.Text = "Tìm Kiếm";
            // 
            // tsbOpen
            // 
            tsbOpen.Image = (Image)resources.GetObject("tsbOpen.Image");
            tsbOpen.ImageTransparentColor = Color.Magenta;
            tsbOpen.Name = "tsbOpen";
            tsbOpen.Size = new Size(80, 24);
            tsbOpen.Text = "Mở file";
            // 
            // tsbSave
            // 
            tsbSave.Image = (Image)resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(82, 24);
            tsbSave.Text = "Lưu file";
            // 
            // tsbAdd
            // 
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(100, 24);
            tsbAdd.Text = "Thêm mới";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBooks);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnLoadCover);
            Controls.Add(picBookCover);
            Controls.Add(lblCover);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtAuthor);
            Controls.Add(lblAuthor);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(txtBookId);
            Controls.Add(lblBookId);
            Controls.Add(statusMain);
            Controls.Add(toolMain);
            Controls.Add(menuMain);
            MainMenuStrip = menuMain;
            Name = "Form1";
            Text = "Form1";
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            toolMain.ResumeLayout(false);
            toolMain.PerformLayout();
            statusMain.ResumeLayout(false);
            statusMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBookCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuMain;
        private ToolStrip toolMain;
        private StatusStrip statusMain;
        private Label lblBookId;
        private TextBox txtBookId;
        private Label lblTitle;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Label lblAuthor;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label lblCover;
        private PictureBox picBookCover;
        private Button btnLoadCover;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSearch;
        private DataGridView dgvBooks;
        private ToolStripMenuItem mnuOpenCsv;
        private ToolStripMenuItem mởFileCSVToolStripMenuItem;
        private ToolStripMenuItem mnuSaveCsv;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem mnuAdd;
        private ToolStripStatusLabel lblTotalBooks;
        private ToolStripStatusLabel lblTotalValue;
        private ToolStripStatusLabel lblCurrentTime;
        private ToolStripMenuItem mnuDelete;
        private ToolStripMenuItem mnuSearch;
        private ToolStripButton tsbOpen;
        private ToolStripButton tsbSave;
        private ToolStripButton tsbAdd;
    }
}
