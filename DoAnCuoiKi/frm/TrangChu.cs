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
        private string chucVu;

        public TrangChu(string ChucVu)
        {
            chucVu = ChucVu;
            InitializeComponent();
        }

        // hàm để tạo tạo và gọi form con
        private Form activeForm = null; 
        private void OpenChildForm(Form childForm)
        {
            // Đóng Form hiện tại nếu có
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm; // Cập nhật Form mới
            childForm.TopLevel = false; // Không phải Form cấp cao nhất
            childForm.FormBorderStyle = FormBorderStyle.None; // Xóa viền

            // Đặt kích thước Panel chính dựa trên kích thước Form con
            panel2.Controls.Clear(); // Xóa các control cũ trong Panel chính
            panel2.AutoScroll = true;

            // Cập nhật kích thước Panel chính dựa trên kích thước ChildForm
            panel2.Size = new Size(childForm.Width, childForm.Height);

            childForm.Dock = DockStyle.Fill; // Lấp đầy Panel chính
            panel2.Controls.Add(childForm); // Thêm Form mới vào Panel chính
            panel2.Tag = childForm; // Gắn thẻ Form
            childForm.BringToFront(); // Đưa Form lên trên cùng
            childForm.Show(); // Hiển thị Form

            // Đặt lại kích thước nếu cần khi không dùng DockStyle.Fill
            panel2.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Text = "Trang chủ";

            OpenChildForm(new BanHang());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý đơn hàng";

            OpenChildForm(new QuanLyDonHang());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (chucVu == "QL")
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
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            this.Text = "Trang chủ";

            OpenChildForm(new BanHang());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý kho";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

