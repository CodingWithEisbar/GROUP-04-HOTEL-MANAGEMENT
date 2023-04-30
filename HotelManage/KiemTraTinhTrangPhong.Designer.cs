
namespace HotelManage
{
    partial class KiemTraTinhTrangPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.timKiemPhongLabel = new System.Windows.Forms.Button();
            this.maPhongTextBox = new System.Windows.Forms.TextBox();
            this.kiemTraPhongLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timKiemPhongLabel);
            this.panel1.Controls.Add(this.maPhongTextBox);
            this.panel1.Controls.Add(this.kiemTraPhongLabel);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 57);
            this.panel1.TabIndex = 0;
            // 
            // timKiemPhongLabel
            // 
            this.timKiemPhongLabel.Location = new System.Drawing.Point(232, 13);
            this.timKiemPhongLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timKiemPhongLabel.Name = "timKiemPhongLabel";
            this.timKiemPhongLabel.Size = new System.Drawing.Size(56, 19);
            this.timKiemPhongLabel.TabIndex = 3;
            this.timKiemPhongLabel.Text = "Tìm";
            this.timKiemPhongLabel.UseVisualStyleBackColor = true;
            this.timKiemPhongLabel.Click += new System.EventHandler(this.button1_Click);
            // 
            // maPhongTextBox
            // 
            this.maPhongTextBox.Location = new System.Drawing.Point(136, 13);
            this.maPhongTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maPhongTextBox.Name = "maPhongTextBox";
            this.maPhongTextBox.Size = new System.Drawing.Size(76, 20);
            this.maPhongTextBox.TabIndex = 2;
            this.maPhongTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // kiemTraPhongLabel
            // 
            this.kiemTraPhongLabel.AutoSize = true;
            this.kiemTraPhongLabel.Location = new System.Drawing.Point(2, 15);
            this.kiemTraPhongLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kiemTraPhongLabel.Name = "kiemTraPhongLabel";
            this.kiemTraPhongLabel.Size = new System.Drawing.Size(128, 13);
            this.kiemTraPhongLabel.TabIndex = 1;
            this.kiemTraPhongLabel.Text = "Kiểm tra tình trạng phòng ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(372, 232);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 81);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // KiemTraTinhTrangPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 73);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KiemTraTinhTrangPhong";
            this.Text = "Kiểm tra tình trạng phòng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button timKiemPhongLabel;
        private System.Windows.Forms.TextBox maPhongTextBox;
        private System.Windows.Forms.Label kiemTraPhongLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}