
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
            this.txtHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHello
            // 
            this.txtHello.AutoSize = true;
            this.txtHello.Location = new System.Drawing.Point(492, 51);
            this.txtHello.Name = "txtHello";
            this.txtHello.Size = new System.Drawing.Size(0, 17);
            this.txtHello.TabIndex = 0;
            // 
            // adminFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHello);
            this.Name = "adminFrm";
            this.Text = "adminFrm";
            this.Load += new System.EventHandler(this.adminFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHello;
    }
}