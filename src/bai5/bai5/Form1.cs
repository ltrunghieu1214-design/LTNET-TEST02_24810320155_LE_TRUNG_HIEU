using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cts;
        private Task _monitorTask;

        private decimal _currentPrice = 65000m;
        private int _syncCount = 0;
        private readonly Random _random = new Random();

        public Form1()
        {
            InitializeComponent();

            SetupGrid();
            SetupEvents();

            btnPause.Enabled = false;
            lblBTCPrice.Text = $"BTC/USD: {_currentPrice:N2} $";
            lblBTCPrice.ForeColor = Color.Green;

            this.FormClosing += Form1_FormClosing;
        }
        private void SetupGrid()
        {
            dgvHistoryLog.Columns.Clear();
            dgvHistoryLog.AutoGenerateColumns = false;
            dgvHistoryLog.ReadOnly = true;
            dgvHistoryLog.AllowUserToAddRows = false;
            dgvHistoryLog.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvHistoryLog.MultiSelect = false;
            dgvHistoryLog.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvHistoryLog.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "colTime",
                    HeaderText = "Thời gian",
                    DataPropertyName = "Time"
                });

            dgvHistoryLog.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "colPrice",
                    HeaderText = "Giá BTC/USD",
                    DataPropertyName = "Price"
                });

            dgvHistoryLog.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "colChange",
                    HeaderText = "Biến động",
                    DataPropertyName = "Change"
                });

            dgvHistoryLog.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "colStatus",
                    HeaderText = "Trạng thái",
                    DataPropertyName = "Status"
                });
        }
        private void SetupEvents()
        {
            btnStart.Click += btnStart_Click;
            btnPause.Click += btnPause_Click;
        }
        private async Task MonitorLoopAsync(
    CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                token.ThrowIfCancellationRequested();

                decimal oldPrice = _currentPrice;

                // Sinh biến động ngẫu nhiên từ -500 đến +500 USD.
                int change = _random.Next(-500, 501);

                decimal newPrice = Math.Max(
                    1m,
                    oldPrice + change
                );

                // Chuyển dữ liệu sang UI Thread để cập nhật giao diện.
                UpdateUI(newPrice, oldPrice);

                // Chờ 2 giây rồi quét lượt tiếp theo.
                await Task.Delay(2000, token);
            }
        }
        private void UpdateUI(
    decimal newPrice,
    decimal oldPrice)
        {
            // Nếu đang chạy trên thread phụ,
            // chuyển thao tác cập nhật về UI Thread.
            if (this.IsDisposed || this.Disposing)
                return;

            if (this.InvokeRequired)
            {
                try
                {
                    this.Invoke(new Action(
                        () => UpdateUI(newPrice, oldPrice)
                    ));
                }
                catch (ObjectDisposedException)
                {
                    // Form đã bị đóng.
                }
                catch (InvalidOperationException)
                {
                    // Không thể Invoke khi Form đang đóng.
                }

                return;
            }

            // GIỮ NGUYÊN TOÀN BỘ CODE CẬP NHẬT GIAO DIỆN CŨ
            // Ví dụ:
            _currentPrice = newPrice;
            _syncCount++;

            lblBTCPrice.Text = $"BTC/USD: {newPrice:N2} $";

            // Từ đây trở xuống chạy trên UI Thread.
            _currentPrice = newPrice;
            _syncCount++;

            decimal difference = newPrice - oldPrice;

            lblBTCPrice.Text =
                $"BTC/USD: {newPrice:N2} $";

            if (difference > 0)
            {
                lblBTCPrice.ForeColor = Color.Green;
            }
            else if (difference < 0)
            {
                lblBTCPrice.ForeColor = Color.Red;
            }

            lblLastUpdate.Text =
                $"Cập nhật cuối: {DateTime.Now:HH:mm:ss}";

            lblSyncCount.Text =
                $"Số lần đồng bộ: {_syncCount}";

            string status;

            if (difference > 0)
                status = "Tăng";
            else if (difference < 0)
                status = "Giảm";
            else
                status = "Không đổi";

            dgvHistoryLog.Rows.Insert(
                0,
                DateTime.Now.ToString("HH:mm:ss"),
                newPrice.ToString("N2"),
                difference.ToString("+#,##0.00;-#,##0.00;0.00"),
                status
            );

            // Giữ tối đa 100 dòng lịch sử để bảng không tăng vô hạn.
            while (dgvHistoryLog.Rows.Count > 100)
            {
                dgvHistoryLog.Rows.RemoveAt(
                    dgvHistoryLog.Rows.Count - 1
                );
            }
        }
        private async void btnStart_Click(
    object sender,
    EventArgs e)
        {
            if (_monitorTask != null && !_monitorTask.IsCompleted)
                return;

            _cts = new CancellationTokenSource();

            btnStart.Enabled = false;
            btnPause.Enabled = true;

            CancellationToken token = _cts.Token;

            _monitorTask = Task.Run(
                () => MonitorLoopAsync(token),
                token
            );

            try
            {
                await _monitorTask;
            }
            catch (OperationCanceledException)
            {
                // Người dùng đã yêu cầu tạm dừng.
            }
            finally
            {
                if (!this.IsDisposed && !this.Disposing)
                {
                    btnStart.Enabled = true;
                    btnPause.Enabled = false;
                }

                _cts?.Dispose();
                _cts = null;
                _monitorTask = null;
            }
        }
        private async void btnPause_Click(
    object sender,
    EventArgs e)
        {
            if (_cts == null)
                return;

            btnPause.Enabled = false;

            _cts.Cancel();

            if (_monitorTask != null)
            {
                try
                {
                    await _monitorTask;
                }
                catch (OperationCanceledException)
                {
                    // Vòng lặp đã dừng bình thường.
                }
            }
        }
    private void Form1_FormClosing(
        object sender,
        FormClosingEventArgs e)
        {
            _cts?.Cancel();
        }











    }
}