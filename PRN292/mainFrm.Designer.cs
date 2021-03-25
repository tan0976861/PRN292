
namespace PRN292
{
    partial class mainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMilkTea = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BillReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 551);
            this.panel1.TabIndex = 5;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(207)))), ((int)(((byte)(144)))));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.lậpPhiếuToolStripMenuItem,
            this.mnuThongTin,
            this.báoCáoToolStripMenuItem,
            this.mnuThoat});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(924, 28);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMilkTea,
            this.mnuCategory});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(82, 24);
            this.mnuDanhMuc.Text = "Manager";
            this.mnuDanhMuc.Click += new System.EventHandler(this.mnuDanhMuc_Click);
            // 
            // mnuMilkTea
            // 
            this.mnuMilkTea.Name = "mnuMilkTea";
            this.mnuMilkTea.Size = new System.Drawing.Size(152, 26);
            this.mnuMilkTea.Text = "MilkTea";
            this.mnuMilkTea.Click += new System.EventHandler(this.mnuMilkTea_Click);
            // 
            // mnuCategory
            // 
            this.mnuCategory.Name = "mnuCategory";
            this.mnuCategory.Size = new System.Drawing.Size(152, 26);
            this.mnuCategory.Text = "Category";
            this.mnuCategory.Click += new System.EventHandler(this.mnuCategory_Click);
            // 
            // lậpPhiếuToolStripMenuItem
            // 
            this.lậpPhiếuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReceipt});
            this.lậpPhiếuToolStripMenuItem.Name = "lậpPhiếuToolStripMenuItem";
            this.lậpPhiếuToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.lậpPhiếuToolStripMenuItem.Text = "Receipt";
            // 
            // mnuReceipt
            // 
            this.mnuReceipt.Name = "mnuReceipt";
            this.mnuReceipt.Size = new System.Drawing.Size(160, 26);
            this.mnuReceipt.Text = "Create Bill";
            this.mnuReceipt.Click += new System.EventHandler(this.mnuNhapHang_Click);
            // 
            // mnuThongTin
            // 
            this.mnuThongTin.Name = "mnuThongTin";
            this.mnuThongTin.Size = new System.Drawing.Size(101, 24);
            this.mnuThongTin.Text = "Information";
            this.mnuThongTin.Click += new System.EventHandler(this.mnuThongTin_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BillReport,
            this.mnuReportProduct});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.báoCáoToolStripMenuItem.Text = "Report";
            this.báoCáoToolStripMenuItem.Click += new System.EventHandler(this.báoCáoToolStripMenuItem_Click);
            // 
            // BillReport
            // 
            this.BillReport.Name = "BillReport";
            this.BillReport.Size = new System.Drawing.Size(143, 26);
            this.BillReport.Text = "Bill";
            this.BillReport.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // mnuReportProduct
            // 
            this.mnuReportProduct.Name = "mnuReportProduct";
            this.mnuReportProduct.Size = new System.Drawing.Size(143, 26);
            this.mnuReportProduct.Text = "Product";
            this.mnuReportProduct.Click += new System.EventHandler(this.mnuBaoCaoSanPham_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(61, 24);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PRN292.Properties.Resources.main3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(924, 551);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 579);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainFrm";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuMilkTea;
        private System.Windows.Forms.ToolStripMenuItem mnuCategory;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuReceipt;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTin;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BillReport;
        private System.Windows.Forms.ToolStripMenuItem mnuReportProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
    }
}