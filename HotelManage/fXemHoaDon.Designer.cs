namespace HotelManage
{
    partial class fXemHoaDon
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
            this.hoaDonLabel = new System.Windows.Forms.Label();
            this.tenKhachHangLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.customerNameTextbox = new System.Windows.Forms.TextBox();
            this.hoaDonDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButt
            // 
            this.backButt.Location = new System.Drawing.Point(12, 12);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(134, 49);
            this.backButt.TabIndex = 7;
            this.backButt.Text = "Quay lại";
            this.backButt.UseVisualStyleBackColor = true;
            this.backButt.Click += new System.EventHandler(this.backButt_Click);
            // 
            // hoaDonLabel
            // 
            this.hoaDonLabel.AutoSize = true;
            this.hoaDonLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoaDonLabel.Location = new System.Drawing.Point(378, 75);
            this.hoaDonLabel.Name = "hoaDonLabel";
            this.hoaDonLabel.Size = new System.Drawing.Size(147, 33);
            this.hoaDonLabel.TabIndex = 14;
            this.hoaDonLabel.Text = "HÓA ĐƠN";
            // 
            // tenKhachHangLabel
            // 
            this.tenKhachHangLabel.AutoSize = true;
            this.tenKhachHangLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenKhachHangLabel.Location = new System.Drawing.Point(12, 149);
            this.tenKhachHangLabel.Name = "tenKhachHangLabel";
            this.tenKhachHangLabel.Size = new System.Drawing.Size(199, 23);
            this.tenKhachHangLabel.TabIndex = 15;
            this.tenKhachHangLabel.Text = "Nhập tên khách hàng:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(654, 137);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(134, 50);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "Tìm";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextbox.Location = new System.Drawing.Point(225, 147);
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Size = new System.Drawing.Size(423, 30);
            this.customerNameTextbox.TabIndex = 17;
            // 
            // hoaDonDataGridView
            // 
            this.hoaDonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoaDonDataGridView.Location = new System.Drawing.Point(12, 197);
            this.hoaDonDataGridView.Name = "hoaDonDataGridView";
            this.hoaDonDataGridView.RowHeadersWidth = 62;
            this.hoaDonDataGridView.RowTemplate.Height = 28;
            this.hoaDonDataGridView.Size = new System.Drawing.Size(913, 312);
            this.hoaDonDataGridView.TabIndex = 19;
            // 
            // fXemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(937, 521);
            this.Controls.Add(this.hoaDonDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.customerNameTextbox);
            this.Controls.Add(this.tenKhachHangLabel);
            this.Controls.Add(this.hoaDonLabel);
            this.Controls.Add(this.backButt);
            this.Name = "fXemHoaDon";
            this.Text = "Xem hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.Label hoaDonLabel;
        private System.Windows.Forms.Label tenKhachHangLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox customerNameTextbox;
        private System.Windows.Forms.DataGridView hoaDonDataGridView;
    }
}