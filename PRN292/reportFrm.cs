using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRN292.BUS;
using PRN292.DB;
using PRN292.DTO;
using System.Data.SqlClient;
namespace PRN292
{
    public partial class reportFrm : Form
    {
        BillBUS billBUS = new BillBUS();
        DataTable dtBill = new DataTable();
        public reportFrm()
        {
            InitializeComponent();
        }
        void loadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            pickerFirstTime.Value = new DateTime(today.Year, today.Month, 1);
            pickerSecondTime.Value = pickerFirstTime.Value.AddMonths(1).AddDays(-1);
        }
        public void loadBillByDate()
        {
            string date1 = pickerFirstTime.Value.ToString();
            string date2 = pickerSecondTime.Value.ToString();
            dtBill = billBUS.getListBillByDate(date1, date2);
            dgvListBill.DataSource = dtBill;
            double tongdoanhthu = 0;
            for (int row = 0; row < dgvListBill.Rows.Count; row++)
            {
                tongdoanhthu += double.Parse(dgvListBill.Rows[row].Cells[1].Value.ToString());
            }
            txtTongDoanhThu.Text = tongdoanhthu.ToString();
            txtTongDoanhThu.Enabled = false;

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            loadBillByDate();
        }

        private void reportFrm_Load(object sender, EventArgs e)
        {
            loadDateTimePickerBill();
            loadBillByDate();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
