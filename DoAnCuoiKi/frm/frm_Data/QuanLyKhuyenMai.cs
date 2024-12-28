using DoAnCuoiKi.model;
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

namespace DoAnCuoiKi.frm.frm_Data
{
    public partial class QuanLyKhuyenMai : Form
    {
        CuaHangDB db = new CuaHangDB();

        public QuanLyKhuyenMai()
        {
            InitializeComponent();
        }

        // Load thong tin bang
        private void QuanLyKhuyenMai_Load(object sender, EventArgs e)
        {
            ResetFields();
            LoadBang();
        }

        private void ResetFields()
        {
            maTextBox.Clear();
            tenTextBox.Clear();
            giaTriTextBox.Clear();
            batDauDatePicker.Value = DateTime.Now;
            ketThucDatePicker.Value = DateTime.Now; 
        }

        private void LoadBang()
        {
            var thongTin = db.KHUYENMAIs.Select(x => new {
                x.MaKM,
                x.TenKM,
                x.GiaTri,
                x.NgayBatDau,
                x.NgayKetThuc
            }).ToList()
            .Select(x => new {
                x.MaKM,
                x.TenKM,
                x.GiaTri,
                BatDau = x.NgayBatDau.ToString("dd/MM/yyyy"),  // Chuyển thành chuỗi sau khi truy vấn
                KetThuc = x.NgayKetThuc.HasValue ? x.NgayKetThuc.Value.ToString("dd/MM/yyyy") : ""  // Kiểm tra null và chuyển thành chuỗi
            }).ToList();
            KhuyenMaiDataGrid.DataSource = thongTin;

            //KhuyenMaiDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void themSuaButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maTextBox.Text)
                && !string.IsNullOrEmpty(tenTextBox.Text)
                && !string.IsNullOrEmpty(giaTriTextBox.Text)
                && !string.IsNullOrEmpty(batDauDatePicker.Value.ToString()))
            {
                if (!float.TryParse(giaTriTextBox.Text, out float giaTri))
                {
                    MessageBox.Show("Giá trị phải là một chữ số", "Thông báo");
                    return;
                }

                try
                {
                    KHUYENMAI km = new KHUYENMAI()
                    {
                        MaKM = maTextBox.Text,
                        TenKM = tenTextBox.Text,
                        GiaTri = giaTri,
                        NgayBatDau = batDauDatePicker.Value.Date,
                        NgayKetThuc = ketThucDatePicker.Value.Date
                    };

                    var checkMa = db.KHUYENMAIs.Where(x => x.MaKM == maTextBox.Text).FirstOrDefault();

                    MessageBox.Show(checkMa == null ? "Thêm thông tin thành công!" : "Cập nhật thông tin thành công!", "Thông báo");

                    db.KHUYENMAIs.AddOrUpdate(km);
                    db.SaveChanges();
                    LoadBang();
                    ResetFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Thông tin chưa được nhập đầy đủ", "Thông báo");
            }
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {
            var ma = db.KHUYENMAIs.FirstOrDefault(x => x.MaKM == maTextBox.Text);
            if (ma != null)
            {
                var checkDonHang = db.DonHangs.FirstOrDefault(x => x.MaKM == maTextBox.Text);
                if (checkDonHang != null)
                {
                    MessageBox.Show("Còn đơn hàng đang chứa mã này.");
                }

                DialogResult dlg = MessageBox.Show("Xóa thông tin khuyến mãi này?", "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    db.KHUYENMAIs.Remove(ma);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công!");
                    LoadBang();
                    ResetFields();
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin khuyến mãi này.");
            }
        }

        private void KhuyenMaiDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = KhuyenMaiDataGrid.Rows[e.RowIndex];
                var maSo = row.Cells["MaKM"].Value.ToString();
                if (!string.IsNullOrEmpty(maSo))
                {
                    var thongTin = db.KHUYENMAIs.FirstOrDefault(x => x.MaKM == maSo);

                    if (thongTin != null)
                    {
                        maTextBox.Text = thongTin.MaKM.ToString();
                        tenTextBox.Text = thongTin.TenKM;
                        giaTriTextBox.Text = thongTin.GiaTri.ToString();
                        batDauDatePicker.Value = thongTin.NgayBatDau;
                        ketThucDatePicker.Value = thongTin.NgayKetThuc.HasValue ? thongTin.NgayKetThuc.Value : DateTime.Now; ;
                    }
                }
            }
        }
    }
}
