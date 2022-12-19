using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookSystemVC
{
    public partial class MainForm : Form
    {
        public MainForm(object user_object)
        {
            InitializeComponent();           
            user.user = user_object.ToString(); //取得user账户
        }

        User user = new User();
        Book book = new Book();
        private void btn_search_Click(object sender, System.EventArgs e)
        {
            if ((txt_search.Text == string.Empty || SearchContorl.SelectedItem == null) && (SearchContorl.Text != "全部"))
            {
                MessageBox.Show("请输入查询信息！\n支持模糊查询。","提示");
                return;
            }
            string method = string.Empty;
            if(SearchContorl.SelectedItem != null)
            {
                if (SearchContorl.Text == "按照书名查找")
                {
                    method = "bookname";
                }
                else if (SearchContorl.Text == "按照类别查找")
                {
                    method = "category";
                }
                else if (SearchContorl.Text == "按照作者查找")
                {
                    method = "author";
                }
                else if (SearchContorl.Text == "按照书号查找")
                {
                    method = "bookid";
                }
                else if (SearchContorl.Text == "全部")
                {
                    method = "all";
                }
                if (method != string.Empty)
                {
                    dataGridView.ReadOnly = true;
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = book.BookSearch(method, txt_search.Text);
                    dataGridView.Update();
                    dataGridView.Refresh();
                }
            }
        }

        private void btnBorrowSearch_Click(object sender, EventArgs e)
        {
            if(txtID.Text == string.Empty)
            {
                MessageBox.Show("请输入书号！","提示");
                return ;
            }
            else
            {
                List<BookInfo> bookInfo = new List<BookInfo>();
                bookInfo = book.BorrowSearch(txtID.Text);
                if(bookInfo.Count > 0)
                {
                    lbl_bookid.Text = bookInfo[0].bookid;
                    lbl_bookname.Text = bookInfo[0].bookname;
                    lbl_author.Text = bookInfo[0].author;
                    lbl_status.Text = bookInfo[0].status;
                    if (lbl_status.Text == "在馆")
                    {
                        btnBorrow.Enabled = true;
                        btnReturn.Enabled = false;
                    }
                    else if (lbl_status.Text == "外借")
                    {
                        btnReturn.Enabled = true; 
                        btnBorrow.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("该图书不存在，请检查书号！", "提示");
                }
            }
        }


        private void btnReturn_Click(object sender, System.EventArgs e)
        {
            if (lbl_bookid.Text != "请输入书号")
            {
                if (book.ReturnBook(user.user)) 
                    MessageBox.Show("还书成功！", "提示");
                else
                    MessageBox.Show("失败！\n请联系管理员！", "提示");
            }
            btnBorrowSearch_Click(sender, e);
            btnReturn.Enabled = false;
        }

        private void btnBorrow_Click(object sender, System.EventArgs e)
        {
            if (lbl_bookid.Text != "请输入书号")
            {
                if (book.BorrowBook(user.user))
                    MessageBox.Show("借书成功！", "提示");
                else
                    MessageBox.Show("失败！\n请联系管理员！", "提示");
            }
            btnBorrowSearch_Click(sender, e);
            btnBorrow.Enabled = false;
        }

        
        
        
        















        //退出登录并启动新登录界面
        private void btn_logout_Click(object sender, EventArgs e)
        {
            //启动新线程应用
            Thread thread = new Thread(new ThreadStart(StartLoginForm));
            thread.Start();
            Close();
        }
        private void StartLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            AccountInfoForm accountInfoForm = new AccountInfoForm(user.user);          
            accountInfoForm.ShowDialog();
        }

        private void btn_changePwd_Click(object sender, EventArgs e)
        {

        }
    }
}
