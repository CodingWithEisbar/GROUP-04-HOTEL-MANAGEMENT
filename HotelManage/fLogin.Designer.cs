﻿
using System;

namespace HotelManage
{
    partial class fLogin
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
            this.keToanCheckBox = new System.Windows.Forms.CheckBox();
            this.LeTanCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.keToanCheckBox);
            this.panel1.Controls.Add(this.LeTanCheckBox);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 323);
            this.panel1.TabIndex = 0;
            // 
            // keToanCheckBox
            // 
            this.keToanCheckBox.AutoSize = true;
            this.keToanCheckBox.Location = new System.Drawing.Point(108, 253);
            this.keToanCheckBox.Name = "keToanCheckBox";
            this.keToanCheckBox.Size = new System.Drawing.Size(90, 24);
            this.keToanCheckBox.TabIndex = 8;
            this.keToanCheckBox.Text = "Kế toán";
            this.keToanCheckBox.UseVisualStyleBackColor = true;
            // 
            // LeTanCheckBox
            // 
            this.LeTanCheckBox.AutoSize = true;
            this.LeTanCheckBox.Location = new System.Drawing.Point(108, 223);
            this.LeTanCheckBox.Name = "LeTanCheckBox";
            this.LeTanCheckBox.Size = new System.Drawing.Size(84, 24);
            this.LeTanCheckBox.TabIndex = 7;
            this.LeTanCheckBox.Text = "Lễ Tân";
            this.LeTanCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(108, 191);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Bellman";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vai trò";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(844, 280);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(118, 38);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(720, 280);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(118, 38);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.passwordTextBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 74);
            this.panel3.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(100, 17);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(844, 26);
            this.passwordTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userNameTextBox);
            this.panel2.Controls.Add(this.Username);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 74);
            this.panel2.TabIndex = 0;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(105, 17);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(838, 26);
            this.userNameTextBox.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(15, 17);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(83, 20);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 352);
            this.Controls.Add(this.panel1);
            this.Name = "fLogin";
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox LeTanCheckBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox keToanCheckBox;
    }
}