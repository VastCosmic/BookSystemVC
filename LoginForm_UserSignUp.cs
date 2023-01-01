using System;
using System.Windows.Forms;

namespace BookSystemVC
{
    public partial class LoginForm_UserSignUp : Form
    {
        public LoginForm_UserSignUp()
        {
            InitializeComponent();
        }

        Login login = new Login();
        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == String.Empty || txt_studentID.Text == String.Empty || txt_name.Text == String.Empty)
            {
                MessageBox.Show("请填写用户信息！", "提示");
            }
            else if (txt_pwd.Text == String.Empty || txt_pwd2.Text == String.Empty)
            {
                MessageBox.Show("请正确填写密码", "提示");
            }
            else if (txt_pwd.Text != txt_pwd2.Text)
            {
                MessageBox.Show("请正确填写密码", "提示");
            }
            else
            {
                int admin = 0;  //默认非管理员
                /*****
                 * 以下为数据库指令，传给Login类执行
                *****/
                //查询该用户名是否注册
                String dbRead_user = "SELECT user FROM usertable WHERE user = " + "'" + txt_user.Text + "'" + ";";
                //查询该学工号是否注册
                String dbRead_id = "SELECT studentID FROM usertable WHERE studentID = " + "'" + txt_studentID.Text + "'" + ";";
                //创建要插入的MySQL语句，注册用户
                String dbInsert = "INSERT INTO " + "usertable" + "(user, studentID, name, password, admin) " +
                    "VALUES(" + "'" + txt_user.Text + "'" + ", " + "'" + txt_studentID.Text + "'" + ", " + "'" + txt_name.Text + "'" + ", " + "'" + txt_pwd.Text + "'" + ", " + "'" + admin.ToString() + "'" + ")";
                //MessageBox.Show(dbInsert);

                if (login.UserAdd(dbRead_user, dbRead_id, dbInsert) == true)
                    MessageBox.Show("注册成功！", "用户注册");
                else
                    MessageBox.Show("注册失败！", "用户注册");

                Close();
            }
        }


    }
}
