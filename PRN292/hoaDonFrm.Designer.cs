
namespace PRN292
{
    partial class hoaDonFrm
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
            this.dgvListMonAn = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.PickerTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.nbDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMonAn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ThongtinQuan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbQuan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbDiscount)).BeginInit();
            this.ThongtinQuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListMonAn
            // 
            this.dgvListMonAn.AllowUserToAddRows = false;
            this.dgvListMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Delete});
            this.dgvListMonAn.Location = new System.Drawing.Point(34, 238);
            this.dgvListMonAn.Name = "dgvListMonAn";
            this.dgvListMonAn.RowHeadersWidth = 51;
            this.dgvListMonAn.RowTemplate.Height = 24;
            this.dgvListMonAn.Size = new System.Drawing.Size(1041, 251);
            this.dgvListMonAn.TabIndex = 19;
            this.dgvListMonAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListMonAn_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Milk Tea Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(61, 310);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(8, 8);
            this.dataGridView2.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnPayment);
            this.panel2.Controls.Add(this.btnAddFood);
            this.panel2.Location = new System.Drawing.Point(20, 495);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 113);
            this.panel2.TabIndex = 17;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(689, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(196, 68);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(381, 26);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(212, 68);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(66, 26);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(212, 68);
            this.btnAddFood.TabIndex = 4;
            this.btnAddFood.Text = "Add ";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TimePicker2);
            this.panel1.Controls.Add(this.PickerTime);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtBalance);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.txtPayment);
            this.panel1.Controls.Add(this.nbDiscount);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.s);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboMonAn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(34, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 151);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TimePicker2
            // 
            this.TimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker2.Location = new System.Drawing.Point(852, 12);
            this.TimePicker2.Name = "TimePicker2";
            this.TimePicker2.Size = new System.Drawing.Size(100, 22);
            this.TimePicker2.TabIndex = 18;
            // 
            // PickerTime
            // 
            this.PickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PickerTime.Location = new System.Drawing.Point(724, 12);
            this.PickerTime.Name = "PickerTime";
            this.PickerTime.Size = new System.Drawing.Size(112, 22);
            this.PickerTime.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(672, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Date:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(520, 108);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(146, 22);
            this.txtBalance.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Balance:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(170, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(239, 22);
            this.txtID.TabIndex = 13;
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(520, 80);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(146, 22);
            this.txtPayment.TabIndex = 12;
            // 
            // nbDiscount
            // 
            this.nbDiscount.Location = new System.Drawing.Point(522, 17);
            this.nbDiscount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nbDiscount.Name = "nbDiscount";
            this.nbDiscount.Size = new System.Drawing.Size(104, 22);
            this.nbDiscount.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(520, 51);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(146, 22);
            this.txtTotal.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Discount";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(170, 111);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(239, 22);
            this.txtQuantity.TabIndex = 10;
            this.txtQuantity.Text = "1";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(170, 78);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(239, 22);
            this.txtPrice.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Payment: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(34, 83);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(40, 17);
            this.s.TabIndex = 5;
            this.s.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // cboMonAn
            // 
            this.cboMonAn.FormattingEnabled = true;
            this.cboMonAn.Location = new System.Drawing.Point(170, 14);
            this.cboMonAn.Name = "cboMonAn";
            this.cboMonAn.Size = new System.Drawing.Size(239, 24);
            this.cboMonAn.TabIndex = 1;
            this.cboMonAn.Text = "Chọn Món";
            this.cboMonAn.SelectedIndexChanged += new System.EventHandler(this.cboMonAn_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách món: ";
            // 
            // ThongtinQuan
            // 
            this.ThongtinQuan.Controls.Add(this.label1);
            this.ThongtinQuan.Controls.Add(this.lbQuan);
            this.ThongtinQuan.Location = new System.Drawing.Point(228, 2);
            this.ThongtinQuan.Name = "ThongtinQuan";
            this.ThongtinQuan.Size = new System.Drawing.Size(789, 54);
            this.ThongtinQuan.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "152 Nguyễn Thị Định, p12,Quận 5, TP HCM.";
            // 
            // lbQuan
            // 
            this.lbQuan.AutoSize = true;
            this.lbQuan.Location = new System.Drawing.Point(307, 0);
            this.lbQuan.Name = "lbQuan";
            this.lbQuan.Size = new System.Drawing.Size(99, 17);
            this.lbQuan.TabIndex = 0;
            this.lbQuan.Text = "LTHM MilkTea";
            // 
            // hoaDonFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(207)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1094, 610);
            this.ControlBox = false;
            this.Controls.Add(this.dgvListMonAn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ThongtinQuan);
            this.Name = "hoaDonFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hoaDonFrm";
            this.Load += new System.EventHandler(this.hoaDonFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbDiscount)).EndInit();
            this.ThongtinQuan.ResumeLayout(false);
            this.ThongtinQuan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker TimePicker2;
        private System.Windows.Forms.DateTimePicker PickerTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.NumericUpDown nbDiscount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMonAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ThongtinQuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbQuan;
        private System.Windows.Forms.Button btnClose;
    }
}