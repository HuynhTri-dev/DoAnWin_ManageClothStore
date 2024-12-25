using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKi.model;

namespace DoAnCuoiKi
{
    public partial class NhaCungCap : Form
    {
        CuaHangDB db = new CuaHangDB();


        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadNCC();
        }

        private void LoadNCC()
        {
            var ncc = db.NHACUNGCAPs.Select(x => new {x.MaNCC, x.TenNCC}).ToList();
            NhaCungCapDataGirdView.DataSource = ncc;
            NhaCungCapDataGirdView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ThemSuaButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MaNCCTextBox.Text) 
                && !string.IsNullOrEmpty(TenNCCTextBox.Text) 
                && !string.IsNullOrEmpty(DiaChiTextBox.Text) 
                && !string.IsNullOrEmpty(SDTTextBox.Text)
                && !string.IsNullOrEmpty(EmailTextBox.Text))
            {
                var source = db.NHACUNGCAPs.Any(x => x.MaNCC == MaNCCTextBox.Text);
                NHACUNGCAP ncc = new NHACUNGCAP()
                {
                    MaNCC = MaNCCTextBox.Text,
                    TenNCC = TenNCCTextBox.Text,
                    DiaChi = DiaChiTextBox.Text,
                    SDT = SDTTextBox.Text,
                    Email = EmailTextBox.Text,
                };
                if (!source)
                {
                    if (string.IsNullOrWhiteSpace(MaNCCTextBox.Text) || string.IsNullOrWhiteSpace(TenNCCTextBox.Text) || string.IsNullOrWhiteSpace(DiaChiTextBox.Text) || string.IsNullOrWhiteSpace(SDTTextBox.Text) || string.IsNullOrWhiteSpace(EmailTextBox.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    }
                    else
                    {
                        db.NHACUNGCAPs.AddOrUpdate(ncc);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công nhà cung cấp!");
                        MaNCCTextBox.Text = string.Empty;
                        TenNCCTextBox.Text = string.Empty;
                        DiaChiTextBox.Text = string.Empty;
                        SDTTextBox.Text = string.Empty;
                        EmailTextBox.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật nhà cung cấp thành công!");
                    MaNCCTextBox.Text = string.Empty;
                    TenNCCTextBox.Text = string.Empty;
                    DiaChiTextBox.Text = string.Empty;
                    SDTTextBox.Text = string.Empty;
                    EmailTextBox.Text = string.Empty;
                }
                LoadNCC();
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin đầy đủ", "Thông báo");
            }
            
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            var ncc = db.NHACUNGCAPs.FirstOrDefault(x => x.MaNCC == MaNCCTextBox.Text);
            DialogResult dlg = MessageBox.Show("Xóa thông tin nhà cung cấp này?", "Xóa nhà cung cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ncc != null)
            {
                if (dlg == DialogResult.Yes)
                {
                    db.NHACUNGCAPs.Remove(ncc);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công!");
                    LoadNCC();
                    MaNCCTextBox.Text = string.Empty;
                    TenNCCTextBox.Text = string.Empty;
                    DiaChiTextBox.Text = string.Empty;
                    SDTTextBox.Text = string.Empty;
                    EmailTextBox.Text = string.Empty;
                }    
            }
            else
            {
                MessageBox.Show("Không có thông tin nhà cung cấp này!");
            }    
        }

        private void TroLaiButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void NhaCungCapDataGirdView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = NhaCungCapDataGirdView.Rows[e.RowIndex];
                var maSo = row.Cells["MaNCC"].Value.ToString();
                if (!string.IsNullOrEmpty(maSo))
                {
                    var thongTin = db.NHACUNGCAPs.FirstOrDefault(x => x.MaNCC == maSo);

                    if (thongTin != null)
                    {
                        MaNCCTextBox.Text = thongTin.MaNCC;
                        TenNCCTextBox.Text = thongTin.TenNCC;
                        DiaChiTextBox.Text = thongTin.DiaChi.ToString();
                        SDTTextBox.Text = thongTin.SDT;
                        EmailTextBox.Text = thongTin.Email;
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
