namespace HotelManage
{
    partial class fCapNhatTinhTrangPhong
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
            this.backButt = new System.Windows.Forms.Button();
            this.capNhatTinhTrangPhongLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButt
            // 
            this.backButt.Location = new System.Drawing.Point(12, 12);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(134, 49);
            this.backButt.TabIndex = 4;
            this.backButt.Text = "Quay lại";
            this.backButt.UseVisualStyleBackColor = true;
            this.backButt.Click += new System.EventHandler(this.backButt_Click);
            // 
            // capNhatTinhTrangPhongLabel
            // 
            this.capNhatTinhTrangPhongLabel.AutoSize = true;
            this.capNhatTinhTrangPhongLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capNhatTinhTrangPhongLabel.Location = new System.Drawing.Point(255, 76);
            this.capNhatTinhTrangPhongLabel.Name = "capNhatTinhTrangPhongLabel";
            this.capNhatTinhTrangPhongLabel.Size = new System.Drawing.Size(447, 33);
            this.capNhatTinhTrangPhongLabel.TabIndex = 13;
            this.capNhatTinhTrangPhongLabel.Text = "CẬP NHẬT TÌNH TRẠNG PHÒNG";
            // 
            // fCapNhatTinhTrangPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 456);
            this.Controls.Add(this.capNhatTinhTrangPhongLabel);
            this.Controls.Add(this.backButt);
            this.Name = "fCapNhatTinhTrangPhong";
            this.Text = "Cập nhật tình trạng phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.Label capNhatTinhTrangPhongLabel;
    }
}