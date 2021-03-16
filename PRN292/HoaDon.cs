using MilkTea;
using PRN292.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace PRN292
{
    public partial class frmHoaDon : Form
    {
        MilkTeaDAO dao = new MilkTeaDAO();
        BillDAO billdao = new BillDAO();
        //MilkTea.DbConnection db = new MilkTea.DbConnection();
        List<CategoryDTO> listCategory;
        List<MilkTeaDTO> list;
        DataTable data = new DataTable();
        int index;
        string tenmonan;
        SqlConnection conn;
        public frmHoaDon()
        {
            InitializeComponent();
          //  loadListCategoy();
            loadListTea();
        }
        //void loadListCategoy()
        //{
        //    listCategory = dao.GetListCategory();
        //    foreach (CategoryDTO dto in listCategory)
        //    {
        //        cboCategory.Items.Add(new CategoryDTO(dto.CategoryID, dto.CategoryName));
        //    }
        //}
        void loadListTea()
        {
            list = dao.GetListMilkTea();
            foreach (MilkTeaDTO dto in list)
            {
                cboMonAn.Items.Add(dto.MilkTeaName);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            // string text = dgvListMonAn.CurrentRow.Cells["Quantity"].Value.ToString();
            // lvTeas.Items.Add(cboMonAn.SelectedItem.ToString());
            // lvTeas.Items.Add(tenmonan);
            string ID = txtID.Text;
            string name = cboMonAn.SelectedItem.ToString();
            double price = double.Parse(txtPrice.Text);
            double qty = double.Parse(txtQuantity.Text);
            double tot = price * qty;
            this.dgvListMonAn.Rows.Add(ID, name, qty, price, tot);

            int sum = 0;

            for (int row = 0; row < dgvListMonAn.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dgvListMonAn.Rows[row].Cells[4].Value);
            }
            txtTotal.Text = sum.ToString();
            txtID.Clear();
            //txtdname.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();



        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            

        }

        private void dgvListMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void lvteas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    private void dgvListMonAn_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 13)
            //{
            //    string conStr = @"Data Source=SE140482\LUONGND;Initial Catalog=MilkTea;Persist Security Info=True;User ID=sa; Password= 23112015";
            //    SqlConnection conn = new SqlConnection(conStr); 
            //    SqlCommand cmd = new SqlCommand("select * from MilkTeas where MilkTeaName = '485'", conn);
            //    conn.Open();
            //    SqlDataReader read = cmd.ExecuteReader();

            //    if (read.Read())
            //    {
            //        string pquantity;
            //        string price;
            //        pquantity = read["Quantity"].ToString();
            //        price = read["Price"].ToString();

            //        txtPrice.Text = price;
            //        txtQuantity.Text = pquantity;
            //    }
            //    else
            //    {
            //        MessageBox.Show("No Barcode Found");
            //    }
            //    conn.Close();
            //}
            //else
            //{
            //    MessageBox.Show("a");
            //}
            //conn.Close();
        }

        private void cboMonAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            string monan = cboMonAn.SelectedItem.ToString();
            if (e.KeyChar == 13)
            {
                SqlConnection conn = MilkTea.DbConnection.GetConnection();
                //string conStr = @"Data Source=SE140482\LUONGND;Initial Catalog=MilkTea;Persist Security Info=True;User ID=sa; Password= 23112015";
                //SqlConnection conn = new SqlConnection(conStr);
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
            else
            {
                MessageBox.Show("a");
            }
            //conn.Close();
        }
    }
}
