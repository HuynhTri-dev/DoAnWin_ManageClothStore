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
    public partial class Mau : Form
    {

        CuaHangDB db = new CuaHangDB();


        public Mau()
        {
            InitializeComponent();
        }

        private void Mau_Load(object sender, EventArgs e)
        {
            LoadMau();
        }

        private void LoadMau()
        {
            var mau = db.MAUs.Select(x => new {x.MaMau, x.TenMau}).ToList();
            MauDataGridView.DataSource = mau;
            MauDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ThemSuaButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(MaMauTextBox.Text)
                && !string.IsNullOrEmpty(TenMauTextBox.Text))
            {

                var color = db.MAUs.Any(x => x.MaMau == MaMauTextBox.Text);
                MAU mau = new MAU()
                {
                    MaMau = MaMauTextBox.Text,
                    TenMau = TenMauTextBox.Text,
                };
                db.MAUs.AddOrUpdate(mau);
                db.SaveChanges();

                if (color == false)
                {
                    MessageBox.Show("Thêm màu thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật màu thành công!");
                    
                }

                LoadMau();
                MaMauTextBox.Text = string.Empty;
                TenMauTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin đầy đủ", "Thông báo");
            }

            
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            var color = db.MAUs.FirstOrDefault(x => x.MaMau == MaMauTextBox.Text);
            DialogResult dlg = MessageBox.Show("Xóa thông tin màu này?", "Xóa màu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (color != null)
            {
                if (dlg == DialogResult.Yes)
                {
                    var checkSanPham = db.SANPHAMs.Any(x => x.MaMau == MaMauTextBox.Text);

                    if (checkSanPham == true)
                    {
                        MessageBox.Show("Còn sản phẩm đang có màu này", "Thông báo");
                        return;
                    }

                    db.MAUs.Remove(color);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công!");
                    LoadMau();
                    MaMauTextBox.Text = string.Empty;
                    TenMauTextBox.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin màu này!");
            }
        }

        private void TroLaiButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TenMauTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MauDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MaMauTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
