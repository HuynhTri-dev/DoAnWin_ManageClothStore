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
    public partial class QuanLyKhachHang : Form
    {

        CuaHangDB db = new CuaHangDB();


        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadForm();
            ClearFields();
        }

        private void LoadForm()
        {
            var KH = db.KHACHHANGs.Select(x => new {
                x.MaKH,
                HoTen = x.Ho + " " + x.TenLot,
                GioiTinh = x.GioiTinh == true ? "Nam" : "Nữ",
                x.NgaySinh,
                x.DiaChi,
                x.GhiChu
            }).ToList()
            .Select(x => new {
                x.MaKH,
                x.HoTen,
                x.GioiTinh,
                NgaySinh = x.NgaySinh.ToString("dd/MM/yyyy"),
                x.DiaChi,
                x.GhiChu
            }).ToList();

            ThongTinKHDataGirdView.DataSource = KH;

            ThongTinKHDataGirdView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearFields()
        {
            MaKhachHangTextBox.Clear();
            HoTenTextBox.Clear();
            NamRadioButton.Checked = true;
            NuRadioButton.Checked = false;
            NgaySinhDateTimePicker.Value = DateTime.Now;
            DiaChiTextBox.Clear();
            ghiChuText.Clear();
        }

        private void ThemSuaButton_Click_1(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(MaKhachHangTextBox.Text)
               && !string.IsNullOrEmpty(HoTenTextBox.Text)
               && (NamRadioButton.Checked == true || NuRadioButton.Checked == true)
               && !string.IsNullOrEmpty(NgaySinhDateTimePicker.Value.ToString()))
            {
                string fullName = HoTenTextBox.Text; // Chuỗi họ tên đầy đủ
                int firstSpaceIndex = fullName.IndexOf(' ');

                string lastName;
                string restName;

                if (firstSpaceIndex == -1)
                {
                    MessageBox.Show("Phải nhập đầu đủ họ tên!", "Thông báo");
                    return;
                }
                else
                {
                    lastName = fullName.Substring(0, firstSpaceIndex); // Họ
                    restName = fullName.Substring(firstSpaceIndex + 1); // Đệm và tên
                }

                

                KHACHHANG KH = new KHACHHANG()
                {
                    MaKH = MaKhachHangTextBox.Text,
                    Ho = lastName,
                    TenLot = restName,
                    GioiTinh = NamRadioButton.Checked,
                    NgaySinh = NgaySinhDateTimePicker.Value,
                    DiaChi = DiaChiTextBox.Text,
                    GhiChu = ghiChuText.Text
                };

                var maKH = db.KHACHHANGs.FirstOrDefault(x => x.MaKH == KH.MaKH);
                db.KHACHHANGs.AddOrUpdate(KH);
                db.SaveChanges();
                LoadForm();
                ClearFields();

                MessageBox.Show(maKH == null ? "Thêm thông tin khách hàng thành công!" : "Cập nhật thông tin khách hàng thành công!", "Thông báo");

            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin cần thiết", "Thông báo");
            }
            
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            var maKH = db.KHACHHANGs.FirstOrDefault(x => x.MaKH == MaKhachHangTextBox.Text);
            if (maKH != null)
            {
                DialogResult dlg = MessageBox.Show("Xóa thông tin khách hàng này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    db.KHACHHANGs.Remove(maKH);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công!");
                    LoadForm();
                    ClearFields();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin khách hàng này!");
            }
        }

        private void ThongTinKHDataGirdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = ThongTinKHDataGirdView.Rows[e.RowIndex];
                var maSo = row.Cells["MaKH"].Value.ToString();
                if (!string.IsNullOrEmpty(maSo))
                {
                    var thongTin = db.KHACHHANGs.FirstOrDefault(x => x.MaKH == maSo);

                    if (thongTin != null)
                    {
                        MaKhachHangTextBox.Text = thongTin.MaKH.ToString();
                        HoTenTextBox.Text = thongTin.Ho + " " + thongTin.TenLot;
                        if (thongTin.GioiTinh == true)
                        {
                            NamRadioButton.Checked = true;
                        }
                        else
                        {
                            NuRadioButton.Checked = true;
                        }
                        DiaChiTextBox.Text = thongTin.DiaChi;
                        NgaySinhDateTimePicker.Value = thongTin.NgaySinh;
                        ghiChuText.Text = thongTin.GhiChu;
                    }
                }
            }
        }

        private void HoTenTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NuRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NamRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ThongTinKHDataGirdView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void NgaySinhDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MaKhachHangTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
