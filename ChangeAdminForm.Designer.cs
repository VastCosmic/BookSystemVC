namespace BookSystemVC
{
    partial class ChangeAdminForm
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
            this.btn_change = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_admin_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_change
            // 
            this.btn_change.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_change.Location = new System.Drawing.Point(219, 234);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(122, 40);
            this.btn_change.TabIndex = 13;
            this.btn_change.Text = "确定修改";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_id.Location = new System.Drawing.Point(130, 108);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(174, 34);
            this.txt_id.TabIndex = 11;
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_admin.Location = new System.Drawing.Point(52, 167);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(112, 27);
            this.lbl_admin.TabIndex = 10;
            this.lbl_admin.Text = "当前权限：";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_user.Location = new System.Drawing.Point(52, 111);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(72, 27);
            this.lbl_user.TabIndex = 9;
            this.lbl_user.Text = "学工号";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_title.Location = new System.Drawing.Point(136, 29);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(158, 31);
            this.lbl_title.TabIndex = 8;
            this.lbl_title.Text = "修改用户权限";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.Location = new System.Drawing.Point(94, 234);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(122, 40);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_admin_status
            // 
            this.lbl_admin_status.AutoSize = true;
            this.lbl_admin_status.Location = new System.Drawing.Point(156, 167);
            this.lbl_admin_status.Name = "lbl_admin_status";
            this.lbl_admin_status.Size = new System.Drawing.Size(148, 27);
            this.lbl_admin_status.TabIndex = 15;
            this.lbl_admin_status.Text = "(请输入学工号)";
            // 
            // ChangeAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.lbl_admin_status);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ChangeAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangeAdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_admin_status;
    }
}