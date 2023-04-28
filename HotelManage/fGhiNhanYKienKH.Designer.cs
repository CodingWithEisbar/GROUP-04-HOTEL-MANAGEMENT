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
            this.customerNameLabel.Location = new System.Drawing.Point(77, 103);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(164, 25);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Tên Khách hàng:";
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextbox.Location = new System.Drawing.Point(247, 98);
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Size = new System.Drawing.Size(360, 30);
            this.customerNameTextbox.TabIndex = 1;
            // 
            // customerFeedbackLabel
            // 
            this.customerFeedbackLabel.AutoSize = true;
            this.customerFeedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerFeedbackLabel.Location = new System.Drawing.Point(77, 166);
            this.customerFeedbackLabel.Name = "customerFeedbackLabel";
            this.customerFeedbackLabel.Size = new System.Drawing.Size(159, 25);
            this.customerFeedbackLabel.TabIndex = 2;
            this.customerFeedbackLabel.Text = "Ý kiến đóng góp:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(82, 207);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(525, 139);
            this.textBox1.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(137, 52);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Quay lại";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // sendFeedbackButton
            // 
            this.sendFeedbackButton.Location = new System.Drawing.Point(267, 373);
            this.sendFeedbackButton.Name = "sendFeedbackButton";
            this.sendFeedbackButton.Size = new System.Drawing.Size(137, 52);
            this.sendFeedbackButton.TabIndex = 5;
            this.sendFeedbackButton.Text = "Gửi";
            this.sendFeedbackButton.UseVisualStyleBackColor = true;
            // 
            // fGhiNhanYKienKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 482);
            this.Controls.Add(this.sendFeedbackButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.customerFeedbackLabel);
            this.Controls.Add(this.customerNameTextbox);
            this.Controls.Add(this.customerNameLabel);
            this.Name = "fGhiNhanYKienKH";
            this.Text = "fGhiNhanYKienKH";
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