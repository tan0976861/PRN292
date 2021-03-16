using MilkTea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN292
{
    public partial class addMilkTeaFrm : Form
    {
        public addMilkTeaFrm()
        {
            InitializeComponent();
            dao = new MilkTeaDAO();
            LoadData();
        }
        List<CategoryDTO> ListCategory;
        MilkTeaDAO dao;
        public void LoadData()
        {
            ListCategory = dao.GetListCategory();
            cboCategory.Items.Clear();
            foreach (CategoryDTO dto in ListCategory)
            {
                cboCategory.Items.Add(new CategoryDTO(dto.CategoryID, dto.CategoryName));
            }
            cboCategory.SelectedIndex = 0;
        }
        public Boolean checkData()
        {
            MilkTeaDTO dto = dao.FindProduct(txtMilkTeaID.Text);
            if(dto != null)
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
            else if(txtMilkTeaID.Text.Length > 50)
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
            else if(txtMilkTeaName.Text.Length > 50)
            {
                error1.SetError(txtMilkTeaName, "Name max length is 50!");
                txtMilkTeaName.Focus();
                return false;
            }
            else
            {
                error1.SetError(txtMilkTeaName, "");
            }

            string regexQuantity = @"^\d+$";

            if (string.IsNullOrEmpty(txtMilkTeaQuantity.Text))
            {
                error1.SetError(txtMilkTeaQuantity, "Quantity can't be blank !");
                txtMilkTeaQuantity.Focus();
                return false;
            }
            else if (txtMilkTeaQuantity.Text.Length > 50)
            {
                error1.SetError(txtMilkTeaQuantity, "Quantity max length is 50!");
                txtMilkTeaQuantity.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtMilkTeaQuantity.Text, regexQuantity))
            {
                error1.SetError(txtMilkTeaQuantity, "Quantity only contains number characters");
                txtMilkTeaQuantity.Focus();
                return false;
            }
            else
            {
                error1.SetError(txtMilkTeaQuantity, "");
            }

            string regexPrice = @"^\d+(.\d{1,2})?$";

            if (string.IsNullOrEmpty(txtMilkTeaPrice.Text))
            {
                error1.SetError(txtMilkTeaPrice, "Price can't be blank !");
                txtMilkTeaPrice.Focus();
                return false;
            }
            else if (txtMilkTeaPrice.Text.Length > 50)
            {
                error1.SetError(txtMilkTeaPrice, "Price max length is 50!");
                txtMilkTeaPrice.Focus();
                return false;
            }

            else if (!Regex.IsMatch(txtMilkTeaPrice.Text, regexPrice))
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
        private void addMilkTeaFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkData())
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
                if (dao.AddNewMilkTea(dto))
                {
                    MessageBox.Show("Add success !!!");
                }
                else
                {
                    MessageBox.Show("Add fail !!!");
                }
            }
        }

        private void txtMilkTeaID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminFrm ad = new adminFrm();
            ad.ShowDialog();
            this.Close();
        }
    }
}
