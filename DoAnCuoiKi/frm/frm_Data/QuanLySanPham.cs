using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKi.model;

namespace DoAnCuoiKi
{
    public partial class QuanLySanPham : Form
    {

        CuaHangDB db = new CuaHangDB();
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            ThuongHieuComboBox();
            NhaCungCapBox();
            LoaiSanPhamComboBox();
            MauBox();
            ChatLieuBox();
            LoadForm();
        }

        private void ThuongHieuComboBox()
        {
            var list = db.THUONGHIEUx.Select(x => x.MaTH).ToList();
            foreach (var item in list)
            {
                NhanHieuComboBox.Items.Add(item);
            }
        }

        private void LoaiSanPhamComboBox()
        {
            var list = db.DANHMUCs.Select(x => x.MaDM).ToList();
            foreach (var item in list) 
                {
                    LoaiSPComboBox.Items.Add(item);
                }
        }

        private void MauBox()
        {
            var list = db.MAUs.Select(x => x.MaMau).ToList();
            foreach(var item in list)
            {
                MauComboBox.Items.Add(item);
            }
        }

        private void NhaCungCapBox()
        {
            var list = db.NHACUNGCAPs.Select(x => x.MaNCC).ToList();
            foreach( var item in list)
            {
                MaNCCComboBox.Items.Add(item);
            }
        }

        private void ChatLieuBox()
        {
            var list = db.CHATLIEUx.Select(x => x.MaCL).ToList();
            foreach ( var item in list)
            {
                MaChatLieuComboBox.Items.Add(item);
            }
        }
        private void LoadForm()
        {
            var sp = db.SANPHAMs.Select(x => new { x.MaSP, x.TenSP, NhanHieu = x.THUONGHIEU.TenTH, LoaiSanPham = x.DANHMUC.TenDM, x.Size, Mau = x.MAU.TenMau, NhaCungCap = x.NHACUNGCAP.TenNCC, ChatLieu = x.CHATLIEU.TenCL, x.MoTa }).ToList();
            SanPhamDataGridView.DataSource = sp;

        }

        private void ThemSuaButton_Click(object sender, EventArgs e)
        {
            
            var sp = db.SANPHAMs.Any(x => x.MaSP == MaSPTextBox.Text);
            SANPHAM sANPHAM = new SANPHAM()
            {
                MaSP = MaSPTextBox.Text,
                TenSP = TenSPTextBox.Text,
                SoLuongTon = int.Parse(SLTonTextBox.Text),
                Size = KichCoComboBox.Text,
                GiaNhap = decimal.Parse(GiaNhapTextBox.Text),
                GiaBan = decimal.Parse(GiaBanTextBox.Text),
                MoTa = MoTaRichTextBox.Text,
                MaDM = LoaiSPComboBox.SelectedItem.ToString(),
                MaNCC = MaNCCComboBox.SelectedItem.ToString(),
                MaMau = MauComboBox.SelectedItem.ToString(),
                MaCL = MaChatLieuComboBox.SelectedItem.ToString(),
                MaTH = NhanHieuComboBox.SelectedItem.ToString()
            };
                
            if (!sp)
            {
                db.SANPHAMs.AddOrUpdate(sANPHAM);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công sản phẩm!");

            }
            else
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công!");
            }
            LoadForm();
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            var sp = db.SANPHAMs.FirstOrDefault(x => x.MaSP == MaSPTextBox.Text);
            if (sp != null)
            {
                DialogResult dlg = MessageBox.Show("Xóa thông tin sản phẩm này?", "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    db.SANPHAMs.Remove(sp);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công!");
                    LoadForm();
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin sản phẩm.");
            }    
        }

        private void QuayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaSPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MauComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoaiSPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NhanHieuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
