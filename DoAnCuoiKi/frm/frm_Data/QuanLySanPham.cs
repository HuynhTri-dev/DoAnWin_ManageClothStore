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
using static QRCoder.PayloadGenerator.SwissQrCode;

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
            ClearFields();
            ThuongHieuComboBox();
            NhaCungCapBox();
            LoaiSanPhamComboBox();
            MauBox();
            ChatLieuBox();
            LoadForm();
        }

        private void ClearFields()
        {
            MaSPTextBox.Clear();
            TenSPTextBox.Clear();
            SLTonTextBox.Text = "0";
            KichCoComboBox.SelectedIndex = -1;
            MauComboBox.SelectedIndex = -1;
            LoaiSPComboBox.SelectedIndex = -1;
            MaNCCComboBox.SelectedIndex = -1;
            MaChatLieuComboBox.SelectedIndex = -1;
            NhanHieuComboBox.SelectedIndex = -1;
            GiaNhapTextBox.Text = "0";
            GiaBanTextBox.Text = "0";
            anhSPPictureBox.Image = null;
            chonAnhLabel.Visible = true;
        }

        private void ThuongHieuComboBox()
        {
            NhanHieuComboBox.Items.Clear();
            var list = db.THUONGHIEUx.Select(x => x.TenTH).ToList();
            foreach (var item in list)
            {
                NhanHieuComboBox.Items.Add(item);
            }
        }

        private void LoaiSanPhamComboBox()
        {
            LoaiSPComboBox.Items.Clear();
            var list = db.DANHMUCs.Select(x => x.TenDM).ToList();
            foreach (var item in list) 
                {
                    LoaiSPComboBox.Items.Add(item);
                }
        }

        private void MauBox()
        {
            MauComboBox.Items.Clear();
            var list = db.MAUs.Select(x => x.TenMau).ToList();
            foreach(var item in list)
            {
                MauComboBox.Items.Add(item);
            }
        }

        private void NhaCungCapBox()
        {
            MaNCCComboBox.Items.Clear();
            var list = db.NHACUNGCAPs.Select(x => x.TenNCC).ToList();
            foreach( var item in list)
            {
                MaNCCComboBox.Items.Add(item);
            }
        }

        private void ChatLieuBox()
        {
            MaChatLieuComboBox.Items.Clear();
            var list = db.CHATLIEUx.Select(x => x.TenCL).ToList();
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

        private void anhSPPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                chonAnhLabel.Visible = false;
                anhSPPictureBox.Image = Image.FromFile(ofd.FileName);
                this.Text = ofd.FileName;
            }
        }
        byte[] ImageToBytes(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        private void ThemSuaButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaSPTextBox.Text)
                || string.IsNullOrEmpty(TenSPTextBox.Text)
                || string.IsNullOrEmpty(SLTonTextBox.Text)
                || LoaiSPComboBox.SelectedItem == null
                || KichCoComboBox.SelectedItem == null
                || MaNCCComboBox.SelectedItem == null
                || MauComboBox.SelectedItem == null
                || MaChatLieuComboBox.SelectedItem == null
                || NhanHieuComboBox.SelectedItem == null)
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin sản phẩm", "Thông báo");
                return;
            }

                if (!decimal.TryParse(GiaNhapTextBox.Text, out decimal giaNhap) || giaNhap < 0)
                {
                    MessageBox.Show("Giá nhập không hợp lệ", "Thông báo");
                    return;
                }

                if (!decimal.TryParse(GiaBanTextBox.Text, out decimal giaBan) || giaBan < 0)
                {
                    MessageBox.Show("Giá bán không hợp lệ", "Thông báo");
                    return;
                }

                
            

            try
            {
                var sp = db.SANPHAMs.Any(x => x.MaSP == MaSPTextBox.Text);
                byte[] b = ImageToBytes(anhSPPictureBox.Image);
                var maDM = db.DANHMUCs.Where(x => x.TenDM == LoaiSPComboBox.SelectedItem.ToString()).Select(x => x.MaDM).FirstOrDefault();
                var maNCC = db.NHACUNGCAPs.Where(x => x.TenNCC == MaNCCComboBox.SelectedItem.ToString()).Select(x => x.MaNCC).FirstOrDefault();
                var maMau = db.MAUs.Where(x => x.TenMau == MauComboBox.SelectedItem.ToString()).Select(x => x.MaMau).FirstOrDefault();
                var maCL = db.CHATLIEUx.Where(x => x.TenCL == MaChatLieuComboBox.SelectedItem.ToString()).Select(x => x.MaCL).FirstOrDefault();
                var maTH = db.THUONGHIEUx.Where(x => x.TenTH == NhanHieuComboBox.SelectedItem.ToString()).Select(x => x.MaTH).FirstOrDefault();
                SANPHAM sanPham = new SANPHAM()
                {
                    MaSP = MaSPTextBox.Text,
                    TenSP = TenSPTextBox.Text,
                    AnhSP = b,
                    SoLuongTon = int.Parse(SLTonTextBox.Text),
                    Size = KichCoComboBox.SelectedItem.ToString(),
                    GiaNhap = giaNhap,
                    GiaBan = giaBan,
                    MoTa = MoTaRichTextBox.Text,
                    MaDM = maDM,
                    MaNCC = maNCC,
                    MaMau = maMau,
                    MaCL = maCL,
                    MaTH = maTH
                };

                db.SANPHAMs.AddOrUpdate(sanPham);
                db.SaveChanges();

                if (!sp)
                {
                    MessageBox.Show("Thêm thành công sản phẩm!", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thông báo");
                }
                LoadForm();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
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
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin sản phẩm.");
            }    
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

        


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(SLTonTextBox.Text, out int sl))
            {
                if (sl >= 0)
                {
                    sl = sl - 1;
                    SLTonTextBox.Text = sl.ToString();  
                }
            }
        }

        private void SLTonTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(SLTonTextBox.Text, out int sl) || string.IsNullOrEmpty(SLTonTextBox.Text) || sl < 0)
            {
                ErrorLabel.Text = "Giá trị nhập không hợp lệ. \nVui lòng nhập số nguyên và >= 0!";
                ErrorLabel.ForeColor = Color.Red; 
            }
            else
            {
                ErrorLabel.Text = ""; 
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(SLTonTextBox.Text, out int sl))
            {
                if (sl >= 0)
                {
                    sl = sl + 1;
                    SLTonTextBox.Text = sl.ToString();
                }
            }
        }

        private void GiaNhapTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void GiaBanTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void SanPhamDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = SanPhamDataGridView.Rows[e.RowIndex];
                var maSo = row.Cells["MaSP"].Value.ToString();
                if (!string.IsNullOrEmpty(maSo))
                {
                    var thongTin = db.SANPHAMs.FirstOrDefault(x => x.MaSP == maSo);

                    if (thongTin != null)
                    {
                        MaSPTextBox.Text = thongTin.MaSP;
                        TenSPTextBox.Text = thongTin.TenSP;
                        SLTonTextBox.Text = thongTin.SoLuongTon.ToString();
                        KichCoComboBox.SelectedItem = thongTin.Size;

                        if (thongTin.AnhSP != null)
                        {
                            using (MemoryStream ms = new MemoryStream(thongTin.AnhSP))
                            {
                                Image img = Image.FromStream(ms);
                                anhSPPictureBox.Image = img;
                                anhSPPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                chonAnhLabel.Visible = false;
                            }
                        }
                        else
                        {
                            anhSPPictureBox.Image = null;
                            chonAnhLabel.Visible = true;
                        }

                        MauComboBox.SelectedItem = thongTin.MAU.TenMau;
                        LoaiSPComboBox.SelectedItem = thongTin.DANHMUC.TenDM;
                        MaNCCComboBox.SelectedItem = thongTin.NHACUNGCAP.TenNCC;
                        MaChatLieuComboBox.SelectedItem = thongTin.CHATLIEU.TenCL;
                        NhanHieuComboBox.SelectedItem = thongTin.THUONGHIEU.TenTH;
                        GiaBanTextBox.Text = thongTin.GiaBan.ToString();
                        GiaNhapTextBox.Text = thongTin.GiaNhap.ToString();
                        MoTaRichTextBox.Text = thongTin.MoTa;
                    }
                }
            }
        }

        private void chonAnhLabel_Click(object sender, EventArgs e)
        {

        }

        private void OpenMauButton_Click(object sender, EventArgs e)
        {
            Mau mau = new Mau();
            DialogResult dr = mau.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                MauBox();
            }
        }

        private void OpenLoaiButton_Click(object sender, EventArgs e)
        {
            LoaiSanPham loaiSanPham = new LoaiSanPham();
            DialogResult dr = loaiSanPham.ShowDialog();
            if(dr == DialogResult.Cancel)
            {
                LoaiSanPhamComboBox();
            }
        }

        private void OpenNCCButton_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            DialogResult dr = ncc.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                NhaCungCapBox();
            }
        }

        private void OpenCLButton_Click(object sender, EventArgs e)
        {
            ChatLieu cl = new ChatLieu();
            DialogResult dr = cl.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                ChatLieuBox();
            }
        }

        private void OpenNHButton_Click(object sender, EventArgs e)
        {
            NhanHieu nh = new NhanHieu();
            DialogResult dr = nh.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                ThuongHieuComboBox();
            }
        }
    }
}
