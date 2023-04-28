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
            this.callTaxiLabel = new System.Windows.Forms.Label();
            this.taxiCompanyList = new System.Windows.Forms.ListView();
            this.backButt = new System.Windows.Forms.Button();
            this.callTaxiButt = new System.Windows.Forms.Button();
            this.sendMessageButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // callTaxiLabel
            // 
            this.callTaxiLabel.AutoSize = true;
            this.callTaxiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callTaxiLabel.Location = new System.Drawing.Point(200, 78);
            this.callTaxiLabel.Name = "callTaxiLabel";
            this.callTaxiLabel.Size = new System.Drawing.Size(514, 46);
            this.callTaxiLabel.TabIndex = 0;
            this.callTaxiLabel.Text = "DANH SÁCH CÁC NHÀ XE";
            // 
            // taxiCompanyList
            // 
            this.taxiCompanyList.HideSelection = false;
            this.taxiCompanyList.Location = new System.Drawing.Point(12, 143);
            this.taxiCompanyList.Name = "taxiCompanyList";
            this.taxiCompanyList.Size = new System.Drawing.Size(920, 300);
            this.taxiCompanyList.TabIndex = 1;
            this.taxiCompanyList.UseCompatibleStateImageBehavior = false;
            // 
            // backButt
            // 
            this.backButt.Location = new System.Drawing.Point(12, 12);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(134, 50);
            this.backButt.TabIndex = 2;
            this.backButt.Text = "Quay lại";
            this.backButt.UseVisualStyleBackColor = true;
            // 
            // callTaxiButt
            // 
            this.callTaxiButt.Location = new System.Drawing.Point(798, 470);
            this.callTaxiButt.Name = "callTaxiButt";
            this.callTaxiButt.Size = new System.Drawing.Size(134, 50);
            this.callTaxiButt.TabIndex = 3;
            this.callTaxiButt.Text = "Gọi";
            this.callTaxiButt.UseVisualStyleBackColor = true;
            // 
            // sendMessageButt
            // 
            this.sendMessageButt.Location = new System.Drawing.Point(658, 470);
            this.sendMessageButt.Name = "sendMessageButt";
            this.sendMessageButt.Size = new System.Drawing.Size(134, 50);
            this.sendMessageButt.TabIndex = 4;
            this.sendMessageButt.Text = "Nhắn tin";
            this.sendMessageButt.UseVisualStyleBackColor = true;
            // 
            // fGoiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 550);
            this.Controls.Add(this.sendMessageButt);
            this.Controls.Add(this.callTaxiButt);
            this.Controls.Add(this.backButt);
            this.Controls.Add(this.taxiCompanyList);
            this.Controls.Add(this.callTaxiLabel);
            this.Name = "fGoiXe";
            this.Text = "Gọi xe cho khách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label callTaxiLabel;
        private System.Windows.Forms.ListView taxiCompanyList;
        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.Button callTaxiButt;
        private System.Windows.Forms.Button sendMessageButt;
    }
}