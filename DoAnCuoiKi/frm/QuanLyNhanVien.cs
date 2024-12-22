using DoAnCuoiKi.frm;
using DoAnCuoiKi.model;
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

namespace DoAnCuoiKi
{
    public partial class QuanLyNhanVien : Form
    {
        CuaHangDB db = new CuaHangDB();
        public QuanLyNhanVien()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadComboRole();
            LoadThongTinNhanVien();
        }

        private void LoadThongTinNhanVien()
        {
            var thongTin = db.NHANVIENs.Select(x => new {x.MaNV, 
                                                         HoTen = x.Ho + " " + x.LotTen, 
                                                         x.ChucVu, 
                                                         GioiTinh = x.GioiTinh == true ? "Nam" : "Nữ",
                                                         x.NgaySinh,
                                                         x.SDT}).ToList();
            nhanVienDataGrid.DataSource = thongTin;
            
            nhanVienDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearFields()
        {
            txtStaffID.Clear();
            txtStaffName.Clear();
            txtSDTS.Clear();
            cboRole.SelectedIndex = -1;
            namRadio.Checked = true;
            nuRadio.Checked = false;
            dtpStaff.Value = DateTime.Now;
            MaTKTextBox.Clear();
        }

        private void LoadComboRole()
        {
            cboRole.Items.Add("QL");
            cboRole.Items.Add("NV");
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStaffID.Text)
            || !string.IsNullOrEmpty(txtStaffName.Text)
            || (namRadio.Checked == true || nuRadio.Checked == true)
            || !string.IsNullOrEmpty(cboRole.SelectedItem.ToString())
            || !string.IsNullOrEmpty(MaTKTextBox.Text))
            {
                if (txtStaffID.Text.Length > 6)
                {
                    MessageBox.Show("Mã chữ có tối đa 6 ký tự", "Thông báo");
                    return;
                }

                string fullName = txtStaffName.Text; // Chuỗi họ tên đầy đủ
                int firstSpaceIndex = fullName.IndexOf(' ');

                string lastName;
                string restName;

                if (firstSpaceIndex == -1)
                {
                    MessageBox.Show("Phải nhập đầu đủ họ tên!", "Thông báo");
                    return;
                }
                else
                {
                    lastName = fullName.Substring(0, firstSpaceIndex); // Họ
                    restName = fullName.Substring(firstSpaceIndex + 1); // Đệm và tên
                }

                NHANVIEN nv = new NHANVIEN()
                {
                    MaNV = txtStaffID.Text,
                    Ho = lastName,
                    LotTen = restName,
                    ChucVu = cboRole.SelectedItem.ToString(),
                    GioiTinh = namRadio.Checked,
                    NgaySinh = dtpStaff.Value.Date,
                    SDT = txtSDTS.Text,
                    MaTK = MaTKTextBox.Text
                };

                db.NHANVIENs.AddOrUpdate(nv);
                db.SaveChanges();
                LoadThongTinNhanVien();
                ClearFields();

                var maNV = db.NHANVIENs.Select(x => x.MaNV == txtStaffID.Text).FirstOrDefault();
                if (maNV)
                {
                    MessageBox.Show("Thêm thông tin thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thành công!");
                }
            }
            else
            {
                MessageBox.Show("Thông tin chưa được nhập đầy đủ", "Thông báo");
            }
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var maNV = db.NHANVIENs.FirstOrDefault(x => x.MaNV == txtStaffID.Text);
            if (maNV != null)
            {
                DialogResult dlg = MessageBox.Show("Xóa thông tin nhân viên này?", "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    db.NHANVIENs.Remove(maNV);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công!");
                    LoadThongTinNhanVien();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin nhân viên này.");
            }
        }

        private void nhanVienDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = nhanVienDataGrid.Rows[e.RowIndex];
                var maSo = row.Cells["MaNV"].Value.ToString();
                if (!string.IsNullOrEmpty(maSo))
                {
                    var thongTin = db.NHANVIENs.FirstOrDefault(x => x.MaNV == maSo);

                    if (thongTin != null)
                    {
                        txtStaffID.Text = thongTin.MaNV.ToString();
                        txtStaffName.Text = thongTin.Ho + " " + thongTin.LotTen;
                        if (thongTin.GioiTinh == true)
                        {
                            namRadio.Checked = true;
                        }
                        else
                        {
                            nuRadio.Checked = true;
                        }
                        txtSDTS.Text = thongTin.SDT;
                        if (thongTin.NgaySinh.HasValue)
                        {
                            dtpStaff.Value = thongTin.NgaySinh.Value;
                        }
                        else
                        {
                            // Gán giá trị mặc định nếu không có ngày sinh
                            dtpStaff.Value = DateTime.Now;
                        }
                        cboRole.SelectedItem = thongTin.ChucVu;
                        MaTKTextBox.Text = thongTin.MaTK;
                    }
                }
            }
        }

        private void MaTKTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void taoTKButton_Click(object sender, EventArgs e)
        {
            DangKyTaiKhoan tk = new DangKyTaiKhoan(MaTKTextBox.Text);
            tk.ShowDialog();

            MaTKTextBox.Text = tk.DataToReturn;
        }
    }
}


