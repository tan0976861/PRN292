using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRN292.BUS;
using PRN292.DB;
using PRN292.DTO;
namespace PRN292
{
    public partial class hoaDonFrm : Form
    {
        MilkTeaBUS bus = new MilkTeaBUS();
        BillBUS billBUS = new BillBUS();
        BillInfoBUS billInfoBUS = new BillInfoBUS();

        //MilkTea.DbConnection db = new MilkTea.DbConnection();
        List<Category> listCategory;
        List<MilkTea> list;
        DataTable data = new DataTable();
        int index;
        string tenmonan;
        SqlConnection conn;
        public hoaDonFrm()
        {
            InitializeComponent();
            loadListTea();
        }
        void loadListTea()
        {
            list = bus.GetListMilkTea();
            foreach (MilkTea dto in list)
            {
                cboMonAn.Items.Add(dto.MilkTeaName);
            }
        }



        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboMonAn.SelectedItem.ToString()))
            {
                MessageBox.Show("Bạn hãy chọn món ăn trước nhé.");
                return;
            }
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Bạn hãy chọn món ăn trước nhé.");
                return;
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Bạn hãy chọn món ăn trước nhé.");
                return;
            }
            string name = cboMonAn.SelectedItem.ToString();
            string ID = txtID.Text;
            double price = double.Parse(txtPrice.Text);
            double qty = double.Parse(txtQuantity.Text);
            double tot = price * qty;


            int sum = 0;
            for (int row = 0; row < dgvListMonAn.Rows.Count; row++)
            {
                if (dgvListMonAn.Rows[row].Cells[0].Value.ToString().Equals(ID))
                {
                    MessageBox.Show("Món này đã được thêm rồi. Vui lòng sửa số tăng số lượng.");
                    return;
                }
            }
            this.dgvListMonAn.Rows.Add(ID, name, qty, price, tot);
            for (int row = 0; row < dgvListMonAn.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dgvListMonAn.Rows[row].Cells[4].Value);
            }
            // cboMonAn.
            txtTotal.Text = sum.ToString();
            //txtID.Clear();
            //txtdname.Clear();
            //txtPrice.Clear();
            txtQuantity.Text = "1";
        }

        private void hoaDonFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPayment.Text))
            {
                MessageBox.Show("Vui lòng nhập tiền thanh toán.");
                return;
            }
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Bạn hãy chọn món ăn và thêm món nhé");
                return;
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Bạn hãy chọn món ăn và thêm món nhé.");
                return;
            }
            if (string.IsNullOrEmpty(txtTotal.Text))
            {
                MessageBox.Show("Bạn hãy chọn món ăn và thêm món nhé.");
                return;
            }


            double total = double.Parse(txtTotal.Text);//21
            double discount = total * (double.Parse(nbDiscount.Text) / 100);//0
            double subtotal = total - discount;

            double pay = double.Parse(txtPayment.Text);
            double bal = pay - subtotal;
            txtBalance.Text = bal.ToString();
            SaveHD();
        }
        public void SaveHD()
        {
            if (dgvListMonAn.Rows.Count == 0)
            {
                MessageBox.Show("Vui Lòng thêm món mới.");
                return;
            }
            string total = txtTotal.Text;
            string pay = txtPayment.Text;
            string discount = nbDiscount.Value.ToString();
            string bal = txtBalance.Text;
            DateTime time = DateTime.Now;
            Bill dtoo = new Bill
            {
                TimeOfCreate = time,
                SumOfMoney = Double.Parse(total),
                Discount = int.Parse(discount),
                Pay = double.Parse(pay),
                Balance = double.Parse(bal)
            };
            int lastid = billBUS.InsertBill(dtoo);
            string MilkteaID;
            int price = 0;
            int qty = 0;
            int tot = 0;
            bool check = false;

            for (int row = 0; row < dgvListMonAn.Rows.Count; row++)
            {
                MilkteaID = dgvListMonAn.Rows[row].Cells[0].Value.ToString();
                //string MilkTeaID =dgvListMonAn.Rows[row].Cells[0].Value.ToString();
                qty = int.Parse(dgvListMonAn.Rows[row].Cells[2].Value.ToString());
                price = int.Parse(dgvListMonAn.Rows[row].Cells[3].Value.ToString());
                tot = int.Parse(dgvListMonAn.Rows[row].Cells[4].Value.ToString());

                BillInfo dtoBillInfo = new BillInfo
                {
                    BillID = lastid,
                    MilkTeaID = MilkteaID,
                    Quantity = qty,
                    Price = price,
                    Money = tot
                };
                check = billInfoBUS.InsertBillInfo(dtoBillInfo);
                check = true;
            }
            if (check)
            {
                MessageBox.Show("Save Successful.");
            }


        }

        private void dgvListMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListMonAn.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                dgvListMonAn.Rows.Remove(dgvListMonAn.Rows[e.RowIndex]);

                int sum = 0;
                for (int row = 0; row < dgvListMonAn.Rows.Count; row++)
                {
                    sum = sum + Convert.ToInt32(dgvListMonAn.Rows[row].Cells[4].Value);
                }

                txtTotal.Text = sum.ToString();
            }
        }

        private void cboMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string monan = cboMonAn.SelectedItem.ToString();
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("select * from MilkTeas where MilkTeaName = '" + monan + "'", conn);
            conn.Open();
            SqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                string pID;
                string price;
                pID = read["MilkTeaID"].ToString();
                price = read["Price"].ToString();

                txtPrice.Text = price;
                txtID.Text = pID;
            }
            else
            {
                MessageBox.Show("No Barcode Found");
            }
            conn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
