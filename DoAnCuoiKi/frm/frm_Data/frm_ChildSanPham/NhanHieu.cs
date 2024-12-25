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
    public partial class NhanHieu : Form
    {

        CuaHangDB db = new CuaHangDB();
        public NhanHieu()
        {
            InitializeComponent();
        }

        private void NhanHieu_Load(object sender, EventArgs e)
        {
            LoadTH();
        }

        private void LoadTH()
        {
            var th = db.THUONGHIEUx.Select(x => new { x.MaTH, x.TenTH}).ToList();
            NhanHieuDataGirdView.DataSource = th;
            NhanHieuDataGirdView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ThemSuaButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MaTHTextBox.Text)
                && !string.IsNullOrEmpty(TenTHTextBox.Text))
            {
                var brand = db.THUONGHIEUx.Any(x => x.MaTH == MaTHTextBox.Text);
                THUONGHIEU th = new THUONGHIEU()
                {
                    MaTH = MaTHTextBox.Text,
                    TenTH = TenTHTextBox.Text
                };
                if (!brand)
                {
                    if (string.IsNullOrWhiteSpace(MaTHTextBox.Text) || string.IsNullOrWhiteSpace(TenTHTextBox.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    }
                    else
                    {
                        db.THUONGHIEUx.AddOrUpdate(th);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thương hiệu thành công!");
                        MaTHTextBox.Text = string.Empty;
                        TenTHTextBox.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật thương hiệu thành công!");
                    MaTHTextBox.Text = string.Empty;
                    TenTHTextBox.Text = string.Empty;
                }
                LoadTH();
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin đầy đủ", "Thông báo");
            }
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            var th = db.THUONGHIEUx.FirstOrDefault(x => x.MaTH == MaTHTextBox.Text);
            DialogResult dlg = MessageBox.Show("Xóa thông tin thương hiệu này?", "Xóa thương hiệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (th != null)
            {
                if (dlg == DialogResult.Yes)
                {
                    db.THUONGHIEUx.Remove(th);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công!");
                    LoadTH();
                    MaTHTextBox.Text = string.Empty;
                    TenTHTextBox.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin thương hiệu này!");
            }
        }

        private void TroLaiButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
