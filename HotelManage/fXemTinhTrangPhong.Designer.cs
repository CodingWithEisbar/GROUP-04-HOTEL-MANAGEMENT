namespace HotelManage
{
    partial class fXemTinhTrangPhong
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
            this.searchButton = new System.Windows.Forms.Button();
            this.roomIDTextbox = new System.Windows.Forms.TextBox();
            this.backButt = new System.Windows.Forms.Button();
            this.roomIDLabel = new System.Windows.Forms.Label();
            this.tinhTrangPhongDataGridView = new System.Windows.Forms.DataGridView();
            this.xemTinhTrangPhongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangPhongDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(641, 124);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(134, 50);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Tìm";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // roomIDTextbox
            // 
            this.roomIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIDTextbox.Location = new System.Drawing.Point(212, 134);
            this.roomIDTextbox.Name = "roomIDTextbox";
            this.roomIDTextbox.Size = new System.Drawing.Size(423, 30);
            this.roomIDTextbox.TabIndex = 8;
            // 
            // backButt
            // 
            this.backButt.Location = new System.Drawing.Point(12, 12);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(134, 50);
            this.backButt.TabIndex = 7;
            this.backButt.Text = "Quay lại";
            this.backButt.UseVisualStyleBackColor = true;
            this.backButt.Click += new System.EventHandler(this.backButt_Click);
            // 
            // roomIDLabel
            // 
            this.roomIDLabel.AutoSize = true;
            this.roomIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIDLabel.Location = new System.Drawing.Point(95, 135);
            this.roomIDLabel.Name = "roomIDLabel";
            this.roomIDLabel.Size = new System.Drawing.Size(111, 25);
            this.roomIDLabel.TabIndex = 6;
            this.roomIDLabel.Text = "Mã phòng: ";
            // 
            // tinhTrangPhongDataGridView
            // 
            this.tinhTrangPhongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tinhTrangPhongDataGridView.Location = new System.Drawing.Point(12, 180);
            this.tinhTrangPhongDataGridView.Name = "tinhTrangPhongDataGridView";
            this.tinhTrangPhongDataGridView.RowHeadersWidth = 62;
            this.tinhTrangPhongDataGridView.RowTemplate.Height = 28;
            this.tinhTrangPhongDataGridView.Size = new System.Drawing.Size(919, 309);
            this.tinhTrangPhongDataGridView.TabIndex = 10;
            // 
            // xemTinhTrangPhongLabel
            // 
            this.xemTinhTrangPhongLabel.AutoSize = true;
            this.xemTinhTrangPhongLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xemTinhTrangPhongLabel.Location = new System.Drawing.Point(307, 70);
            this.xemTinhTrangPhongLabel.Name = "xemTinhTrangPhongLabel";
            this.xemTinhTrangPhongLabel.Size = new System.Drawing.Size(369, 33);
            this.xemTinhTrangPhongLabel.TabIndex = 12;
            this.xemTinhTrangPhongLabel.Text = "XEM TÌNH TRẠNG PHÒNG";
            // 
            // fXemTinhTrangPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 501);
            this.Controls.Add(this.xemTinhTrangPhongLabel);
            this.Controls.Add(this.tinhTrangPhongDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.roomIDTextbox);
            this.Controls.Add(this.backButt);
            this.Controls.Add(this.roomIDLabel);
            this.Name = "fXemTinhTrangPhong";
            this.Text = "Xem tình trạng phòng";
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangPhongDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox roomIDTextbox;
        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.Label roomIDLabel;
        private System.Windows.Forms.DataGridView tinhTrangPhongDataGridView;
        private System.Windows.Forms.Label xemTinhTrangPhongLabel;
    }
}