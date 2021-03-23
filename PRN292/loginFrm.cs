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
using DAL;
namespace PRN292
{
    public partial class loginFrm : Form
    {
        UserDao dao;
        public loginFrm()
        {
            InitializeComponent();
            dao = new UserDao();
        }
        public loginFrm(string user)
        {
            InitializeComponent();
            dao = new UserDao();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserID = txtUserID.Text;
            string Password = txtPassword.Text;
            string error = "";
            if (UserID.Length == 0)
            {
                error += "UserID can't be blank!\n";
            }
            if (Password.Length == 0)
            {
                error += "Password can't be blank!\n";
            }
            if (error.Equals(""))
            {

                string role = dao.CheckLogin(UserID, Password);
                if (role.Equals("fail"))
                    {
                    MessageBox.Show("ID or Password is not correct");
                }
                else
                {
                    if (role.Equals("AD"))
                    {
                        this.Hide();
                        adminFrm ad = new adminFrm(UserID);
                        DialogResult dialog = ad.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("a");
                    }
                }
                
            }
            else
            {
                MessageBox.Show(error);
            }
        }
            


        private void loginFrm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
