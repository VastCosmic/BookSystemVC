using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSystemVC
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //登录
        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.UserLogin(txt_user.Text, txt_pwd.Text) == true)
            {
                //MessageBox.Show("登录成功！");
                //启动新线程主应用
                Thread thread = new Thread(new ParameterizedThreadStart(StartMainForm));
                string user = txt_user.Text;
                thread.Start(user);
                Close();
            }
            else
            {
                MessageBox.Show("用户ID或密码错误！");
            }
        }

        //跳转注册
        private void btn_signup_Click(object sender, EventArgs e)
        {
            LoginForm_UserSignUp loginForm_UserSignUp = new LoginForm_UserSignUp();
            loginForm_UserSignUp.ShowDialog();
        }

        //启动主界面
        private void StartMainForm(object user)
        {
            MainForm mainForm = new MainForm(user);
            Application.Run(mainForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //启动新线程主应用
            Thread thread = new Thread(new ParameterizedThreadStart(StartMainForm));
            string user = txt_user.Text;
            thread.Start("admin");
            Close();
        }
    }
}
