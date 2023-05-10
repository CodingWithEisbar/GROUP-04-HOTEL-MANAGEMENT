
namespace HotelManage
{
    partial class BellmanDashboard
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.kiểmTraTìnhTrạngPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKíThôngTinVậnChuyểnHànhLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Text = "Kiểm tra trạng thái phòng";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip2.Text = "kiểm tra trạng thái phong";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiểmTraTìnhTrạngPhòngToolStripMenuItem,
            this.đăngKíThôngTinVậnChuyểnHànhLíToolStripMenuItem,
            this.dịchVụToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(600, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // kiểmTraTìnhTrạngPhòngToolStripMenuItem
            // 
            this.kiểmTraTìnhTrạngPhòngToolStripMenuItem.Name = "kiểmTraTìnhTrạngPhòngToolStripMenuItem";
            this.kiểmTraTìnhTrạngPhòngToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.kiểmTraTìnhTrạngPhòngToolStripMenuItem.Text = "Kiểm tra tình trạng phòng";
            this.kiểmTraTìnhTrạngPhòngToolStripMenuItem.Click += new System.EventHandler(this.kiểmTraTìnhTrạngPhòngToolStripMenuItem_Click);
            // 
            // đăngKíThôngTinVậnChuyểnHànhLíToolStripMenuItem
            // 
            this.đăngKíThôngTinVậnChuyểnHànhLíToolStripMenuItem.Name = "đăngKíThôngTinVậnChuyểnHànhLíToolStripMenuItem";
            this.đăngKíThôngTinVậnChuyểnHànhLíToolStripMenuItem.Size = new System.Drawing.Size(217, 20);
            this.đăngKíThôngTinVậnChuyểnHànhLíToolStripMenuItem.Text = "Đăng kí thông tin vận chuyển hành lí ";
            this.đăngKíThôngTinVậnChuyểnHànhLíToolStripMenuItem.Click += new System.EventHandler(this.đăngKíThôngTinVậnChuyểnHànhLíToolStripMenuItem_Click);
            // 
            // dịchVụToolStripMenuItem
            // 
            this.dịchVụToolStripMenuItem.Name = "dịchVụToolStripMenuItem";
            this.dịchVụToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.dịchVụToolStripMenuItem.Text = "Dịch vụ ";
            this.dịchVụToolStripMenuItem.Click += new System.EventHandler(this.dịchVụToolStripMenuItem_Click);
            // 
            // BellmanDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BellmanDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bellman Dashboard";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraTìnhTrạngPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKíThôngTinVậnChuyểnHànhLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dịchVụToolStripMenuItem;
    }
}