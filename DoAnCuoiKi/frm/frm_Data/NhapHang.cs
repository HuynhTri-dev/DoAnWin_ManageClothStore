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
    public partial class NhapHang : Form
    {
        string MASP;
        CuaHangDB db = new CuaHangDB();
        public NhapHang(string MaSP)
        {
            InitializeComponent();
            MASP = MaSP;
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MASP))
            {
                MaSPText.Text = MASP;
                var sp = db.SANPHAMs.Where(x => x.MaSP == MASP).Select(x => new {x.TenSP, x.NHACUNGCAP.TenNCC }).FirstOrDefault();
                TenSPText.Text = sp.TenSP;
                TenNCCText.Text = sp.TenNCC;
            }
        }

        private void NhapHangButton_Click(object sender, EventArgs e)
        {
            // kiểm tra số lượng nhập có hợp lệ không
            if (string.IsNullOrEmpty(MaSPText.Text)
                || string.IsNullOrEmpty(SoLuongNhapText.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thôgn tin!");
                return;
            }

            if (!int.TryParse(SoLuongNhapText.Text, out int soLuongNhap))
            {
                MessageBox.Show("Số lượng nhập không hợp lệ!");
                return;
            }

            try
            {
                var sp = db.SANPHAMs.Where(x => x.MaSP == MASP).FirstOrDefault();
                sp.SoLuongTon += soLuongNhap;
                db.SaveChanges();
                MessageBox.Show("Nhập hàng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập hàng thất bại!");
            }
        }

        private void DongButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
