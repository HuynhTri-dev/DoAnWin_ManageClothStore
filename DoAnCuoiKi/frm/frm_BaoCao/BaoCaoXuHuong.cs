using DoAnCuoiKi.model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DoAnCuoiKi.XuatHoaDon;

namespace DoAnCuoiKi.frm.frm_BaoCao
{
    public partial class BaoCaoXuHuong : Form
    {
        CuaHangDB db = new CuaHangDB();
        public BaoCaoXuHuong()
        {
            InitializeComponent();
        }

        private void ThangText_ValueChanged(object sender, EventArgs e)
        {
            ThangText.Maximum = 12;
        }

        public class BaoCaoSanPham
        {
            public string MaSP { get; set; }
            public string TenSP { get; set; }
            public int SoLuong { get; set; }
        }

        public class BaoCaoDanhMuc
        {
            public string MaDM { get; set; }
            public string TenDM { get; set; }
            public int SoLuong { get; set; }
        }

        private void LapBaoCaoButton_Click(object sender, EventArgs e)
        {
            var thang = ThangText.Value;
            var nam = NamText.Value;

            // Kiểm tra tháng năm đã nhập chưa
            if (string.IsNullOrEmpty(thang.ToString()) || string.IsNullOrEmpty(nam.ToString()))
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin");
                return;
            }

            // Kiểm tra tháng có hợp lệ không
            if (thang < 1 || thang > 12)
            {
                MessageBox.Show("Tháng không hợp lệ");
                return;
            }

            var sanPham = db.CHITIETDONHANGs
                .Where(x => x.DonHang.NgayLapDon.Month == thang && x.DonHang.NgayLapDon.Year == nam)
                .GroupBy(x => x.MaSP)
                .Select(x => new BaoCaoSanPham
                {
                    MaSP = x.Key,
                    TenSP = x.FirstOrDefault().SANPHAM.TenSP,
                    SoLuong = x.Sum(y => y.SoLuong)
                })
                .OrderByDescending(x => x.SoLuong)
                .ToList();

            var danhMuc = db.CHITIETDONHANGs
                .Where(x => x.DonHang.NgayLapDon.Month == thang && x.DonHang.NgayLapDon.Year == nam)
                .GroupBy(x => x.SANPHAM.MaDM)
                .Select(x => new BaoCaoDanhMuc
                {
                    MaDM = x.Key,
                    TenDM = x.FirstOrDefault().SANPHAM.DANHMUC.TenDM,
                    SoLuong = x.Sum(y => y.SoLuong)
                })
                .OrderByDescending(x => x.SoLuong)
                .ToList();

            if (sanPham == null && danhMuc == null)
            {
                MessageBox.Show("Không có đủ thông tin để báo cáo");
                return;
            }

            int tong = 0;
            foreach (var item in sanPham)
            {
                tong += item.SoLuong;
            }
            TongSanPhamText.Text = tong.ToString();


            sanphamfrid.DataSource = sanPham;
            danhmucfrid.DataSource = danhMuc;



            SanPhamReportViewer.LocalReport.ReportPath = "D:\\HUTECH\\C#\\CuaHangQuanAo\\CuaHangQuanAo_DoAn\\DoAnCuoiKi\\frm\\frm_BaoCao\\rptXuHuong.rdlc";
            var sp = new ReportDataSource("SanPham", sanPham);
            var dm = new ReportDataSource("DanhMuc", danhMuc);

            var paraThang = new ReportParameter("Thang", thang.ToString());

            SanPhamReportViewer.LocalReport.DataSources.Clear();
            SanPhamReportViewer.LocalReport.DataSources.Add(sp);
            SanPhamReportViewer.LocalReport.DataSources.Add(dm);
            SanPhamReportViewer.LocalReport.SetParameters(paraThang);
            SanPhamReportViewer.RefreshReport();
        }

        private void NamText_ValueChanged(object sender, EventArgs e)
        {
            NamText.Maximum = 3000;
            NamText.Minimum = 1000;
        }

        private void BaoCaoXuHuong_Load(object sender, EventArgs e)
        {

        }
    }
}
