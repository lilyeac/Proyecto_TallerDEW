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
-- Table structure for table `razas`
--

DROP TABLE IF EXISTS `razas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `razas` (
  `Id_raz` int NOT NULL AUTO_INCREMENT,
  `Des_raz` varchar(800) DEFAULT NULL,
  `Ori_raz` varchar(800) DEFAULT NULL,
  `His_raz` varchar(8000) DEFAULT NULL,
  `Tem_raz` varchar(3000) DEFAULT NULL,
  `Fot_raz` mediumblob,
  `Not_raz` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_raz`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `razas`
--

LOCK TABLES `razas` WRITE;
/*!40000 ALTER TABLE `razas` DISABLE KEYS */;
INSERT INTO `razas` VALUES (1,'perro pequeño con unas Dimensione de 18 a 22 cm con Peso	1,5 a 3 kg','Los antepasados del pomerania eran perros de trineo en Islandia y Laponia, que llegaron a Europa a través de Pomerania. La región de Pomerania, bañada al norte por el mar Báltico y limitada al oeste por la isla de Rügen y al este por el río Vístula, ha sido ocupada por muchos pueblos: celtas, eslavos, polacos, suecos, daneses y prusianos. Su nombre procede de Pomore o Pommern, lo que significa junto al mar, y le fue dado en tiempos de Carlomagno. Es en Pomerania donde el Spitz ganó fama como mascota y perro de labor.','Los criadores caninos mejoraron el pelaje y adaptaron al perro a la vida urbana, pero los pomerania pesaban más de 10 kg al llegar a Inglaterra.Se atribuye a los criadores la reducción de talla del animal y el desarrollo de su variedad de colores, siguiendo métodos de prueba y error y aplicando las teorías genéticas de Gregor Mendel. El pomerania actual es pequeño debido a la crianza selectiva, pero conserva la robustez y el pelaje típicos de los perros de climas fríos.Fue la reina de Inglaterra Carlota de Mecklemburgo-Strelitz quien introdujo al pomerania entre la nobleza de su país, pero la raza solo alcanzó fama internacional cuando su nieta Victoria volvió de unas vacaciones en Florencia, Italia, con un pomeranio llamado Marco.El pomerania como raza moderna no existió hasta el siglo XIX. Los perros de las reinas Carlota y Victoria eran mucho más grandes, probablemente un Spitz Alemán y un Spitz Volpino. Lo mismo puede decirse de otros propietarios históricos de pomeranos anteriores al siglo XIX.\n','Los pomeranos son típicamente una raza amigable, alegre, amorosa y vivaz.8​ Les encanta estar alrededor de sus propietarios y son conocidos por ser protectores de ellos.9​ Están alertas y conscientes de los cambios en su medio ambiente y ladrándole a todo nuevo estímulo, lo que puede convertirse en un hábito de ladrar excesivamente en cualquier situación. Son defensivos de su territorio, y por lo tanto, van a ladrar por cualquier ruido exterior.10​ Son extrovertidos y disfrutan cuando son el centro de atención, pero pueden llegar a ser muy agresivos y dominantes si no están bien entrenados y educados.9​ Por lo mismo, también es muy importante socializarlo desde cachorro, ya que tampoco es raro que se muestren desconfiados en presencia de extraños.A nivel de inteligencia el pomerano ocupó el puesto veintitrés en la clasificación de Stanley Coren acerca de la inteligencia de los perros.11​Es un perro activo, independiente, que se adapta fácilmente a la vida urbana y es excelente para el campo. No obstante, puede que no interactúe bien con niños pequeños, ya que debido a su pequeña talla puede ser lastimado con facilidad. Hay que tener en cuenta que es un perro de carácter fuerte, como todos los spitz, por lo que no tolerará maltratos por parte de los pequeños, y podría llegar a morder o mostrarse asustado e inseguro en esos casos.Si se pretende introducir otro animal u otra mascota junto al pomerano, es mejor hacerlo cuando el animal es todavía cachorro. Se recomienda supervisar los juegos con perros de raza grande, ya que su pequeño tamaño y sus finos huesos lo hacen susceptible de sufrir graves daños con los movimientos y fuerza de un perro grande, pudiendo causarle heridas graves e incluso la muerte.',NULL,'NA');
/*!40000 ALTER TABLE `razas` ENABLE KEYS */;
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
