using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static BookSystemVC.Login;

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
                        state = read[5].ToString()
                    };
                    bookInfo.Add(a);
                }
            }
        }
    }
}
