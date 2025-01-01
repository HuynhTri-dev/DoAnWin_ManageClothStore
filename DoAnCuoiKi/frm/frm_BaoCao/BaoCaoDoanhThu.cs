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
    public partial class BaoCaoDoanhThu : Form
    {
        CuaHangDB db = new CuaHangDB();
        public BaoCaoDoanhThu()
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
                // Validate input month
                if (!DateTime.TryParseExact(txtMonth.Text, "MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime month))
                {
                    MessageBox.Show("Vui lòng nhập tháng hợp lệ theo định dạng MM-yyyy.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate start and end date of the given month
                DateTime startDate = new DateTime(month.Year, month.Month, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);



                var hoaDonTheoNgay = db.HOADONs
                       .Where(hd => hd.NgayLap >= startDate && hd.NgayLap <= endDate)
                       .GroupBy(hd => System.Data.Entity.DbFunctions.TruncateTime(hd.NgayLap)) 
                                                                          
                       .Select(g => new
                       {
                           NgayLap = g.Key.Value,
                           TongTien = g.Sum(hd => hd.TongTien)
                       })
                       .OrderBy(x => x.NgayLap)
                       .ToList();


                // Đưa data vào chart
                chartRevenue.Series.Clear();

                var series = new Series()
                {
                    ChartType = SeriesChartType.Column, 
                    XValueType = ChartValueType.DateTime, 
                    YValueType = ChartValueType.Double
                };

                chartRevenue.Series.Add(series);
                
                foreach (var item in hoaDonTheoNgay)
                {
                    series.Points.AddXY(item.NgayLap, item.TongTien);
                }

                dgvReport.DataSource = hoaDonTheoNgay;

                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Format = "dd";
                chartRevenue.ChartAreas[0].AxisX.Interval = 1; 
                chartRevenue.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;

                // Cấu hình trục Y (Doanh thu)
                chartRevenue.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";
                chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "#,0";



                decimal totalRevenue = 0;
                foreach (DataGridViewRow row in dgvReport.Rows)
                {
                    if (row.Cells["TongTien"].Value != null)
                    {
                        totalRevenue += Convert.ToDecimal(row.Cells["TongTien"].Value);
                    }
                }

                lblTotalRevenue.Text = $"Tổng doanh thu tháng {month.Month}: {totalRevenue.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"))}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

       

        private void chartRevenue_Click(object sender, EventArgs e)
        {

        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
