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
        MilkTeaDAO daoMT = new MilkTeaDAO();
        CategoryDAO daoCT = new CategoryDAO();
        List<MilkTeaDTO> list;
        List<CategoryDTO> listCategory;
        int index;
        int index2;
        public adminFrm()
        {
            InitializeComponent();
            daoMT = new MilkTeaDAO();
        }
        public adminFrm(string user)
        {
            InitializeComponent();
            lblHello.Text = "Hello " +  user;
        }
        public void LoadData()
        {
            listCategory = daoCT.GetListCategory();
            list = daoMT.GetListMilkTea();

            cboCategory.Items.Clear();
            foreach (CategoryDTO dto in listCategory)
            {
                cboCategory.Items.Add(new CategoryDTO(dto.CategoryID,dto.CategoryName));
            }
            //cboCategory.DataSource = listCategory;
            //cboCategory.DisplayMember = "CategoryID - CategoryName";
            
            dgvMilkTea.DataSource = list;
            dgvCategory.DataSource = listCategory;
            btnUpdate.Enabled = false;
        }
        private Boolean CheckDataToAdd()
        {
            MilkTeaDTO dto = daoMT.FindProduct(txtMilkTeaID.Text);
            if (dto != null)
            {
                error1.SetError(txtMilkTeaID, "ID is duplicate !");
                txtMilkTeaID.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtMilkTeaID.Text))
            {
                error1.SetError(txtMilkTeaID, "ID can't be blank !");
                txtMilkTeaID.Focus();
                return false;
            }
            else if (txtMilkTeaID.Text.Length > 50)
            {
                error1.SetError(txtMilkTeaID, "ID max length is 50!");
                txtMilkTeaID.Focus();
                return false;
            }
            else
            {
                error1.SetError(txtMilkTeaID, "");
            }

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
            string regexPrice = @"^\d+(.\d{1,2})?$";

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

            if (!Regex.IsMatch(txtMilkTeaPrice.Text, regexPrice))
            {
                error1.SetError(txtMilkTeaPrice, "Price only contains number characters");
                txtMilkTeaPrice.Focus();
                return false;
            }
            else
            {
                error1.SetError(txtMilkTeaPrice, "");
            }
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

            if (!Regex.IsMatch(txtMilkTeaQuantity.Text, regexQuantity))
            {
                error1.SetError(txtMilkTeaQuantity, "Quantity only contains number characters");
                txtMilkTeaQuantity.Focus();
                return false;
            }
            else
            {
                error1.SetError(txtMilkTeaQuantity, "");
            }
            if (string.IsNullOrEmpty(txtImage.Text))
            {
                error1.SetError(txtImage, "Image can't be blank !");
                txtImage.Focus();
                return false;
            }
            else if(txtImage.Text.Length > 500)
            {
                error1.SetError(txtImage, "Image max length is 500 !");
                return false;
            }
            else
            {
                error1.SetError(txtImage,"");
            }

            return true;
        }
        private Boolean CheckDataCategoryToAdd()
        {
            CategoryDTO dto = daoCT.FindCategory(txtCategoryID.Text);
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
        private Boolean CheckMilkTeaPrice()
        {
            
            return true;

        }
        private Boolean CheckDataToUpdate()
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
                error1.SetError(txtMilkTeaName, "");
            }
            string regexPrice = @"^\d+(.\d{1,2})?$";

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

            if (!Regex.IsMatch(txtMilkTeaPrice.Text, regexPrice))
            {
                error1.SetError(txtMilkTeaPrice, "Price only contains number characters");
                txtMilkTeaPrice.Focus();
                return false;
            }
            else
            {
                error1.SetError(txtMilkTeaPrice, "");
            }
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

            if (!Regex.IsMatch(txtMilkTeaQuantity.Text, regexQuantity))
            {
                error1.SetError(txtMilkTeaQuantity, "Quantity only contains number characters");
                txtMilkTeaQuantity.Focus();
                return false;
            }
            else
            {
                error1.SetError(txtMilkTeaQuantity, "");
            }
            if (string.IsNullOrEmpty(txtImage.Text))
            {
                error1.SetError(txtImage, "Image can't be blank !");
                txtImage.Focus();
                return false;
            }
            else if (txtImage.Text.Length > 500)
            {
                error1.SetError(txtImage, "Image max length is 500 !");
                return false;
            }
            else
            {
                error1.SetError(txtImage, "");
            }

            return true;
        }
        private void adminFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckDataToAdd())
            {
                CategoryDTO obj = (CategoryDTO)cboCategory.SelectedItem;
                MilkTeaDTO dto = new MilkTeaDTO
                {
                    MilkTeaID = txtMilkTeaID.Text,
                    MilkTeaName = txtMilkTeaName.Text,
                    Quantity = int.Parse(txtMilkTeaQuantity.Text),
                    Price = float.Parse(txtMilkTeaPrice.Text),
                    Category = obj.CategoryID,
                    Image = txtImage.Text
                };
                if (daoMT.AddNewMilkTea(dto))
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
            if (CheckDataToUpdate())
            {
                    CategoryDTO obj = (CategoryDTO)cboCategory.SelectedItem;
                    MilkTeaDTO dto = new MilkTeaDTO
                    {
                        MilkTeaID = txtMilkTeaID.Text,
                        MilkTeaName = txtMilkTeaName.Text,
                        Quantity = int.Parse(txtMilkTeaQuantity.Text),
                        Price = float.Parse(txtMilkTeaPrice.Text),
                        Category = obj.CategoryID,
                        Image = txtImage.Text
                    };
                    if (daoMT.Update(dto))
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
                MessageBox.Show("Please input the ID to Delete");
                return;
            }
            if (MessageBox.Show("Do you want to delete ", "Announce", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string ID = txtMilkTeaID.Text;
                if (daoMT.Delete(ID))
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

        private void dgvMilkTea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvMilkTea.CurrentCell == null ? -1 : dgvMilkTea.CurrentCell.RowIndex;
            if (index != -1)
            {
                txtMilkTeaID.Text = dgvMilkTea.Rows[index].Cells[0].Value.ToString();
                txtMilkTeaName.Text = dgvMilkTea.Rows[index].Cells[1].Value.ToString();
                txtMilkTeaPrice.Text = dgvMilkTea.Rows[index].Cells[2].Value.ToString();
                txtMilkTeaQuantity.Text = dgvMilkTea.Rows[index].Cells[3].Value.ToString();
                MilkTeaDTO obj = dgvMilkTea.Rows[index].DataBoundItem as MilkTeaDTO;
                listCategory = daoCT.GetListCategory();
                int i = 0;
                foreach (CategoryDTO dto in listCategory)
                {
                    if (dto.CategoryID.Equals(obj.Category))
                        cboCategory.SelectedIndex = i;
                    i++;
                }

                string cateID = daoMT.getCategoryIDByMilkTeaID(txtMilkTeaID.Text);
                cboCategory.SelectedItem = cateID;
                txtImage.Text = dgvMilkTea.Rows[index].Cells[5].Value.ToString();
                picbMilkTea.Image = Image.FromFile(txtImage.Text);
            }
            txtMilkTeaID.Enabled = false;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }
         
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picbMilkTea.Image = Image.FromFile(dlgOpen.FileName);
                txtImage.Text = dlgOpen.FileName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMilkTeaID.Text = "" ;
            txtMilkTeaName.Text = "" ;
            txtMilkTeaPrice.Text = "";
            txtMilkTeaQuantity.Text = "";
            txtImage.Text = "";
            
            txtMilkTeaID.Enabled = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                list = daoMT.SearchMilkTea(txtSearch.Text);
                dgvMilkTea.DataSource = list;
            }
            else
            {
                LoadData();
            }
        }

        private void dgvMilkTea_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index2 = dgvCategory.CurrentCell == null ? -1 : dgvCategory.CurrentCell.RowIndex;
            if(index2 != -1)
            {
                txtCategoryID.Text = dgvCategory.Rows[index2].Cells[0].Value.ToString();
                txtCategoryName.Text = dgvCategory.Rows[index2].Cells[1].Value.ToString();
            }
        }

        private void Category_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshCategory_Click(object sender, EventArgs e)
        {
            txtCategoryID.Text = "";
            txtCategoryName.Text = "";
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (CheckDataCategoryToAdd())
            {
                string CategoryID = txtCategoryID.Text;
                string CategoryName = txtCategoryName.Text;
                CategoryDTO dto = new CategoryDTO(CategoryID, CategoryName);
                if (daoCT.Add(dto))
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
            if (CheckDataToUpdate())
            {
                string CategoryID = txtCategoryID.Text;
                string CategoryName = txtCategoryName.Text;
                CategoryDTO dto = new CategoryDTO(CategoryID, CategoryName);
                if (daoCT.Update(dto))
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
                if (daoCT.Delete(ID))
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
    }
}
