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
using System.Text.RegularExpressions;

namespace PRN292
{
    public partial class adminFrm : Form
    {
        MilkTeaDAO dao = new MilkTeaDAO();
        List<MilkTeaDTO> list;
        List<CategoryDTO> listCategory;
        int index;
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
            list = dao.GetListMilkTea();

           /* txtMilkTeaID.DataBindings.Clear();
            txtMilkTeaName.DataBindings.Clear();
            txtMilkTeaQuantity.DataBindings.Clear();
            txtMilkTeaPrice.DataBindings.Clear();

            txtMilkTeaID.DataBindings.Add("Text", list, "MilkTeaID");
            txtMilkTeaName.DataBindings.Add("Text", list, "MilkTeaName");
            txtMilkTeaQuantity.DataBindings.Add("Text", list, "Quantity");
            txtMilkTeaPrice.DataBindings.Add("Text", list, "Price");*/

            cboCategory.Items.Clear();
            foreach (CategoryDTO dto in listCategory)
            {
                cboCategory.Items.Add(new CategoryDTO(dto.CategoryID,dto.CategoryName));
            }
            //cboCategory.DataSource = listCategory;
            //cboCategory.DisplayMember = "CategoryID - CategoryName";
            

            txtMilkTeaID.Enabled = false;
            dgvMilkTea.DataSource = list;
        }
        private Boolean CheckMilkTeaName()
        {
            if (string.IsNullOrEmpty(txtMilkTeaName.Text))
            {
                error1.SetError(txtMilkTeaName, "Name can't be blank !");
                txtMilkTeaName.Focus();
                return false;
            }
            
            else if (txtMilkTeaName.Text.Length >= 50)
            {
                error1.SetError(txtMilkTeaName, "Name max length is 50!");
                txtMilkTeaName.Focus();
                return false;
            }
            else
            {
                error1.SetError(txtMilkTeaName,"");
            }
            return true;
        }
        private Boolean CheckMilkTeaQuantity()
        {
            string regexQuantity = @"^\d+$";

            if (string.IsNullOrEmpty(txtMilkTeaQuantity.Text))
            {
                error1.SetError(txtMilkTeaQuantity, "Quantity can't be blank !");
                txtMilkTeaQuantity.Focus();
                return false;
            }
            if (txtMilkTeaQuantity.Text.Length > 50)
            {
                error1.SetError(txtMilkTeaQuantity, "Quantity max length is 50!");
                txtMilkTeaQuantity.Focus();
                return false;
            }
            
            if(!Regex.IsMatch(txtMilkTeaQuantity.Text, regexQuantity))
            {
                error1.SetError(txtMilkTeaQuantity, "Quantity only contains number characters");
                txtMilkTeaQuantity.Focus();
                return false;
            }
            else
            {
                error1.SetError(txtMilkTeaQuantity, "");
            }

            
            return true;

        }
        private Boolean CheckMilkTeaPrice()
        {
            string regexQuantity = @"^\d+(.\d{1,2})?$";

            if (string.IsNullOrEmpty(txtMilkTeaPrice.Text))
            {
                error1.SetError(txtMilkTeaPrice, "Price can't be blank !");
                txtMilkTeaPrice.Focus();
                return false;
            }
            if (txtMilkTeaPrice.Text.Length > 50)
            {
                error1.SetError(txtMilkTeaPrice, "Price max length is 50!");
                txtMilkTeaPrice.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtMilkTeaPrice.Text, regexQuantity))
            {
                error1.SetError(txtMilkTeaPrice, "Price only contains number characters");
                txtMilkTeaPrice.Focus();
                return false;
            }
            else
            {
                error1.SetError(txtMilkTeaPrice, "");
            }
            return true;

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
            index = dgvMilkTea.CurrentCell == null ? -1 : dgvMilkTea.CurrentCell.RowIndex;
            if(index != -1)
            {
                txtMilkTeaID.Text = dgvMilkTea.Rows[index].Cells[0].Value.ToString();
                txtMilkTeaName.Text = dgvMilkTea.Rows[index].Cells[1].Value.ToString();
                txtMilkTeaQuantity.Text = dgvMilkTea.Rows[index].Cells[2].Value.ToString();
                txtMilkTeaPrice.Text = dgvMilkTea.Rows[index].Cells[3].Value.ToString();
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckMilkTeaName() && CheckMilkTeaQuantity() && CheckMilkTeaPrice())
            {
                    CategoryDTO obj = (CategoryDTO)cboCategory.SelectedItem;
                    MilkTeaDTO dto = new MilkTeaDTO
                    {
                        MilkTeaID = txtMilkTeaID.Text,
                        MilkTeaName = txtMilkTeaName.Text,
                        Quantity = int.Parse(txtMilkTeaQuantity.Text),
                        Price = float.Parse(txtMilkTeaPrice.Text),
                        Category = obj.CategoryID
                    };
                    if (dao.Update(dto))
                    {
                        MessageBox.Show("Update successfully.", "Announce", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadData();
            }
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

        private void dgvMilkTea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvMilkTea.CurrentCell == null ? -1 : dgvMilkTea.CurrentCell.RowIndex;
            if (index != -1)
            {
                txtMilkTeaID.Text = dgvMilkTea.Rows[index].Cells[0].Value.ToString();
                txtMilkTeaName.Text = dgvMilkTea.Rows[index].Cells[1].Value.ToString();
                txtMilkTeaQuantity.Text = dgvMilkTea.Rows[index].Cells[2].Value.ToString();
                MilkTeaDTO obj = dgvMilkTea.SelectedRows[0].DataBoundItem as MilkTeaDTO;
                listCategory = dao.GetListCategory();
                int i = 0;
                foreach (CategoryDTO dto in listCategory)
                {
                    if (dto.CategoryID.Equals(obj.Category))
                        cboCategory.SelectedIndex = i;
                    i++;
                }
                txtMilkTeaPrice.Text = dgvMilkTea.Rows[index].Cells[3].Value.ToString();
                string cateID = dao.getCategoryIDByMilkTeaID(txtMilkTeaID.Text);
                cboCategory.SelectedItem = cateID;
            }
        }


    }
}
