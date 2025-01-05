using DoAnCuoiKi.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAnCuoiKi.frm.frm_BaoCao
{
    public partial class QuanLyDoanhThu : Form
    {
        CuaHangDB db = new CuaHangDB();
        public QuanLyDoanhThu()
        {
            InitializeComponent();
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            txtMonth.Text = "MM-yyyy";
            lblTotalRevenue.Text = "Tổng doanh thu: 0";
            KhoiTaoChart();
        }

        private void KhoiTaoChart()
        {
            // Clear any existing series and chart areas
            chartRevenue.Series.Clear();
            chartRevenue.ChartAreas.Clear();

            // Add a new Chart Area
            ChartArea chartArea = new ChartArea("RevenueChartArea");
            chartArea.AxisX.Title = "Ngày";
            chartArea.AxisY.Title = "Doanh thu (VND)";
            chartArea.AxisX.Interval = 1;
            chartRevenue.ChartAreas.Add(chartArea);

            // Add a Series for Revenue
            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column; // Column chart
            series.XValueType = ChartValueType.String;
            chartRevenue.Series.Add(series);
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtMonth.Text.Trim();

                // Chuẩn hóa đầu vào: thêm "0" nếu tháng có một chữ số
                string[] parts = input.Split('-');
                if (parts.Length == 2 && parts[0].Length == 1)
                {
                    parts[0] = "0" + parts[0];
                    input = string.Join("-", parts);
                }

                if (!DateTime.TryParseExact(input, "MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime month))
                {
                    MessageBox.Show("Vui lòng nhập tháng hợp lệ theo định dạng MM-yyyy.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate start and end date of the given month
                DateTime startDate = new DateTime(month.Year, month.Month, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);



                var hoaDonTheoNgay = db.HOADONs
                       .Where(hd => hd.NgayLap >= startDate && hd.NgayLap <= endDate)
                       .GroupBy(hd => System.Data.Entity.DbFunctions.TruncateTime(hd.NgayLap));

                var dataReport = hoaDonTheoNgay.Select(hd => new
                {
                    NgayLap = hd.Key,
                    TongTien = hd.Sum(h => h.TongTien),
                    LoiNhuan = hd.Select(h => h.MaDH) 
                                    .Join(db.CHITIETDONHANGs, 
                                            maDon => maDon,  
                                            ct => ct.MaDH,
                                            (maDon, ct) => new
                                            {
                                                ct.SANPHAM.GiaBan,
                                                ct.SANPHAM.GiaNhap,
                                                ct.SoLuong
                                            })
                                    .Sum(ct => (ct.GiaBan - ct.GiaNhap) * ct.SoLuong) 
                }).ToList()
                .Select(hd => new
                {
                    hd.NgayLap,
                    TongTien = hd.TongTien.ToString("C0", CultureInfo.GetCultureInfo("vi-VN")),
                    LoiNhuan = hd.LoiNhuan.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"))
                }).ToList();

                dgvReport.DataSource = dataReport;

                // Đưa data vào chart
                var dataChart = hoaDonTheoNgay.Select(hd => new { NgayLap = hd.Key, TongTien = hd.Sum(h => h.TongTien) }).ToList();

                chartRevenue.Series.Clear();

                var series = new Series("Doanh thu")
                {
                    ChartType = SeriesChartType.Column, 
                    XValueType = ChartValueType.DateTime, 
                    YValueType = ChartValueType.Double
                };

                chartRevenue.Series.Add(series);
                
                foreach (var item in dataChart)
                {
                    series.Points.AddXY(item.NgayLap, item.TongTien);
                }

                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Format = "dd";
                chartRevenue.ChartAreas[0].AxisX.Interval = 1; 
                chartRevenue.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;

                // Cấu hình trục Y (Doanh thu)
                chartRevenue.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";
                chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "#,0";



                decimal totalRevenue = 0;
                decimal loiNhuan = 0;
                foreach (DataGridViewRow row in dgvReport.Rows)
                {
                    if (row.Cells["TongTien"].Value != null)
                    {
                        string value = row.Cells["TongTien"].Value.ToString();
                        value = value.Replace("₫", "").Replace(".", "").Trim();
                        if (decimal.TryParse(value, out decimal parsedValue))
                        {
                            totalRevenue += parsedValue;
                        }
                    }

                    if (row.Cells["LoiNhuan"].Value != null)
                    {
                        string value = row.Cells["LoiNhuan"].Value.ToString();
                        value = value.Replace("₫", "").Replace(".", "").Trim();
                        if (decimal.TryParse(value, out decimal parsedValue))
                        {
                            loiNhuan += parsedValue;
                        }
                    }
                }

                thangNam.Text = $"DOANH THU {month.Month}/{month.Year}";

                lblTotalRevenue.Text = $"Tổng doanh thu: {totalRevenue.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"))}";
                lblLoiNhuan.Text = loiNhuan.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void XuatBaoCaoButton_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtMonth.Text.Trim();

                // Chuẩn hóa đầu vào: thêm "0" nếu tháng có một chữ số
                string[] parts = input.Split('-');
                if (parts.Length == 2 && parts[0].Length == 1)
                {
                    parts[0] = "0" + parts[0];
                    input = string.Join("-", parts);
                }

                if (!DateTime.TryParseExact(input, "MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime month))
                {
                    MessageBox.Show("Vui lòng nhập tháng hợp lệ theo định dạng MM-yyyy.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate start and end date of the given month
                DateTime startDate = new DateTime(month.Year, month.Month, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                MessageBox.Show($"{startDate}, {endDate}");

                BaoCaoDoanhThu bcdt = new BaoCaoDoanhThu(startDate, endDate);
                bcdt.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xuất báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void chartRevenue_Click(object sender, EventArgs e)
        {

        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
