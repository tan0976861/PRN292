
namespace PRN292
{
    partial class addMilkTeaFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMilkTeaID = new System.Windows.Forms.TextBox();
            this.txtMilkTeaName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.errorMilkTeaID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMilkTeaName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorQuantity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorMilkTeaID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMilkTeaName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category";
            // 
            // txtMilkTeaID
            // 
            this.txtMilkTeaID.Location = new System.Drawing.Point(231, 52);
            this.txtMilkTeaID.Name = "txtMilkTeaID";
            this.txtMilkTeaID.Size = new System.Drawing.Size(287, 22);
            this.txtMilkTeaID.TabIndex = 5;
            // 
            // txtMilkTeaName
            // 
            this.txtMilkTeaName.Location = new System.Drawing.Point(231, 104);
            this.txtMilkTeaName.Name = "txtMilkTeaName";
            this.txtMilkTeaName.Size = new System.Drawing.Size(287, 22);
            this.txtMilkTeaName.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(231, 163);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(287, 22);
            this.txtQuantity.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(231, 226);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(287, 22);
            this.txtPrice.TabIndex = 8;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(231, 281);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(287, 22);
            this.txtCategory.TabIndex = 9;
            // 
            // errorMilkTeaID
            // 
            this.errorMilkTeaID.ContainerControl = this;
            // 
            // errorMilkTeaName
            // 
            this.errorMilkTeaName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorMilkTeaName.ContainerControl = this;
            // 
            // errorQuantity
            // 
            this.errorQuantity.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorQuantity.ContainerControl = this;
            // 
            // errorPrice
            // 
            this.errorPrice.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorPrice.ContainerControl = this;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(269, 351);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(487, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // addMilkTeaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 486);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtMilkTeaName);
            this.Controls.Add(this.txtMilkTeaID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addMilkTeaFrm";
            this.Text = "addMilkTeaFrm";
            ((System.ComponentModel.ISupportInitialize)(this.errorMilkTeaID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMilkTeaName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMilkTeaID;
        private System.Windows.Forms.TextBox txtMilkTeaName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.ErrorProvider errorMilkTeaID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorMilkTeaName;
        private System.Windows.Forms.ErrorProvider errorQuantity;
        private System.Windows.Forms.ErrorProvider errorPrice;
    }
}