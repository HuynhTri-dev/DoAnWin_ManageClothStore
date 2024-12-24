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
    public partial class LoaiSanPham : Form
    {

        CuaHangDB db = new CuaHangDB();


        public LoaiSanPham()
        {
            InitializeComponent();
        }

        private void LoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadLSP();
        }

        private void LoadLSP()
        {
            var sp = db.DANHMUCs.Select(x => new {x.MaDM, x.TenDM}).ToList();
            LoaiSanPhamDataGirdView.DataSource = sp;
        }

        private void ThemSuaButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MaDMTextBox.Text)
                && !string.IsNullOrEmpty(TenDMTextBox.Text))
            {
                var sp = db.DANHMUCs.Any(x => x.MaDM == MaDMTextBox.Text);
                DANHMUC dm = new DANHMUC()
                {
                    MaDM = MaDMTextBox.Text,
                    TenDM = TenDMTextBox.Text
                };
                if (!sp)
                {
                    if (string.IsNullOrWhiteSpace(MaDMTextBox.Text) || string.IsNullOrWhiteSpace(TenDMTextBox.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi");
                    }
                    else
                    {
                        db.DANHMUCs.AddOrUpdate(dm);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công danh mục!");
                        MaDMTextBox.Text = string.Empty;
                        TenDMTextBox.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật danh mục thành công!");
                    MaDMTextBox.Text = string.Empty;
                    TenDMTextBox.Text = string.Empty;
                }
                LoadLSP();
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin đầy đủ", "Thông báo");
            }
            
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            var dm = db.DANHMUCs.FirstOrDefault(x => x.MaDM == MaDMTextBox.Text);
            DialogResult dlg = MessageBox.Show("Xóa thông tin danh mục này?", "Xóa danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dm != null)
            {
                if (dlg == DialogResult.Yes)
                {
                    db.DANHMUCs.Remove(dm);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công!");
                    LoadLSP();
                    MaDMTextBox.Text = string.Empty;
                    TenDMTextBox.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Không có danh mục này!");
            }
        }

        private void TroLaiButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
