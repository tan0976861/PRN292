using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRN292.DTO;
using PRN292.BUS;
namespace PRN292
{
    public partial class categoryFrm : Form
    {
        public categoryFrm()
        {
            InitializeComponent();
        }
        CategoryBUS busCT = new CategoryBUS();
        List<Category> listCategory;
        int index;
        public void LoadData()
        {
            listCategory = busCT.GetListCategory();
            dgvCategory.DataSource = listCategory;
        }
        private Boolean CheckDataCategoryToAdd()
        {
            Category dto = busCT.FindCategory(txtCategoryID.Text);
            if (dto != null)
            {
                error1.SetError(txtCategoryID, "ID is duplicate !");
                txtCategoryID.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtCategoryID.Text))
            {
                error1.SetError(txtCategoryID, "ID can't be blank !");
                txtCategoryID.Focus();
                return false;
            }
            else if (txtCategoryID.Text.Length > 50)
            {
                error1.SetError(txtCategoryID, "ID max length is 50!");
                txtCategoryID.Focus();
                return false;
            }
            else
            {
                error1.SetError(txtCategoryID, "");
            }

            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                error1.SetError(txtCategoryName, "Name can't be blank !");
                txtCategoryName.Focus();
                return false;
            }

            else if (txtCategoryName.Text.Length >= 50)
            {
                error1.SetError(txtCategoryName, "Name max length is 50!");
                txtCategoryName.Focus();
                return false;
            }
            else
            {
                error1.SetError(txtCategoryName, "");
            }
            return true;

        }
        private Boolean CheckDataCategoryToUpdate()
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                error1.SetError(txtCategoryName, "Name can't be blank !");
                txtCategoryName.Focus();
                return false;
            }

            else if (txtCategoryName.Text.Length >= 50)
            {
                error1.SetError(txtCategoryName, "Name max length is 50!");
                txtCategoryName.Focus();
                return false;
            }
            else
            {
                error1.SetError(txtCategoryName, "");
            }
            return true;

        }



        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (CheckDataCategoryToAdd())
            {
                string CategoryID = txtCategoryID.Text;
                string CategoryName = txtCategoryName.Text;
                Category dto = new Category(CategoryID, CategoryName);
                if (busCT.Add(dto))
                {
                    MessageBox.Show("Add success !!!");
                }
                else
                {
                    MessageBox.Show("Add fail !!!");
                }
                LoadData();
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (CheckDataCategoryToUpdate())
            {
                string CategoryID = txtCategoryID.Text;
                string CategoryName = txtCategoryName.Text;
                Category dto = new Category(CategoryID, CategoryName);
                if (busCT.Update(dto))
                {
                    MessageBox.Show("Update successfully.", "Announce", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail.", "Announce", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadData();
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryID.Text == "")
            {
                MessageBox.Show("Please input the ID to Delete");
                return;
            }
            if (MessageBox.Show("Do you want to delete ", "Announce", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string ID = txtCategoryID.Text;
                if (busCT.Delete(ID))
                {
                    LoadData();
                    Refresh();
                    MessageBox.Show("Delete success");
                }
                else
                {
                    MessageBox.Show("Delete fail!");
                }
            }
        }

        private void btnCloseCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvCategory.CurrentCell == null ? -1 : dgvCategory.CurrentCell.RowIndex;
            if (index != -1)
            {
                txtCategoryID.Text = dgvCategory.Rows[index].Cells[0].Value.ToString();
                txtCategoryName.Text = dgvCategory.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void btnRefreshCategory_Click(object sender, EventArgs e)
        {
            txtCategoryID.Text = "";
            txtCategoryName.Text = "";
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoryFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
