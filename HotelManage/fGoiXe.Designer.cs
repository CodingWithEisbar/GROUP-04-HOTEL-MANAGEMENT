namespace HotelManage
{
    partial class fGoiXe
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
            this.callTaxiButt = new System.Windows.Forms.Button();
            this.danhSachCacNhaXeLabel = new System.Windows.Forms.Label();
            this.nhaXeDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nhaXeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButt
            // 
            this.backButt.Location = new System.Drawing.Point(8, 8);
            this.backButt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(89, 32);
            this.backButt.TabIndex = 2;
            this.backButt.Text = "Quay lại";
            this.backButt.UseVisualStyleBackColor = true;
            this.backButt.Click += new System.EventHandler(this.backButt_Click);
            // 
            // callTaxiButt
            // 
            this.callTaxiButt.Location = new System.Drawing.Point(532, 306);
            this.callTaxiButt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.callTaxiButt.Name = "callTaxiButt";
            this.callTaxiButt.Size = new System.Drawing.Size(89, 32);
            this.callTaxiButt.TabIndex = 3;
            this.callTaxiButt.Text = "Gọi";
            this.callTaxiButt.UseVisualStyleBackColor = true;
            this.callTaxiButt.Click += new System.EventHandler(this.callTaxiButt_Click);
            // 
            // danhSachCacNhaXeLabel
            // 
            this.danhSachCacNhaXeLabel.AutoSize = true;
            this.danhSachCacNhaXeLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSachCacNhaXeLabel.Location = new System.Drawing.Point(193, 46);
            this.danhSachCacNhaXeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.danhSachCacNhaXeLabel.Name = "danhSachCacNhaXeLabel";
            this.danhSachCacNhaXeLabel.Size = new System.Drawing.Size(242, 22);
            this.danhSachCacNhaXeLabel.TabIndex = 13;
            this.danhSachCacNhaXeLabel.Text = "DANH SÁCH CÁC NHÀ XE";
            // 
            // nhaXeDataGridView
            // 
            this.nhaXeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhaXeDataGridView.Location = new System.Drawing.Point(8, 72);
            this.nhaXeDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nhaXeDataGridView.Name = "nhaXeDataGridView";
            this.nhaXeDataGridView.ReadOnly = true;
            this.nhaXeDataGridView.RowHeadersWidth = 62;
            this.nhaXeDataGridView.RowTemplate.Height = 28;
            this.nhaXeDataGridView.Size = new System.Drawing.Size(613, 229);
            this.nhaXeDataGridView.TabIndex = 14;
            // 
            // fGoiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 358);
            this.Controls.Add(this.nhaXeDataGridView);
            this.Controls.Add(this.danhSachCacNhaXeLabel);
            this.Controls.Add(this.callTaxiButt);
            this.Controls.Add(this.backButt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fGoiXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gọi xe cho khách";
            ((System.ComponentModel.ISupportInitialize)(this.nhaXeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.Button callTaxiButt;
        private System.Windows.Forms.Label danhSachCacNhaXeLabel;
        private System.Windows.Forms.DataGridView nhaXeDataGridView;
    }
}