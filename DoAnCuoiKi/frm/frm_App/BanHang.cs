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

        private void BanHang_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MANV))
            {
                MaNVTextBox.Text = MANV;
            }

            LoadMaHoaDon();
            LoadGioHang();
            LoadProducts(); 
        }

        private void LoadMaHoaDon()
        {
            // Lấy mã hóa đơn cuối cùng từ cơ sở dữ liệu
            var lastMaHD = db.DonHangs  
                             .OrderByDescending(h => h.MaDH) // Sắp xếp giảm dần theo MaHD
                             .Select(h => h.MaDH)           // Chỉ lấy trường MaHD
                             .FirstOrDefault();             // Lấy giá trị đầu tiên (lớn nhất)

            // Nếu không có hóa đơn nào trong cơ sở dữ liệu, đặt giá trị mặc định
            string newMaHD = "DH0001";

            if (!string.IsNullOrEmpty(lastMaHD))
            {
                // Tăng mã hóa đơn lên 1
                int numberPart = int.Parse(lastMaHD.Substring(2)); // Lấy phần số sau "HD"
                newMaHD = "DH" + (numberPart + 1).ToString("D4");  // Cộng 1 và format thành "D4"
            }

            // Hiển thị mã hóa đơn mới lên TextBox
            MaDHTextBox.Text = newMaHD;
        }

        private void LoadGioHang()
        {
            DonHangDataGrid.DataSource = gioHangs.ToList();
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

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

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

        private void MaKMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
