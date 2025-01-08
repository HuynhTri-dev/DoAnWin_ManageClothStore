using DoAnCuoiKi.frm.frm_BaoCao;
using DoAnCuoiKi.frm.frm_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class TrangChu : Form
    {
        private string CHUCVU;
        private string MANV;
        public TrangChu(string ChucVu, string maNV)
        {
            CHUCVU = ChucVu;
            InitializeComponent();
            this.MANV = maNV;
        }

        // hàm để tạo tạo và gọi form con
        private Form activeForm = null; 
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm; 
            childForm.TopLevel = false; // Không phải Form cấp cao nhất
            childForm.FormBorderStyle = FormBorderStyle.None; 

            panel2.Controls.Clear(); 
            panel2.AutoScroll = true;

            panel2.Size = new Size(childForm.Width, childForm.Height);

            childForm.Dock = DockStyle.Fill; 
            panel2.Controls.Add(childForm); 
            panel2.Tag = childForm; 
            childForm.BringToFront(); 
            childForm.Show(); 

            panel2.Refresh();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            this.Text = "Trang chủ";
            OpenChildForm(new BanHang(MANV));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Text = "Trang chủ";

            OpenChildForm(new BanHang(MANV));
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý đơn hàng";

            OpenChildForm(new QuanLyDongHang());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (CHUCVU == "QL")
            {
                this.Text = "Quản lý nhân viên";
                OpenChildForm(new QuanLyNhanVien());
            }
            else
            {
                MessageBox.Show("Đây là chức năng của quản lý", "Thông báo");
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý khách hàng";
            OpenChildForm(new QuanLyKhachHang());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                this.DialogResult = dr;
                this.Close();
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý đơn hàng";

            OpenChildForm(new QuanLySanPham());
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý doanh thu";
            OpenChildForm(new QuanLyDoanhThu());
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            this.Text = "Khuyến mãi";

            OpenChildForm(new QuanLyKhuyenMai());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HoaDonButton_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý hóa đơn";

            OpenChildForm(new QuanLyHoaDon());
        }

        private Timer toggleMenuTimer;

        private const int max = 1500; // Chiều rộng khi menu mở
        private const int min = 1300; // Chiều rộng khi menu đóng
        private bool isMenuExpanded = true;
        private void ShowMenu_Click(object sender, EventArgs e)
        {
            toggleMenuTimer = new Timer();
            toggleMenuTimer.Interval = 10; // Tốc độ hiệu ứng (ms)
            toggleMenuTimer.Tick += ToggleMenuTimer_Tick;
            toggleMenuTimer.Start();
        }

        private void ToggleMenuTimer_Tick(object sender, EventArgs e)
        {
            if (isMenuExpanded)
            {
                panel2.Width += 10;
                panel2.Left -= 10;
                if (panel2.Width >= max)
                {
                    isMenuExpanded = false;
                    toggleMenuTimer.Stop();
                }
            }
            else
            {
                panel2.Width -= 10;
                panel2.Left += 10;
                if (panel2.Width <= min)
                {
                    isMenuExpanded = true;
                    toggleMenuTimer.Stop();
                }
            }
        }
    }
}

