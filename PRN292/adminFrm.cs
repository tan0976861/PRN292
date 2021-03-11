using System;
using MilkTea;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN292
{
    public partial class adminFrm : Form
    {
        MilkTeaDAO dao = new MilkTeaDAO();
        List<MilkTeaDTO> list;
        public adminFrm()
        {
            InitializeComponent();
            dao = new MilkTeaDAO();
        }
        public adminFrm(string user)
        {
            InitializeComponent();
            lblHello.Text = "Hello " +  user;
        }
        public void LoadData()
        {
            list = dao.GetListMilkTea();

            txtMilkTeaID.DataBindings.Clear();
            txtMilkTeaName.DataBindings.Clear();
            txtMilkTeaQuantity.DataBindings.Clear();
            txtMilkTeaName.DataBindings.Clear();
            txtCategory.DataBindings.Clear();

            txtMilkTeaID.DataBindings.Add("Text", list, "MilkTeaID");
            txtMilkTeaName.DataBindings.Add("Text", list, "MilkTeaName");
            txtMilkTeaQuantity.DataBindings.Add("Text", list, "Quantity");
            txtMilkTeaPrice.DataBindings.Add("Text", list, "Price");
            //txtCategory.DataBindings.Add("Text", list, "CategoryName");
            txtMilkTeaID.Enabled = false;
            dgvMilkTea.DataSource = list;

        }
        private void adminFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addMilkTeaFrm add = new addMilkTeaFrm();
            add.ShowDialog();
        }

        private void dgvMilkTea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }   
    
}
