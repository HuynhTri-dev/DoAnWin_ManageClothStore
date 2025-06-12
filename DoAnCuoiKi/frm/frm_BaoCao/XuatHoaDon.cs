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
    public partial class XuatHoaDon : Form
    {

        CuaHangDB db = new CuaHangDB();
        string MAHD;

        public XuatHoaDon(string MaHD)
        {
            InitializeComponent();
            MAHD = MaHD;
        }

        public class ThongTinHoaDon
        {
            public string maHD { get; set; }
            public DateTime ngayLap { get; set; }
            public decimal tongTien { get; set; }
            public string phuongThucThanhToan { get; set; }
        }

        public class CTHD
        {
            public string tenSP { get; set; }
            public int soLuong { get; set; }
            public decimal donGia { get; set; }
        }

        private void XuatHoaDon_Load(object sender, EventArgs e)
        {
                var tthd = db.HOADONs.FirstOrDefault(x => x.MaHD == MAHD);

            if (tthd == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn");
                this.Close();
                return;
                
            }

            List<ThongTinHoaDon> thongTinHoaDon = new List<ThongTinHoaDon>();

            ThongTinHoaDon tt = new ThongTinHoaDon
            {
                maHD = tthd.MaHD,
                ngayLap = tthd.NgayLap,
                tongTien = tthd.TongTien,
                phuongThucThanhToan = tthd.PhuongThucThanhToan,
            };

            thongTinHoaDon.Add(tt);

            

            List<CTHD> listCTHD = new List<CTHD>();
            var ctdh = db.CHITIETDONHANGs.Where(x => x.MaDH == tthd.MaDH).ToList();

            decimal tamTinh = 0;

            foreach (var item in ctdh)
            {
                var sp = db.SANPHAMs.FirstOrDefault(x => x.MaSP == item.MaSP);
                CTHD temp = new CTHD()
                {
                    tenSP = sp.TenSP,
                    soLuong = item.SoLuong,
                    donGia = sp.GiaBan,
                };

                tamTinh += item.SoLuong * sp.GiaBan;

                listCTHD.Add(temp);
            }

            // Gia tri giam gia
            decimal giamGia = 0;

            // Lấy giá trị khuyến mãi trực tiếp trong một truy vấn
            var giaTriKhuyenMai = db.DonHangs
                .Where(x => x.MaDH == tthd.MaDH && x.MaKM != null)
                .Select(x => x.KHUYENMAI.GiaTri)
                .FirstOrDefault();

            giamGia = tamTinh * (decimal)(giaTriKhuyenMai / 100);



            DonHangReportViewer.LocalReport.ReportPath = "D:\\HUTECH\\C#\\CuaHangQuanAo\\CuaHangQuanAo_DoAn\\DoAnCuoiKi\\frm\\frm_BaoCao\\rptDonHang.rdlc";
            var source = new ReportDataSource("ThongTinHD", thongTinHoaDon);
            var source2 = new ReportDataSource("CTHD", listCTHD);

            var tamTinhPara = new ReportParameter("TamTinh", tamTinh.ToString("0"));
            var giamGiaPara = new ReportParameter("GiamGia", giamGia.ToString("0"));

            DonHangReportViewer.LocalReport.DataSources.Clear();
            DonHangReportViewer.LocalReport.DataSources.Add(source);
            DonHangReportViewer.LocalReport.DataSources.Add(source2);

            DonHangReportViewer.LocalReport.SetParameters(tamTinhPara);
            DonHangReportViewer.LocalReport.SetParameters(giamGiaPara);

            DonHangReportViewer.RefreshReport();

            DonHangReportViewer.Controls.Add(DonHangReportViewer);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DonHangReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
