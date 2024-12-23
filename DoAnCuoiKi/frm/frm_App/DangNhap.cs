using DoAnCuoiKi.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnCuoiKi
{
    public partial class DangNhap : Form
    {
        CuaHangDB db = new CuaHangDB();
        private Timer timer;
        public DangNhap()
        {
            InitializeComponent();

            SetPlaceholder(txtLoginName, "Tên đăng nhập");
            SetPlaceholder(txtPass, "Mật khẩu");

            //timer
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += timer1_Tick; 
            timer.Start();

            this.Load += Form1_Load;

        }

        private void SetPlaceholder(System.Windows.Forms.TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };
            textBox.LostFocus += (sender, e) =>
            { 
            if (String.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        };
     }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginName.Text;
            string password = txtPass.Text;
            
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                var tkTonTai = db.TAIKHOANs.Where(x => x.TenTK == username).FirstOrDefault();
                if (tkTonTai != null)
                {
                    var mkCheck = db.TAIKHOANs.Where(x => x.TenTK == username && x.MatKhau == password).FirstOrDefault();

                    if (mkCheck != null)
                    {
                        var chucVu = db.NHANVIENs.Where(x => x.TAIKHOAN.TenTK == username).Select(x => x.ChucVu).FirstOrDefault();

                        if (chucVu == "QL")
                        {
                            MessageBox.Show("Đăng nhập thành công vào tài khoản quản lý", "Thông báo");
                        }

                        TrangChu trangChu = new TrangChu(chucVu);
                        this.Hide();
                        DialogResult dr = trangChu.ShowDialog();
                        
                        

                        if (dr == DialogResult.Yes)
                        {
                            this.Show();
                            ClearValue();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu chưa đúng", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản này chưa tồn tại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin tài khoản", "Thông báo");
            }
        }

        private void ClearValue()
        {
            txtLoginName.Clear();
            txtPass.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoginName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
 }

