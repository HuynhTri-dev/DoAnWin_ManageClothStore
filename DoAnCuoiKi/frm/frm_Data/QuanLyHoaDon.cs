using DoAnCuoiKi.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zuby.ADGV;
using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;

namespace DoAnCuoiKi.frm.frm_Data
{
    public partial class QuanLyHoaDon : Form
    {
        CuaHangDB db = new CuaHangDB();
        public class HoaDon
        {
            public string MaHD { get; set; }
            public DateTime NgayLap { get; set; }
            public decimal TongTien { get; set; }
            public string PhuongThucThanhToan { get; set; }
            public string MaNV { get; set; }
            public string MaDH { get; set; }
            public string GhiChu { get; set; }
            
        }
        List<HoaDon> filterList = new List<HoaDon>();
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void LoadData()
        {
            var thongTin = db.HOADONs.Select(x => new {x.MaHD, x.NgayLap, x.TongTien,x.PhuongThucThanhToan,x.MaNV,x.MaDH, x.GhiChu}).ToList();

            foreach (var th in thongTin)
            {
                HoaDon hd = new HoaDon()
                { MaHD = th.MaHD, 
                  NgayLap = th.NgayLap, 
                  TongTien = th.TongTien, 
                  PhuongThucThanhToan = th.PhuongThucThanhToan, 
                  MaNV = th.MaNV, 
                  MaDH = th.MaDH, 
                  GhiChu = th.GhiChu 
                };
                filterList.Add(hd);
            }
            
            HoaDonAdvance.DataSource = thongTin;
        }

        private void HoaDonAdvance_FilterStringChanged(object sender, AdvancedDataGridView.FilterEventArgs e)
        {


            try
            {
                if (string.IsNullOrEmpty(HoaDonAdvance.FilterString) == true)
                {
                    LoadData();
                }
                else
                {
                    var listfilter = FilterStringconverter(HoaDonAdvance.FilterString);
                    filterList = filterList.AsQueryable().Where(listfilter).ToList();
                    HoaDonAdvance.DataSource = filterList;
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

        private void HoaDonAdvance_SortStringChanged(object sender, AdvancedDataGridView.SortEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(HoaDonAdvance.SortString) == true)
                    return;

                var sortStr = HoaDonAdvance.SortString.Replace("[", "").Replace("]", "");

                if (string.IsNullOrEmpty(HoaDonAdvance.FilterString) == true)
                {
                    HoaDonAdvance.DataSource = db.HOADONs.AsQueryable().OrderBy(sortStr).ToList();
                }
                else
                {
                    filterList = filterList.AsQueryable().OrderBy(sortStr).ToList();
                    HoaDonAdvance.DataSource = filterList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + MethodBase.GetCurrentMethod().Name, "Thông báo");
            }
        }

        private void HoaDonAdvance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = HoaDonAdvance.Rows[e.RowIndex];
                var maSo = row.Cells["MaDH"].Value.ToString();
                if (!string.IsNullOrEmpty(maSo))
                {
                    var thongTin = db.DonHangs.FirstOrDefault(x => x.MaDH == maSo);

                    if (thongTin != null)
                    {
                        MaDHText.Text = thongTin.MaDH;
                        NgayLap.Value = thongTin.NgayLapDon;
                        LoaiDHText.Text = thongTin.LoaiDH;  
                        MaKHText.Text = thongTin?.MaKH;
                        MaNVText.Text = thongTin.MaNV;
                        MaKMText.Text = thongTin.MaKM;
                    }

                    var data = db.CHITIETDONHANGs.Where(x => x.MaDH == maSo).Select(x => new { x.MaSP, x.SoLuong}).ToList();
                    CTDHDataGrid.DataSource = data;
                }
            }
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            var maDH = db.DonHangs.FirstOrDefault(x => x.MaDH == MaDHText.Text);
            var maHD = db.HOADONs.FirstOrDefault(x => x.MaDH == maDH.MaDH);
            if (maDH != null && maHD != null)
            {
                var chiTietDH = db.CHITIETDONHANGs.Where(x => x.MaDH == maDH.MaDH).ToList();
                DialogResult dlg = MessageBox.Show("Xóa thông tin đơn hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    db.HOADONs.Remove(maHD);
                    foreach(var ct in chiTietDH)
                    {
                        db.CHITIETDONHANGs.Remove(ct);
                    }
                    db.DonHangs.Remove(maDH);

                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    LoadData();
                    ClearField();
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin đon hàng này.");
            }
        }

        private void ClearField()
        {
            MaDHText.Clear();
            NgayLap.Value = DateTime.Now;
            LoaiDHText.Clear();
            MaKHText.Clear();
            MaNVText.Clear();
            MaKMText.Clear();
            CTDHDataGrid.DataSource = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
