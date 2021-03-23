
namespace PRN292
{
    partial class adminFrm
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
            this.components = new System.ComponentModel.Container();
            this.txtHello = new System.Windows.Forms.Label();
            this.lblHello = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MilkTea = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.picbMilkTea = new System.Windows.Forms.PictureBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMilkTeaPrice = new System.Windows.Forms.TextBox();
            this.txtMilkTeaQuantity = new System.Windows.Forms.TextBox();
            this.txtMilkTeaName = new System.Windows.Forms.TextBox();
            this.txtMilkTeaID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMilkTea = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.TabPage();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.btnRefreshCategory = new System.Windows.Forms.Button();
            this.btnCloseCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.MilkTea.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbMilkTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilkTea)).BeginInit();
            this.Category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHello
            // 
            this.txtHello.Location = new System.Drawing.Point(0, 0);
            this.txtHello.Name = "txtHello";
            this.txtHello.Size = new System.Drawing.Size(100, 23);
            this.txtHello.TabIndex = 15;
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(844, 469);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(0, 17);
            this.lblHello.TabIndex = 16;
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // MilkTea
            // 
            this.MilkTea.Controls.Add(this.tabPage1);
            this.MilkTea.Controls.Add(this.Category);
            this.MilkTea.Location = new System.Drawing.Point(4, 49);
            this.MilkTea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MilkTea.Name = "MilkTea";
            this.MilkTea.SelectedIndex = 0;
            this.MilkTea.Size = new System.Drawing.Size(1379, 629);
            this.MilkTea.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnAddImage);
            this.tabPage1.Controls.Add(this.picbMilkTea);
            this.tabPage1.Controls.Add(this.txtImage);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cboCategory);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txtMilkTeaPrice);
            this.tabPage1.Controls.Add(this.txtMilkTeaQuantity);
            this.tabPage1.Controls.Add(this.txtMilkTeaName);
            this.tabPage1.Controls.Add(this.txtMilkTeaID);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvMilkTea);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1371, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MilkTea";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(83, 212);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(247, 22);
            this.txtSearch.TabIndex = 35;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(740, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 23);
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.Image = global::PRN292.Properties.Resources.S_Close_Xs_S_D_2x;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1002, 476);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 39);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddImage.Location = new System.Drawing.Point(859, 26);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(82, 74);
            this.btnAddImage.TabIndex = 30;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // picbMilkTea
            // 
            this.picbMilkTea.Location = new System.Drawing.Point(1002, 26);
            this.picbMilkTea.Name = "picbMilkTea";
            this.picbMilkTea.Size = new System.Drawing.Size(245, 158);
            this.picbMilkTea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbMilkTea.TabIndex = 34;
            this.picbMilkTea.TabStop = false;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(465, 136);
            this.txtImage.Margin = new System.Windows.Forms.Padding(4);
            this.txtImage.Multiline = true;
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(247, 48);
            this.txtImage.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Image";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(465, 83);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(247, 24);
            this.cboCategory.TabIndex = 27;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Image = global::PRN292.Properties.Resources.SP_Delete_Sm_S_D;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(714, 477);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 39);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Image = global::PRN292.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(362, 477);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(166, 39);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Image = global::PRN292.Properties.Resources.SP_Add_Sm_S_D_3to2x;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(83, 477);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 39);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMilkTeaPrice
            // 
            this.txtMilkTeaPrice.Location = new System.Drawing.Point(83, 139);
            this.txtMilkTeaPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMilkTeaPrice.Name = "txtMilkTeaPrice";
            this.txtMilkTeaPrice.Size = new System.Drawing.Size(247, 22);
            this.txtMilkTeaPrice.TabIndex = 25;
            // 
            // txtMilkTeaQuantity
            // 
            this.txtMilkTeaQuantity.Location = new System.Drawing.Point(465, 28);
            this.txtMilkTeaQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMilkTeaQuantity.Name = "txtMilkTeaQuantity";
            this.txtMilkTeaQuantity.Size = new System.Drawing.Size(247, 22);
            this.txtMilkTeaQuantity.TabIndex = 26;
            // 
            // txtMilkTeaName
            // 
            this.txtMilkTeaName.Location = new System.Drawing.Point(83, 83);
            this.txtMilkTeaName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMilkTeaName.Name = "txtMilkTeaName";
            this.txtMilkTeaName.Size = new System.Drawing.Size(247, 22);
            this.txtMilkTeaName.TabIndex = 24;
            // 
            // txtMilkTeaID
            // 
            this.txtMilkTeaID.Location = new System.Drawing.Point(83, 28);
            this.txtMilkTeaID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMilkTeaID.Name = "txtMilkTeaID";
            this.txtMilkTeaID.Size = new System.Drawing.Size(247, 22);
            this.txtMilkTeaID.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // dgvMilkTea
            // 
            this.dgvMilkTea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMilkTea.Location = new System.Drawing.Point(-4, 239);
            this.dgvMilkTea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMilkTea.Name = "dgvMilkTea";
            this.dgvMilkTea.RowHeadersWidth = 51;
            this.dgvMilkTea.RowTemplate.Height = 24;
            this.dgvMilkTea.Size = new System.Drawing.Size(1373, 234);
            this.dgvMilkTea.TabIndex = 2;
            this.dgvMilkTea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMilkTea_CellClick);
            this.dgvMilkTea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMilkTea_CellContentClick_1);
            // 
            // Category
            // 
            this.Category.BackColor = System.Drawing.Color.Gainsboro;
            this.Category.Controls.Add(this.txtSearchCategory);
            this.Category.Controls.Add(this.btnRefreshCategory);
            this.Category.Controls.Add(this.btnCloseCategory);
            this.Category.Controls.Add(this.btnDeleteCategory);
            this.Category.Controls.Add(this.btnUpdateCategory);
            this.Category.Controls.Add(this.btnAddCategory);
            this.Category.Controls.Add(this.txtCategoryName);
            this.Category.Controls.Add(this.txtCategoryID);
            this.Category.Controls.Add(this.label12);
            this.Category.Controls.Add(this.label13);
            this.Category.Controls.Add(this.dgvCategory);
            this.Category.Location = new System.Drawing.Point(4, 25);
            this.Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Category.Name = "Category";
            this.Category.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Category.Size = new System.Drawing.Size(1371, 600);
            this.Category.TabIndex = 1;
            this.Category.Text = "Category";
            this.Category.Click += new System.EventHandler(this.Category_Click);
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Location = new System.Drawing.Point(86, 216);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(247, 22);
            this.txtSearchCategory.TabIndex = 56;
            // 
            // btnRefreshCategory
            // 
            this.btnRefreshCategory.Location = new System.Drawing.Point(743, 30);
            this.btnRefreshCategory.Name = "btnRefreshCategory";
            this.btnRefreshCategory.Size = new System.Drawing.Size(72, 23);
            this.btnRefreshCategory.TabIndex = 48;
            this.btnRefreshCategory.Text = "Refresh";
            this.btnRefreshCategory.UseVisualStyleBackColor = true;
            this.btnRefreshCategory.Click += new System.EventHandler(this.btnRefreshCategory_Click);
            // 
            // btnCloseCategory
            // 
            this.btnCloseCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCloseCategory.Image = global::PRN292.Properties.Resources.S_Close_Xs_S_D_2x;
            this.btnCloseCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseCategory.Location = new System.Drawing.Point(1005, 480);
            this.btnCloseCategory.Name = "btnCloseCategory";
            this.btnCloseCategory.Size = new System.Drawing.Size(146, 39);
            this.btnCloseCategory.TabIndex = 55;
            this.btnCloseCategory.Text = "Close";
            this.btnCloseCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteCategory.Image = global::PRN292.Properties.Resources.SP_Delete_Sm_S_D;
            this.btnDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategory.Location = new System.Drawing.Point(717, 481);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(156, 39);
            this.btnDeleteCategory.TabIndex = 53;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateCategory.Image = global::PRN292.Properties.Resources.update;
            this.btnUpdateCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCategory.Location = new System.Drawing.Point(365, 481);
            this.btnUpdateCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(166, 39);
            this.btnUpdateCategory.TabIndex = 52;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddCategory.Image = global::PRN292.Properties.Resources.SP_Add_Sm_S_D_3to2x;
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(86, 481);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(163, 39);
            this.btnAddCategory.TabIndex = 50;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(418, 31);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(247, 22);
            this.txtCategoryName.TabIndex = 43;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(86, 32);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(247, 22);
            this.txtCategoryID.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "ID";
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(-1, 243);
            this.dgvCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.Size = new System.Drawing.Size(1373, 234);
            this.dgvCategory.TabIndex = 36;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            this.dgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(576, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 36);
            this.label6.TabIndex = 31;
            this.label6.Text = "Manager MilkTea";
            // 
            // adminFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 601);
            this.Controls.Add(this.MilkTea);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHello);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "adminFrm";
            this.Text = "adminFrm";
            this.Load += new System.EventHandler(this.adminFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.MilkTea.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbMilkTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilkTea)).EndInit();
            this.Category.ResumeLayout(false);
            this.Category.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHello;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.TabControl MilkTea;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMilkTeaPrice;
        private System.Windows.Forms.TextBox txtMilkTeaQuantity;
        private System.Windows.Forms.TextBox txtMilkTeaName;
        private System.Windows.Forms.TextBox txtMilkTeaID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMilkTea;
        private System.Windows.Forms.TabPage Category;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.PictureBox picbMilkTea;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.Button btnRefreshCategory;
        private System.Windows.Forms.Button btnCloseCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvCategory;
    }
}