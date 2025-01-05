using DoAnCuoiKi.model;
//using Microsoft.AnalysisServices;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi.frm.frm_BaoCao
{
    public partial class BaoCaoNhapKho : Form
    {
        CuaHangDB db = new CuaHangDB();

        public BaoCaoNhapKho()
        {
            InitializeComponent();
            this. NhapKhoReport.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThangText_ValueChanged(object sender, EventArgs e)
        {
        }

        private void NamText_ValueChanged(object sender, EventArgs e)
        {
        }

        private void LapBaoCaoButton_Click(object sender, EventArgs e)
        {
            var thang = ThangText.Value;
            var nam = NamText.Value;

            // Kiểm tra tháng năm đã nhập chưa
            if (string.IsNullOrEmpty(thang.ToString()) || string.IsNullOrEmpty(nam.ToString()))
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin");
                return;
            }

            // Kiểm tra tháng có hợp lệ không
            if (thang < 1 || thang > 12)
            {
                MessageBox.Show("Tháng không hợp lệ");
                return;
            }

            var thongTin = db.PHIEUNHAPKHOes.Where(p => p.NgayNhap.Month == thang && p.NgayNhap.Year == nam).ToList();

            NhapKhoReport.LocalReport.ReportPath = "D:\\HUTECH\\C#\\CuaHangQuanAo\\CuaHangQuanAo_DoAn\\DoAnCuoiKi\\frm\\frm_BaoCao\\rptNhapHang.rdlc";
            var nhapKhoData = new ReportDataSource("NhapKhoDataSet", thongTin);

            var thangPar = new ReportParameter("Thang", thang.ToString());
            var namPar = new ReportParameter("Nam", nam.ToString());

            NhapKhoReport.LocalReport.DataSources.Clear();

            NhapKhoReport.LocalReport.DataSources.Add(nhapKhoData);
            NhapKhoReport.LocalReport.SetParameters(thangPar);
            NhapKhoReport.LocalReport.SetParameters(namPar);

            NhapKhoReport.RefreshReport();
        }

        private void BaoCaoNhapKho_Load(object sender, EventArgs e)
        {
            ThangText.Minimum = 1;
            ThangText.Maximum = 12;
            NamText.Minimum = 1000;
            NamText.Maximum = 3000;
            ThangText.Value = (decimal)DateTime.Now.Month;
            NamText.Value = (decimal)DateTime.Now.Year;

            this.NhapKhoReport.RefreshReport();
        }
    }
}
