namespace HotelManage
{
    partial class fInHoaDon
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
            this.hoaDonLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoaDonLabel
            // 
            this.hoaDonLabel.AutoSize = true;
            this.hoaDonLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoaDonLabel.Location = new System.Drawing.Point(181, 112);
            this.hoaDonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hoaDonLabel.Name = "hoaDonLabel";
            this.hoaDonLabel.Size = new System.Drawing.Size(196, 22);
            this.hoaDonLabel.TabIndex = 15;
            this.hoaDonLabel.Text = "ĐANG IN HÓA ĐƠN...";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(232, 186);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 32);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Hủy";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // fInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(575, 292);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.hoaDonLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In hóa đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoaDonLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}