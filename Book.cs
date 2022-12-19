using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static BookSystemVC.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookSystemVC
{
    internal class Book
    {
        //一个图书类型的List，以用于查询显示
        List<BookInfo> bookInfo = new List<BookInfo>();

        /// <summary>
        /// 提供图书查询功能
        /// </summary>
        /// <param name="method">
        /// 类别查询    category
        /// 书名查询    bookname
        /// 作者查询    author
        /// 书号查询    bookid
        /// </param>
        /// <param name="key">
        /// 查询关键字
        /// </param>
        public List<BookInfo> BookSearch(string method, string key)
        {
            if(method == "category")
            {
                return SearchByCategory(key);
            }
            else if(method == "bookname")
            {
                return SearchByBookname(key);
            }
            else if(method == "author")
            {
                return SearchByAuthor(key);
            }
            else if(method == "bookid")
            {
                return SearchByBookid(key);
            }
            else if (method == "all")
            {
                return SearchByBookname(string.Empty);
            }
            return bookInfo;
        }
        protected List<BookInfo> SearchByCategory(string key)
        {
            string dbCommand = "select * from booktable where category like '%" + key + "%'";
            LoadBook(dbCommand);
            return bookInfo;
        }
        protected List<BookInfo> SearchByBookname(string key)
        {
            string dbCommand = "select * from booktable where bookname like '%" + key + "%'";
            LoadBook(dbCommand);
            return bookInfo;
        }
        protected List<BookInfo> SearchByAuthor(string key)
        {
            string dbCommand = "select * from booktable where author like '%" + key + "%'";
            LoadBook(dbCommand);
            return bookInfo;
        }
        protected List<BookInfo> SearchByBookid(string key)
        {
            string dbCommand = "select * from booktable where bookid='" + key + "'";
            LoadBook(dbCommand);
            return bookInfo;
        }

        //加载图书信息
        protected void LoadBook(string dbCommand)
        {
            //数据库实例
            DB db = new DB();
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
        /// 提供借书的查询功能
        /// </summary>
        /// <param name="key">
        /// 需要bookid
        /// </param>
        public List<BookInfo> BorrowSearch(string key)
        {
            //查询id对应书籍
            return SearchByBookid(key);
        }

        /// <summary>
        /// 还书接口
        /// </summary>
        /// <param name="bookid"></param>
        /// <param name="user">用户名</param>
        /// <returns></returns>
        public bool ReturnBook(string user)
        {
            return RB_Book(1, user);
        }
        /// <summary>
        /// 借书接口
        /// </summary>
        /// <param name="bookid"></param>
        /// <param name="user">用户名</param>
        /// <returns></returns>
        public bool BorrowBook(string user)
        {
            return RB_Book(0, user);
        }

        /// <summary>
        /// 还书借书统一实现
        /// </summary>
        /// <param name="action">
        /// 0：借书    1：还书
        /// </param>
        /// <param name="user">用户名</param>
        /// <returns></returns>
        protected bool RB_Book(int action, string user)
        {               
            //数据库实例
            DB db = new DB();

            /*******数据库指令*******/
            //还书借书
            string dbCommand_return = "update booktable set status='在馆' where bookid='" + bookInfo[0].bookid + "'";
            string dbCommand_borrow = "update booktable set status='外借' where bookid='" + bookInfo[0].bookid + "'";           
            //还书借书记录
            string dbCommand_AddRecord_borrow = "INSERT INTO borrowrecord(user, bookid, bookname, borrowtime, status) VALUES('"
                + user + "'," + bookInfo[0].bookid + ",'" + bookInfo[0].bookname + "',curdate(),'未还')";
            string dbCommand_AddRecord_Return = "update borrowrecord set status = '已还', returntime=curdate() where bookid='" + bookInfo[0].bookid + "' AND status='未还'";
            

            switch (action)
            {
                case 0:
                    if (db.Execute(dbCommand_borrow) > 0)
                    {
                        if (db.Execute(dbCommand_AddRecord_borrow) > 0)
                            return true;
                        return false;
                    }
                    break;
                case 1:
                    if (db.Execute(dbCommand_return) > 0)
                    {
                        if (db.Execute(dbCommand_AddRecord_Return) > 0)
                            return true;
                        return false;
                    }
                    break;
                default:
                    return false;
            }
            return false;
        }
    }
}
