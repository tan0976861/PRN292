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
        List<CategoryDTO> listCategory;
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
            listCategory = dao.GetListCategory();
            list = dao.GetListMilkTea(listCategory);

            txtMilkTeaID.DataBindings.Clear();
            txtMilkTeaName.DataBindings.Clear();
            txtMilkTeaQuantity.DataBindings.Clear();
            txtMilkTeaName.DataBindings.Clear();

            txtMilkTeaID.DataBindings.Add("Text", list, "MilkTeaID");
            txtMilkTeaName.DataBindings.Add("Text", list, "MilkTeaName");
            txtMilkTeaQuantity.DataBindings.Add("Text", list, "Quantity");
            //txtMilkTeaPrice.DataBindings.Add("Text", list, "Price");
            
            cboCategory.Items.Clear();
            foreach (CategoryDTO dto in listCategory)
            {
                cboCategory.Items.Add(dto.CategoryName);
            }
            //cboCategory.DataSource = listCategory;
            //cboCategory.DisplayMember = "CategoryName";
            //foreach (CategoryDTO dto in listCategory)
            //{
            //    if(dto.CategoryName.Equals())
            //        cboCategory.SelectedItem = dto.CategoryName;
            //}

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMilkTeaID.Text == "")
            {
                MessageBox.Show("Please choose MilkTea you want to remove. ", "Announce", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Do you want to delete ?", "Announce", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string MilkTeaID = txtMilkTeaID.Text;
                dao.Delete(MilkTeaID);
                LoadData();
                MessageBox.Show("Delete successfully. ", "Announce", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }   
    
}
