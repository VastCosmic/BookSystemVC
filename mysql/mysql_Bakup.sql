/*
MySQL Backup
Database: table
Backup Time: 2023-01-01 15:36:27
*/

SET FOREIGN_KEY_CHECKS=0;
DROP TABLE IF EXISTS `table`.`bookcategory`;
DROP TABLE IF EXISTS `table`.`booktable`;
DROP TABLE IF EXISTS `table`.`borrowrecord`;
DROP TABLE IF EXISTS `table`.`usertable`;
CREATE TABLE `bookcategory` (
  `Category` varchar(20) NOT NULL COMMENT '类别'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `booktable` (
  `bookid` int(10) NOT NULL AUTO_INCREMENT COMMENT '书编号',
  `category` varchar(20) NOT NULL COMMENT '类别',
  `bookname` varchar(100) NOT NULL COMMENT '书名',
  `author` varchar(20) DEFAULT NULL COMMENT '作者',
  `press` varchar(100) DEFAULT NULL COMMENT '出版社',
  `status` varchar(20) NOT NULL COMMENT '状态',
  PRIMARY KEY (`bookid`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;
CREATE TABLE `borrowrecord` (
  `id` int(10) NOT NULL AUTO_INCREMENT COMMENT '借书序列号',
  `user` varchar(20) NOT NULL COMMENT '用户名',
  `bookid` int(10) NOT NULL COMMENT '书号',
  `bookname` varchar(50) NOT NULL COMMENT '书名',
  `borrowtime` date NOT NULL COMMENT '借书时间',
  `returntime` date DEFAULT NULL COMMENT '还书时间',
  `status` varchar(20) NOT NULL COMMENT '状态',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;
CREATE TABLE `usertable` (
  `user` varchar(20) NOT NULL COMMENT '用户名',
  `studentID` varchar(20) NOT NULL COMMENT '学号',
  `name` varchar(20) NOT NULL COMMENT '姓名',
  `password` varchar(20) NOT NULL COMMENT '密码',
  `admin` int(1) unsigned NOT NULL DEFAULT '0' COMMENT '管理员权限开关',
  PRIMARY KEY (`user`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
BEGIN;
LOCK TABLES `table`.`bookcategory` WRITE;
DELETE FROM `table`.`bookcategory`;
INSERT INTO `table`.`bookcategory` (`Category`) VALUES ('其他'),('文学'),('网络小说'),('计算机类');
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `table`.`booktable` WRITE;
DELETE FROM `table`.`booktable`;
INSERT INTO `table`.`booktable` (`bookid`,`category`,`bookname`,`author`,`press`,`status`) VALUES (11, '文学', '西游记', '吴承恩', '人民出版社', '在馆'),(12, '文学', '红楼梦', '曹雪芹', '人民出版社', '在馆'),(13, '计算机类', 'Java2实用教程', '耿祥义、张跃平', '清华大学出版社', '在馆'),(14, '文学', '少年Pi的奇幻漂流', '[加拿大]扬·马特尔', '译林出版社', '在馆'),(15, '计算机类', '算法竞赛入门经典', '刘汝佳', '清华大学出版社', '在馆'),(16, '计算机类', '数据结构与算法分析', '冯舜玺', '机械工业出版社', '外借'),(17, '其他', '有滋有味：我的厨艺人生', '[美]露西·尼斯利', '北京联合出版公司', '在馆'),(18, '网络小说', '解忧杂货店', '[日]东野圭吾', '南海出版公司', '在馆');
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `table`.`borrowrecord` WRITE;
DELETE FROM `table`.`borrowrecord`;
INSERT INTO `table`.`borrowrecord` (`id`,`user`,`bookid`,`bookname`,`borrowtime`,`returntime`,`status`) VALUES (17, 'lhy', 15, '算法竞赛入门经典', '2022-12-01', '2022-12-19', '已还'),(18, '人', 11, '西游记', '2022-11-30', '2022-12-01', '已还'),(19, '1234', 16, '数据结构与算法分析', '2022-10-05', '2022-11-16', '已还'),(25, '1', 12, '红楼梦', '2022-12-19', '2022-12-19', '已还'),(28, 'admin', 12, '红楼梦', '2022-12-20', '2022-12-20', '已还'),(29, 'admin', 14, '少年Pi的奇幻漂流', '2022-12-30', '2022-12-30', '已还'),(30, 'admin', 14, '少年Pi的奇幻漂流', '2022-12-31', '2022-12-31', '已还');
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `table`.`usertable` WRITE;
DELETE FROM `table`.`usertable`;
INSERT INTO `table`.`usertable` (`user`,`studentID`,`name`,`password`,`admin`) VALUES ('1', '1', '1', '1', 1),('1234', '1234', '1234', '1234', 0),('admin', '0', 'admin', 'admin', 1),('amy1001', '1001', 'Amy', '123456', 0),('lhy', '20020013019', 'LHY', '123456789', 0),('test', 'test', 'test', '123', 0),('人', '2222', '人人人', '123456', 0);
UNLOCK TABLES;
COMMIT;
