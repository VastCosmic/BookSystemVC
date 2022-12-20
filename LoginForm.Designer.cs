﻿namespace BookSystemVC
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_login_title = new System.Windows.Forms.Label();
            this.lbl_login_user = new System.Windows.Forms.Label();
            this.lbl_login_pwd = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_login_title
            // 
            this.lbl_login_title.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_login_title.Location = new System.Drawing.Point(12, 33);
            this.lbl_login_title.Name = "lbl_login_title";
            this.lbl_login_title.Size = new System.Drawing.Size(560, 38);
            this.lbl_login_title.TabIndex = 0;
            this.lbl_login_title.Text = "图书管理系统";
            this.lbl_login_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_login_user
            // 
            this.lbl_login_user.AutoSize = true;
            this.lbl_login_user.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_login_user.Location = new System.Drawing.Point(45, 123);
            this.lbl_login_user.Name = "lbl_login_user";
            this.lbl_login_user.Size = new System.Drawing.Size(90, 27);
            this.lbl_login_user.TabIndex = 1;
            this.lbl_login_user.Text = "用   户：";
            // 
            // lbl_login_pwd
            // 
            this.lbl_login_pwd.AutoSize = true;
            this.lbl_login_pwd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_login_pwd.Location = new System.Drawing.Point(48, 184);
            this.lbl_login_pwd.Name = "lbl_login_pwd";
            this.lbl_login_pwd.Size = new System.Drawing.Size(90, 27);
            this.lbl_login_pwd.TabIndex = 2;
            this.lbl_login_pwd.Text = "密   码：";
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.Location = new System.Drawing.Point(93, 273);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(200, 50);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.AutoSize = true;
            this.btn_signup.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_signup.Location = new System.Drawing.Point(292, 273);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(200, 50);
            this.btn_signup.TabIndex = 4;
            this.btn_signup.Text = "注册";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(188, 127);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(209, 29);
            this.txt_user.TabIndex = 5;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(188, 188);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(209, 29);
            this.txt_pwd.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 79);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_login_pwd);
            this.Controls.Add(this.lbl_login_user);
            this.Controls.Add(this.lbl_login_title);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login_title;
        private System.Windows.Forms.Label lbl_login_user;
        private System.Windows.Forms.Label lbl_login_pwd;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Button button1;
    }
}

