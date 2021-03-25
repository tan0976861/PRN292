using System;
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
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }

        private void mnuMilkTea_Click(object sender, EventArgs e)
        {
            milkteaFrm frm = new milkteaFrm();
            frm.Show();
        }

        private void mnuCategory_Click(object sender, EventArgs e)
        {
            categoryFrm frm = new categoryFrm();
            frm.Show();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {

        }

        private void mnuNhapHang_Click(object sender, EventArgs e)
        {
            hoaDonFrm HoaDonFrm = new hoaDonFrm();
            HoaDonFrm.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportFrm ReportFrm = new reportFrm();
            ReportFrm.ShowDialog();
        }

        private void mnuDanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void mnuBaoCaoSanPham_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuThongTin_Click(object sender, EventArgs e)
        {
            InfrormatonFrm infoFrm = new InfrormatonFrm();
            infoFrm.ShowDialog();

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginFrm loginFrm = new loginFrm();
            loginFrm.ShowDialog();
        }
    }
}
