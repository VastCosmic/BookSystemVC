using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSystemVC
{
    internal class Login
    {
        public class userInfo
        {
            public string user { get; set; }
            public string studentID { get; set; }
            public string name { get; set; }
            public string password { get; set; }
            public string admin { get; set; }
        }

        //1.定义一个用户类型的List数组，userInfo类的代码在下方
        List<userInfo> User = new List<userInfo>();
        //2.我们要读取查询语句的数据，并且保存了。这里我们将使用IDataReader语句
        //数据库类的实例，类的代码在下方
        DB db = new DB();
        
        public Login()
        {
            LoadUser();
        }

        //加载用户信息
        protected void LoadUser()   
        {
            //解析方法
            using (IDataReader read = db.read("select * from usertable"))
            {
                while (read.Read())
                {
                    userInfo a = new userInfo
                    {
                        user = read[0].ToString(),
                        studentID = read[1].ToString(),
                        name = read[2].ToString(),
                        password = read[3].ToString(),
                        admin = read[4].ToString()
                    };
                    User.Add(a);
                }
            }
        }

        //用户登录
        public bool UserLogin(string UserID,string UserPwd)
        {
            if(UserID == null || UserPwd == null)
            {
                MessageBox.Show("请输入用户ID及密码！");
                return false;
            }
            else
            {
                for(int i = 0; i < User.Count; i++)
                {
                    if (UserID == User[i].user && UserPwd == User[i].password)
                    {
                        MessageBox.Show("登录成功！");
                        return true;
                    }
                }
                MessageBox.Show("用户ID或密码错误！");
                return false;
            }
        }

        public bool UserAdd()
        {
            //解析方法
            //using ()
            //{

            //}
            return false;
        }
    }
}
