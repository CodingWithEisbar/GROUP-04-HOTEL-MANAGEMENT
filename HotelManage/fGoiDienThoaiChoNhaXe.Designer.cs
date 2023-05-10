namespace HotelManage
{
    partial class fGoiDienThoaiChoNhaXe
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.callingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(295, 320);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(134, 49);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Kết thúc";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // callingLabel
            // 
            this.callingLabel.AutoSize = true;
            this.callingLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callingLabel.Location = new System.Drawing.Point(211, 138);
            this.callingLabel.Name = "callingLabel";
            this.callingLabel.Size = new System.Drawing.Size(356, 33);
            this.callingLabel.TabIndex = 14;
            this.callingLabel.Text = "Đang liên hệ với nhà xe...";
            // 
            // fGoiDienThoaiChoNhaXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 424);
            this.Controls.Add(this.callingLabel);
            this.Controls.Add(this.cancelButton);
            this.Name = "fGoiDienThoaiChoNhaXe";
            this.Text = "Điện thoại";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label callingLabel;
    }
}