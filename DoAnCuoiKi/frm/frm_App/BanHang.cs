using DoAnCuoiKi.frm.frm_Data;
using DoAnCuoiKi.frm.frm_ThanhToan;
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

        // Gia tien
        public decimal PhaiThu = 0;
        public string MaDonHang = "";
        public string PhuongThuc = "Tiền mặt";

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
            LoadMaDonHang();
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
            var khuyenMais = db.KHUYENMAIs.ToList();

            foreach (var km in khuyenMais)
            {
                // kiem tra khuyen mai co hieu luc khong
                if (km.NgayBatDau <= DateTime.Now && km.NgayKetThuc >= DateTime.Now)
                {
                    MaKMComboBox.Items.Add(km.TenKM);
                }
            }
        }
        // Cập nhật giá trị từng khuyến mãi
        private void MaKMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MaKMComboBox.SelectedItem != null)
            {
                var giaTri = db.KHUYENMAIs.Where(x => x.TenKM == MaKMComboBox.SelectedItem.ToString()).Select(x => x.GiaTri).FirstOrDefault();

                GiaTriTextBox.Text = giaTri.ToString();
                LoadGia();
            }
            else
            {
                GiaTriTextBox.Clear();
            }
            
        }

        //Load mã hoá đơn
        private void LoadMaDonHang()
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

            MaDonHang = newMaHD;
            MaDHTextBox.Text = MaDonHang;
        }
        // cập nhật lại giá trị mã hóa đơn
        private void MaDHTextBox_TextChanged(object sender, EventArgs e)
        {
            MaDonHang = MaDHTextBox.Text;
        }

        // Load bảng datagrid giỏ hàng
        private void LoadGioHang()
        {
            DonHangDataGrid.DataSource = gioHangs.ToList();

            foreach (DataGridViewColumn column in DonHangDataGrid.Columns)
            {
                if (column.Name == "SoLuong")
                {
                    column.ReadOnly = false;
                }
                else
                {
                    column.ReadOnly = true;
                }
            }

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
            PhaiThu = tongTien - giamGia;
            PhaiThuTextBox.Text = (PhaiThu).ToString("0.##");
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
                moreInfo.Click += (s, e) => ShowProductDetails(product.MaSP);
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
                productPanel.Enabled = true;
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

        // Chức năng thay đổi số lượng trong sản phẩm
        private void DonHangDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            // Kiểm tra nếu cột là "SoLuong"
            if (DonHangDataGrid.Columns[columnIndex].Name == "SoLuong")
            {
                try
                {
                    int soLuong = int.Parse(DonHangDataGrid.Rows[rowIndex].Cells["SoLuong"].Value.ToString());

                    var ma = DonHangDataGrid.Rows[rowIndex].Cells["MaSP"].Value.ToString();

                    var slt = db.SANPHAMs.Where(x => x.MaSP == ma).Select(x => x.SoLuongTon).FirstOrDefault();

                    if (soLuong > slt)
                    {
                        MessageBox.Show("Số lượng tồn không đủ", "Thông báo");
                        soLuong = slt;
                        return;
                    }

                    decimal donGia = db.SANPHAMs.Where(x => x.MaSP == ma).Select(x => x.GiaBan).FirstOrDefault();

                    decimal thanhTien = soLuong * donGia;

                    DonHangDataGrid.Rows[rowIndex].Cells["ThanhTien"].Value = thanhTien;

                    LoadGia();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng nhập số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Nut tao qr
        private void MaQRButton_Click(object sender, EventArgs e)
        {
            TaoQR taoQR = new TaoQR(MaDonHang, PhaiThu);
            DialogResult dr = taoQR.ShowDialog();
            if (dr == DialogResult.OK)
            {
                PhuongThuc = "Momo";
                MessageBox.Show("Thanh toán thành công", "Thông báo");
            }
        }
        // chức năng xóa hàng trong giỏ
        private void XoaButton_Click(object sender, EventArgs e)
        {
            if (DonHangDataGrid.SelectedCells.Count > 0)
            {
                var selectedCell = DonHangDataGrid.SelectedCells[0];

                var selectedRow = selectedCell.OwningRow;

                var productId = selectedRow.Cells["MaSP"].Value.ToString();


                var productToRemove = gioHangs.FirstOrDefault(p => p.MaSP == productId);

                if (productToRemove != null)
                {
                    gioHangs.Remove(productToRemove);

                    // Cập nhật lại DataGridView
                    DonHangDataGrid.Refresh();
                    LoadGioHang();
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tìm thấy trong giỏ hàng.");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn hàng muốn xóa");
            }
        }
        // chức năng thanh toán 
        private void ThanhToanButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaDHTextBox.Text) 
                || string.IsNullOrEmpty(MaNVTextBox.Text) 
                || string.IsNullOrEmpty(NgayLapDatePicker.Value.ToString()) 
                || LoaiDHComboBox.SelectedItem == null 
                || string.IsNullOrEmpty(PhaiThuTextBox.Text) 
                || string.IsNullOrEmpty(PhuongThuc))
            {
                MessageBox.Show("Thông tin chưa đầy đủ", "Thông báo");
                return;
            }

            if (gioHangs == null || gioHangs.Count == 0) 
            { 
                MessageBox.Show("Không có sản phẩm trong giỏ hàng", "Thông báo"); 
                return; 
            }

            if (PhuongThuc == "Tiền mặt" && string.IsNullOrEmpty(KhachDuaTextBox.Text))
            {
                MessageBox.Show("Chưa thu tiền khách", "Thông báo");
                return;
            }

            string maKM = null;
            if (MaKMComboBox.SelectedItem != null)
            {
                maKM = db.KHUYENMAIs
                          .Where(x => x.TenKM == MaKMComboBox.SelectedItem.ToString())
                          .Select(x => x.MaKM)
                          .FirstOrDefault();
            }


            // nhap dia chi giao hang
            if (LoaiDHComboBox.SelectedItem.ToString() == "Online")
            {
                ThongTinGiaoHang giaoHang = new ThongTinGiaoHang();
                DialogResult dr = giaoHang.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    MessageBox.Show("Cần phải nhập thông tin giao hàng", "Thông báo");
                    return;
                }
                if (dr == DialogResult.OK)
                {
                    PHIEUGIAOHANG pgh = new PHIEUGIAOHANG()
                    {
                        MaPhieu = giaoHang.MaPhieu,
                        DiaChi = giaoHang.DiaChi,
                        NgayLap = giaoHang.NgayLap,
                        NgayGiaoHang = giaoHang.NgayGiaoHang,
                        TrangThaiGiaoHang = giaoHang.TrangThaiGiaoHang,
                        Phi = giaoHang.Phi,
                        GhiChu = giaoHang.GhiChu,
                        MaDH = MaDHTextBox.Text
                    };
                    db.PHIEUGIAOHANGs.Add(pgh);
                }
            }


            //Sau đó lưu dữ liệu
            //Luu don truoc
                DonHang dh = new DonHang()
                {
                    MaDH = MaDHTextBox.Text,
                    NgayLapDon = NgayLapDatePicker.Value,
                    LoaiDH = LoaiDHComboBox.SelectedItem.ToString() == "Online" ? "ON" : "OF",
                    MaKH = string.IsNullOrEmpty(MaKHTextBox.Text) ? null : MaKHTextBox.Text,
                    MaNV = MaNVTextBox.Text,
                    MaKM = string.IsNullOrEmpty(maKM) ? null : maKM
                };



            db.DonHangs.Add(dh);
            db.SaveChanges();

            //Luu chi tiet don
            foreach (var sanPham in gioHangs)
            {
                CHITIETDONHANG ctdh = new CHITIETDONHANG()
                {
                    MaDH = MaDHTextBox.Text,
                    MaSP = sanPham.MaSP,
                    SoLuong = sanPham.SoLuong
                };
                db.CHITIETDONHANGs.Add(ctdh);

                var sp = db.SANPHAMs.FirstOrDefault(x => x.MaSP == sanPham.MaSP);
                sp.SoLuongTon -= sanPham.SoLuong;
                db.SaveChanges();
            }

            //Lưu hóa đơn
           HOADON hd = new HOADON()
           {
               MaHD = LoadMaHoaDon(),
               NgayLap = NgayLapDatePicker.Value,
               TongTien = decimal.Parse(PhaiThuTextBox.Text),
               PhuongThucThanhToan = PhuongThuc,
               GhiChu = GhiChuRichText.Text,
               MaDH = MaDHTextBox.Text
           };
            db.HOADONs.Add(hd);
            db.SaveChanges();
            ResetGioHang();
            MessageBox.Show("Hoàn thành đơn hàng", "Thông báo");
            flowLayoutPanel1.Refresh();
            LoadProducts();

            XuatHoaDon xuatHoaDon = new XuatHoaDon(hd.MaHD);
            xuatHoaDon.ShowDialog();
        }

        private void ResetGioHang()
        {
            LoadMaDonHang();
            NgayLapDatePicker.Value = DateTime.Now;
            gioHangs.Clear();
            LoadGioHang();
            MaKHTextBox.Clear();
            MaKMComboBox.SelectedIndex = -1;
            LoaiDHComboBox.SelectedIndex = -1;
            GhiChuRichText.Clear();
            KhachDuaTextBox.Text = "0";
        }

        // Tao mã hóa đơn
        private string LoadMaHoaDon()
        {
            string maDH = MaDHTextBox.Text;
            var maHD = "HD" + maDH.Substring(2);

            var checkTonTai = db.HOADONs.FirstOrDefault(s => s.MaHD == maHD);

            if (checkTonTai == null)
            {
                return maHD;
            }
            else
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại","Thông báo");
                return string.Empty;
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

        

        private void KhachDuaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void GiaoHangButton_Click(object sender, EventArgs e)
        {
            
        }

        private void KhachDuaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            { 
                e.Handled = true;
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
        }
    }
}
