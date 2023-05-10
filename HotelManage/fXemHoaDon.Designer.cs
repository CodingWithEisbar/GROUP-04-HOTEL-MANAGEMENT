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
            this.inHoaDonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButt
            // 
            this.backButt.Location = new System.Drawing.Point(8, 8);
            this.backButt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(89, 32);
            this.backButt.TabIndex = 7;
            this.backButt.Text = "Quay lại";
            this.backButt.UseVisualStyleBackColor = true;
            this.backButt.Click += new System.EventHandler(this.backButt_Click);
            // 
            // hoaDonLabel
            // 
            this.hoaDonLabel.AutoSize = true;
            this.hoaDonLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoaDonLabel.Location = new System.Drawing.Point(252, 49);
            this.hoaDonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hoaDonLabel.Name = "hoaDonLabel";
            this.hoaDonLabel.Size = new System.Drawing.Size(98, 22);
            this.hoaDonLabel.TabIndex = 14;
            this.hoaDonLabel.Text = "HÓA ĐƠN";
            // 
            // tenKhachHangLabel
            // 
            this.tenKhachHangLabel.AutoSize = true;
            this.tenKhachHangLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenKhachHangLabel.Location = new System.Drawing.Point(8, 97);
            this.tenKhachHangLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenKhachHangLabel.Name = "tenKhachHangLabel";
            this.tenKhachHangLabel.Size = new System.Drawing.Size(146, 16);
            this.tenKhachHangLabel.TabIndex = 15;
            this.tenKhachHangLabel.Text = "Nhập tên khách hàng:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(436, 89);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(89, 32);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "Tìm";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextbox.Location = new System.Drawing.Point(150, 96);
            this.customerNameTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Size = new System.Drawing.Size(283, 23);
            this.customerNameTextbox.TabIndex = 17;
            // 
            // hoaDonDataGridView
            // 
            this.hoaDonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoaDonDataGridView.Location = new System.Drawing.Point(8, 128);
            this.hoaDonDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hoaDonDataGridView.Name = "hoaDonDataGridView";
            this.hoaDonDataGridView.ReadOnly = true;
            this.hoaDonDataGridView.RowHeadersWidth = 62;
            this.hoaDonDataGridView.RowTemplate.Height = 28;
            this.hoaDonDataGridView.Size = new System.Drawing.Size(609, 203);
            this.hoaDonDataGridView.TabIndex = 19;
            // 
            // inHoaDonButton
            // 
            this.inHoaDonButton.Location = new System.Drawing.Point(527, 335);
            this.inHoaDonButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inHoaDonButton.Name = "inHoaDonButton";
            this.inHoaDonButton.Size = new System.Drawing.Size(89, 32);
            this.inHoaDonButton.TabIndex = 20;
            this.inHoaDonButton.Text = "In hóa đơn";
            this.inHoaDonButton.UseVisualStyleBackColor = true;
            this.inHoaDonButton.Click += new System.EventHandler(this.inHoaDonButton_Click);
            // 
            // fXemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(625, 372);
            this.Controls.Add(this.inHoaDonButton);
            this.Controls.Add(this.hoaDonDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.customerNameTextbox);
            this.Controls.Add(this.tenKhachHangLabel);
            this.Controls.Add(this.hoaDonLabel);
            this.Controls.Add(this.backButt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fXemHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button inHoaDonButton;
    }
}