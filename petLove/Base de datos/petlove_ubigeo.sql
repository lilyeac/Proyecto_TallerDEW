-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: petlove
-- ------------------------------------------------------
-- Server version	8.0.26

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
-- Table structure for table `ubigeo`
--

DROP TABLE IF EXISTS `ubigeo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ubigeo` (
  `Cod_ubi` int NOT NULL AUTO_INCREMENT,
  `Dis_ubi` varchar(50) DEFAULT NULL,
  `Prv_ubi` varchar(50) DEFAULT NULL,
  `Dep_ubi` varchar(50) DEFAULT NULL,
  `Ord_ubi` int DEFAULT NULL,
  `Not_ubi` varchar(50) DEFAULT NULL,
  `Cdi_ubi` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Cod_ubi`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ubigeo`
--

LOCK TABLES `ubigeo` WRITE;
/*!40000 ALTER TABLE `ubigeo` DISABLE KEYS */;
INSERT INTO `ubigeo` VALUES (1,'Ancón','Lima','Lima',2,'na','150102'),(2,'Ate Vitarte','Lima','Lima',3,'na','150103'),(3,'Barranco','Lima','Lima',4,'na','150104'),(4,'Breña','Lima','Lima',5,'na','150105'),(5,'Carabayllo','Lima','Lima',6,'na','150106'),(6,'Chaclacayo','Lima','Lima',8,'na','150107'),(7,'Chorrillos','Lima','Lima',9,'na','	150108'),(8,'Cieneguilla','Lima','Lima',40,'na','150109'),(9,'Comas','Lima','Lima',7,'na','150110'),(10,'El Agustino','Lima','Lima',10,'na','150111'),(11,'Independencia','Lima','Lima',28,'na','150112'),(12,'Jesús María','Lima','Lima',11,'na','150113'),(13,'La Molina','Lima','Lima',12,'na','150114'),(14,'La Victoria','Lima','Lima',13,'na','150115'),(15,'Lima','Lima','Lima',1,'na','150101'),(16,'Lince','Lima','Lima',14,'na','150116'),(17,'Los Olivos','Lima','Lima',39,'na','150117'),(18,'Lurigancho','Lima','Lima',15,'na','150118'),(19,'Lurín','Lima','Lima',16,'na','150119'),(20,'Magdalena del Mar','Lima','Lima',17,'na','150120'),(21,'Miraflores','Lima','Lima',18,'na','150122'),(22,'Pachacamac','Lima','Lima',19,'na','150123'),(23,'Pucusana','Lima','Lima',20,'na','150124'),(24,'Pueblo Libre','Lima','Lima',21,'na','150121'),(25,'Puente Piedra','Lima','Lima',22,'na','150125'),(26,'Punta Hermosa','Lima','Lima',24,'na','150126'),(27,'Punta Negra','Lima','Lima',23,'na','150127'),(28,'Rímac','Lima','Lima',25,'na','150128'),(29,'San Bartolo','Lima','Lima',26,'na','150129'),(30,'San Borja','Lima','Lima',41,'na','150130'),(31,'San Isidro','Lima','Lima',27,'na','150131'),(32,'San Juan de Lurigancho','Lima','Lima',36,'na','150132'),(33,'San Juan de Miraflores','Lima','Lima',29,'na','150133'),(34,'San Luis','Lima','Lima',30,'na','	150134'),(35,'San Martín de Porres','Lima','Lima',31,'na','150135'),(36,'San Miguel','Lima','Lima',32,'na','150136'),(37,'Santa Anita','Lima','Lima',43,'na','150137'),(38,'Santa María del Mar','Lima','Lima',37,'na','150138'),(39,'Santa Rosa','Lima','Lima',38,'na','150139	'),(40,'Santiago de Surco','Lima','Lima',33,'na','150140'),(41,'Surquillo','Lima','Lima',34,'na','150141'),(42,'Villa El Salvador','Lima','Lima',42,'na','150142	'),(43,'Villa María del Triunfo','Lima','Lima',35,'na','150143');
/*!40000 ALTER TABLE `ubigeo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-06-22  3:05:50
