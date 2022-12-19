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
    public partial class ChangePwdForm : Form
    {
        User user = new User();
        public ChangePwdForm(string username)
        {
            InitializeComponent();
            user.user = username;
            LoadUser();
        }

        //定义一个用户类型的List数组
        List<User> User = new List<User>();
        //加载用户信息
        protected void LoadUser()
        {
            DB db = new DB();
            //解析方法
            using (IDataReader read = db.read("select * from usertable where user='" + user.user + "'"))
            {
                while (read.Read())
                {
                    User a = new User
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

        protected void changePwd()
        {
            if (txt_oldpwd.Text == User[0].password)
            {
                if(txt_pwd.Text == txt_pwd2.Text)
                {
                    DB db = new DB();
                    string dbCommand = "update usertable set password='" + txt_pwd.Text + "' where studentID='" + User[0].studentID + "'";
                    if (db.Execute(dbCommand) > 0)
                    {
                        MessageBox.Show("修改成功！", "提示");
                    }
                    else
                    {
                        MessageBox.Show("修改失败！", "提示");
                    }
                    Close();
                }
                else
                {
                    txt_pwd.Text = String.Empty;
                    txt_pwd2.Text = String.Empty;
                    MessageBox.Show("请检查两次输入的密码！", "提示");
                }
            }
            else
            {                
                txt_oldpwd.Text = String.Empty;
                txt_pwd.Text = String.Empty;
                txt_pwd2.Text = String.Empty;
                MessageBox.Show("原密码错误！", "警告");
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            changePwd();
        }
    }
}
