using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRN292.BUS;
namespace PRN292
{
    public partial class loginFrm : Form
    {
        UserBUS bus;
        public loginFrm()
        {
            InitializeComponent();
            bus = new UserBUS();
        }
        public loginFrm(string user)
        {
            InitializeComponent();
            bus = new UserBUS();
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
                string user = bus.Login(UserID, Password);
                if (user.Equals("fail"))
                {
                    MessageBox.Show("ID or Password is not correct");
                }
                else
                {
                    this.Hide();
                    mainFrm frm = new mainFrm();
                    frm.ShowDialog(); 
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show(error);
            }
        }
            


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
