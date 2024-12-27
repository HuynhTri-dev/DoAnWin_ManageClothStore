using DoAnCuoiKi.frm.frm_Data;
using DoAnCuoiKi.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DoAnCuoiKi.frm.frm_Data.QuanLyHoaDon;

namespace DoAnCuoiKi
{
    public partial class QuanLyDonHang : Form
    {
        CuaHangDB db = new CuaHangDB();

        public class PhieuGiaoHang
        {
            public string MaPhieu { get; set; }
            public DateTime NgayLap { get; set; }
            public string DiaChi { get; set; }
            public DateTime NgayGiaoHang { get; set; }
            public string TrangThaiGiaoHang { get; set; }
            public string MaDH { get; set; }
            public decimal Phi { get; set; }
            public string GhiChu { get; set; }
        }
        List<PhieuGiaoHang> filterList = new List<PhieuGiaoHang>();

        // API Key gg map
        private const string ApiKey = "AIzaSyDMGi-gemh0_zCdxATofIcE3xVbqYd1U7E";
        public QuanLyDonHang()
        {
            InitializeComponent();
        }

        private void QuanLyDonHang_Load(object sender, EventArgs e)
        {
            LoadGoogleMaps();
            LoadData();
        }

        private void LoadData()
        {
            var thongTin = db.PHIEUGIAOHANGs.Select(x => new { x.MaPhieu, x.NgayLap, x.DiaChi, x.NgayGiaoHang, x.TrangThaiGiaoHang, x.MaDH, Phi = x.PHIGIAOHANG.Phi, x.GhiChu }).ToList();
            foreach (var x in thongTin)
            {
                PhieuGiaoHang hd = new PhieuGiaoHang()
                {
                    MaPhieu = x.MaPhieu,
                    NgayLap = x.NgayLap,
                    DiaChi = x.DiaChi,
                    NgayGiaoHang = x.NgayGiaoHang,
                    TrangThaiGiaoHang = x.TrangThaiGiaoHang,
                    MaDH = x.MaDH,
                    Phi = x.Phi,
                    GhiChu = x.GhiChu
                };
                filterList.Add(hd);
            }

            DonHangAdvanced.DataSource = thongTin;
        }

        private void LoadGoogleMaps()
        {
            MapWebView.Source = new Uri(@"D:\HUTECH\C#\CuaHangQuanAo\DoAnCuoiKi\DoAnCuoiKi\DoAnCuoiKi\frm\frm_Data\Map.html");
        }

        private void DonHangAdvanced_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
