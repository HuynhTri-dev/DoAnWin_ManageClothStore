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
        CuaHangDB db = new CuaHangDB();
        public BanHang()
        {
            InitializeComponent();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            LoadProducts(); 
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

                moreInfo.Click += (s,e) => ShowProductDetails(product.MaSP);

                // Gán sự kiện click cho Panel
                //productPanel.Click += (s, e) => 

                // Thêm các control vào Panel
                productPanel.Controls.Add(productImage);
                productPanel.Controls.Add(productName);
                productPanel.Controls.Add(soLuong);
                productPanel.Controls.Add(productPrice);
                
                productPanel.Controls.Add(moreInfo);

                // Thêm Panel vào FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(productPanel);
            }
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
            // Lấy thông tin sản phẩm từ cơ sở dữ liệu
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
    }
}
