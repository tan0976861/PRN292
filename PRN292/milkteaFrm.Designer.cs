
namespace PRN292
{
    partial class milkteaFrm
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
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
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.picbMilkTea = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilkTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMilkTea)).BeginInit();
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
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(92, 266);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(247, 22);
            this.txtSearch.TabIndex = 56;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(749, 80);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 23);
            this.btnRefresh.TabIndex = 48;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddImage.Location = new System.Drawing.Point(868, 80);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(82, 74);
            this.btnAddImage.TabIndex = 49;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(474, 190);
            this.txtImage.Margin = new System.Windows.Forms.Padding(4);
            this.txtImage.Multiline = true;
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(247, 48);
            this.txtImage.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Image";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(474, 137);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(247, 24);
            this.cboCategory.TabIndex = 46;
            // 
            // txtMilkTeaPrice
            // 
            this.txtMilkTeaPrice.Location = new System.Drawing.Point(92, 193);
            this.txtMilkTeaPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMilkTeaPrice.Name = "txtMilkTeaPrice";
            this.txtMilkTeaPrice.Size = new System.Drawing.Size(247, 22);
            this.txtMilkTeaPrice.TabIndex = 44;
            // 
            // txtMilkTeaQuantity
            // 
            this.txtMilkTeaQuantity.Location = new System.Drawing.Point(474, 82);
            this.txtMilkTeaQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMilkTeaQuantity.Name = "txtMilkTeaQuantity";
            this.txtMilkTeaQuantity.Size = new System.Drawing.Size(247, 22);
            this.txtMilkTeaQuantity.TabIndex = 45;
            // 
            // txtMilkTeaName
            // 
            this.txtMilkTeaName.Location = new System.Drawing.Point(92, 137);
            this.txtMilkTeaName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMilkTeaName.Name = "txtMilkTeaName";
            this.txtMilkTeaName.Size = new System.Drawing.Size(247, 22);
            this.txtMilkTeaName.TabIndex = 43;
            // 
            // txtMilkTeaID
            // 
            this.txtMilkTeaID.Location = new System.Drawing.Point(92, 82);
            this.txtMilkTeaID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMilkTeaID.Name = "txtMilkTeaID";
            this.txtMilkTeaID.Size = new System.Drawing.Size(247, 22);
            this.txtMilkTeaID.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID";
            // 
            // dgvMilkTea
            // 
            this.dgvMilkTea.AllowUserToAddRows = false;
            this.dgvMilkTea.AllowUserToResizeColumns = false;
            this.dgvMilkTea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMilkTea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMilkTea.Location = new System.Drawing.Point(5, 293);
            this.dgvMilkTea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMilkTea.Name = "dgvMilkTea";
            this.dgvMilkTea.RowHeadersWidth = 51;
            this.dgvMilkTea.RowTemplate.Height = 24;
            this.dgvMilkTea.Size = new System.Drawing.Size(1373, 234);
            this.dgvMilkTea.TabIndex = 36;
            this.dgvMilkTea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMilkTea_CellClick);
            this.dgvMilkTea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMilkTea_CellContentClick_2);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "Search";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.Image = global::PRN292.Properties.Resources.S_Close_Xs_S_D_2x;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1011, 530);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 39);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picbMilkTea
            // 
            this.picbMilkTea.Location = new System.Drawing.Point(1011, 80);
            this.picbMilkTea.Name = "picbMilkTea";
            this.picbMilkTea.Size = new System.Drawing.Size(245, 158);
            this.picbMilkTea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbMilkTea.TabIndex = 54;
            this.picbMilkTea.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Image = global::PRN292.Properties.Resources.SP_Delete_Sm_S_D;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(723, 531);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 39);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Image = global::PRN292.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(327, 531);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(210, 39);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Image = global::PRN292.Properties.Resources.SP_Add_Sm_S_D_3to2x;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(92, 531);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 39);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // milkteaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(207)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1379, 601);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.picbMilkTea);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMilkTeaPrice);
            this.Controls.Add(this.txtMilkTeaQuantity);
            this.Controls.Add(this.txtMilkTeaName);
            this.Controls.Add(this.txtMilkTeaID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMilkTea);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHello);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "milkteaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MilkTeaManager";
            this.Load += new System.EventHandler(this.adminFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilkTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMilkTea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHello;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.PictureBox picbMilkTea;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.Label label8;
    }
}