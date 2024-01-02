-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: user_passwords
-- ------------------------------------------------------
-- Server version	8.0.35

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
-- Table structure for table `website_credentials`
--

DROP TABLE IF EXISTS `website_credentials`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `website_credentials` (
  `id` int NOT NULL AUTO_INCREMENT,
  `website_link` varchar(255) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `website_name` varchar(255) NOT NULL,
  `is_social` tinyint(1) NOT NULL DEFAULT '0',
  `is_edu` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `website_credentials`
--

LOCK TABLES `website_credentials` WRITE;
/*!40000 ALTER TABLE `website_credentials` DISABLE KEYS */;
INSERT INTO `website_credentials` VALUES (22,'www.test01.com','test01@gamil.com','test01','test01',0,0),(23,'www.test02.com','test02@gmail.com','test02','test02',0,0),(24,'www.test03.com','test03@gmail.com','test03','test03',0,0),(25,'www.test04.com','test04@gmail.com','yesy04','test04',0,0),(26,'www.test05.com','test05@gmail.com','test05','test05',0,0),(27,'www.test06.com','test06@gmail.com','test06','test06',0,0),(28,'www.test07.com','test07@gmail.com','test07','test07',1,0),(29,'www.test08.com','test08!@gmail.com','test08','test08',1,0),(30,'www.test09.com','test09@gmail.com','test09','test09',1,0),(31,'www.test10.com','test10@gmail.com','test10','test10',1,0),(32,'www.test11.com','test11@gmail.com','test11','test11',1,0),(33,'www.test12.com','test12@gmail.com','test12','test12',1,0),(34,'www.test13.com','test13@gmail.com','test13','test13',1,0),(35,'www.test14.com','test14@gmail.com','test14','test14',0,1),(36,'www.test15.com','test15@gmail.com','test15','test15',0,1),(37,'www.test16.com','test16@gmail.com','test16','test16',0,1),(38,'www.test17.com','test17@gmail.com','test17','test17',0,1),(39,'www.test18.com','test18@gmail.com','test18','test18',0,1),(40,'www.test19.com','test19@gmail.com','test19','test19',1,0);
/*!40000 ALTER TABLE `website_credentials` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-02  4:37:05
