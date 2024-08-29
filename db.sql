-- MariaDB dump 10.19  Distrib 10.4.32-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: quizdb
-- ------------------------------------------------------
-- Server version	10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ergebnis`
--

DROP TABLE IF EXISTS `ergebnis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ergebnis` (
  `ErgebnisID` int(11) NOT NULL AUTO_INCREMENT,
  `SpielerID` int(11) DEFAULT NULL,
  `Pkt` int(11) DEFAULT NULL,
  `Datum` date DEFAULT NULL,
  PRIMARY KEY (`ErgebnisID`),
  KEY `SpielerID` (`SpielerID`),
  CONSTRAINT `ergebnis_ibfk_1` FOREIGN KEY (`SpielerID`) REFERENCES `spieler` (`SpielerID`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ergebnis`
--

LOCK TABLES `ergebnis` WRITE;
/*!40000 ALTER TABLE `ergebnis` DISABLE KEYS */;
INSERT INTO `ergebnis` VALUES (1,1,100,'2023-01-01'),(2,2,150,'2023-02-15'),(3,3,120,'2023-03-10'),(4,1,200,'2023-04-20');
/*!40000 ALTER TABLE `ergebnis` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kontinente`
--

DROP TABLE IF EXISTS `kontinente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kontinente` (
  `KontinentID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  PRIMARY KEY (`KontinentID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kontinente`
--

LOCK TABLES `kontinente` WRITE;
/*!40000 ALTER TABLE `kontinente` DISABLE KEYS */;
INSERT INTO `kontinente` VALUES (1,'Afrika'),(2,'Antarktika'),(3,'Asien'),(4,'Europa'),(5,'Nordamerika'),(6,'Ozeanien'),(7,'Südamerika');
/*!40000 ALTER TABLE `kontinente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `laender`
--

DROP TABLE IF EXISTS `laender`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `laender` (
  `LandID` int(11) NOT NULL AUTO_INCREMENT,
  `Land` varchar(255) NOT NULL,
  `Hauptstadt` varchar(255) NOT NULL,
  `KontinentID` int(11) DEFAULT NULL,
  `Abkuerzung` varchar(2) NOT NULL,
  PRIMARY KEY (`LandID`),
  KEY `KontinentID` (`KontinentID`),
  CONSTRAINT `laender_ibfk_1` FOREIGN KEY (`KontinentID`) REFERENCES `kontinente` (`KontinentID`)
) ENGINE=InnoDB AUTO_INCREMENT=196 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `laender`
--

LOCK TABLES `laender` WRITE;
/*!40000 ALTER TABLE `laender` DISABLE KEYS */;
INSERT INTO `laender` VALUES (1,'Afghanistan','Kabul',3,'AF'),(2,'Albanien','Tirana',4,'AL'),(3,'Algerien','Algier',1,'DZ'),(4,'Andorra','Andorra la Vella',4,'AD'),(5,'Angola','Luanda',1,'AO'),(6,'Argentinien','Buenos Aires',7,'AR'),(7,'Armenien','Eriwan',3,'AM'),(8,'Australien','Canberra',6,'AU'),(9,'Aserbaidschan','Baku',3,'AZ'),(10,'Äthiopien','Addis Abeba',1,'ET'),(11,'Bahamas','Nassau',5,'BS'),(12,'Bahrain','Manama',3,'BH'),(13,'Bangladesch','Dhaka',3,'BD'),(14,'Barbados','Bridgetown',5,'BB'),(15,'Belgien','Brüssel',4,'BE'),(16,'Belize','Belmopan',5,'BZ'),(17,'Benin','Porto-Novo',1,'BJ'),(18,'Bhutan','Thimphu',3,'BT'),(19,'Bolivien','Sucre',7,'BO'),(20,'Bosnien und Herzegowina','Sarajevo',4,'BA'),(21,'Botswana','Gaborone',1,'BW'),(22,'Brasilien','Brasília',7,'BR'),(23,'Brunei','Bandar Seri Begawan',3,'BN'),(24,'Bulgarien','Sofia',4,'BG'),(25,'Burkina Faso','Ouagadougou',1,'BF'),(26,'Burundi','Gitega',1,'BI'),(27,'Chile','Santiago de Chile',7,'CL'),(28,'China','Peking',3,'CN'),(29,'Costa Rica','San José',5,'CR'),(30,'Dänemark','Kopenhagen',4,'DK'),(31,'Deutschland','Berlin',4,'DE'),(32,'Dominica','Roseau',5,'DM'),(33,'Dominikanische Republik','Santo Domingo',5,'DO'),(34,'Dschibuti','Dschibuti',1,'DJ'),(35,'Ecuador','Quito',7,'EC'),(36,'El Salvador','San Salvador',5,'SV'),(37,'Elfenbeinküste','Yamoussoukro',1,'CI'),(38,'Eritrea','Asmara',1,'ER'),(39,'Estland','Tallinn',4,'EE'),(40,'Eswatini','Mbabane',1,'SZ'),(41,'Fidschi','Suva',6,'FJ'),(42,'Finnland','Helsinki',4,'FI'),(43,'Frankreich','Paris',4,'FR'),(44,'Gabun','Libreville',1,'GA'),(45,'Gambia','Banjul',1,'GM'),(46,'Georgien','Tiflis',3,'GE'),(47,'Ghana','Accra',1,'GH'),(48,'Grenada','St. George\'s',5,'GD'),(49,'Griechenland','Athen',4,'GR'),(50,'Guatemala','Guatemala-Stadt',5,'GT'),(51,'Guinea','Conakry',1,'GN'),(52,'Guinea-Bissau','Bissau',1,'GW'),(53,'Guyana','Georgetown',7,'GY'),(54,'Haiti','Port-au-Prince',5,'HT'),(55,'Honduras','Tegucigalpa',5,'HN'),(56,'Indien','Neu-Delhi',3,'IN'),(57,'Indonesien','Jakarta',3,'ID'),(58,'Irak','Bagdad',3,'IQ'),(59,'Iran','Teheran',3,'IR'),(60,'Irland','Dublin',4,'IE'),(61,'Island','Reykjavík',4,'IS'),(62,'Israel','Jerusalem',3,'IL'),(63,'Italien','Rom',4,'IT'),(64,'Jamaika','Kingston',5,'JM'),(65,'Japan','Tokio',3,'JP'),(66,'Jemen','Sanaa',3,'YE'),(67,'Jordanien','Amman',3,'JO'),(68,'Kambodscha','Phnom Penh',3,'KH'),(69,'Kamerun','Yaoundé',1,'CM'),(70,'Kanada','Ottawa',5,'CA'),(71,'Kap Verde','Praia',1,'CV'),(72,'Kasachstan','Astana',3,'KZ'),(73,'Katar','Doha',3,'QA'),(74,'Kenia','Nairobi',1,'KE'),(75,'Kirgisistan','Bischkek',3,'KG'),(76,'Kiribati','Tarawa',6,'KI'),(77,'Kolumbien','Bogotá',7,'CO'),(78,'Komoren','Moroni',1,'KM'),(79,'Demokratische Republik Kongo','Kinshasa',1,'CD'),(80,'Republik Kongo','Brazzaville',1,'CG'),(81,'Nordkorea','Pjöngjang',3,'KP'),(82,'Südkorea','Seoul',3,'KR'),(83,'Kosovo','Pristina',4,'XK'),(84,'Kroatien','Zagreb',4,'HR'),(85,'Kuba','Havanna',5,'CU'),(86,'Kuwait','Kuwait-Stadt',3,'KW'),(87,'Laos','Vientiane',3,'LA'),(88,'Lesotho','Maseru',1,'LS'),(89,'Lettland','Riga',4,'LV'),(90,'Libanon','Beirut',3,'LB'),(91,'Liberia','Monrovia',1,'LR'),(92,'Libyen','Tripolis',1,'LY'),(93,'Liechtenstein','Vaduz',4,'LI'),(94,'Litauen','Vilnius',4,'LT'),(95,'Luxemburg','Luxemburg',4,'LU'),(96,'Madagaskar','Antananarivo',1,'MG'),(97,'Malawi','Lilongwe',1,'MW'),(98,'Malaysia','Kuala Lumpur',3,'MY'),(99,'Malediven','Malé',3,'MV'),(100,'Mali','Bamako',1,'ML'),(101,'Malta','Valletta',4,'MT'),(102,'Marokko','Rabat',1,'MA'),(103,'Marshallinseln','Majuro',6,'MH'),(104,'Mauretanien','Nouakchott',1,'MR'),(105,'Mauritius','Port Louis',1,'MU'),(106,'Mexiko','Mexiko-Stadt',5,'MX'),(107,'Mikronesien','Palikir',6,'FM'),(108,'Moldawien','Chi?inau',4,'MD'),(109,'Monaco','Monaco',4,'MC'),(110,'Mongolei','Ulaanbaatar',3,'MN'),(111,'Montenegro','Podgorica',4,'ME'),(112,'Mosambik','Maputo',1,'MZ'),(113,'Myanmar','Naypyidaw',3,'MM'),(114,'Namibia','Windhoek',1,'NA'),(115,'Nauru','Yaren',6,'NR'),(116,'Nepal','Kathmandu',3,'NP'),(117,'Neuseeland','Wellington',6,'NZ'),(118,'Nicaragua','Managua',5,'NI'),(119,'Niederlande','Amsterdam',4,'NL'),(120,'Niger','Niamey',1,'NE'),(121,'Nigeria','Abuja',1,'NG'),(122,'Nordmazedonien','Skopje',4,'MK'),(123,'Norwegen','Oslo',4,'NO'),(124,'Oman','Maskat',3,'OM'),(125,'Österreich','Wien',4,'AT'),(126,'Pakistan','Islamabad',3,'PK'),(127,'Palau','Ngerulmud',6,'PW'),(128,'Panama','Panama-Stadt',5,'PA'),(129,'Papua-Neuguinea','Port Moresby',6,'PG'),(130,'Paraguay','Asunción',7,'PY'),(131,'Peru','Lima',7,'PE'),(132,'Philippinen','Manila',3,'PH'),(133,'Polen','Warschau',4,'PL'),(134,'Portugal','Lissabon',4,'PT'),(135,'Ruanda','Kigali',1,'RW'),(136,'Rumänien','Bukarest',4,'RO'),(137,'Russland','Moskau',3,'RU'),(138,'Saint Kitts und Nevis','Basseterre',5,'KN'),(139,'St. Lucia','Castries',5,'LC'),(140,'St. Vincent und die Grenadinen','Kingstown',5,'VC'),(141,'Samoa','Apia',6,'WS'),(142,'San Marino','San Marino',4,'SM'),(143,'São Tomé und Príncipe','São Tomé',1,'ST'),(144,'Saudi-Arabien','Riad',3,'SA'),(145,'Senegal','Dakar',1,'SN'),(146,'Serbien','Belgrad',4,'RS'),(147,'Seychellen','Victoria',1,'SC'),(148,'Sierra Leone','Freetown',1,'SL'),(149,'Simbabwe','Harare',1,'ZW'),(150,'Singapur','Singapur',3,'SG'),(151,'Slowakei','Bratislava',4,'SK'),(152,'Slowenien','Ljubljana',4,'SI'),(153,'Somalia','Mogadischu',1,'SO'),(154,'Spanien','Madrid',4,'ES'),(155,'Sri Lanka','Sri Jayawardenepura Kotte',3,'LK'),(156,'Südafrika','Pretoria',1,'ZA'),(157,'Sudan','Khartum',1,'SD'),(158,'Südsudan','Juba',1,'SS'),(159,'Suriname','Paramaribo',7,'SR'),(160,'Syrien','Damaskus',3,'SY'),(161,'Tadschikistan','Duschanbe',3,'TJ'),(162,'Tansania','Dodoma',1,'TZ'),(163,'Thailand','Bangkok',3,'TH'),(164,'Timor-Leste','Dili',3,'TL'),(165,'Togo','Lomé',1,'TG'),(166,'Tonga','Nuku?alofa',6,'TO'),(167,'Trinidad und Tobago','Port of Spain',5,'TT'),(168,'Tschad','N\'Djamena',1,'TD'),(169,'Tschechien','Prag',4,'CZ'),(170,'Tunesien','Tunis',1,'TN'),(171,'Türkei','Ankara',3,'TR'),(172,'Turkmenistan','Aschgabat',3,'TM'),(173,'Tuvalu','Funafuti',6,'TV'),(174,'Uganda','Kampala',1,'UG'),(175,'Ukraine','Kiew',4,'UA'),(176,'Ungarn','Budapest',4,'HU'),(177,'Uruguay','Montevideo',7,'UY'),(178,'Usbekistan','Taschkent',3,'UZ'),(179,'Vanuatu','Port Vila',6,'VU'),(180,'Venezuela','Caracas',7,'VE'),(181,'Vereinigte Arabische Emirate','Abu Dhabi',3,'AE'),(182,'Vereinigte Staaten','Washington, D.C.',5,'US'),(183,'Vereinigtes Königreich','London',4,'GB'),(184,'Vietnam','Hanoi',3,'VN'),(185,'Zentralafrikanische Republik','Bangui',1,'CF'),(186,'Zypern','Nikosia',3,'CY'),(187,'Äquatorialguinea','Malabo',1,'GQ'),(188,'Kongo','Brazzaville',1,'CG'),(189,'Libyen','Tripolis',1,'LY'),(190,'Mali','Bamako',1,'ML'),(191,'Montenegro','Podgorica',4,'ME'),(192,'Nordkorea','Pjöngjang',3,'KP'),(193,'São Tomé und Príncipe','São Tomé',1,'ST'),(194,'St. Vincent und die Grenadinen','Kingstown',5,'VC'),(195,'Tschad','N\'Djamena',1,'TD');
/*!40000 ALTER TABLE `laender` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `spieler`
--

DROP TABLE IF EXISTS `spieler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `spieler` (
  `SpielerID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  PRIMARY KEY (`SpielerID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `spieler`
--

LOCK TABLES `spieler` WRITE;
/*!40000 ALTER TABLE `spieler` DISABLE KEYS */;
INSERT INTO `spieler` VALUES (1,'Horst'),(2,'max'),(3,'Jamaine'),(4,'Max'),(5,'max'),(6,'max'),(7,'Hussein');
/*!40000 ALTER TABLE `spieler` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-28  0:16:11
