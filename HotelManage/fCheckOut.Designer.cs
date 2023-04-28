namespace HotelManage
{
    partial class fCheckOut
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
            this.xemDanhSachQuanLyButton = new System.Windows.Forms.Button();
            this.tinhTrangPhongButton = new System.Windows.Forms.Button();
            this.inHoaDonButton = new System.Windows.Forms.Button();
            this.capNhatTinhTrangPhongButton = new System.Windows.Forms.Button();
            this.ghiNhanYKienButton = new System.Windows.Forms.Button();
            this.goiXeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xemDanhSachQuanLyButton
            // 
            this.xemDanhSachQuanLyButton.Location = new System.Drawing.Point(256, 88);
            this.xemDanhSachQuanLyButton.Name = "xemDanhSachQuanLyButton";
            this.xemDanhSachQuanLyButton.Size = new System.Drawing.Size(607, 56);
            this.xemDanhSachQuanLyButton.TabIndex = 0;
            this.xemDanhSachQuanLyButton.Text = "Xem danh sách quản lý";
            this.xemDanhSachQuanLyButton.UseVisualStyleBackColor = true;
            // 
            // tinhTrangPhongButton
            // 
            this.tinhTrangPhongButton.Location = new System.Drawing.Point(256, 172);
            this.tinhTrangPhongButton.Name = "tinhTrangPhongButton";
            this.tinhTrangPhongButton.Size = new System.Drawing.Size(607, 56);
            this.tinhTrangPhongButton.TabIndex = 1;
            this.tinhTrangPhongButton.Text = "Xem tình trạng phòng";
            this.tinhTrangPhongButton.UseVisualStyleBackColor = true;
            // 
            // inHoaDonButton
            // 
            this.inHoaDonButton.Location = new System.Drawing.Point(256, 275);
            this.inHoaDonButton.Name = "inHoaDonButton";
            this.inHoaDonButton.Size = new System.Drawing.Size(607, 56);
            this.inHoaDonButton.TabIndex = 2;
            this.inHoaDonButton.Text = "In hóa đơn";
            this.inHoaDonButton.UseVisualStyleBackColor = true;
            // 
            // capNhatTinhTrangPhongButton
            // 
            this.capNhatTinhTrangPhongButton.Location = new System.Drawing.Point(256, 385);
            this.capNhatTinhTrangPhongButton.Name = "capNhatTinhTrangPhongButton";
            this.capNhatTinhTrangPhongButton.Size = new System.Drawing.Size(607, 56);
            this.capNhatTinhTrangPhongButton.TabIndex = 3;
            this.capNhatTinhTrangPhongButton.Text = "Cập nhật tình trạng phòng";
            this.capNhatTinhTrangPhongButton.UseVisualStyleBackColor = true;
            // 
            // ghiNhanYKienButton
            // 
            this.ghiNhanYKienButton.Location = new System.Drawing.Point(256, 480);
            this.ghiNhanYKienButton.Name = "ghiNhanYKienButton";
            this.ghiNhanYKienButton.Size = new System.Drawing.Size(607, 56);
            this.ghiNhanYKienButton.TabIndex = 4;
            this.ghiNhanYKienButton.Text = "Ghi nhận ý kiến khách hàng";
            this.ghiNhanYKienButton.UseVisualStyleBackColor = true;
            // 
            // goiXeButton
            // 
            this.goiXeButton.Location = new System.Drawing.Point(256, 570);
            this.goiXeButton.Name = "goiXeButton";
            this.goiXeButton.Size = new System.Drawing.Size(607, 56);
            this.goiXeButton.TabIndex = 5;
            this.goiXeButton.Text = "Gọi xe";
            this.goiXeButton.UseVisualStyleBackColor = true;
            // 
            // fCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 744);
            this.Controls.Add(this.goiXeButton);
            this.Controls.Add(this.ghiNhanYKienButton);
            this.Controls.Add(this.capNhatTinhTrangPhongButton);
            this.Controls.Add(this.inHoaDonButton);
            this.Controls.Add(this.tinhTrangPhongButton);
            this.Controls.Add(this.xemDanhSachQuanLyButton);
            this.Name = "fCheckOut";
            this.Text = "Check out";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button xemDanhSachQuanLyButton;
        private System.Windows.Forms.Button tinhTrangPhongButton;
        private System.Windows.Forms.Button inHoaDonButton;
        private System.Windows.Forms.Button capNhatTinhTrangPhongButton;
        private System.Windows.Forms.Button ghiNhanYKienButton;
        private System.Windows.Forms.Button goiXeButton;
    }
}