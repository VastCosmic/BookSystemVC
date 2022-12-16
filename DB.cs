using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSystemVC
{
    /// <summary>
    /// DB中封装对于数据库的连接与操作，便于更换不同种的数据库
    /// </summary>
    internal class DB
    {
        //连接数据库
        public MySqlConnection connect()
        {
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=LHY137017677;database=table;";
            MySqlConnection con = new MySqlConnection(connetStr);

            con.Open();
            //MessageBox.Show("数据库连接成功");
            return con;
        }

        //执行语句的数据库方法
        public MySqlCommand command(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, connect());
            return cmd;
        }

        //行数影响的方法
        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        //返回查询结果的方法
        public MySqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }

    }
}
