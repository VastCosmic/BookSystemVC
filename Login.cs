﻿using System;
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

        DB db = new DB();
        //定义一个用户类型的List数组
        List<userInfo> User = new List<userInfo>();
        
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
                        return true;
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// 用户注册方法
        /// </summary>
        /// <param name="dbRead">
        /// 需要数据库指令，用以判断该学工号是否已经注册
        /// </param>
        /// <param name="dbInsert">
        /// 需要数据库指令，用以进行注册
        /// </param>
        /// <returns></returns>
        public bool UserAdd(string dbRead, string dbInsert)
        {
            DB db = new DB();

            //查询该学工号是否注册
            if (db.read(dbRead).HasRows)
            {
                MessageBox.Show("该用户已经注册！请联系管理员。");
                return false;
            }

            //注册用户
            if (db.Execute(dbInsert) > 0)
            {
                return true;
            }
            return false;
        }
    }
}