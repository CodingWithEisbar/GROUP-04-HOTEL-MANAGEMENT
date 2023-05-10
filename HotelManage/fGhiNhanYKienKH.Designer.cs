namespace HotelManage
{
    partial class fGhiNhanYKienKH
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
            this.customerNameTextbox = new System.Windows.Forms.TextBox();
            this.customerFeedbackLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.sendFeedbackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(51, 67);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(117, 17);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Tên Khách hàng:";
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextbox.Location = new System.Drawing.Point(165, 64);
            this.customerNameTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Size = new System.Drawing.Size(241, 23);
            this.customerNameTextbox.TabIndex = 1;
            // 
            // customerFeedbackLabel
            // 
            this.customerFeedbackLabel.AutoSize = true;
            this.customerFeedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerFeedbackLabel.Location = new System.Drawing.Point(51, 108);
            this.customerFeedbackLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerFeedbackLabel.Name = "customerFeedbackLabel";
            this.customerFeedbackLabel.Size = new System.Drawing.Size(115, 17);
            this.customerFeedbackLabel.TabIndex = 2;
            this.customerFeedbackLabel.Text = "Ý kiến đóng góp:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(55, 135);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 92);
            this.textBox1.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(8, 6);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 34);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Quay lại";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // sendFeedbackButton
            // 
            this.sendFeedbackButton.Location = new System.Drawing.Point(178, 242);
            this.sendFeedbackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendFeedbackButton.Name = "sendFeedbackButton";
            this.sendFeedbackButton.Size = new System.Drawing.Size(91, 34);
            this.sendFeedbackButton.TabIndex = 4;
            this.sendFeedbackButton.Text = "Gửi";
            this.sendFeedbackButton.UseVisualStyleBackColor = true;
            this.sendFeedbackButton.Click += new System.EventHandler(this.sendFeedbackButton_Click);
            // 
            // fGhiNhanYKienKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 313);
            this.Controls.Add(this.sendFeedbackButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.customerFeedbackLabel);
            this.Controls.Add(this.customerNameTextbox);
            this.Controls.Add(this.customerNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fGhiNhanYKienKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ghi nhận ý kiến khách hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextbox;
        private System.Windows.Forms.Label customerFeedbackLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button sendFeedbackButton;
    }
}