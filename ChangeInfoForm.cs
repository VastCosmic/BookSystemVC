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
    public partial class ChangeInfoForm : Form
    {
        User user = new User();
        public ChangeInfoForm(string username)
        {
            InitializeComponent();
            user.user = username;
            LoadUser();
            showOldInfo();
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
                        password = "***",
                        admin = read[4].ToString()
                    };
                    User.Add(a);
                }
            }
        }

        protected void showOldInfo()
        {
            txt_user.Text = User[0].user;
            txt_name.Text = User[0].name;
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            string dbCommand = "update usertable set user='" + txt_user.Text + "', name='" + txt_name.Text + "' where studentID='" + User[0].studentID + "'";
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
    }
}
