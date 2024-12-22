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

namespace DoAnCuoiKi.frm
{
    public partial class DangKyTaiKhoan : Form
    {
        CuaHangDB db = new CuaHangDB();

        public string DataToReturn { get; set; }

        public DangKyTaiKhoan(string maTk)
        {
            InitializeComponent();
            LoadTaiKhoan(maTk);
        }

        private void DangKyTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void LoadTaiKhoan(string maTK)
        {
            if(!string.IsNullOrEmpty(maTK))
            {
                var tk = db.TAIKHOANs.FirstOrDefault(x => x.MaTK == maTK);

                maTKText.Text = tk.MaTK;
                tenDangNhapTextBox.Text = tk.TenTK;
                matKhauTextBox.Text = tk.MatKhau;
            }
        }

        private void addUpdateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maTKText.Text) || !string.IsNullOrEmpty(tenDangNhapTextBox.Text) || !string.IsNullOrEmpty(matKhauTextBox.Text))
            {
                if (maTKText.Text.Length > 6)
                {
                    MessageBox.Show("Mã chữ có tối đa 6 ký tự", "Thông báo");
                    return;
                }

                TAIKHOAN tk = new TAIKHOAN()
                {
                    MaTK = maTKText.Text,
                    TenTK = tenDangNhapTextBox.Text,
                    MatKhau = matKhauTextBox.Text,
                };

                db.TAIKHOANs.AddOrUpdate(tk);
                db.SaveChanges();

                var maNV = db.NHANVIENs.FirstOrDefault(x => x.MaNV == maTKText.Text);
                if (maNV == null)
                {
                    MessageBox.Show("Thêm thông tin thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thành công!");
                }

                DataToReturn = maTKText.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin","Thông ");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var tk = db.TAIKHOANs.FirstOrDefault(x => x.MaTK == maTKText.Text);
            if (tk != null)
            {
                var phuThuoc = db.NHANVIENs.FirstOrDefault(x => x.MaTK == maTKText.Text);
                if (phuThuoc != null)
                {
                    MessageBox.Show("Nhân viên này còn hoạt động!", "Thông báo");
                    return;
                }

                DialogResult dlg = MessageBox.Show("Xóa thông tin nhân viên này?", "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    db.TAIKHOANs.Remove(tk);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin nhân viên này.");
            }
        }
    }
}
