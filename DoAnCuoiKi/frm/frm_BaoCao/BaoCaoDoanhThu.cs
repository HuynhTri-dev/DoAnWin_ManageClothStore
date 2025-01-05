using DoAnCuoiKi.model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DoAnCuoiKi.BanHang;

namespace DoAnCuoiKi.frm.frm_BaoCao
{
    public partial class BaoCaoDoanhThu : Form
    {
        CuaHangDB db = new CuaHangDB();
        DateTime StartDate;
        DateTime EndDate;

        public class DoanhThu
        {
            public string Ngay { get; set; }
            public decimal Tien { get; set; }
            public decimal LoiNhuan { get; set; }
        }

        public BaoCaoDoanhThu(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            StartDate = startDate;
            EndDate = endDate;
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            var dataReport = db.HOADONs
                       .Where(hd => hd.NgayLap >= StartDate && hd.NgayLap <= EndDate)
                       .GroupBy(hd => System.Data.Entity.DbFunctions.TruncateTime(hd.NgayLap))
                       .Select(hd => new
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
                       .Select (x => new DoanhThu
                       {
                           Ngay = x.NgayLap.HasValue ? x.NgayLap.Value.ToString("dd") : "",
                           Tien = x.TongTien,
                           LoiNhuan = x.LoiNhuan
                       }).ToList();
                       

            if (dataReport.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            DoanhThuReportViewer.LocalReport.ReportPath = "D:\\HUTECH\\C#\\CuaHangQuanAo\\CuaHangQuanAo_DoAn\\DoAnCuoiKi\\frm\\frm_BaoCao\\rptDoanhThu.rdlc";
            var dataDoanhThu = new ReportDataSource("DoanhThu", dataReport);
            var thangPara = new ReportParameter("Thang", StartDate.Month.ToString());
            var namPara = new ReportParameter("Nam", StartDate.Year.ToString());

            DoanhThuReportViewer.LocalReport.DataSources.Clear();
            DoanhThuReportViewer.LocalReport.DataSources.Add(dataDoanhThu);

            DoanhThuReportViewer.LocalReport.SetParameters(thangPara);
            DoanhThuReportViewer.LocalReport.SetParameters(namPara);

            DoanhThuReportViewer.RefreshReport();
        }

        private void DoanhThuReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
