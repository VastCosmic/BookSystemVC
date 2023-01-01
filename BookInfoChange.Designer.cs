namespace BookSystemVC
{
    partial class BookInfoChange
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
            this.txt_bookid = new System.Windows.Forms.TextBox();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.txt_bookname = new System.Windows.Forms.TextBox();
            this.txt_press = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.lbl_bookid = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_bookname = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_press = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_status = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_title.Location = new System.Drawing.Point(222, 19);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(191, 39);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "图书信息管理";
            // 
            // txt_bookid
            // 
            this.txt_bookid.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_bookid.Location = new System.Drawing.Point(127, 109);
            this.txt_bookid.Name = "txt_bookid";
            this.txt_bookid.Size = new System.Drawing.Size(146, 34);
            this.txt_bookid.TabIndex = 4;
            this.txt_bookid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bookid_KeyPress);
            // 
            // txt_category
            // 
            this.txt_category.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_category.Location = new System.Drawing.Point(127, 175);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(146, 34);
            this.txt_category.TabIndex = 5;
            // 
            // txt_bookname
            // 
            this.txt_bookname.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_bookname.Location = new System.Drawing.Point(127, 241);
            this.txt_bookname.Name = "txt_bookname";
            this.txt_bookname.Size = new System.Drawing.Size(146, 34);
            this.txt_bookname.TabIndex = 6;
            // 
            // txt_press
            // 
            this.txt_press.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_press.Location = new System.Drawing.Point(403, 175);
            this.txt_press.Name = "txt_press";
            this.txt_press.Size = new System.Drawing.Size(146, 34);
            this.txt_press.TabIndex = 11;
            // 
            // txt_author
            // 
            this.txt_author.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_author.Location = new System.Drawing.Point(403, 109);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(146, 34);
            this.txt_author.TabIndex = 10;
            // 
            // lbl_bookid
            // 
            this.lbl_bookid.AutoSize = true;
            this.lbl_bookid.Location = new System.Drawing.Point(69, 112);
            this.lbl_bookid.Name = "lbl_bookid";
            this.lbl_bookid.Size = new System.Drawing.Size(52, 27);
            this.lbl_bookid.TabIndex = 13;
            this.lbl_bookid.Text = "书号";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(69, 178);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(52, 27);
            this.lbl_category.TabIndex = 14;
            this.lbl_category.Text = "类别";
            // 
            // lbl_bookname
            // 
            this.lbl_bookname.AutoSize = true;
            this.lbl_bookname.Location = new System.Drawing.Point(69, 244);
            this.lbl_bookname.Name = "lbl_bookname";
            this.lbl_bookname.Size = new System.Drawing.Size(52, 27);
            this.lbl_bookname.TabIndex = 15;
            this.lbl_bookname.Text = "书名";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(305, 244);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(92, 27);
            this.lbl_status.TabIndex = 18;
            this.lbl_status.Text = "借还状态";
            // 
            // lbl_press
            // 
            this.lbl_press.AutoSize = true;
            this.lbl_press.Location = new System.Drawing.Point(325, 178);
            this.lbl_press.Name = "lbl_press";
            this.lbl_press.Size = new System.Drawing.Size(72, 27);
            this.lbl_press.TabIndex = 17;
            this.lbl_press.Text = "出版社";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Location = new System.Drawing.Point(345, 112);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(52, 27);
            this.lbl_author.TabIndex = 16;
            this.lbl_author.Text = "作者";
            // 
            // btn_add
            // 
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.Location = new System.Drawing.Point(0, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(634, 100);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_status.FormattingEnabled = true;
            this.txt_status.Items.AddRange(new object[] {
            "在馆",
            "外借"});
            this.txt_status.Location = new System.Drawing.Point(403, 240);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(146, 35);
            this.txt_status.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 100);
            this.panel1.TabIndex = 21;
            // 
            // BookInfoChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_press);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_bookname);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_bookid);
            this.Controls.Add(this.txt_press);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_bookname);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.txt_bookid);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "BookInfoChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图书信息管理";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_bookid;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.TextBox txt_bookname;
        private System.Windows.Forms.TextBox txt_press;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.Label lbl_bookid;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_bookname;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_press;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox txt_status;
        private System.Windows.Forms.Panel panel1;
    }
}