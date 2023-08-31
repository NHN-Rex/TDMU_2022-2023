-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: 2124802050013
-- ------------------------------------------------------
-- Server version	8.0.33

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `dangky`
--

DROP TABLE IF EXISTS `dangky`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dangky` (
  `MADV` int NOT NULL,
  `SODT` varchar(11) NOT NULL,
  PRIMARY KEY (`MADV`,`SODT`),
  KEY `SODT` (`SODT`),
  CONSTRAINT `dangky_ibfk_1` FOREIGN KEY (`MADV`) REFERENCES `dichvu` (`MADV`),
  CONSTRAINT `dangky_ibfk_2` FOREIGN KEY (`SODT`) REFERENCES `dienthoai` (`SODT`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dangky`
--

LOCK TABLES `dangky` WRITE;
/*!40000 ALTER TABLE `dangky` DISABLE KEYS */;
INSERT INTO `dangky` VALUES (1,'0000000000'),(5,'0000000000'),(2,'1111111111'),(4,'1111111111'),(1,'2222222222'),(3,'2222222222'),(8,'4444444444'),(1,'6666666666'),(1,'7777777777');
/*!40000 ALTER TABLE `dangky` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dichvu`
--

DROP TABLE IF EXISTS `dichvu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dichvu` (
  `MADV` int NOT NULL AUTO_INCREMENT,
  `TENDV` varchar(50) NOT NULL,
  PRIMARY KEY (`MADV`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dichvu`
--

LOCK TABLES `dichvu` WRITE;
/*!40000 ALTER TABLE `dichvu` DISABLE KEYS */;
INSERT INTO `dichvu` VALUES (1,'Dịch vụ A23 SMS'),(2,'Dịch vụ funring'),(3,'Dịch vụ SMS PRO'),(4,'Dịch vụ SMS Brand Name'),(5,'Dịch vụ điện báo và Telex'),(6,'Dịch vụ FACSLMLLE (FAX)'),(7,'Dịch vụ truyền số liệu'),(8,'Dịch vụ Điện thoại “Thu cước từ người được gọi”');
/*!40000 ALTER TABLE `dichvu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dienthoai`
--

DROP TABLE IF EXISTS `dienthoai`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dienthoai` (
  `SODT` varchar(11) NOT NULL,
  `MAKH` int NOT NULL,
  `LOAIDT` varchar(50) NOT NULL,
  `SOHD` int NOT NULL,
  PRIMARY KEY (`SODT`),
  KEY `MAKH` (`MAKH`),
  CONSTRAINT `dienthoai_ibfk_1` FOREIGN KEY (`MAKH`) REFERENCES `khachhang` (`MAKH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dienthoai`
--

LOCK TABLES `dienthoai` WRITE;
/*!40000 ALTER TABLE `dienthoai` DISABLE KEYS */;
INSERT INTO `dienthoai` VALUES ('0000000000',1,'Vô tuyến',1),('1111111111',2,'Dây cáp',2),('2222222222',3,'Vô tuyến',3),('3333333333',4,'Dây cáp',4),('4444444444',5,'Vô tuyến',5),('5555555555',6,'Dây cáp',6),('6666666666',7,'Vô tuyến',7),('7777777777',8,'Dây cáp',8);
/*!40000 ALTER TABLE `dienthoai` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `khachhang`
--

DROP TABLE IF EXISTS `khachhang`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `khachhang` (
  `MAKH` int NOT NULL AUTO_INCREMENT,
  `TENKH` varchar(100) NOT NULL,
  `DIACHI` varchar(100) NOT NULL,
  `LOAIKH` varchar(50) NOT NULL,
  PRIMARY KEY (`MAKH`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `khachhang`
--

LOCK TABLES `khachhang` WRITE;
/*!40000 ALTER TABLE `khachhang` DISABLE KEYS */;
INSERT INTO `khachhang` VALUES (1,'Nguyễn Hữu Nghĩa','Bình Dương','Cá Nhân'),(2,'Lục Tấn Khoa','Bình Dương','Doanh Nghiệp'),(3,'Phạm Tuấn Vũ','Bình Dương','Cá Nhân'),(4,'Trần Trung Nguyên','Thủ Dầu Một','Doanh Nghiệp'),(5,'Nguyễn Thị Thanh Hằng','Thủ Dầu Một','Cá Nhân'),(6,'Phan Thuý Thanh','Thủ Dầu Một','Doanh Nghiệp'),(7,'Đặng Trịnh Duy Anh','Bình Dương','Doanh Nghiệp'),(8,'Phan Thị An','Sài Gòn','Doanh Nghiệp');
/*!40000 ALTER TABLE `khachhang` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-07-21 17:36:11
