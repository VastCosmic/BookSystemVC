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
            this.lbl_wel_user = new System.Windows.Forms.Label();
            this.lbl_wel = new System.Windows.Forms.Label();
            this.PageSearch = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.SearchContorl = new System.Windows.Forms.ComboBox();
            this.PageBookBorrow = new System.Windows.Forms.TabPage();
            this.panel_borrow = new System.Windows.Forms.Panel();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnBorrowSearch = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_BorrowTitle = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_bookname = new System.Windows.Forms.Label();
            this.lbl_bookid = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblauth = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblBorrowIDInput = new System.Windows.Forms.Label();
            this.PageAccount = new System.Windows.Forms.TabPage();
            this.dataGridViewAccount = new System.Windows.Forms.DataGridView();
            this.btn_changeAdmin = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_changePwd = new System.Windows.Forms.Button();
            this.btn_changeInfo = new System.Windows.Forms.Button();
            this.btn_record = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.PageBookAdmin = new System.Windows.Forms.TabPage();
            this.lbl_bookidAdmin = new System.Windows.Forms.Label();
            this.txt_bookidAdmin = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dataGridView_admin = new System.Windows.Forms.DataGridView();
            this.btn_delet_book = new System.Windows.Forms.Button();
            this.btn_change_book = new System.Windows.Forms.Button();
            this.btn_add_book = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_search = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_searchTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_accountTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_bookTitle = new System.Windows.Forms.Label();
            this.MainControl.SuspendLayout();
            this.PageMain.SuspendLayout();
            this.PageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.PageBookBorrow.SuspendLayout();
            this.panel_borrow.SuspendLayout();
            this.panel5.SuspendLayout();
            this.PageAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).BeginInit();
            this.PageBookAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).BeginInit();
            this.panel_search.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainControl
            // 
            this.MainControl.Controls.Add(this.PageMain);
            this.MainControl.Controls.Add(this.PageSearch);
            this.MainControl.Controls.Add(this.PageBookBorrow);
            this.MainControl.Controls.Add(this.PageAccount);
            this.MainControl.Controls.Add(this.PageBookAdmin);
            this.MainControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MainControl.Location = new System.Drawing.Point(13, 13);
            this.MainControl.Name = "MainControl";
            this.MainControl.SelectedIndex = 0;
            this.MainControl.Size = new System.Drawing.Size(1159, 686);
            this.MainControl.TabIndex = 0;
            this.MainControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MainControl_DrawItem);
            this.MainControl.SelectedIndexChanged += new System.EventHandler(this.MainControl_SelectedIndexChanged);
            this.MainControl.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.MainControl_Deselecting);
            // 
            // PageMain
            // 
            this.PageMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PageMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PageMain.Controls.Add(this.label3);
            this.PageMain.Controls.Add(this.label2);
            this.PageMain.Controls.Add(this.label1);
            this.PageMain.Controls.Add(this.lbl_wel_user);
            this.PageMain.Controls.Add(this.lbl_wel);
            this.PageMain.Location = new System.Drawing.Point(4, 30);
            this.PageMain.Name = "PageMain";
            this.PageMain.Size = new System.Drawing.Size(1151, 652);
            this.PageMain.TabIndex = 0;
            this.PageMain.Text = "主界面";
            // 
            // lbl_wel_user
            // 
            this.lbl_wel_user.AutoSize = true;
            this.lbl_wel_user.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_wel_user.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_wel_user.Location = new System.Drawing.Point(3, 0);
            this.lbl_wel_user.Name = "lbl_wel_user";
            this.lbl_wel_user.Size = new System.Drawing.Size(130, 64);
            this.lbl_wel_user.TabIndex = 1;
            this.lbl_wel_user.Text = "user";
            // 
            // lbl_wel
            // 
            this.lbl_wel.AutoSize = true;
            this.lbl_wel.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_wel.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_wel.Location = new System.Drawing.Point(279, 168);
            this.lbl_wel.Name = "lbl_wel";
            this.lbl_wel.Size = new System.Drawing.Size(592, 75);
            this.lbl_wel.TabIndex = 0;
            this.lbl_wel.Text = "欢迎使用图书管理系统";
            // 
            // PageSearch
            // 
            this.PageSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PageSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PageSearch.Controls.Add(this.panel_search);
            this.PageSearch.Controls.Add(this.dataGridView);
            this.PageSearch.Location = new System.Drawing.Point(4, 30);
            this.PageSearch.Name = "PageSearch";
            this.PageSearch.Size = new System.Drawing.Size(1151, 652);
            this.PageSearch.TabIndex = 2;
            this.PageSearch.Text = "图书查询";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(890, 652);
            this.dataGridView.TabIndex = 16;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_search.Location = new System.Drawing.Point(0, 547);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(250, 100);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "检索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.txt_search.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_search.Location = new System.Drawing.Point(0, 131);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(250, 39);
            this.txt_search.TabIndex = 2;
            // 
            // SearchContorl
            // 
            this.SearchContorl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SearchContorl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchContorl.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.SearchContorl.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchContorl.FormattingEnabled = true;
            this.SearchContorl.Items.AddRange(new object[] {
            "全部",
            "按照书名查找",
            "按照类别查找",
            "按照作者查找",
            "按照书号查找"});
            this.SearchContorl.Location = new System.Drawing.Point(0, 89);
            this.SearchContorl.Name = "SearchContorl";
            this.SearchContorl.Size = new System.Drawing.Size(250, 36);
            this.SearchContorl.TabIndex = 1;
            this.SearchContorl.Text = "请选择查询方式";
            // 
            // PageBookBorrow
            // 
            this.PageBookBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PageBookBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PageBookBorrow.Controls.Add(this.panel_borrow);
            this.PageBookBorrow.Controls.Add(this.lbl_status);
            this.PageBookBorrow.Controls.Add(this.lbl_author);
            this.PageBookBorrow.Controls.Add(this.lbl_bookname);
            this.PageBookBorrow.Controls.Add(this.lbl_bookid);
            this.PageBookBorrow.Controls.Add(this.lblstatus);
            this.PageBookBorrow.Controls.Add(this.lblauth);
            this.PageBookBorrow.Controls.Add(this.lblname);
            this.PageBookBorrow.Controls.Add(this.lblid);
            this.PageBookBorrow.Controls.Add(this.txtID);
            this.PageBookBorrow.Controls.Add(this.lblBorrowIDInput);
            this.PageBookBorrow.Location = new System.Drawing.Point(4, 30);
            this.PageBookBorrow.Name = "PageBookBorrow";
            this.PageBookBorrow.Size = new System.Drawing.Size(1151, 652);
            this.PageBookBorrow.TabIndex = 1;
            this.PageBookBorrow.Text = "图书借还";
            // 
            // panel_borrow
            // 
            this.panel_borrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_borrow.Controls.Add(this.btnBorrow);
            this.panel_borrow.Controls.Add(this.btnBorrowSearch);
            this.panel_borrow.Controls.Add(this.btnReturn);
            this.panel_borrow.Controls.Add(this.panel5);
            this.panel_borrow.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_borrow.Location = new System.Drawing.Point(901, 0);
            this.panel_borrow.Name = "panel_borrow";
            this.panel_borrow.Size = new System.Drawing.Size(250, 652);
            this.panel_borrow.TabIndex = 15;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Enabled = false;
            this.btnBorrow.FlatAppearance.BorderSize = 0;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBorrow.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBorrow.Location = new System.Drawing.Point(0, 549);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(250, 100);
            this.btnBorrow.TabIndex = 9;
            this.btnBorrow.Text = "借阅";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnBorrowSearch
            // 
            this.btnBorrowSearch.FlatAppearance.BorderSize = 0;
            this.btnBorrowSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowSearch.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBorrowSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBorrowSearch.Location = new System.Drawing.Point(0, 337);
            this.btnBorrowSearch.Name = "btnBorrowSearch";
            this.btnBorrowSearch.Size = new System.Drawing.Size(250, 100);
            this.btnBorrowSearch.TabIndex = 14;
            this.btnBorrowSearch.Text = "检索";
            this.btnBorrowSearch.UseVisualStyleBackColor = true;
            this.btnBorrowSearch.Click += new System.EventHandler(this.btnBorrowSearch_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Enabled = false;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReturn.Location = new System.Drawing.Point(0, 443);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(250, 100);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "还书";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.lbl_BorrowTitle);
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 80);
            this.panel5.TabIndex = 5;
            // 
            // lbl_BorrowTitle
            // 
            this.lbl_BorrowTitle.AutoSize = true;
            this.lbl_BorrowTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_BorrowTitle.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Bold);
            this.lbl_BorrowTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_BorrowTitle.Location = new System.Drawing.Point(4, 0);
            this.lbl_BorrowTitle.Name = "lbl_BorrowTitle";
            this.lbl_BorrowTitle.Size = new System.Drawing.Size(246, 72);
            this.lbl_BorrowTitle.TabIndex = 1;
            this.lbl_BorrowTitle.Text = "图书借还";
            this.lbl_BorrowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_status.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_status.Location = new System.Drawing.Point(557, 393);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(150, 31);
            this.lbl_status.TabIndex = 13;
            this.lbl_status.Text = "(请输入书号)";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_author.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_author.Location = new System.Drawing.Point(557, 349);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(150, 31);
            this.lbl_author.TabIndex = 12;
            this.lbl_author.Text = "(请输入书号)";
            // 
            // lbl_bookname
            // 
            this.lbl_bookname.AutoSize = true;
            this.lbl_bookname.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_bookname.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_bookname.Location = new System.Drawing.Point(557, 305);
            this.lbl_bookname.Name = "lbl_bookname";
            this.lbl_bookname.Size = new System.Drawing.Size(150, 31);
            this.lbl_bookname.TabIndex = 11;
            this.lbl_bookname.Text = "(请输入书号)";
            // 
            // lbl_bookid
            // 
            this.lbl_bookid.AutoSize = true;
            this.lbl_bookid.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_bookid.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_bookid.Location = new System.Drawing.Point(557, 261);
            this.lbl_bookid.Name = "lbl_bookid";
            this.lbl_bookid.Size = new System.Drawing.Size(150, 31);
            this.lbl_bookid.TabIndex = 10;
            this.lbl_bookid.Text = "(请输入书号)";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblstatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblstatus.Location = new System.Drawing.Point(465, 393);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(62, 31);
            this.lblstatus.TabIndex = 7;
            this.lblstatus.Text = "状态";
            // 
            // lblauth
            // 
            this.lblauth.AutoSize = true;
            this.lblauth.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblauth.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblauth.Location = new System.Drawing.Point(465, 349);
            this.lblauth.Name = "lblauth";
            this.lblauth.Size = new System.Drawing.Size(62, 31);
            this.lblauth.TabIndex = 6;
            this.lblauth.Text = "作者";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblname.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblname.Location = new System.Drawing.Point(465, 305);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(62, 31);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "书名";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblid.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblid.Location = new System.Drawing.Point(465, 261);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(62, 31);
            this.lblid.TabIndex = 4;
            this.lblid.Text = "书号";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtID.Location = new System.Drawing.Point(329, 122);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(493, 34);
            this.txtID.TabIndex = 3;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBorrowIDInput
            // 
            this.lblBorrowIDInput.AutoSize = true;
            this.lblBorrowIDInput.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBorrowIDInput.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBorrowIDInput.Location = new System.Drawing.Point(165, 121);
            this.lblBorrowIDInput.Name = "lblBorrowIDInput";
            this.lblBorrowIDInput.Size = new System.Drawing.Size(158, 31);
            this.lblBorrowIDInput.TabIndex = 2;
            this.lblBorrowIDInput.Text = "请输入书号：";
            // 
            // PageAccount
            // 
            this.PageAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PageAccount.Controls.Add(this.panel1);
            this.PageAccount.Controls.Add(this.dataGridViewAccount);
            this.PageAccount.Location = new System.Drawing.Point(4, 30);
            this.PageAccount.Name = "PageAccount";
            this.PageAccount.Size = new System.Drawing.Size(1151, 652);
            this.PageAccount.TabIndex = 3;
            this.PageAccount.Text = "账户管理";
            // 
            // dataGridViewAccount
            // 
            this.dataGridViewAccount.AllowUserToDeleteRows = false;
            this.dataGridViewAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridViewAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccount.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAccount.Name = "dataGridViewAccount";
            this.dataGridViewAccount.RowTemplate.Height = 23;
            this.dataGridViewAccount.Size = new System.Drawing.Size(792, 646);
            this.dataGridViewAccount.TabIndex = 9;
            // 
            // btn_changeAdmin
            // 
            this.btn_changeAdmin.Enabled = false;
            this.btn_changeAdmin.FlatAppearance.BorderSize = 0;
            this.btn_changeAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changeAdmin.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.btn_changeAdmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_changeAdmin.Location = new System.Drawing.Point(172, 301);
            this.btn_changeAdmin.Name = "btn_changeAdmin";
            this.btn_changeAdmin.Size = new System.Drawing.Size(175, 75);
            this.btn_changeAdmin.TabIndex = 8;
            this.btn_changeAdmin.Text = "修改权限";
            this.btn_changeAdmin.UseVisualStyleBackColor = true;
            this.btn_changeAdmin.Click += new System.EventHandler(this.btn_changeAdmin_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_logout.Location = new System.Drawing.Point(0, 524);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(350, 125);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = "退出登录";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_changePwd
            // 
            this.btn_changePwd.FlatAppearance.BorderSize = 0;
            this.btn_changePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changePwd.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.btn_changePwd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_changePwd.Location = new System.Drawing.Point(0, 301);
            this.btn_changePwd.Name = "btn_changePwd";
            this.btn_changePwd.Size = new System.Drawing.Size(175, 75);
            this.btn_changePwd.TabIndex = 6;
            this.btn_changePwd.Text = "修改密码";
            this.btn_changePwd.UseVisualStyleBackColor = true;
            this.btn_changePwd.Click += new System.EventHandler(this.btn_changePwd_Click);
            // 
            // btn_changeInfo
            // 
            this.btn_changeInfo.FlatAppearance.BorderSize = 0;
            this.btn_changeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changeInfo.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.btn_changeInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_changeInfo.Location = new System.Drawing.Point(0, 220);
            this.btn_changeInfo.Name = "btn_changeInfo";
            this.btn_changeInfo.Size = new System.Drawing.Size(175, 75);
            this.btn_changeInfo.TabIndex = 5;
            this.btn_changeInfo.Text = "修改信息";
            this.btn_changeInfo.UseVisualStyleBackColor = true;
            this.btn_changeInfo.Click += new System.EventHandler(this.btn_changeInfo_Click);
            // 
            // btn_record
            // 
            this.btn_record.FlatAppearance.BorderSize = 0;
            this.btn_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_record.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.btn_record.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_record.Location = new System.Drawing.Point(172, 220);
            this.btn_record.Name = "btn_record";
            this.btn_record.Size = new System.Drawing.Size(175, 75);
            this.btn_record.TabIndex = 4;
            this.btn_record.Text = "借书记录";
            this.btn_record.UseVisualStyleBackColor = true;
            this.btn_record.Click += new System.EventHandler(this.btn_record_Click);
            // 
            // btn_info
            // 
            this.btn_info.FlatAppearance.BorderSize = 0;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.btn_info.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_info.Location = new System.Drawing.Point(0, 89);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(350, 125);
            this.btn_info.TabIndex = 2;
            this.btn_info.Text = "账户信息";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // PageBookAdmin
            // 
            this.PageBookAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PageBookAdmin.Controls.Add(this.panel4);
            this.PageBookAdmin.Controls.Add(this.dataGridView_admin);
            this.PageBookAdmin.Location = new System.Drawing.Point(4, 30);
            this.PageBookAdmin.Name = "PageBookAdmin";
            this.PageBookAdmin.Size = new System.Drawing.Size(1151, 652);
            this.PageBookAdmin.TabIndex = 4;
            this.PageBookAdmin.Text = "图书管理";
            // 
            // lbl_bookidAdmin
            // 
            this.lbl_bookidAdmin.Enabled = false;
            this.lbl_bookidAdmin.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_bookidAdmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_bookidAdmin.Location = new System.Drawing.Point(0, 120);
            this.lbl_bookidAdmin.Name = "lbl_bookidAdmin";
            this.lbl_bookidAdmin.Size = new System.Drawing.Size(350, 27);
            this.lbl_bookidAdmin.TabIndex = 11;
            this.lbl_bookidAdmin.Text = "请输入需要修改或删除的图书书号";
            this.lbl_bookidAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_bookidAdmin
            // 
            this.txt_bookidAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_bookidAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bookidAdmin.Enabled = false;
            this.txt_bookidAdmin.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Bold);
            this.txt_bookidAdmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_bookidAdmin.Location = new System.Drawing.Point(0, 150);
            this.txt_bookidAdmin.Name = "txt_bookidAdmin";
            this.txt_bookidAdmin.Size = new System.Drawing.Size(350, 78);
            this.txt_bookidAdmin.TabIndex = 10;
            this.txt_bookidAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bookidAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bookidAdmin_KeyPress);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Enabled = false;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.btn_refresh.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_refresh.Location = new System.Drawing.Point(0, 552);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(350, 100);
            this.btn_refresh.TabIndex = 9;
            this.btn_refresh.Text = "刷新图书列表";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dataGridView_admin
            // 
            this.dataGridView_admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_admin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_admin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView_admin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_admin.Location = new System.Drawing.Point(3, 6);
            this.dataGridView_admin.Name = "dataGridView_admin";
            this.dataGridView_admin.RowTemplate.Height = 23;
            this.dataGridView_admin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_admin.Size = new System.Drawing.Size(792, 646);
            this.dataGridView_admin.TabIndex = 8;
            this.dataGridView_admin.Visible = false;
            // 
            // btn_delet_book
            // 
            this.btn_delet_book.Enabled = false;
            this.btn_delet_book.FlatAppearance.BorderSize = 0;
            this.btn_delet_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delet_book.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.btn_delet_book.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_delet_book.Location = new System.Drawing.Point(0, 340);
            this.btn_delet_book.Name = "btn_delet_book";
            this.btn_delet_book.Size = new System.Drawing.Size(350, 100);
            this.btn_delet_book.TabIndex = 5;
            this.btn_delet_book.Text = "删除图书信息";
            this.btn_delet_book.UseVisualStyleBackColor = true;
            this.btn_delet_book.Click += new System.EventHandler(this.btn_delet_book_Click);
            // 
            // btn_change_book
            // 
            this.btn_change_book.Enabled = false;
            this.btn_change_book.FlatAppearance.BorderSize = 0;
            this.btn_change_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change_book.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.btn_change_book.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_change_book.Location = new System.Drawing.Point(0, 446);
            this.btn_change_book.Name = "btn_change_book";
            this.btn_change_book.Size = new System.Drawing.Size(350, 100);
            this.btn_change_book.TabIndex = 4;
            this.btn_change_book.Text = "修改图书信息";
            this.btn_change_book.UseVisualStyleBackColor = true;
            this.btn_change_book.Click += new System.EventHandler(this.btn_change_book_Click);
            // 
            // btn_add_book
            // 
            this.btn_add_book.Enabled = false;
            this.btn_add_book.FlatAppearance.BorderSize = 0;
            this.btn_add_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_book.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.btn_add_book.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_add_book.Location = new System.Drawing.Point(0, 234);
            this.btn_add_book.Name = "btn_add_book";
            this.btn_add_book.Size = new System.Drawing.Size(350, 100);
            this.btn_add_book.TabIndex = 3;
            this.btn_add_book.Text = "添加图书信息";
            this.btn_add_book.UseVisualStyleBackColor = true;
            this.btn_add_book.Click += new System.EventHandler(this.btn_add_book_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(389, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 75);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(282, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(586, 75);
            this.label2.TabIndex = 3;
            this.label2.Text = "the BookVC System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(167, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(816, 75);
            this.label3.TabIndex = 4;
            this.label3.Text = "ブック管理システムへようこそ";
            // 
            // panel_search
            // 
            this.panel_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_search.Controls.Add(this.panel3);
            this.panel_search.Controls.Add(this.SearchContorl);
            this.panel_search.Controls.Add(this.btn_search);
            this.panel_search.Controls.Add(this.txt_search);
            this.panel_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_search.Location = new System.Drawing.Point(899, 0);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(250, 650);
            this.panel_search.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lbl_searchTitle);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 80);
            this.panel3.TabIndex = 5;
            // 
            // lbl_searchTitle
            // 
            this.lbl_searchTitle.AutoSize = true;
            this.lbl_searchTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_searchTitle.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Bold);
            this.lbl_searchTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_searchTitle.Location = new System.Drawing.Point(4, 0);
            this.lbl_searchTitle.Name = "lbl_searchTitle";
            this.lbl_searchTitle.Size = new System.Drawing.Size(246, 72);
            this.lbl_searchTitle.TabIndex = 1;
            this.lbl_searchTitle.Text = "图书查询";
            this.lbl_searchTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_changeAdmin);
            this.panel1.Controls.Add(this.btn_info);
            this.panel1.Controls.Add(this.btn_changePwd);
            this.panel1.Controls.Add(this.btn_changeInfo);
            this.panel1.Controls.Add(this.btn_record);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(801, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 652);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbl_accountTitle);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 80);
            this.panel2.TabIndex = 5;
            // 
            // lbl_accountTitle
            // 
            this.lbl_accountTitle.AutoSize = true;
            this.lbl_accountTitle.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Bold);
            this.lbl_accountTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_accountTitle.Location = new System.Drawing.Point(50, 0);
            this.lbl_accountTitle.Name = "lbl_accountTitle";
            this.lbl_accountTitle.Size = new System.Drawing.Size(246, 72);
            this.lbl_accountTitle.TabIndex = 1;
            this.lbl_accountTitle.Text = "账户管理";
            this.lbl_accountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.btn_add_book);
            this.panel4.Controls.Add(this.btn_change_book);
            this.panel4.Controls.Add(this.lbl_bookidAdmin);
            this.panel4.Controls.Add(this.btn_refresh);
            this.panel4.Controls.Add(this.txt_bookidAdmin);
            this.panel4.Controls.Add(this.btn_delet_book);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(801, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 652);
            this.panel4.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.lbl_bookTitle);
            this.panel6.Location = new System.Drawing.Point(0, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(347, 80);
            this.panel6.TabIndex = 5;
            // 
            // lbl_bookTitle
            // 
            this.lbl_bookTitle.AutoSize = true;
            this.lbl_bookTitle.Enabled = false;
            this.lbl_bookTitle.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Bold);
            this.lbl_bookTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_bookTitle.Location = new System.Drawing.Point(50, 0);
            this.lbl_bookTitle.Name = "lbl_bookTitle";
            this.lbl_bookTitle.Size = new System.Drawing.Size(246, 72);
            this.lbl_bookTitle.TabIndex = 1;
            this.lbl_bookTitle.Text = "图书管理";
            this.lbl_bookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.MainControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统";
            this.MainControl.ResumeLayout(false);
            this.PageMain.ResumeLayout(false);
            this.PageMain.PerformLayout();
            this.PageSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.PageBookBorrow.ResumeLayout(false);
            this.PageBookBorrow.PerformLayout();
            this.panel_borrow.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.PageAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).EndInit();
            this.PageBookAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).EndInit();
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainControl;
        private System.Windows.Forms.TabPage PageMain;
        private System.Windows.Forms.TabPage PageSearch;
        private System.Windows.Forms.TabPage PageBookBorrow;
        private System.Windows.Forms.TabPage PageAccount;
        private System.Windows.Forms.ComboBox SearchContorl;    
        private System.Windows.Forms.Label lbl_BorrowTitle;
        private System.Windows.Forms.Label lblBorrowIDInput;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblauth;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_bookname;
        private System.Windows.Forms.Label lbl_bookid;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btnBorrowSearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_changeAdmin;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_changePwd;
        private System.Windows.Forms.Button btn_changeInfo;
        private System.Windows.Forms.Button btn_record;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.DataGridView dataGridViewAccount;
        private System.Windows.Forms.Label lbl_wel;
        private System.Windows.Forms.Label lbl_wel_user;
        private System.Windows.Forms.TabPage PageBookAdmin;
        private System.Windows.Forms.Button btn_delet_book;
        private System.Windows.Forms.Button btn_change_book;
        private System.Windows.Forms.Button btn_add_book;
        private System.Windows.Forms.DataGridView dataGridView_admin;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_bookidAdmin;
        private System.Windows.Forms.Label lbl_bookidAdmin;
        private System.Windows.Forms.Panel panel_borrow;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_searchTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_accountTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_bookTitle;
    }
}