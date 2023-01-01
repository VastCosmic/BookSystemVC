using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BookSystemVC
{
    public partial class AccountInfoForm : Form
    {
        User user = new User();
        public AccountInfoForm(string username)
        {
            InitializeComponent();
            user.user = username;
            showUserInfo();
        }

        //定义一个用户类型的List数组
        List<User> User = new List<User>();
        //加载用户信息
        protected void LoadUser(string dbCommand)
        {
            DB db = new DB();
            //解析方法
            using (IDataReader read = db.read(dbCommand))
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
        protected void showUserInfo()
        {
            string dbCommand_User = "select * from usertable where user='" + user.user + "'";
            LoadUser(dbCommand_User);
            if (User[0].admin == "1")
            {
                User.Clear();
                string dbCommand_AllUser = "select * from usertable";
                LoadUser(dbCommand_AllUser);
            }
            dataGridView.DataSource = User;
        }
    }
}
