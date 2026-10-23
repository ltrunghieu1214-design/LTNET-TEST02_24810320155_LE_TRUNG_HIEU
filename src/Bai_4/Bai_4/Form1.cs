
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancellationSource;
        private bool isProcessing = false;

        private class RevenueRow
        {
            public string TransactionId { get; set; }
            public DateTime TransactionDate { get; set; }
            public string Branch { get; set; }
            public string Description { get; set; }
            public decimal Amount { get; set; }
        }

        public Form1()
        {
            InitializeComponent();

            dtpFromDate.Value = DateTime.Today.AddDays(-7);
            dtpToDate.Value = DateTime.Today;

            cboBranch.Items.AddRange(new object[]
            {
                "Tất cả chi nhánh",
                "Chi nhánh Hà Nội",
                "Chi nhánh Hải Phòng",
                "Chi nhánh Đà Nẵng",
                "Chi nhánh TP.HCM"
            });

            cboBranch.SelectedIndex = 0;
            cboBranch.DropDownStyle = ComboBoxStyle.DropDownList;

            pgbLoading.Minimum = 0;
            pgbLoading.Maximum = 100;
            pgbLoading.Value = 0;

            dgvRevenueData.AutoGenerateColumns = true;
            dgvRevenueData.ReadOnly = true;
            dgvRevenueData.AllowUserToAddRows = false;
            dgvRevenueData.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            lblProcessingStatus.Text = "Sẵn sàng";
            btnCancel.Enabled = false;

            btnAnalyze.Click += btnAnalyze_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private async void btnAnalyze_Click(
            object sender, EventArgs e)
        {
            if (isProcessing)
                return;

            if (dtpFromDate.Value.Date > dtpToDate.Value.Date)
            {
                MessageBox.Show(
                    "Ngày bắt đầu không được lớn hơn ngày kết thúc!");
                return;
            }

            isProcessing = true;
            btnAnalyze.Enabled = false;
            btnCancel.Enabled = true;
            pgbLoading.Value = 0;

            cancellationSource = new CancellationTokenSource();
            CancellationToken token = cancellationSource.Token;

            DateTime fromDate = dtpFromDate.Value.Date;
            DateTime toDate = dtpToDate.Value.Date;
            string branch = cboBranch.SelectedItem.ToString();

            try
            {
                IProgress<int> progress = new Progress<int>(value =>
                {
                    pgbLoading.Value = value;
                    lblProcessingStatus.Text =
                        $"Đang thống kê... {value}%";
                });

                List<RevenueRow> result = await Task.Run(async () =>
                {
                    Random random = new Random();

                    // Gia lap xu ly trong khoang 5 giay
                    for (int i = 1; i <= 50; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        await Task.Delay(100, token);

                        progress.Report(i * 2);
                    }

                    string[] branches =
                    {
                        "Chi nhánh Hà Nội",
                        "Chi nhánh Hải Phòng",
                        "Chi nhánh Đà Nẵng",
                        "Chi nhánh TP.HCM"
                    };

                    string[] descriptions =
                    {
                        "Bán hàng",
                        "Dịch vụ",
                        "Đơn hàng trực tuyến",
                        "Thanh toán hóa đơn"
                    };

                    List<RevenueRow> rows = new List<RevenueRow>();

                    for (int i = 1; i <= 30; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        int dayRange = (toDate - fromDate).Days + 1;
                        DateTime date = fromDate.AddDays(
                            random.Next(Math.Max(1, dayRange)));

                        string selectedBranch =
                            branches[random.Next(branches.Length)];

                        rows.Add(new RevenueRow
                        {
                            TransactionId = $"GD{i:000}",
                            TransactionDate = date,
                            Branch = selectedBranch,
                            Description = descriptions[
                                random.Next(descriptions.Length)],
                            Amount = random.Next(100, 5001) * 1000m
                        });
                    }

                    return rows
                        .Where(r =>
                            r.TransactionDate.Date >= fromDate &&
                            r.TransactionDate.Date <= toDate &&
                            (branch == "Tất cả chi nhánh" ||
                             r.Branch == branch))
                        .OrderBy(r => r.TransactionDate)
                        .ToList();

                }, token);

                dgvRevenueData.DataSource = null;
                dgvRevenueData.DataSource = result;

                decimal total = result.Sum(r => r.Amount);

                pgbLoading.Value = 100;
                lblProcessingStatus.Text =
                    $"Hoàn tất: {result.Count} giao dịch";

                MessageBox.Show(
                    $"Thống kê thành công!\n" +
                    $"Số giao dịch: {result.Count}\n" +
                    $"Tổng doanh thu: {total:N0} VNĐ",
                    "Kết quả thống kê");
            }
            catch (OperationCanceledException)
            {
                pgbLoading.Value = 0;
                lblProcessingStatus.Text = "Đã hủy thao tác!";

                MessageBox.Show(
                    "Đã hủy thao tác!",
                    "Thông báo");
            }
            catch (Exception ex)
            {
                lblProcessingStatus.Text = "Có lỗi xảy ra";

                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Thông báo lỗi");
            }
            finally
            {
                isProcessing = false;
                btnAnalyze.Enabled = true;
                btnCancel.Enabled = false;

                cancellationSource?.Dispose();
                cancellationSource = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (isProcessing && cancellationSource != null)
            {
                btnCancel.Enabled = false;
                lblProcessingStatus.Text = "Đang hủy...";
                cancellationSource.Cancel();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // De trong neu khong can xu ly khi mo Form
        }
    }
}
