namespace HotelManage
{
    partial class fXemDanhSachQuanLy
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
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.backButt = new System.Windows.Forms.Button();
            this.customerNameTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.danhSachQuanLyDataGridView = new System.Windows.Forms.DataGridView();
            this.xemTinhTrangPhongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachQuanLyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(19, 75);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(152, 17);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Nhập tên khách hàng: ";
            // 
            // backButt
            // 
            this.backButt.Location = new System.Drawing.Point(8, 8);
            this.backButt.Margin = new System.Windows.Forms.Padding(2);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(89, 32);
            this.backButt.TabIndex = 3;
            this.backButt.Text = "Quay lại";
            this.backButt.UseVisualStyleBackColor = true;
            this.backButt.Click += new System.EventHandler(this.backButt_Click);
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextbox.Location = new System.Drawing.Point(161, 75);
            this.customerNameTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Size = new System.Drawing.Size(283, 23);
            this.customerNameTextbox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(447, 69);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(89, 32);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Tìm";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // danhSachQuanLyDataGridView
            // 
            this.danhSachQuanLyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachQuanLyDataGridView.Location = new System.Drawing.Point(12, 114);
            this.danhSachQuanLyDataGridView.Name = "danhSachQuanLyDataGridView";
            this.danhSachQuanLyDataGridView.ReadOnly = true;
            this.danhSachQuanLyDataGridView.RowHeadersWidth = 62;
            this.danhSachQuanLyDataGridView.Size = new System.Drawing.Size(610, 228);
            this.danhSachQuanLyDataGridView.TabIndex = 6;
            // 
            // xemTinhTrangPhongLabel
            // 
            this.xemTinhTrangPhongLabel.AutoSize = true;
            this.xemTinhTrangPhongLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xemTinhTrangPhongLabel.Location = new System.Drawing.Point(108, 43);
            this.xemTinhTrangPhongLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xemTinhTrangPhongLabel.Name = "xemTinhTrangPhongLabel";
            this.xemTinhTrangPhongLabel.Size = new System.Drawing.Size(428, 22);
            this.xemTinhTrangPhongLabel.TabIndex = 13;
            this.xemTinhTrangPhongLabel.Text = "DANH SÁCH DỊCH VỤ KHÁCH HÀNG SỬ DỤNG";
            // 
            // fXemDanhSachQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(634, 354);
            this.Controls.Add(this.xemTinhTrangPhongLabel);
            this.Controls.Add(this.danhSachQuanLyDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.customerNameTextbox);
            this.Controls.Add(this.backButt);
            this.Controls.Add(this.customerNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fXemDanhSachQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem danh sách quản lý khách sạn";
            ((System.ComponentModel.ISupportInitialize)(this.danhSachQuanLyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.TextBox customerNameTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView danhSachQuanLyDataGridView;
        private System.Windows.Forms.Label xemTinhTrangPhongLabel;
    }
}