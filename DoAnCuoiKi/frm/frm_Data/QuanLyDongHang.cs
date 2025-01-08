using DoAnCuoiKi.frm.frm_Data;
using DoAnCuoiKi.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class QuanLyDongHang : Form
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
        public QuanLyDongHang()
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
            var thongTin = db.PHIEUGIAOHANGs.Select(x => new { x.MaPhieu, x.NgayLap, x.DiaChi, x.NgayGiaoHang, x.TrangThaiGiaoHang, x.MaDH, x.Phi , x.GhiChu }).ToList();
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
            MapWebView.Source = new Uri(@"D:\HUTECH\C#\CuaHangQuanAo\CuaHangQuanAo_DoAn\DoAnCuoiKi\frm\frm_Data\Map.html");
        }

        private void DonHangAdvanced_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = DonHangAdvanced.Rows[e.RowIndex];
                var maSo = row.Cells["MaDH"].Value.ToString();
                if (!string.IsNullOrEmpty(maSo))
                {
                    var thongTin = db.PHIEUGIAOHANGs.FirstOrDefault(x => x.MaDH == maSo);
                    if (thongTin != null)
                    {
                        MaPhieuText.Text = thongTin.MaPhieu;
                        DiaChiText.Text = thongTin.DiaChi;
                        NgayLapDate.Value = thongTin.NgayLap;
                        NgayGiaoDate.Value = thongTin.NgayGiaoHang;
                        GhiChuText.Text = thongTin.GhiChu;
                        PhiText.Text = thongTin.Phi.ToString();
                        TrangThaComboBox.SelectedItem = thongTin.TrangThaiGiaoHang;
                        MaDHText.Text = thongTin.MaDH;
                    }

                }
            }
        }

        private void MapWebView_Click(object sender, EventArgs e)
        {

        }

        private void CapNhatButton_Click(object sender, EventArgs e)
        {
            // update
            try
            {
                var phieu = db.PHIEUGIAOHANGs.FirstOrDefault(x => x.MaPhieu == MaPhieuText.Text);
                if (phieu != null)
                {
                    phieu.DiaChi = DiaChiText.Text;
                    phieu.NgayLap = NgayLapDate.Value;
                    phieu.NgayGiaoHang = NgayGiaoDate.Value;
                    phieu.GhiChu = GhiChuText.Text;
                    phieu.Phi = decimal.Parse(PhiText.Text);
                    phieu.TrangThaiGiaoHang = TrangThaComboBox.SelectedItem.ToString();
                    phieu.MaDH = MaDHText.Text;
                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu giao hàng", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        // Tìm kiếm dựa theo mã phiếu hàng hoặc mã đơn hàng
        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            
            var maDH = MaDHText.Text;
            var maPhieu = MaPhieuText.Text;
            
            var query = db.PHIEUGIAOHANGs.AsQueryable();
            if (!string.IsNullOrEmpty(maDH))
            {
                query = query.Where(x => x.MaDH == maDH);
            }
            if (!string.IsNullOrEmpty(maPhieu))
            {
                query = query.Where(x => x.MaPhieu == maPhieu);
            }

            var phieu = query.ToList();

            if (phieu == null || !phieu.Any())
            {
                MessageBox.Show("Đơn hàn này không có thông tin vận chuyển", "Thông báo");
                return;
            }

            DonHangAdvanced.Refresh();
            DonHangAdvanced.DataSource = phieu;
        }

        private void DonHangAdvanced_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(DonHangAdvanced.FilterString) == true)
                {
                    LoadData();
                }
                else
                {
                    var listfilter = FilterStringconverter(DonHangAdvanced.FilterString);
                    filterList = filterList.AsQueryable().Where(listfilter).ToList();
                    DonHangAdvanced.DataSource = filterList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + MethodBase.GetCurrentMethod().Name, "Thông báo");
            }
        }

        private void DonHangAdvanced_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(DonHangAdvanced.SortString) == true)
                    return;

                var sortStr = DonHangAdvanced.SortString.Replace("[", "").Replace("]", "");

                if (string.IsNullOrEmpty(DonHangAdvanced.FilterString) == true)
                {
                    DonHangAdvanced.DataSource = db.PHIEUGIAOHANGs.AsQueryable().OrderBy(sortStr).Select(x => new { x.MaPhieu, x.NgayLap, x.DiaChi, x.NgayGiaoHang, x.TrangThaiGiaoHang, x.MaDH, x.Phi, x.GhiChu }).ToList();
                }
                else
                {
                    filterList = filterList.AsQueryable().OrderBy(sortStr).ToList();
                    DonHangAdvanced.DataSource = filterList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + MethodBase.GetCurrentMethod().Name, "Thông báo");
            }
        }

        private string FilterStringconverter(string filter)
        {
            string newColFilter = "";
            filter = filter.Replace("(", "").Replace(")", "");
            var colFilterList = filter.Split(new string[] { "AND" }, StringSplitOptions.None);
            string andOperator = "";
            foreach (var colFilter in colFilterList)
            {
                newColFilter += andOperator;
                var temp1 = colFilter.Trim().Split(new string[] { "IN" }, StringSplitOptions.None);
                var colName = temp1[0].Split('[', ']')[1].Trim();
                newColFilter += string.Format("({0} != null && (", colName);
                string orOperator = "";
                var filterValsList = temp1[1].Split(',');
                foreach (var filterVal in filterValsList)
                {
                    var cleanFilterVal = filterVal.Replace("'", "").Trim();

                    double tempNum = 0;
                    if (Double.TryParse(cleanFilterVal, out tempNum))
                        newColFilter += string.Format("{0} {1} = {2}", orOperator, colName, cleanFilterVal.Trim());
                    else
                        newColFilter += string.Format("{0} {1}.Contains('{2}')", orOperator, colName, cleanFilterVal.Trim());

                    orOperator = " OR ";
                }

                newColFilter += "))";

                andOperator = " AND ";
            }
            return newColFilter.Replace("'", "\"");
        }
    }
}
