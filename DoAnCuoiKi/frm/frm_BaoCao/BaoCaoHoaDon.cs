using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKi.model;
using Microsoft.Reporting.WinForms;

namespace DoAnCuoiKi
{
    public partial class BaoCaoHoaDon : Form
    {

        CuaHangDB db = new CuaHangDB();


        public BaoCaoHoaDon()
        {
            InitializeComponent();
        }

        public class HoaDon
        {
            public string MaHD { get; set; }
            public DateTime NgayLap { get; set; }
            public decimal TongTien { get; set; }
            public string PhuongThucThanhToan { get; set; }
            public string MaDH { get; set; }
            public string TenNV { get; set; }
            public string GhiChu { get; set; }
        }

        public List<HoaDon> DanhSachHoaDon(int thang, int nam)
        {
            var hoaDons = db.HOADONs.Where(x => x.NgayLap.Month == thang && x.NgayLap.Year == nam).Select(x => new HoaDon
            {
                MaHD = x.MaHD,
                NgayLap = x.NgayLap,
                TongTien = x.TongTien,
                PhuongThucThanhToan = x.PhuongThucThanhToan,
                MaDH = x.MaDH,
                TenNV = x.DonHang.NHANVIEN.Ho + " " + x.DonHang.NHANVIEN.LotTen,
                GhiChu = x.GhiChu
            }).ToList();

            return hoaDons;
        }

        public class BaoCao
        {
            public string GiaTri {  get; set; }
            public float tyLe {  get; set; }

        }

        public List<BaoCao> BaoCaoTyLe(int thang, int nam)
        {
            List<BaoCao> listBC = new List<BaoCao>();

            var tong = db.HOADONs.Where(hd => hd.NgayLap.Month == thang && hd.NgayLap.Year == nam).Count();

            var x = db.HOADONs.Where(hd => hd.NgayLap.Month == thang && hd.NgayLap.Year == nam && hd.TongTien < 500000).Count();
            var y = db.HOADONs.Where(hd => hd.NgayLap.Month == thang && hd.NgayLap.Year == nam && hd.TongTien >= 500000 && hd.TongTien <= 1000000).Count();
            var z = db.HOADONs.Where(hd => hd.NgayLap.Month == thang && hd.NgayLap.Year == nam && hd.TongTien > 1000000).Count();

            listBC.Add(new BaoCao { GiaTri = "< 500.000", tyLe = (float)x / tong});
            listBC.Add(new BaoCao { GiaTri = "500.000 - 1.000.000", tyLe = (float)y / tong});
            listBC.Add(new BaoCao { GiaTri = "> 1.000.000", tyLe = (float)z / tong});

            return listBC;
        }

        private void BaoCaoHoaDon_Load(object sender, EventArgs e)
        {
            ThangText.Minimum = 1;
            ThangText.Maximum = 12;
            NamText.Minimum = 1000;
            NamText.Maximum = 3000;
            ThangText.Value = (decimal)DateTime.Now.Month;
            NamText.Value = (decimal)DateTime.Now.Year;
            this.BaoCaoReportViewer.RefreshReport();
        }

        private void ThangText_ValueChanged(object sender, EventArgs e)
        {
        }

        private void NamText_ValueChanged(object sender, EventArgs e)
        {
        }

        private void LapBaoCaoButton_Click(object sender, EventArgs e)
        {
            var thang = (int)ThangText.Value;
            var nam = (int)NamText.Value;

            if (string.IsNullOrEmpty(thang.ToString())
                || string.IsNullOrEmpty(nam.ToString()))
            {
                MessageBox.Show("Gía trị không hợp lệ");
            }

            BaoCaoReportViewer.LocalReport.ReportPath = "D:\\HUTECH\\C#\\CuaHangQuanAo\\CuaHangQuanAo_DoAn\\DoAnCuoiKi\\frm\\frm_BaoCao\\rptBaoCao.rdlc";
            var dsHoaDon = new ReportDataSource("HoaDonDataSet", DanhSachHoaDon(thang, nam));
            var tyleHoaDon = new ReportDataSource("BaoCaoDataSet", BaoCaoTyLe(thang, nam));

            var thangPara = new ReportParameter("Thang", thang.ToString());
            var namPara = new ReportParameter("Nam", nam.ToString());

            BaoCaoReportViewer.LocalReport.DataSources.Clear();
            BaoCaoReportViewer.LocalReport.DataSources.Add(tyleHoaDon);
            BaoCaoReportViewer.LocalReport.DataSources.Add(dsHoaDon);

            BaoCaoReportViewer.LocalReport.SetParameters(thangPara);
            BaoCaoReportViewer.LocalReport.SetParameters(namPara);

            BaoCaoReportViewer.RefreshReport();
        }
    }
}
