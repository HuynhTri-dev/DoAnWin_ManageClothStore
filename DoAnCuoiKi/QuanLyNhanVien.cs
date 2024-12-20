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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStaffID.Text) ||
        string.IsNullOrWhiteSpace(txtStaffName.Text) ||
        string.IsNullOrWhiteSpace(txtSDTS.Text) ||
        string.IsNullOrWhiteSpace(txtAddress.Text) ||
        cboRole.SelectedIndex == -1 ||
        cboGender.SelectedIndex == -1)

            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.Rows.Add(
        txtStaffID.Text,           // Mã nhân viên
        txtStaffName.Text,                // Họ tên
        cboGender.Text,             // Giới tính
        dtpStaff.Value.ToShortDateString(), // Ngày sinh
        txtSDTS.Text,                  // Số điện thoại
        cboRole.Text,               // Chức vụ
        txtAddress.Text                // Địa chỉ
    );

            // Xóa trắng các ô sau khi thêm
            ClearFields();
        }

        // Hàm xóa trắng các ô nhập liệu
        private void ClearFields()
        {
            txtStaffID.Clear();
            txtStaffName.Clear();
            txtSDTS.Clear();
            cboRole.SelectedIndex = -1;
            txtAddress.Clear();
            cboGender.SelectedIndex = -1;
            dtpStaff.Value = DateTime.Now;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có dòng nào để xóa hoặc chưa chọn dòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStaffID.Text) ||
                string.IsNullOrWhiteSpace(txtStaffName.Text) ||
                string.IsNullOrWhiteSpace(txtSDTS.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                cboRole.SelectedIndex == -1 ||
                cboGender.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                row.Cells[0].Value = txtStaffID.Text;
                row.Cells[1].Value = txtStaffName.Text;
                row.Cells[2].Value = cboGender.Text;
                row.Cells[3].Value = dtpStaff.Value.ToShortDateString();
                row.Cells[4].Value = txtSDTS.Text;
                row.Cells[5].Value = cboRole.Text;
                row.Cells[6].Value = txtAddress.Text;

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}


