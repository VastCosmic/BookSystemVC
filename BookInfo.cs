namespace BookSystemVC
{
    /// <summary>
    /// 图书信息类
    /// </summary>
    internal class BookInfo
    {
        //书号
        public string bookid { get; set; }
        //类别
        public string category { get; set; }
        //书名
        public string bookname { get; set; }
        //作者
        public string author { get; set; }
        //出版社
        public string press { get; set; }
        //状态
        public string status { get; set; }
    }
}
