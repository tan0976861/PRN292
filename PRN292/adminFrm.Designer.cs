
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
            this.dgvMilkTea = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMilkTeaID = new System.Windows.Forms.TextBox();
            this.txtMilkTeaName = new System.Windows.Forms.TextBox();
            this.txtMilkTeaQuantity = new System.Windows.Forms.TextBox();
            this.txtMilkTeaPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilkTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHello
            // 
            this.txtHello.Location = new System.Drawing.Point(0, 0);
            this.txtHello.Name = "txtHello";
            this.txtHello.Size = new System.Drawing.Size(100, 23);
            this.txtHello.TabIndex = 15;
            // 
            // dgvMilkTea
            // 
            this.dgvMilkTea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMilkTea.Location = new System.Drawing.Point(0, -1);
            this.dgvMilkTea.Name = "dgvMilkTea";
            this.dgvMilkTea.RowHeadersWidth = 51;
            this.dgvMilkTea.RowTemplate.Height = 24;
            this.dgvMilkTea.Size = new System.Drawing.Size(743, 538);
            this.dgvMilkTea.TabIndex = 1;
            this.dgvMilkTea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMilkTea_CellClick);
            this.dgvMilkTea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMilkTea_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(792, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(792, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(792, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(792, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Category";
            // 
            // txtMilkTeaID
            // 
            this.txtMilkTeaID.Location = new System.Drawing.Point(873, 35);
            this.txtMilkTeaID.Name = "txtMilkTeaID";
            this.txtMilkTeaID.Size = new System.Drawing.Size(247, 22);
            this.txtMilkTeaID.TabIndex = 7;
            // 
            // txtMilkTeaName
            // 
            this.txtMilkTeaName.Location = new System.Drawing.Point(873, 107);
            this.txtMilkTeaName.Name = "txtMilkTeaName";
            this.txtMilkTeaName.Size = new System.Drawing.Size(247, 22);
            this.txtMilkTeaName.TabIndex = 8;
            // 
            // txtMilkTeaQuantity
            // 
            this.txtMilkTeaQuantity.Location = new System.Drawing.Point(873, 178);
            this.txtMilkTeaQuantity.Name = "txtMilkTeaQuantity";
            this.txtMilkTeaQuantity.Size = new System.Drawing.Size(247, 22);
            this.txtMilkTeaQuantity.TabIndex = 9;
            // 
            // txtMilkTeaPrice
            // 
            this.txtMilkTeaPrice.Location = new System.Drawing.Point(873, 253);
            this.txtMilkTeaPrice.Name = "txtMilkTeaPrice";
            this.txtMilkTeaPrice.Size = new System.Drawing.Size(247, 22);
            this.txtMilkTeaPrice.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(795, 403);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1001, 403);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1195, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(844, 469);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(0, 17);
            this.lblHello.TabIndex = 16;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(873, 327);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(247, 24);
            this.cboCategory.TabIndex = 17;
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // error2
            // 
            this.error2.ContainerControl = this;
            // 
            // error3
            // 
            this.error3.ContainerControl = this;
            // 
            // adminFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 536);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblHello);
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
            this.Controls.Add(this.txtHello);
            this.Name = "adminFrm";
            this.Text = "adminFrm";
            this.Load += new System.EventHandler(this.adminFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilkTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHello;
        private System.Windows.Forms.DataGridView dgvMilkTea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMilkTeaID;
        private System.Windows.Forms.TextBox txtMilkTeaName;
        private System.Windows.Forms.TextBox txtMilkTeaQuantity;
        private System.Windows.Forms.TextBox txtMilkTeaPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.ErrorProvider error2;
        private System.Windows.Forms.ErrorProvider error3;
    }
}