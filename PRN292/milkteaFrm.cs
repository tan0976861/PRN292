using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using PRN292.BUS;
using PRN292.DTO;

namespace PRN292
{
    public partial class milkteaFrm : Form
    {
        MilkTeaBUS busMT = new MilkTeaBUS();
        CategoryBUS busCT = new CategoryBUS();
        List<MilkTea> list;
        List<Category> listCategory;
        int index;
        int index2;
        public milkteaFrm()
        {
            InitializeComponent();
            busMT = new MilkTeaBUS();
        }
        public milkteaFrm(string user)
        {
            InitializeComponent();
            lblHello.Text = "Hello " +  user;
        }
        public void LoadData()
        {
            listCategory = busCT.GetListCategory();
            list = busMT.GetListMilkTea();

            cboCategory.Items.Clear();
            foreach (Category dto in listCategory)
            {
                cboCategory.Items.Add(new Category(dto.CategoryID,dto.CategoryName));
            }
            //cboCategory.DataSource = listCategory;
            //cboCategory.DisplayMember = "CategoryID - CategoryName";
            
            dgvMilkTea.DataSource = list;
            btnUpdate.Enabled = false;
        }
        private Boolean CheckDataToAdd()
        {
            MilkTea dto = busMT.FindProduct(txtMilkTeaID.Text);
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
            else if (txtMilkTeaID.Text.Length > 5)
            {
                error1.SetError(txtMilkTeaID, "ID max length is 5!");
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
                Category obj = (Category)cboCategory.SelectedItem;
                MilkTea dto = new MilkTea
                {
                    MilkTeaID = txtMilkTeaID.Text,
                    MilkTeaName = txtMilkTeaName.Text,
                    Quantity = int.Parse(txtMilkTeaQuantity.Text),
                    Price = float.Parse(txtMilkTeaPrice.Text),
                    Category = obj.CategoryID,
                    Image = txtImage.Text
                };
                if (busMT.AddNewMilkTea(dto))
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
                    Category obj = (Category)cboCategory.SelectedItem;
                    MilkTea dto = new MilkTea
                    {
                        MilkTeaID = txtMilkTeaID.Text,
                        MilkTeaName = txtMilkTeaName.Text,
                        Quantity = int.Parse(txtMilkTeaQuantity.Text),
                        Price = float.Parse(txtMilkTeaPrice.Text),
                        Category = obj.CategoryID,
                        Image = txtImage.Text
                    };
                    if (busMT.Update(dto))
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
                if (busMT.Delete(ID))
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
                MilkTea obj = dgvMilkTea.Rows[index].DataBoundItem as MilkTea;
                listCategory = busCT.GetListCategory();
                int i = 0;
                foreach (Category dto in listCategory)
                {
                    if (dto.CategoryID.Equals(obj.Category))
                        cboCategory.SelectedIndex = i;
                    i++;
                }

                string cateID = busMT.getCategoryIDByMilkTeaID(txtMilkTeaID.Text);
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
                list = busMT.SearchMilkTea(txtSearch.Text);
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
        private void dgvMilkTea_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
