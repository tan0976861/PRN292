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
        UserModel us ;
        UserDao dao;
        public loginFrm()
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

                User user = dao.CheckLogin(UserID, Password);

                if (user.RoleID.Equals("adminn"))
                {
                    adminFrm ad = new adminFrm(UserID);
                    DialogResult dialog = ad.ShowDialog();
                }
                else
                {
                    MessageBox.Show("a");
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
    }
}
