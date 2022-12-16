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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        Login login = new Login();
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (login.UserLogin(txt_user.Text, txt_pwd.Text) == true)
            {

            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            LoginForm_UserSignUp loginForm_UserSignUp = new LoginForm_UserSignUp();
            loginForm_UserSignUp.ShowDialog();
        }
    }
}
