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
            this.roomIDLabel = new System.Windows.Forms.Label();
            this.backButt = new System.Windows.Forms.Button();
            this.roomIDTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // roomIDLabel
            // 
            this.roomIDLabel.AutoSize = true;
            this.roomIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIDLabel.Location = new System.Drawing.Point(51, 112);
            this.roomIDLabel.Name = "roomIDLabel";
            this.roomIDLabel.Size = new System.Drawing.Size(111, 25);
            this.roomIDLabel.TabIndex = 0;
            this.roomIDLabel.Text = "Mã phòng: ";
            // 
            // backButt
            // 
            this.backButt.Location = new System.Drawing.Point(12, 12);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(134, 50);
            this.backButt.TabIndex = 3;
            this.backButt.Text = "Quay lại";
            this.backButt.UseVisualStyleBackColor = true;
            // 
            // roomIDTextbox
            // 
            this.roomIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIDTextbox.Location = new System.Drawing.Point(168, 111);
            this.roomIDTextbox.Name = "roomIDTextbox";
            this.roomIDTextbox.Size = new System.Drawing.Size(423, 30);
            this.roomIDTextbox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(597, 101);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(134, 50);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Tìm";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(56, 184);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(845, 289);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // fXemDanhSachQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 545);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.roomIDTextbox);
            this.Controls.Add(this.backButt);
            this.Controls.Add(this.roomIDLabel);
            this.Name = "fXemDanhSachQuanLy";
            this.Text = "Xem danh sách quản lý khách sạn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomIDLabel;
        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.TextBox roomIDTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView listView1;
    }
}