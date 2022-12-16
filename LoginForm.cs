using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private Thread thread;
        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.UserLogin(txt_user.Text, txt_pwd.Text) == true)
            {
                MessageBox.Show("登录成功！");
                thread = new Thread(new ThreadStart(StartMainForm));
                thread.Start();
                Close();
            }
            else
            {
                MessageBox.Show("用户ID或密码错误！");
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            LoginForm_UserSignUp loginForm_UserSignUp = new LoginForm_UserSignUp();
            loginForm_UserSignUp.ShowDialog();            
        }

        private void StartMainForm()
        {
            MainForm mainForm = new MainForm();
            Application.Run(mainForm);
        }    
    }
}
