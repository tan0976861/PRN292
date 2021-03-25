
namespace PRN292
{
    partial class categoryFrm
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
            this.btnRefreshCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCloseCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefreshCategory
            // 
            this.btnRefreshCategory.Location = new System.Drawing.Point(600, 28);
            this.btnRefreshCategory.Name = "btnRefreshCategory";
            this.btnRefreshCategory.Size = new System.Drawing.Size(72, 23);
            this.btnRefreshCategory.TabIndex = 53;
            this.btnRefreshCategory.Text = "Refresh";
            this.btnRefreshCategory.UseVisualStyleBackColor = true;
            this.btnRefreshCategory.Click += new System.EventHandler(this.btnRefreshCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(374, 28);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(186, 22);
            this.txtCategoryName.TabIndex = 52;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(78, 28);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(183, 22);
            this.txtCategoryID.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 50;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "ID";
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToResizeColumns = false;
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(-2, 176);
            this.dgvCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.Size = new System.Drawing.Size(822, 234);
            this.dgvCategory.TabIndex = 57;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            this.dgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellContentClick);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // btnCloseCategory
            // 
            this.btnCloseCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCloseCategory.Image = global::PRN292.Properties.Resources.S_Close_Xs_S_D_2x;
            this.btnCloseCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseCategory.Location = new System.Drawing.Point(694, 426);
            this.btnCloseCategory.Name = "btnCloseCategory";
            this.btnCloseCategory.Size = new System.Drawing.Size(126, 40);
            this.btnCloseCategory.TabIndex = 62;
            this.btnCloseCategory.Text = "Close";
            this.btnCloseCategory.UseVisualStyleBackColor = true;
            this.btnCloseCategory.Click += new System.EventHandler(this.btnCloseCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteCategory.Image = global::PRN292.Properties.Resources.SP_Delete_Sm_S_D;
            this.btnDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategory.Location = new System.Drawing.Point(455, 426);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(127, 40);
            this.btnDeleteCategory.TabIndex = 61;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateCategory.Image = global::PRN292.Properties.Resources.update;
            this.btnUpdateCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCategory.Location = new System.Drawing.Point(235, 426);
            this.btnUpdateCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(127, 40);
            this.btnUpdateCategory.TabIndex = 60;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddCategory.Image = global::PRN292.Properties.Resources.SP_Add_Sm_S_D_3to2x;
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(-2, 428);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(137, 38);
            this.btnAddCategory.TabIndex = 59;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // categoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(207)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(820, 479);
            this.ControlBox = false;
            this.Controls.Add(this.btnCloseCategory);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.btnRefreshCategory);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Name = "categoryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categoryFrm";
            this.Load += new System.EventHandler(this.categoryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Button btnCloseCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.ErrorProvider error1;
    }
}