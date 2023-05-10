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
            ((System.ComponentModel.ISupportInitialize)(this.capNhatDataGridView)).BeginInit();
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
            this.capNhatTinhTrangPhongLabel.Location = new System.Drawing.Point(243, 69);
            this.capNhatTinhTrangPhongLabel.Name = "capNhatTinhTrangPhongLabel";
            this.capNhatTinhTrangPhongLabel.Size = new System.Drawing.Size(447, 33);
            this.capNhatTinhTrangPhongLabel.TabIndex = 13;
            this.capNhatTinhTrangPhongLabel.Text = "CẬP NHẬT TÌNH TRẠNG PHÒNG";
            // 
            // capNhatDataGridView
            // 
            this.capNhatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.capNhatDataGridView.Location = new System.Drawing.Point(12, 117);
            this.capNhatDataGridView.Name = "capNhatDataGridView";
            this.capNhatDataGridView.RowHeadersWidth = 62;
            this.capNhatDataGridView.RowTemplate.Height = 28;
            this.capNhatDataGridView.Size = new System.Drawing.Size(868, 303);
            this.capNhatDataGridView.TabIndex = 14;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(381, 426);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(134, 49);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Cập nhật";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // fCapNhatTinhTrangPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 485);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.capNhatDataGridView);
            this.Controls.Add(this.capNhatTinhTrangPhongLabel);
            this.Controls.Add(this.backButt);
            this.Name = "fCapNhatTinhTrangPhong";
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
    }
}