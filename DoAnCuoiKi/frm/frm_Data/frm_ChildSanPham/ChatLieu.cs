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
    public partial class ChatLieu : Form
    {

        CuaHangDB db = new CuaHangDB();

        public ChatLieu()
        {
            InitializeComponent();
        }

        private void ChatLieu_Load(object sender, EventArgs e)
        {
            LoadCL();
        }

        private void LoadCL()
        {
            var cl = db.CHATLIEUx.Select(x => new {x.MaCL, x.TenCL}).ToList();
            ChatLieuDataGridView.DataSource = cl;
            ChatLieuDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ThemSuaButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MaCLTextBox.Text)
                && !string.IsNullOrEmpty(TenCLTextBox.Text))
            {
                var chat = db.CHATLIEUx.Any(x => x.MaCL == MaCLTextBox.Text);
                CHATLIEU cl = new CHATLIEU()
                {
                    MaCL = MaCLTextBox.Text,
                    TenCL = TenCLTextBox.Text
                };

                db.CHATLIEUx.AddOrUpdate(cl);
                db.SaveChanges();
                
                

                if (!chat)
                {
                    MessageBox.Show("Thêm chất liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật chất liệu thành công!");
                }
                LoadCL();
                MaCLTextBox.Text = string.Empty;
                TenCLTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin đầy đủ", "Thông báo");
            }
            
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            var cl = db.CHATLIEUx.FirstOrDefault(x => x.MaCL == MaCLTextBox.Text);
            DialogResult dlg = MessageBox.Show("Xóa thông tin chất liệu này?", "Xóa chất liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cl != null)
            {
                if (dlg == DialogResult.Yes)
                {
                    var checkSanPham = db.SANPHAMs.Any(x => x.MaCL == MaCLTextBox.Text);

                    if (checkSanPham == true)
                    {
                        MessageBox.Show("Còn sản phẩm có chất liệu này", "Thông báo");
                        return;
                    }

                    db.CHATLIEUx.Remove(cl);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công!");
                    LoadCL();
                    MaCLTextBox.Text = string.Empty;
                    TenCLTextBox.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin sản phẩm này!");
            }    
        }

        private void TroLaiButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
