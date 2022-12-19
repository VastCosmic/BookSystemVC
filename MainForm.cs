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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Book book = new Book();
        private void btn_search_Click(object sender, System.EventArgs e)
        {
            if ((txt_search.Text == string.Empty || SearchContorl.SelectedItem == null) && (SearchContorl.Text != "全部"))
            {
                MessageBox.Show("请完善查询信息！","提示");
                return;
            }
            string method = string.Empty;
            if(SearchContorl.SelectedItem != null)
            {
                if (SearchContorl.Text == "按照书名查找")
                {
                    method = "bookname";
                }
                else if (SearchContorl.Text == "按照类别查找")
                {
                    method = "category";
                }
                else if (SearchContorl.Text == "按照作者查找")
                {
                    method = "author";
                }
                else if (SearchContorl.Text == "按照书号查找")
                {
                    method = "bookid";
                }
                else if (SearchContorl.Text == "全部")
                {
                    method = "all";
                }
                if (method != string.Empty)
                {
                    dataGridView.ReadOnly = true;
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = book.BookSearch(method, txt_search.Text);
                    dataGridView.Update();
                    dataGridView.Refresh();
                }
            }
        }

        private void btnBorrowSearch_Click(object sender, System.EventArgs e)
        {
            if(txtID.Text == string.Empty)
            {
                MessageBox.Show("请输入书号！","提示");
                return ;
            }
        }

        private void btnReturn_Click(object sender, System.EventArgs e)
        {

        }

        private void btnBorrow_Click(object sender, System.EventArgs e)
        {

        }
    }
}
