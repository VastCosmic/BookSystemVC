using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSystemVC
{
    public partial class BookInfoChange : Form
    {
        //一个图书类型的List，以用于查询显示
        List<BookInfo> bookInfo = new List<BookInfo>();
        //影响的书号
        string bookid="-1";
        public BookInfoChange(string bookid)
        {
            InitializeComponent();
            //若有书号传入，则变更为为修改图书信息模式
            if (bookid != "-1")
                ChangeModel(bookid);
        }
        protected void ChangeModel(string id)
        {
            bookid = id;
            btn_add.Text = "确定修改";
            txt_bookid.ReadOnly = true;
            LoadBookInfo();
            ViewBookInfo();
        }
        /// <summary>
        /// 限制输入模块
        /// 只允许输入数字、退格符
        /// </summary>
        private void txt_bookid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        /// <summary>
        /// 界面按钮，添加书籍
        /// </summary>
        private void btn_add_Click(object sender, EventArgs e)
        {
            //添加模式
            if (bookid == "-1")
            {
                string info = "书号：" + txt_bookid.Text + "\n书名：" + txt_bookname.Text + "\n类别：" + txt_category.Text + "\n作者：" + txt_author.Text + "\n出版社：" + txt_press.Text + "\n状态：" + txt_status.Text;
                if (DialogResult.OK == MessageBox.Show(info, "请确认信息！", MessageBoxButtons.OKCancel))
                {
                    bool result = CallAddBook();
                    if (result) MessageBox.Show("添加成功！", "提示");
                    else MessageBox.Show("添加失败！", "警告");
                }
            }
            //修改模式
            else
            {
                string info = "书号：" + txt_bookid.Text + "\n书名：" + txt_bookname.Text + "\n类别：" + txt_category.Text + "\n作者：" + txt_author.Text + "\n出版社：" + txt_press.Text + "\n状态：" + txt_status.Text;
                if (DialogResult.OK == MessageBox.Show(info, "请确认信息！", MessageBoxButtons.OKCancel))
                {
                    bool result = ChangeBookinfo();
                    if (result) { Close(); }
                    else MessageBox.Show("修改失败！", "警告");
                }
            }
        }
        /// <summary>
        /// 启动添加书籍模块
        /// </summary>
        /// <returns></returns>
        protected bool CallAddBook()
        {
            //检查输入
            if (CheckInput() == false) 
                return false;
            //不存在才可以添加
            if (CheckID() == false)
            {
                if(AddBook()==true)
                    return true;
                else
                    return false;
            }else
            MessageBox.Show("请检查书籍信息是否重复或错误！", "警告");
            return false;
        }
        /// <summary>
        /// 检查输入信息是否正确
        /// </summary>
        protected bool CheckInput()
        {
            if (txt_bookid.Text != String.Empty && txt_category.Text != String.Empty && txt_author.Text != String.Empty && txt_bookname.Text != String.Empty && txt_press.Text != String.Empty && txt_status.Text != String.Empty)
                return true;
            MessageBox.Show("请正确输入信息！", "提示");
            return false;
        }
        /// <summary>
        /// 检查是否存在该书号
        /// </summary>
        /// <returns></returns>
        protected bool CheckID()
        {
            DB db = new DB();
            string dbCommand = "SELECT bookid FROM booktable WHERE bookid=" + txt_bookid.Text;
            if (db.read(dbCommand).HasRows) { return true; }
            return false;
        }
        /// <summary>
        /// 添加图书
        /// 该方法与数据库对接,向booktable中添加书籍，向category中添加书籍类别
        /// </summary>
        /// <returns></returns>
        protected bool AddBook()
        {
            DB db = new DB();
            string dbCommand = "INSERT INTO " + "booktable" + "(bookid, category, bookname, author, press, status) " +
                    "VALUES(" + "'" + txt_bookid.Text + "'" + ", " + "'" + txt_category.Text + "'" + ", " + "'" + txt_bookname.Text + "'" + ", " + "'" + txt_author.Text + "'" + ", " + "'" + txt_press.Text + "'" + ", " + "'" + txt_status.Text + "'" + ")";
            if (db.Execute(dbCommand) > 0)
            {
                if(AddCategory()==true)
                    return true;
                MessageBox.Show("添加书籍类别出错！", "警告");
                return false;
            }
            return false;
        }
        /// <summary>
        /// 添加书籍类别的具体实现
        /// </summary>
        /// <returns></returns>
        protected bool AddCategory()
        {
            DB db = new DB();
            string dbCommand_Check = "SELECT * FROM bookcategory WHERE Category=" + "'" + txt_category.Text + "'";
            string dbCommand_Insert = "INSERT INTO bookcategory (Category) VALUES('" + txt_category.Text + "')";
            if (db.read(dbCommand_Check).HasRows)
            {   //已有类别，不增加
                return true;
            }
            else
                if (db.Execute(dbCommand_Insert) > 0)
                    return true;
            return false;
        }
        /// <summary>
        /// 加载书籍信息，便于修改
        /// </summary>
        protected void LoadBookInfo()
        {
            //数据库实例
            DB db = new DB();
            string dbCommand = "SELECT * FROM booktable WHERE bookid=" + bookid;
            //重置图书信息数据
            bookInfo.Clear();
            //解析方法
            using (IDataReader read = db.read(dbCommand))
            {
                while (read.Read())
                {
                    BookInfo a = new BookInfo
                    {
                        bookid = read[0].ToString(),
                        category = read[1].ToString(),
                        bookname = read[2].ToString(),
                        author = read[3].ToString(),
                        press = read[4].ToString(),
                        status = read[5].ToString()
                    };
                    bookInfo.Add(a);
                }
            }
        }
        /// <summary>
        /// 显示书籍信息
        /// </summary>
        protected void ViewBookInfo()
        {
            txt_bookid.Text = bookInfo[0].bookid;
            txt_category.Text = bookInfo[0].category;
            txt_bookname.Text = bookInfo[0].bookname;
            txt_author.Text = bookInfo[0].author;
            txt_press.Text = bookInfo[0].press;
            txt_status.Text = bookInfo[0].status;
        }
        /// <summary>
        /// 修改书籍信息
        /// </summary>
        /// <returns></returns>
        protected bool ChangeBookinfo()
        {
            DB db = new DB();
            string dbCommand_delect = "DELETE FROM booktable WHERE bookid=" + bookInfo[0].bookid;
            string dbCommand = "INSERT INTO " + "booktable" + "(bookid, category, bookname, author, press, status) " +
                "VALUES(" + "'" + txt_bookid.Text + "'" + ", " + "'" + txt_category.Text + "'" + ", " + "'" + txt_bookname.Text + "'" + ", " + "'" + txt_author.Text + "'" + ", " + "'" + txt_press.Text + "'" + ", " + "'" + txt_status.Text + "'" + ")";          
            if (db.Execute(dbCommand_delect) > 0)
            {
                if (db.Execute(dbCommand) > 0)
                {
                    MessageBox.Show("修改成功！", "提示");
                    return true;
                }
            }
            return false;
        }
    }
}

