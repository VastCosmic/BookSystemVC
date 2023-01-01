namespace BookSystemVC
{
    partial class ChangePwdForm
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_pwd2 = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.lbl_pwd2 = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.txt_oldpwd = new System.Windows.Forms.TextBox();
            this.lbl_oldpwd = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_title.Location = new System.Drawing.Point(162, 21);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(110, 31);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "修改密码";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pwd2
            // 
            this.txt_pwd2.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_pwd2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_pwd2.Location = new System.Drawing.Point(130, 191);
            this.txt_pwd2.Name = "txt_pwd2";
            this.txt_pwd2.Size = new System.Drawing.Size(243, 34);
            this.txt_pwd2.TabIndex = 10;
            // 
            // txt_pwd
            // 
            this.txt_pwd.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_pwd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_pwd.Location = new System.Drawing.Point(130, 136);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(243, 34);
            this.txt_pwd.TabIndex = 9;
            // 
            // lbl_pwd2
            // 
            this.lbl_pwd2.AutoSize = true;
            this.lbl_pwd2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_pwd2.Location = new System.Drawing.Point(32, 194);
            this.lbl_pwd2.Name = "lbl_pwd2";
            this.lbl_pwd2.Size = new System.Drawing.Size(92, 27);
            this.lbl_pwd2.TabIndex = 8;
            this.lbl_pwd2.Text = "重复密码";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_pwd.Location = new System.Drawing.Point(52, 136);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(72, 27);
            this.lbl_pwd.TabIndex = 7;
            this.lbl_pwd.Text = "新密码";
            // 
            // txt_oldpwd
            // 
            this.txt_oldpwd.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_oldpwd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_oldpwd.Location = new System.Drawing.Point(130, 81);
            this.txt_oldpwd.Name = "txt_oldpwd";
            this.txt_oldpwd.Size = new System.Drawing.Size(243, 34);
            this.txt_oldpwd.TabIndex = 12;
            // 
            // lbl_oldpwd
            // 
            this.lbl_oldpwd.AutoSize = true;
            this.lbl_oldpwd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_oldpwd.Location = new System.Drawing.Point(52, 84);
            this.lbl_oldpwd.Name = "lbl_oldpwd";
            this.lbl_oldpwd.Size = new System.Drawing.Size(72, 27);
            this.lbl_oldpwd.TabIndex = 11;
            this.lbl_oldpwd.Text = "旧密码";
            // 
            // btn_change
            // 
            this.btn_change.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_change.FlatAppearance.BorderSize = 0;
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_change.Location = new System.Drawing.Point(0, 0);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(434, 80);
            this.btn_change.TabIndex = 13;
            this.btn_change.Text = "确定修改";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_change);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 80);
            this.panel1.TabIndex = 14;
            // 
            // ChangePwdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_oldpwd);
            this.Controls.Add(this.lbl_oldpwd);
            this.Controls.Add(this.txt_pwd2);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.lbl_pwd2);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ChangePwdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改密码";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_pwd2;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label lbl_pwd2;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.TextBox txt_oldpwd;
        private System.Windows.Forms.Label lbl_oldpwd;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Panel panel1;
    }
}