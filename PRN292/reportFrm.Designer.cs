
namespace PRN292
{
    partial class reportFrm
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
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListBill = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pickerFirstTime = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.pickerSecondTime = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(782, 514);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(161, 22);
            this.txtTongDoanhThu.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total revenue:";
            // 
            // dgvListBill
            // 
            this.dgvListBill.AllowUserToAddRows = false;
            this.dgvListBill.AllowUserToResizeColumns = false;
            this.dgvListBill.AllowUserToResizeRows = false;
            this.dgvListBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBill.Location = new System.Drawing.Point(185, 148);
            this.dgvListBill.Name = "dgvListBill";
            this.dgvListBill.ReadOnly = true;
            this.dgvListBill.RowHeadersWidth = 51;
            this.dgvListBill.RowTemplate.Height = 24;
            this.dgvListBill.Size = new System.Drawing.Size(758, 328);
            this.dgvListBill.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pickerFirstTime);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.pickerSecondTime);
            this.panel1.Location = new System.Drawing.Point(185, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 100);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "From";
            // 
            // pickerFirstTime
            // 
            this.pickerFirstTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerFirstTime.Location = new System.Drawing.Point(81, 45);
            this.pickerFirstTime.Name = "pickerFirstTime";
            this.pickerFirstTime.Size = new System.Drawing.Size(135, 22);
            this.pickerFirstTime.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(287, 32);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(187, 44);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Statistical";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // pickerSecondTime
            // 
            this.pickerSecondTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerSecondTime.Location = new System.Drawing.Point(537, 41);
            this.pickerSecondTime.Name = "pickerSecondTime";
            this.pickerSecondTime.Size = new System.Drawing.Size(119, 22);
            this.pickerSecondTime.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::PRN292.Properties.Resources.S_Close_Xs_S_D_2x1;
            this.btnClose.Location = new System.Drawing.Point(962, 498);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 55);
            this.btnClose.TabIndex = 15;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // reportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRN292.Properties.Resources._2_1;
            this.ClientSize = new System.Drawing.Size(1131, 571);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListBill);
            this.Controls.Add(this.panel1);
            this.Name = "reportFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.reportFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker pickerFirstTime;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker pickerSecondTime;
        private System.Windows.Forms.Button btnClose;
    }
}