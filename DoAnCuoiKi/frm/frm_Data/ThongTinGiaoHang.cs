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

namespace DoAnCuoiKi.frm.frm_Data
{
    public partial class ThongTinGiaoHang : Form
    {
        public string MaPhieu { get; private set; }
        public string DiaChi { get; private set; }
        public DateTime NgayLap { get; private set; }
        public DateTime NgayGiaoHang { get; private set; }
        public string TrangThaiGiaoHang { get; private set; }
        public decimal Phi { get; private set; }
        public string GhiChu { get; private set; }
        CuaHangDB db = new CuaHangDB();
        public ThongTinGiaoHang()
        {
            InitializeComponent();
        }

        private void ThongTinGiaoHang_Load(object sender, EventArgs e)
        {
            LoadMaPhieu();
        }

        private void LoadMaPhieu()  
        {
            var lastMaPhieu = db.PHIEUGIAOHANGs
                             .OrderByDescending(h => h.MaPhieu)
                             .Select(h => h.MaPhieu)
                             .FirstOrDefault();

            string newMaPhieu = "PH0001";

            if (!string.IsNullOrEmpty(lastMaPhieu))
            {
                int numberPart = int.Parse(lastMaPhieu.Substring(2));
                newMaPhieu = "PH" + (numberPart + 1).ToString("D4");
            }

            MaPhieuText.Text = newMaPhieu;
        }


            private void HoanThanhButton_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(MaPhieuText.Text)
                    || string.IsNullOrEmpty(DiaChiText.Text)
                    || string.IsNullOrEmpty(PhiText.Text)
                    || TrangThaiCombo.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }

                if (!decimal.TryParse(PhiText.Text, out decimal phi))
                {
                    MessageBox.Show("Giá trị không hợp lệ");
                    return;
                }

                if (NgayGiaoDate.Value < NgayLapDate.Value)
                {
                    MessageBox.Show("Ngày giao hàng không thể sớm hơn ngày lập");
                    return;
                }

                try
                {
                    MaPhieu = MaPhieuText.Text;
                    DiaChi = DiaChiText.Text;
                    NgayLap = NgayLapDate.Value;
                    NgayGiaoHang = NgayGiaoDate.Value;
                    TrangThaiGiaoHang = TrangThaiCombo.SelectedItem.ToString();
                    Phi = phi;
                    GhiChu = GhiChuText.Text;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

    }
}
