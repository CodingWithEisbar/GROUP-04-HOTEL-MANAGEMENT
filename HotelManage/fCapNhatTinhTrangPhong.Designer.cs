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
            this.capNhatDataGridView = new System.Windows.Forms.DataGridView();
            this.updateButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.roomIDTextbox = new System.Windows.Forms.TextBox();
            this.roomIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.capNhatDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButt
            // 
            this.backButt.Location = new System.Drawing.Point(8, 8);
            this.backButt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(89, 32);
            this.backButt.TabIndex = 4;
            this.backButt.Text = "Quay lại";
            this.backButt.UseVisualStyleBackColor = true;
            this.backButt.Click += new System.EventHandler(this.backButt_Click);
            // 
            // capNhatTinhTrangPhongLabel
            // 
            this.capNhatTinhTrangPhongLabel.AutoSize = true;
            this.capNhatTinhTrangPhongLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capNhatTinhTrangPhongLabel.Location = new System.Drawing.Point(148, 46);
            this.capNhatTinhTrangPhongLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.capNhatTinhTrangPhongLabel.Name = "capNhatTinhTrangPhongLabel";
            this.capNhatTinhTrangPhongLabel.Size = new System.Drawing.Size(302, 22);
            this.capNhatTinhTrangPhongLabel.TabIndex = 13;
            this.capNhatTinhTrangPhongLabel.Text = "CẬP NHẬT TÌNH TRẠNG PHÒNG";
            // 
            // capNhatDataGridView
            // 
            this.capNhatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.capNhatDataGridView.Location = new System.Drawing.Point(11, 123);
            this.capNhatDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.capNhatDataGridView.Name = "capNhatDataGridView";
            this.capNhatDataGridView.RowHeadersWidth = 62;
            this.capNhatDataGridView.RowTemplate.Height = 28;
            this.capNhatDataGridView.Size = new System.Drawing.Size(584, 199);
            this.capNhatDataGridView.TabIndex = 14;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(255, 335);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(89, 32);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Cập nhật";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(453, 82);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(89, 32);
            this.searchButton.TabIndex = 21;
            this.searchButton.Text = "Tìm";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // roomIDTextbox
            // 
            this.roomIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIDTextbox.Location = new System.Drawing.Point(101, 87);
            this.roomIDTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.roomIDTextbox.Name = "roomIDTextbox";
            this.roomIDTextbox.Size = new System.Drawing.Size(348, 23);
            this.roomIDTextbox.TabIndex = 20;
            // 
            // roomIDLabel
            // 
            this.roomIDLabel.AutoSize = true;
            this.roomIDLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIDLabel.Location = new System.Drawing.Point(23, 90);
            this.roomIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomIDLabel.Name = "roomIDLabel";
            this.roomIDLabel.Size = new System.Drawing.Size(74, 16);
            this.roomIDLabel.TabIndex = 19;
            this.roomIDLabel.Text = "Mã phòng:";
            // 
            // fCapNhatTinhTrangPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 387);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.roomIDTextbox);
            this.Controls.Add(this.roomIDLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.capNhatDataGridView);
            this.Controls.Add(this.capNhatTinhTrangPhongLabel);
            this.Controls.Add(this.backButt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fCapNhatTinhTrangPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật tình trạng phòng";
            ((System.ComponentModel.ISupportInitialize)(this.capNhatDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.Label capNhatTinhTrangPhongLabel;
        private System.Windows.Forms.DataGridView capNhatDataGridView;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox roomIDTextbox;
        private System.Windows.Forms.Label roomIDLabel;
    }
}