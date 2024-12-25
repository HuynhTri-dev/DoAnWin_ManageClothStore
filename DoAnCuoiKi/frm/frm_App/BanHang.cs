using DoAnCuoiKi.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class BanHang : Form
    {
        // Kết nối database
        CuaHangDB db = new CuaHangDB();

        // Tạo list giỏi hàng
        public class Hang
        {
            public string MaSP { get; set; }
            public string TenSP { get; set; }
            public int SoLuong { get; set; }
            public decimal ThanhTien { get; set; }

            public Hang(string ma, string ten, int sl, decimal tt)
            {
                MaSP = ma;
                TenSP = ten;
                SoLuong = sl;
                ThanhTien = tt;
            }
        }

        private List<Hang> gioHangs = new List<Hang>();

        // Định danh nhân viên
        private string MANV;
        public BanHang(string MaNV)
        {
            MANV = MaNV;
            InitializeComponent();
        }
        // Load Page
        private void BanHang_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MANV))
            {
                MaNVTextBox.Text = MANV;
            }
            LoadComboKhuyenMai();
            GiaTriTextBox.Text = "0";
            LoadMaHoaDon();
            LoadGioHang();
            LoadProducts(); 

            // Group
            TongTienTextBox.Text = "0";
            GiamTextBox.Text = "0";
            PhaiThuTextBox.Text = "0";
            KhachDuaTextBox.Text = "0";
            TienThoiTextBox.Text = "0";
        }

        // Hiển thị collection combo khuyến mãi
        private void LoadComboKhuyenMai()
        {
            var khuyenMais = db.KHUYENMAIs.Select(x => x.TenKM).ToList();

            foreach(var km in khuyenMais)
            {
                MaKMComboBox.Items.Add(km);
            }
        }
        // Cập nhật giá trị từng khuyến mãi
        private void MaKMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var giaTri = db.KHUYENMAIs.Where(x => x.TenKM == MaKMComboBox.SelectedItem.ToString()).Select(x => x.GiaTri).FirstOrDefault();

            GiaTriTextBox.Text = giaTri.ToString();
            LoadGia();
        }
        //Load mã hoá đơn
        private void LoadMaHoaDon()
        {
            var lastMaHD = db.DonHangs  
                             .OrderByDescending(h => h.MaDH) 
                             .Select(h => h.MaDH)          
                             .FirstOrDefault();             

            string newMaHD = "DH0001";

            if (!string.IsNullOrEmpty(lastMaHD))
            {
                int numberPart = int.Parse(lastMaHD.Substring(2));
                newMaHD = "DH" + (numberPart + 1).ToString("D4"); 
            }

            MaDHTextBox.Text = newMaHD;
        }
        // Load bảng datagrid giỏ hàng
        private void LoadGioHang()
        {
            DonHangDataGrid.DataSource = gioHangs.ToList();
            LoadGia();
        }


        private void LoadGia()
        {
            // Mỗi lần mà load lại thì phải cập nhật laị giá trị của group Giá Tiền
            decimal tongTien = 0;
            foreach (var x in gioHangs)
            {
                tongTien += x.ThanhTien;
            }

            TongTienTextBox.Text = tongTien.ToString();

            decimal giamGia = 0;
            if (float.TryParse(GiaTriTextBox.Text, out float giam))
            {
                giamGia = tongTien * (decimal)(giam / 100);
                GiamTextBox.Text = giamGia.ToString("0.##");
            }

            PhaiThuTextBox.Text = (tongTien - giamGia).ToString("0.##");
        }

        private void LoadProducts()
        {
            // Lấy danh sách sản phẩm từ cơ sở dữ liệu
            var products = db.SANPHAMs.Select(p => new
            {
                p.MaSP,
                p.TenSP,
                p.GiaBan,
                p.AnhSP,
                p.Size,
                p.MAU.TenMau,
                p.THUONGHIEU.TenTH,
                p.CHATLIEU.TenCL,
                p.DANHMUC.TenDM,
                p.NHACUNGCAP.TenNCC,
                p.SoLuongTon
            }).ToList();

            // Dọn dẹp FlowLayoutPanel
            flowLayoutPanel1.Controls.Clear();

            foreach (var product in products)
            {
                

                // Tạo Panel cho mỗi sản phẩm
                Panel productPanel = new Panel
                {
                    Size = new Size(200, 260),
                    BorderStyle = BorderStyle.Fixed3D,
                    Margin = new Padding(0, 0, 50, 50)
                };

                // Tạo PictureBox để hiển thị ảnh sản phẩm
                PictureBox productImage = new PictureBox
                {
                    Size = new Size(180, 150),
                    Location = new Point(10, 10),
                    Image = product.AnhSP != null ? ByteArrayToImage(product.AnhSP) : null,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                // Tạo Label để hiển thị tên sản phẩm
                Label productName = new Label
                {
                    Text = product.TenSP,
                    Location = new Point(10, 170),
                    AutoSize = true
                };

                Label soLuong = new Label
                {
                    Text = $"Số lượng: {product.SoLuongTon}",
                    Location = new Point(10, 190),
                    AutoSize = true
                };

                // Tạo Label để hiển thị giá sản phẩm
                Label productPrice = new Label
                {
                    Text = $"Giá: {product.GiaBan:#,##0} VND",
                    Location = new Point(10, 210),
                    AutoSize = true,
                    ForeColor = Color.Green
                };

                // Tạo nút thêm thông tin chi tiết
                Button moreInfo = new Button
                {
                    Text = "Thông tin chi tiết",
                    AutoSize = true,
                    Location = new Point(50, 230),
                    BackColor = Color.White
                };

                //Thêm các chức năng của các label và img, button
                moreInfo.Click += (s,e) => ShowProductDetails(product.MaSP);
                productImage.Click += (s, e) => ThemVaoGioHang(product.MaSP, product.TenSP, product.GiaBan);
                productName.Click += (s, e) => ThemVaoGioHang(product.MaSP, product.TenSP, product.GiaBan);
                soLuong.Click += (s, e) => ThemVaoGioHang(product.MaSP, product.TenSP, product.GiaBan);
                productPrice.Click += (s, e) => ThemVaoGioHang(product.MaSP, product.TenSP, product.GiaBan);

                // Thêm các control vào Panel
                productPanel.Controls.Add(productImage);
                productPanel.Controls.Add(productName);
                productPanel.Controls.Add(soLuong);
                productPanel.Controls.Add(productPrice);
                productPanel.Controls.Add(moreInfo);

                // Neu san pham het
                if (product.SoLuongTon <= 0)
                {
                    Label soldOut = new Label()
                    {
                        Size = new Size(200, 50),
                       
                        BackColor = Color.Red,
                        Text = "Sold Out",
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Tahoma", 16, FontStyle.Bold),
                        Location = new Point(0, 75),
                    };


                    productPanel.Controls.Add(soldOut);
                    soldOut.BringToFront();
                    productPanel.Enabled = false;
                }

                productPanel.Enabled = true;

                productPanel.Click += (s, e) => ThemVaoGioHang(product.MaSP, product.TenSP, product.GiaBan);


                // Thêm Panel vào FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(productPanel);
            }
        }
        // Chức năng thêm hàng vào giỏ
        private void ThemVaoGioHang(string MaSP, string TenSP, decimal GiaBan)
        {
            var sanPham = gioHangs.FirstOrDefault(h => h.MaSP == MaSP);

            if (sanPham != null)
            {
                sanPham.SoLuong++;
                sanPham.ThanhTien = sanPham.SoLuong * GiaBan;
            }
            else
            {
                MessageBox.Show($"Thêm sản phẩm: {TenSP}", "Thông báo");
                gioHangs.Add(new Hang(MaSP, TenSP, 1, GiaBan));
            }

            LoadGioHang();
        }
        // Đổi ảnh sang dạng nhị phân
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
        // Chức năng hiển thị thông tin sản phẩm
        private void ShowProductDetails(string productId)
        {
            var product = db.SANPHAMs.FirstOrDefault(p => p.MaSP == productId);
            if (product != null)
            {
                MessageBox.Show(
                    $"Mã sản phẩm: {product.MaSP}\n" +
                    $"Tên sản phẩm: {product.TenSP}\n" +
                    $"Giá bán: {product.GiaBan:#,##0} VND\n" +
                    $"Danh mục: {product.DANHMUC.TenDM}\n" +
                    $"Số lượng tồn: {product.SoLuongTon}\n" +
                    $"Size: {product.Size}\n" +
                    $"Màu: {product.MAU.TenMau}\n" +
                    $"Chất liệu: {product.CHATLIEU.TenCL}\n" +
                    $"Thương hiệu: {product.THUONGHIEU.TenTH}\n" +
                    $"Nhà cung cấp: {product.NHACUNGCAP.TenNCC}\n" +
                    $"Mô tả: {product.MoTa}",
                    "Thông tin sản phẩm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        // Đổi giá trị thối mỗi khi khách đưa tiền
        private void KhachDuaTextBox_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(KhachDuaTextBox.Text, out decimal khachDua)
                && khachDua >= 0
                && decimal.TryParse(PhaiThuTextBox.Text, out decimal phaiThu))
            {
                if (khachDua >= phaiThu)
                {
                    TienThoiTextBox.Text = (khachDua - phaiThu).ToString();
                }
                else
                {
                    TienThoiTextBox.Text = "0";
                    MessageBox.Show("Khách đưa chưa đủ", "Thông báo");  
                }
            }
            else
            {
                
                MessageBox.Show("Giá trị không đúng", "Thông báo");
            }
        }

        private void ThanhToanButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaKHTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void KhachDuaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
