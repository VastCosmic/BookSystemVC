using System;
using System.Data;
using System.Windows.Forms;

namespace BookSystemVC
{
    public partial class ChangeAdminForm : Form
    {
        public ChangeAdminForm()
        {
            InitializeComponent();

        }
        int admin = 0;
        private void btn_change_Click(object sender, EventArgs e)
        {
            ChangeAdminInfo();
        }

        private void LoadAdminInfo()
        {
            DB db = new DB();
            string dbCommand = "select * from usertable where studentID='" + txt_id.Text + "'";
            //解析方法
            using (IDataReader read = db.read(dbCommand))
            {
                while (read.Read())
                {
                    if (read[4].ToString() == "1")
                    {
                        lbl_admin_status.Text = "管理员";
                        admin = 1;
                    }
                    else if (read[4].ToString() == "0")
                    {
                        lbl_admin_status.Text = "普通用户";
                        admin = 0;
                    }
                }
            }

        }

        private void ChangeAdminInfo()
        {
            DB db = new DB();
            string dbCommand;
            if (admin == 0)
            {
                dbCommand = "update usertable set admin=1 where studentID='" + txt_id.Text + "'";
            }
            else
            {
                dbCommand = "update usertable set admin=0 where studentID='" + txt_id.Text + "'";
            }
            if (db.Execute(dbCommand) > 0)
            {
                MessageBox.Show("修改成功！", "提示");
                LoadAdminInfo();
            }
            else
            {
                MessageBox.Show("修改失败！", "提示");
                LoadAdminInfo();
            }
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            LoadAdminInfo();
        }
    }
}
