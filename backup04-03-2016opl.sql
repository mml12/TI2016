--
-- Current Database: `opl`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `opl` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `opl`;

--
-- Table structure for table `accounts`
--

DROP TABLE IF EXISTS `accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `accounts` (
  `id_accounts` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `account_type` varchar(45) NOT NULL COMMENT 'admin, grent, func, client',
  PRIMARY KEY (`id_accounts`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;