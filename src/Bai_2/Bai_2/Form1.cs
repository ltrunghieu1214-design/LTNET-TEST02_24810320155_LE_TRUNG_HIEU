
using Bai_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class Form1 : Form
    {
        private readonly BindingList<BookModel> books = new();
        private readonly BindingSource bookSource = new();
        private readonly System.Windows.Forms.Timer clockTimer = new();

        private string coverPath = "";
        private int nextBookId = 1;
        private bool isSearching = false;

        public Form1()
        {
            InitializeComponent();

            SetupBooks();
            ConnectEvents();
            UpdateStatus();

            clockTimer.Interval = 1000;
            clockTimer.Tick += (s, e) =>
            {
                SetStatusText("lblCurrentTime",
                    $"Thời gian: {DateTime.Now:HH:mm:ss}");
            };
            clockTimer.Start();
        }

        // =========================
        // 1. KHOI TAO GIAO DIEN
        // =========================

        private void SetupBooks()
        {
            bookSource.DataSource = books;
            dgvBooks.AutoGenerateColumns = true;
            dgvBooks.DataSource = bookSource;

            dgvBooks.ReadOnly = true;
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.MultiSelect = false;
            dgvBooks.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.RowHeadersVisible = false;

            picBookCover.SizeMode = PictureBoxSizeMode.Zoom;
            picBookCover.BorderStyle = BorderStyle.FixedSingle;

            txtBookId.ReadOnly = true;

            SetStatusText("lblTotalBooks", "Tổng số sách: 0");
            SetStatusText("lblTotalValue", "Tổng giá trị kho: 0 VNĐ");
            SetStatusText("lblCurrentTime",
                $"Thời gian: {DateTime.Now:HH:mm:ss}");
        }

        private void ConnectEvents()
        {
            // Gan su kien, tranh dang ky trung
            btnAdd.Click -= btnAdd_Click;
            btnAdd.Click += btnAdd_Click;

            btnEdit.Click -= btnEdit_Click;
            btnEdit.Click += btnEdit_Click;

            btnDelete.Click -= btnDelete_Click;
            btnDelete.Click += btnDelete_Click;

            btnSearch.Click -= btnSearch_Click;
            btnSearch.Click += btnSearch_Click;

            btnLoadCover.Click -= btnLoadCover_Click;
            btnLoadCover.Click += btnLoadCover_Click;

            dgvBooks.SelectionChanged -= dgvBooks_SelectionChanged;
            dgvBooks.SelectionChanged += dgvBooks_SelectionChanged;

            // Ket noi cac muc MenuStrip neu da tao
            ConnectMenu("mnuAdd", mnuAdd_Click);
            ConnectMenu("mnuDelete", mnuDelete_Click);
            ConnectMenu("mnuSearch", mnuSearch_Click);
            ConnectMenu("mnuOpenCsv", mnuOpenCsv_Click);
            ConnectMenu("mnuSaveCsv", mnuSaveCsv_Click);
            ConnectMenu("mnuExit", mnuExit_Click);

            // Ket noi cac nut ToolStrip neu da tao
            ConnectMenu("tsbOpen", tsbOpen_Click);
            ConnectMenu("tsbSave", tsbSave_Click);
            ConnectMenu("tsbAdd", tsbAdd_Click);
        }

        private void ConnectMenu(
            string itemName, EventHandler handler)
        {
            ToolStripItem item = FindToolStripItem(itemName);

            if (item != null)
            {
                item.Click -= handler;
                item.Click += handler;
            }
        }

        private ToolStripItem FindToolStripItem(string itemName)
        {
            foreach (Control control in GetAllControls(this))
            {
                if (control is ToolStrip strip)
                {
                    foreach (ToolStripItem item in strip.Items)
                    {
                        ToolStripItem found =
                            FindItemRecursive(item, itemName);

                        if (found != null)
                            return found;
                    }
                }
            }

            return null;
        }

        private ToolStripItem FindItemRecursive(
            ToolStripItem item, string itemName)
        {
            if (item.Name == itemName)
                return item;

            if (item is ToolStripDropDownItem dropDown)
            {
                foreach (ToolStripItem child in dropDown.DropDownItems)
                {
                    ToolStripItem found =
                        FindItemRecursive(child, itemName);

                    if (found != null)
                        return found;
                }
            }

            return null;
        }

        private IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                yield return child;

                foreach (Control nested in GetAllControls(child))
                    yield return nested;
            }
        }

        private void SetStatusText(string itemName, string value)
        {
            ToolStripItem item = FindToolStripItem(itemName);

            if (item != null)
                item.Text = value;
        }

        // =========================
        // 2. SINH MA SACH
        // =========================

        private string GenerateBookId()
        {
            string id;

            do
            {
                id = $"SACH{nextBookId++:000}";
            }
            while (books.Any(b => b.BookId == id));

            return id;
        }

        // =========================
        // 3. KIEM TRA DU LIEU
        // =========================

        private bool ValidateBookInput()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách!");
                txtTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả!");
                txtAuthor.Focus();
                return false;
            }

            if (!TryReadPrice(txtPrice.Text, out decimal price)
                || price <= 0)
            {
                MessageBox.Show(
                    "Đơn giá phải là số lớn hơn 0!\n" +
                    "Ví dụ: 50000 hoặc 50000,5");
                txtPrice.Focus();
                return false;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(),
                out int quantity) || quantity < 0)
            {
                MessageBox.Show(
                    "Số lượng phải là số nguyên không âm!");
                txtQuantity.Focus();
                return false;
            }

            return true;
        }

        private bool TryReadPrice(string text, out decimal price)
        {
            text = text.Trim();

            return decimal.TryParse(
                       text,
                       NumberStyles.Number,
                       CultureInfo.CurrentCulture,
                       out price)
                   || decimal.TryParse(
                       text,
                       NumberStyles.Number,
                       CultureInfo.InvariantCulture,
                       out price);
        }

        // =========================
        // 4. THEM SACH
        // =========================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateBookInput())
                return;

            BookModel book = new BookModel
            {
                BookId = GenerateBookId(),
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                Price = ReadPrice(txtPrice.Text),
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                CoverPath = coverPath
            };

            books.Add(book);
            ShowAllBooks();
            SelectBook(book);
            UpdateStatus();

            MessageBox.Show("Thêm sách thành công!");
        }

        private decimal ReadPrice(string text)
        {
            TryReadPrice(text, out decimal price);
            return price;
        }

        // =========================
        // 5. TAI ANH BIA
        // =========================

        private void btnLoadCover_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Chọn ảnh bìa sách";
            dialog.Filter =
                "Tệp ảnh (*.jpg;*.jpeg;*.png;*.bmp)|" +
                "*.jpg;*.jpeg;*.png;*.bmp|Tất cả tệp (*.*)|*.*";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using Image temp = Image.FromFile(dialog.FileName);
                Image newImage = new Bitmap(temp);

                ReplaceCoverImage(newImage);
                coverPath = dialog.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể mở ảnh bìa:\n" + ex.Message);
            }
        }

        private void ReplaceCoverImage(Image newImage)
        {
            Image oldImage = picBookCover.Image;
            picBookCover.Image = newImage;

            if (oldImage != null)
                oldImage.Dispose();
        }

        // =========================
        // 6. CHON SACH TREN BANG
        // =========================

        private void dgvBooks_SelectionChanged(
            object sender, EventArgs e)
        {
            if (isSearching)
                return;

            if (dgvBooks.CurrentRow?.DataBoundItem
                is not BookModel book)
                return;

            DisplayBook(book);
        }

        private void DisplayBook(BookModel book)
        {
            txtBookId.Text = book.BookId;
            txtTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            txtPrice.Text = book.Price.ToString(
                CultureInfo.CurrentCulture);
            txtQuantity.Text = book.Quantity.ToString();

            coverPath = book.CoverPath;

            try
            {
                if (!string.IsNullOrWhiteSpace(coverPath)
                    && File.Exists(coverPath))
                {
                    using Image temp = Image.FromFile(coverPath);
                    ReplaceCoverImage(new Bitmap(temp));
                }
                else
                {
                    ReplaceCoverImage(null);
                }
            }
            catch
            {
                ReplaceCoverImage(null);
            }
        }

        private void SelectBook(BookModel book)
        {
            foreach (DataGridViewRow row in dgvBooks.Rows)
            {
                if (row.DataBoundItem is BookModel current
                    && current.BookId == book.BookId)
                {
                    row.Selected = true;
                    dgvBooks.CurrentCell =
                        row.Cells.Cast<DataGridViewCell>()
                            .FirstOrDefault(c => c.Visible);

                    break;
                }
            }

            DisplayBook(book);
        }

        // =========================
        // 7. SUA SACH
        // =========================

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow?.DataBoundItem
                is not BookModel book)
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa!");
                return;
            }

            if (!ValidateBookInput())
                return;

            book.Title = txtTitle.Text.Trim();
            book.Author = txtAuthor.Text.Trim();
            book.Price = ReadPrice(txtPrice.Text);
            book.Quantity = int.Parse(txtQuantity.Text.Trim());
            book.CoverPath = coverPath;

            bookSource.ResetBindings(false);
            UpdateStatus();

            MessageBox.Show("Cập nhật sách thành công!");
        }

        // =========================
        // 8. XOA SACH
        // =========================

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow?.DataBoundItem
                is not BookModel book)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa!");
                return;
            }

            DialogResult answer = MessageBox.Show(
                $"Bạn có chắc muốn xóa sách '{book.Title}'?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (answer != DialogResult.Yes)
                return;

            books.Remove(book);
            ShowAllBooks();
            ClearBookInputs();
            UpdateStatus();

            MessageBox.Show("Đã xóa sách!");
        }

        // =========================
        // 9. TIM KIEM SACH
        // =========================

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = ShowInputDialog(
                "Nhập mã sách, tên sách hoặc tác giả:",
                "Tìm kiếm sách");

            if (keyword == null)
                return;

            keyword = keyword.Trim();

            if (keyword.Length == 0)
            {
                ShowAllBooks();
                return;
            }

            var results = books.Where(b =>
                b.BookId.Contains(
                    keyword, StringComparison.OrdinalIgnoreCase)
                || b.Title.Contains(
                    keyword, StringComparison.OrdinalIgnoreCase)
                || b.Author.Contains(
                    keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();

            isSearching = true;

            try
            {
                bookSource.DataSource =
                    new BindingList<BookModel>(results);

                dgvBooks.DataSource = bookSource;
                dgvBooks.ClearSelection();
            }
            finally
            {
                isSearching = false;
            }

            ClearBookInputs();

            MessageBox.Show($"Tìm thấy {results.Count} sách.");
        }

        private string ShowInputDialog(string message, string title)
        {
            using Form dialog = new Form();

            dialog.Text = title;
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.ClientSize = new Size(390, 135);
            dialog.MinimizeBox = false;
            dialog.MaximizeBox = false;
            dialog.ShowInTaskbar = false;

            Label label = new Label
            {
                Text = message,
                AutoSize = true,
                Location = new Point(12, 12)
            };

            TextBox input = new TextBox
            {
                Location = new Point(12, 40),
                Width = 365
            };

            Button ok = new Button
            {
                Text = "Tìm",
                DialogResult = DialogResult.OK,
                Location = new Point(205, 80),
                Width = 80
            };

            Button cancel = new Button
            {
                Text = "Hủy",
                DialogResult = DialogResult.Cancel,
                Location = new Point(295, 80),
                Width = 80
            };

            dialog.Controls.AddRange(
                new Control[] { label, input, ok, cancel });

            dialog.AcceptButton = ok;
            dialog.CancelButton = cancel;

            return dialog.ShowDialog(this) == DialogResult.OK
                ? input.Text
                : null;
        }

        private void ShowAllBooks()
        {
            isSearching = true;

            try
            {
                bookSource.DataSource = books;
                dgvBooks.DataSource = bookSource;
                bookSource.ResetBindings(false);
                dgvBooks.ClearSelection();
            }
            finally
            {
                isSearching = false;
            }
        }

        // =========================
        // 10. XOA TRANG NHAP
        // =========================

        private void ClearBookInputs()
        {
            txtBookId.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();

            coverPath = "";
            ReplaceCoverImage(null);
        }

        // =========================
        // 11. CAP NHAT THONG KE
        // =========================

        private void UpdateStatus()
        {
            int totalQuantity = books.Sum(b => b.Quantity);
            decimal totalValue = books.Sum(b => b.TotalValue);

            SetStatusText("lblTotalBooks",
                $"Tổng số sách: {totalQuantity:N0}");

            SetStatusText("lblTotalValue",
                $"Tổng giá trị kho: {totalValue:N0} VNĐ");

            SetStatusText("lblCurrentTime",
                $"Thời gian: {DateTime.Now:HH:mm:ss}");
        }

        // =========================
        // 12. XUAT FILE CSV
        // =========================

        private void SaveCsv()
        {
            using SaveFileDialog dialog = new SaveFileDialog();

            dialog.Title = "Lưu danh sách sách";
            dialog.Filter = "Tệp CSV (*.csv)|*.csv";
            dialog.FileName = "DanhSachSach.csv";
            dialog.DefaultExt = "csv";
            dialog.AddExtension = true;
            dialog.OverwritePrompt = true;

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using StreamWriter writer = new StreamWriter(
                    dialog.FileName, false, new UTF8Encoding(true));

                writer.WriteLine(
                    "BookId,Title,Author,Price,Quantity,CoverPath");

                foreach (BookModel book in books)
                {
                    string[] fields =
                    {
                        book.BookId,
                        book.Title,
                        book.Author,
                        book.Price.ToString(
                            CultureInfo.InvariantCulture),
                        book.Quantity.ToString(
                            CultureInfo.InvariantCulture),
                        book.CoverPath
                    };

                    writer.WriteLine(
                        string.Join(",", fields.Select(EscapeCsv)));
                }

                MessageBox.Show("Lưu file CSV thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi lưu file CSV:\n" + ex.Message);
            }
        }

        private string EscapeCsv(string value)
        {
            return "\"" +
                (value ?? "").Replace("\"", "\"\"") +
                "\"";
        }

        // =========================
        // 13. DOC FILE CSV
        // =========================

        private string[] ParseCsvLine(string line)
        {
            List<string> fields = new List<string>();
            StringBuilder field = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '"')
                {
                    if (inQuotes
                        && i + 1 < line.Length
                        && line[i + 1] == '"')
                    {
                        field.Append('"');
                        i++;
                    }
                    else
                    {
                        inQuotes = !inQuotes;
                    }
                }
                else if (c == ',' && !inQuotes)
                {
                    fields.Add(field.ToString());
                    field.Clear();
                }
                else
                {
                    field.Append(c);
                }
            }

            if (inQuotes)
                throw new FormatException(
                    "Dữ liệu CSV có dấu ngoặc kép không hợp lệ.");

            fields.Add(field.ToString());
            return fields.ToArray();
        }

        private void LoadCsv()
        {
            using OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Mở danh sách sách";
            dialog.Filter = "Tệp CSV (*.csv)|*.csv";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                string[] lines = File.ReadAllLines(
                    dialog.FileName, Encoding.UTF8);

                List<BookModel> importedBooks =
                    new List<BookModel>();

                for (int i = 1; i < lines.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(lines[i]))
                        continue;

                    string[] fields = ParseCsvLine(lines[i]);

                    if (fields.Length != 6)
                        throw new FormatException(
                            $"Dữ liệu dòng {i + 1} không có đủ 6 cột.");

                    if (!decimal.TryParse(
                        fields[3],
                        NumberStyles.Number,
                        CultureInfo.InvariantCulture,
                        out decimal price) || price < 0)
                    {
                        throw new FormatException(
                            $"Đơn giá không hợp lệ tại dòng {i + 1}.");
                    }

                    if (!int.TryParse(fields[4], out int quantity)
                        || quantity < 0)
                    {
                        throw new FormatException(
                            $"Số lượng không hợp lệ tại dòng {i + 1}.");
                    }

                    importedBooks.Add(new BookModel
                    {
                        BookId = fields[0],
                        Title = fields[1],
                        Author = fields[2],
                        Price = price,
                        Quantity = quantity,
                        CoverPath = fields[5]
                    });
                }

                // Chi thay danh sach hien tai khi doc file thanh cong
                books.RaiseListChangedEvents = false;

                try
                {
                    books.Clear();

                    foreach (BookModel book in importedBooks)
                        books.Add(book);
                }
                finally
                {
                    books.RaiseListChangedEvents = true;
                    bookSource.DataSource = books;
                    bookSource.ResetBindings(false);
                }

                nextBookId = 1;

                foreach (BookModel book in books)
                {
                    if (book.BookId.StartsWith(
                        "SACH", StringComparison.OrdinalIgnoreCase)
                        && int.TryParse(
                            book.BookId.Substring(4), out int id))
                    {
                        nextBookId = Math.Max(nextBookId, id + 1);
                    }
                }

                ClearBookInputs();
                UpdateStatus();

                MessageBox.Show(
                    $"Đã đọc thành công {books.Count} sách.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể đọc file CSV:\n" + ex.Message);
            }
        }

        // =========================
        // 14. CAC SU KIEN MENU
        // =========================

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            btnDelete.PerformClick();
        }

        private void mnuSearch_Click(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void mnuOpenCsv_Click(object sender, EventArgs e)
        {
            LoadCsv();
        }

        private void mnuSaveCsv_Click(object sender, EventArgs e)
        {
            SaveCsv();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // =========================
        // 15. CAC SU KIEN TOOLSTRIP
        // =========================

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            LoadCsv();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveCsv();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        // =========================
        // 16. DONG FORM
        // =========================

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            clockTimer.Stop();
            clockTimer.Dispose();

            if (picBookCover.Image != null)
            {
                Image oldImage = picBookCover.Image;
                picBookCover.Image = null;
                oldImage.Dispose();
            }

            base.OnFormClosed(e);
        }
    }
}
