using DoAnCuoiKi.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zuby.ADGV;
using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;

namespace DoAnCuoiKi.frm.frm_Data
{
    public partial class QuanLyHoaDon : Form
    {
        CuaHangDB db = new CuaHangDB();
        List<HOADON> dataGrid;
        List<HOADON> filterList;
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void LoadData()
        {
            var thongTin = db.HOADONs.ToList();
            dataGrid = filterList = thongTin;
            HoaDonAdvance.DataSource = dataGrid;
        }

        private void HoaDonAdvance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HoaDonAdvance_FilterStringChanged(object sender, AdvancedDataGridView.FilterEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(HoaDonAdvance.FilterString) == true)
                {
                    filterList = dataGrid;
                    HoaDonAdvance.DataSource = dataGrid;

                }
                else
                {
                    var listfilter = FilterStringconverter(HoaDonAdvance.FilterString);

                    filterList = filterList.AsQueryable().Where(listfilter).ToList();

                    HoaDonAdvance.DataSource = filterList;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " - " + MethodBase.GetCurrentMethod().Name);
            }
        }
        private string FilterStringconverter(string filter)
        {
            string newColFilter = "";
            filter = filter.Replace("(", "").Replace(")", "");
            var colFilterList = filter.Split(new string[] { "AND" }, StringSplitOptions.None);
            string andOperator = "";
            foreach (var colFilter in colFilterList)
            {
                newColFilter += andOperator;
                var temp1 = colFilter.Trim().Split(new string[] { "IN" }, StringSplitOptions.None);
                var colName = temp1[0].Split('[', ']')[1].Trim();
                newColFilter += string.Format("({0} != null && (", colName);
                string orOperator = "";
                var filterValsList = temp1[1].Split(',');
                foreach (var filterVal in filterValsList)
                {
                    var cleanFilterVal = filterVal.Replace("'", "").Trim();

                    double tempNum = 0;
                    if (Double.TryParse(cleanFilterVal, out tempNum))
                        newColFilter += string.Format("{0} {1} = {2}", orOperator, colName, cleanFilterVal.Trim());
                    else
                        newColFilter += string.Format("{0} {1}.Contains('{2}')", orOperator, colName, cleanFilterVal.Trim());

                    orOperator = " OR ";
                }

                newColFilter += "))";

                andOperator = " AND ";
            }
            return newColFilter.Replace("'", "\"");
        }

    }
}
