namespace BookSystemVC
{
    partial class MainForm
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
            this.MainControl = new System.Windows.Forms.TabControl();
            this.PageMain = new System.Windows.Forms.TabPage();
            this.PageSearch = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.SearchContorl = new System.Windows.Forms.ComboBox();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.PageBookBorrow = new System.Windows.Forms.TabPage();
            this.btnBorrowSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblauth = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblBorrowIDInput = new System.Windows.Forms.Label();
            this.lblBorrowTitle = new System.Windows.Forms.Label();
            this.PageAccount = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.MainControl.SuspendLayout();
            this.PageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.PageBookBorrow.SuspendLayout();
            this.PageAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainControl
            // 
            this.MainControl.Controls.Add(this.PageMain);
            this.MainControl.Controls.Add(this.PageSearch);
            this.MainControl.Controls.Add(this.PageBookBorrow);
            this.MainControl.Controls.Add(this.PageAccount);
            this.MainControl.Location = new System.Drawing.Point(13, 13);
            this.MainControl.Name = "MainControl";
            this.MainControl.SelectedIndex = 0;
            this.MainControl.Size = new System.Drawing.Size(1159, 636);
            this.MainControl.TabIndex = 0;
            // 
            // PageMain
            // 
            this.PageMain.Location = new System.Drawing.Point(4, 30);
            this.PageMain.Name = "PageMain";
            this.PageMain.Size = new System.Drawing.Size(1151, 602);
            this.PageMain.TabIndex = 0;
            this.PageMain.Text = "主界面";
            this.PageMain.UseVisualStyleBackColor = true;
            // 
            // PageSearch
            // 
            this.PageSearch.Controls.Add(this.dataGridView);
            this.PageSearch.Controls.Add(this.btn_search);
            this.PageSearch.Controls.Add(this.txt_search);
            this.PageSearch.Controls.Add(this.SearchContorl);
            this.PageSearch.Controls.Add(this.lblSearchTitle);
            this.PageSearch.Location = new System.Drawing.Point(4, 30);
            this.PageSearch.Name = "PageSearch";
            this.PageSearch.Size = new System.Drawing.Size(1151, 602);
            this.PageSearch.TabIndex = 2;
            this.PageSearch.Text = "图书查询";
            this.PageSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(48, 140);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1043, 459);
            this.dataGridView.TabIndex = 16;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.Location = new System.Drawing.Point(846, 87);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(245, 47);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "检索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_search.Location = new System.Drawing.Point(348, 94);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(455, 34);
            this.txt_search.TabIndex = 2;
            // 
            // SearchContorl
            // 
            this.SearchContorl.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchContorl.FormattingEnabled = true;
            this.SearchContorl.Items.AddRange(new object[] {
            "按照书名查找",
            "按照类别查找",
            "按照作者查找",
            "按照书号查找"});
            this.SearchContorl.Location = new System.Drawing.Point(48, 93);
            this.SearchContorl.Name = "SearchContorl";
            this.SearchContorl.Size = new System.Drawing.Size(263, 35);
            this.SearchContorl.TabIndex = 1;
            this.SearchContorl.Text = "请选择查询方式";
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSearchTitle.Location = new System.Drawing.Point(447, 0);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(256, 75);
            this.lblSearchTitle.TabIndex = 0;
            this.lblSearchTitle.Text = "图书查询";
            // 
            // PageBookBorrow
            // 
            this.PageBookBorrow.Controls.Add(this.btnBorrowSearch);
            this.PageBookBorrow.Controls.Add(this.label5);
            this.PageBookBorrow.Controls.Add(this.label4);
            this.PageBookBorrow.Controls.Add(this.label3);
            this.PageBookBorrow.Controls.Add(this.label1);
            this.PageBookBorrow.Controls.Add(this.btnBorrow);
            this.PageBookBorrow.Controls.Add(this.btnReturn);
            this.PageBookBorrow.Controls.Add(this.lblstatus);
            this.PageBookBorrow.Controls.Add(this.lblauth);
            this.PageBookBorrow.Controls.Add(this.lblname);
            this.PageBookBorrow.Controls.Add(this.lblid);
            this.PageBookBorrow.Controls.Add(this.txtID);
            this.PageBookBorrow.Controls.Add(this.lblBorrowIDInput);
            this.PageBookBorrow.Controls.Add(this.lblBorrowTitle);
            this.PageBookBorrow.Location = new System.Drawing.Point(4, 30);
            this.PageBookBorrow.Name = "PageBookBorrow";
            this.PageBookBorrow.Size = new System.Drawing.Size(1151, 602);
            this.PageBookBorrow.TabIndex = 1;
            this.PageBookBorrow.Text = "图书借还";
            this.PageBookBorrow.UseVisualStyleBackColor = true;
            // 
            // btnBorrowSearch
            // 
            this.btnBorrowSearch.Location = new System.Drawing.Point(884, 152);
            this.btnBorrowSearch.Name = "btnBorrowSearch";
            this.btnBorrowSearch.Size = new System.Drawing.Size(127, 42);
            this.btnBorrowSearch.TabIndex = 14;
            this.btnBorrowSearch.Text = "检索";
            this.btnBorrowSearch.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(455, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "(请输入书号)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(455, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "(请输入书号)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(455, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "(请输入书号)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(455, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "(请输入书号)";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(636, 487);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(200, 80);
            this.btnBorrow.TabIndex = 9;
            this.btnBorrow.Text = "借阅";
            this.btnBorrow.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(315, 487);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 80);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "还书";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblstatus.Location = new System.Drawing.Point(344, 378);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(52, 27);
            this.lblstatus.TabIndex = 7;
            this.lblstatus.Text = "状态";
            // 
            // lblauth
            // 
            this.lblauth.AutoSize = true;
            this.lblauth.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblauth.Location = new System.Drawing.Point(344, 334);
            this.lblauth.Name = "lblauth";
            this.lblauth.Size = new System.Drawing.Size(52, 27);
            this.lblauth.TabIndex = 6;
            this.lblauth.Text = "作者";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblname.Location = new System.Drawing.Point(344, 290);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(52, 27);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "书名";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblid.Location = new System.Drawing.Point(344, 246);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(52, 27);
            this.lblid.TabIndex = 4;
            this.lblid.Text = "书号";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtID.Location = new System.Drawing.Point(329, 156);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(493, 34);
            this.txtID.TabIndex = 3;
            // 
            // lblBorrowIDInput
            // 
            this.lblBorrowIDInput.AutoSize = true;
            this.lblBorrowIDInput.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBorrowIDInput.Location = new System.Drawing.Point(173, 159);
            this.lblBorrowIDInput.Name = "lblBorrowIDInput";
            this.lblBorrowIDInput.Size = new System.Drawing.Size(132, 27);
            this.lblBorrowIDInput.TabIndex = 2;
            this.lblBorrowIDInput.Text = "请输入书号：";
            // 
            // lblBorrowTitle
            // 
            this.lblBorrowTitle.AutoSize = true;
            this.lblBorrowTitle.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBorrowTitle.Location = new System.Drawing.Point(447, 0);
            this.lblBorrowTitle.Name = "lblBorrowTitle";
            this.lblBorrowTitle.Size = new System.Drawing.Size(256, 75);
            this.lblBorrowTitle.TabIndex = 1;
            this.lblBorrowTitle.Text = "图书借还";
            // 
            // PageAccount
            // 
            this.PageAccount.Controls.Add(this.label2);
            this.PageAccount.Location = new System.Drawing.Point(4, 30);
            this.PageAccount.Name = "PageAccount";
            this.PageAccount.Size = new System.Drawing.Size(1151, 602);
            this.PageAccount.TabIndex = 3;
            this.PageAccount.Text = "账户管理";
            this.PageAccount.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(447, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 75);
            this.label2.TabIndex = 1;
            this.label2.Text = "账户管理";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.MainControl);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MainControl.ResumeLayout(false);
            this.PageSearch.ResumeLayout(false);
            this.PageSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.PageBookBorrow.ResumeLayout(false);
            this.PageBookBorrow.PerformLayout();
            this.PageAccount.ResumeLayout(false);
            this.PageAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainControl;
        private System.Windows.Forms.TabPage PageMain;
        private System.Windows.Forms.TabPage PageSearch;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.TabPage PageBookBorrow;
        private System.Windows.Forms.TabPage PageAccount;
        private System.Windows.Forms.ComboBox SearchContorl;    
        private System.Windows.Forms.Label lblBorrowTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBorrowIDInput;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblauth;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btnBorrowSearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}