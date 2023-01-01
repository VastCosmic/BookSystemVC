using System.Collections.Generic;
using System.Data;

namespace BookSystemVC
{
    /// <summary>
    /// 借阅历史类
    /// </summary>
    internal class BorrowRecord
    {
        public string user { get; set; }
        public string bookid { get; set; }
        public string bookname { get; set; }
        public string borrowtime { get; set; }
        public string returntime { get; set; }
        public string status { get; set; }

        List<BorrowRecord> records = new List<BorrowRecord>();

        public List<BorrowRecord> LoadRecord(string username)
        {
            //数据库实例
            DB db = new DB();
            records.Clear();
            string dbCommand = "select * from borrowrecord where user='" + username + "'";
            //解析方法
            using (IDataReader read = db.read(dbCommand))
            {
                while (read.Read())
                {
                    BorrowRecord a = new BorrowRecord
                    {
                        user = read[1].ToString(),
                        bookid = read[2].ToString(),
                        bookname = read[3].ToString(),
                        borrowtime = read[4].ToString(),
                        returntime = read[5].ToString(),
                        status = read[6].ToString(),
                    };
                    records.Add(a);
                }
            }
            return records;
        }
    }
}
