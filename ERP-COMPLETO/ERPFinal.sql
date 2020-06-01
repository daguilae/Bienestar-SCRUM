CREATE DATABASE  IF NOT EXISTS `mydb` /*!40100 DEFAULT CHARACTER SET latin1 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mydb`;
-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: mydb
-- ------------------------------------------------------
-- Server version	8.0.19

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
-- Table structure for table `acreedor`
--

DROP TABLE IF EXISTS `acreedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `acreedor` (
  `pkidacreedor` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `telefono` int DEFAULT NULL,
  `nit` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `calidadservicio` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidacreedor`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acreedor`
--

LOCK TABLES `acreedor` WRITE;
/*!40000 ALTER TABLE `acreedor` DISABLE KEYS */;
INSERT INTO `acreedor` VALUES (1,'Mario',53624126,'261542357','mario852@gmail.com','15 calle zona 2','Muy Insatisfecho',1),(2,'Distribuidora Santa',96745235,'712356981','laSanta@gmail.com','20 avenida de la calle A','Muy Insatisfecho',1),(3,'Alejandro',54454444,'454545454','alejandro22@gmail.com','63 avenida zona 5','Muy Insatisfecho',1);
/*!40000 ALTER TABLE `acreedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asistencia`
--

DROP TABLE IF EXISTS `asistencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `asistencia` (
  `pkcodigoasistencia` int NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int NOT NULL,
  `fechaentrada` date DEFAULT NULL,
  `fechasalida` date DEFAULT NULL,
  `horaentrada` time DEFAULT NULL,
  `horasalida` time DEFAULT NULL,
  PRIMARY KEY (`pkcodigoasistencia`),
  KEY `fk_asistencia_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_asistencia_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asistencia`
--

LOCK TABLES `asistencia` WRITE;
/*!40000 ALTER TABLE `asistencia` DISABLE KEYS */;
INSERT INTO `asistencia` VALUES (1,1,'2020-01-05','2020-01-05','07:00:00','16:00:00'),(2,2,'2020-02-04','2020-02-04','07:00:00','16:00:00'),(3,3,'2020-03-03','2020-03-03','07:00:00','16:00:00');
/*!40000 ALTER TABLE `asistencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ayuda`
--

DROP TABLE IF EXISTS `ayuda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ayuda` (
  `Id_ayuda` int NOT NULL,
  `Ruta` text CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `indice` text CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ayuda`
--

LOCK TABLES `ayuda` WRITE;
/*!40000 ALTER TABLE `ayuda` DISABLE KEYS */;
INSERT INTO `ayuda` VALUES (1,'Página web ayuda/ayuda.chm','menu.html'),(2,'Página web ayuda/ayuda.chm','Menúboletos.html'),(1,'Página web ayuda/ayuda.chm','menu.html'),(2,'Página web ayuda/ayuda.chm','Menúboletos.html');
/*!40000 ALTER TABLE `ayuda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ayudas`
--

DROP TABLE IF EXISTS `ayudas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ayudas` (
  `pkcodigoayuda` int NOT NULL,
  `rutayuda` varchar(190) DEFAULT NULL,
  `indicedeayuda` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkcodigoayuda`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ayudas`
--

LOCK TABLES `ayudas` WRITE;
/*!40000 ALTER TABLE `ayudas` DISABLE KEYS */;
INSERT INTO `ayudas` VALUES (1,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Conceptos.html',1),(2,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Curriculum.html',1),(3,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Despido.html',1),(4,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','MantenimientoDepartamentos.html',1),(5,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','ReuniónEliminar.html',1),(6,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','SanciónEliminar.html',1),(7,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Empleados.html',1),(8,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','ControlAsistencia.html',1),(9,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Reunión.html',1),(10,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Sanción.html',1),(11,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Jornada.html',1),(12,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Medio Comunicacion.html',1),(13,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','ReuniónModificar.html',1),(14,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','MantenimientoPerfiles.html',1),(15,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Tipo Contratacion.html',1),(16,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','asignacionempleado.html',1),(17,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','ProcesoBusquedaInterna.html',1),(18,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Convocatoria.html',1),(19,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Desempenio.html',1),(20,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','ProcesoBusquedaInterna',1),(21,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','PreSeleccion.html',1),(22,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Metas.html',1),(23,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Nomina.html',1),(24,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','PreSeleccion',1),(25,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','ProcesoSolicitudEmpleado',1),(55,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Acreedor.html',1),(56,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Ruta.html',1),(57,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Transporte.html',1),(58,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Tipo_Transporte.html',1),(59,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','DisponibilidadBodega.html',1),(60,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','MantenimientoImpuesto.html',1),(61,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','ProcesoFacturaProveedor.html',1),(62,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','devoluciones.html',1),(63,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','oredencompra.html',1),(64,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','ListaMovInv.html',1),(65,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','MovInv.html',1),(66,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','MantBodega.html',1),(67,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','MantProducto.html',1),(68,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','MantProveedores.html',1),(70,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','CuentasContables.html',1),(71,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','HorasExtras.html',1),(72,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Poliza.html',1),(73,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Estacion.html',1),(74,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','AsignacionEstacionPedido.html',1),(75,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','EstandarCalidad.html',1),(76,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','ControlCalidadProducto.html',1),(77,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Gastos.html',1),(78,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','CostosProduccion.html',1),(79,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','BodegaInterna.html',1),(80,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','DescripcionProducto.html',1),(81,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Formula.html',1),(82,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','Merma.html',1),(83,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','SeleccionPedido.html',1),(84,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','ProductoFormula.html',1),(85,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','SolicitudCompra.html',1),(86,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','TipoMerma.html',1),(87,'C:/Empresa_Bienestar/Ayudas/ayudasrrhh.chm','OrdenProduccion.html',1);
/*!40000 ALTER TABLE `ayudas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bitacora`
--

DROP TABLE IF EXISTS `bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bitacora` (
  `cod_bitacora` int NOT NULL AUTO_INCREMENT,
  `ip` varchar(45) DEFAULT NULL,
  `MAC` varchar(45) DEFAULT NULL,
  `usuario` varchar(45) DEFAULT NULL,
  `departamento` varchar(45) DEFAULT NULL,
  `fecha_hora` datetime DEFAULT NULL,
  `accion` varchar(45) DEFAULT NULL,
  `formulario` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`cod_bitacora`)
) ENGINE=InnoDB AUTO_INCREMENT=136 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bitacora`
--

LOCK TABLES `bitacora` WRITE;
/*!40000 ALTER TABLE `bitacora` DISABLE KEYS */;
INSERT INTO `bitacora` VALUES (49,'192.168.43.238','0A0027000002','1','SCM','0000-00-00 00:00:00','Guardar','Frm_MantRuta'),(50,'192.168.43.238','0A0027000002','1','SCM','0000-00-00 00:00:00','Guardar','Frm_MantTipoTransporte'),(51,'192.168.43.238','0A0027000002','1','SCM','0000-00-00 00:00:00','Guardar','Frm_MantTransporte'),(52,'','','','SCM','0000-00-00 00:00:00','Guardar','Frm_MantBodega'),(53,'192.168.43.238','0A0027000002','1','SCM','0000-00-00 00:00:00','Guardar','Frm_MantAcreedor'),(54,'192.168.43.238','0A0027000002','1','SCM','0000-00-00 00:00:00','Guardar','Frm_MantImpuestos'),(55,'','','','SCM','0000-00-00 00:00:00','Guardar','Frm_MantBodega'),(56,'','','','SCM','0000-00-00 00:00:00','Guardar','Frm_MantProducto'),(57,'','','','SCM','0000-00-00 00:00:00','Guardar','Frm_MantProducto'),(58,'192.168.43.238','0A0027000002','1','SCM','0000-00-00 00:00:00','Guardar','Frm_MantImpuestos'),(59,'192.168.43.238','0A0027000002','1','SCM','0000-00-00 00:00:00','Modificar','Frm_MantImpuestos'),(60,'','','1','SCM','0000-00-00 00:00:00','Guardar','Frm_MantProveedores'),(61,'','','1','SCM','0000-00-00 00:00:00','Modificar','Frm_MantProveedores'),(62,'192.168.43.238','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Modificar','Frm_MantEmpleado'),(63,'192.168.43.238','0A0027000002','Usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_Asignaciondeconcepto'),(64,'192.168.43.238','0A0027000002','Lucas','RRHH','0000-00-00 00:00:00','Guardar','Frm_MediodeComunicacion'),(65,'192.168.43.238','0A0027000002','Lucas','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantTipoContratacion'),(66,'192.168.43.238','0A0027000002','Lucas','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantTipoContratacion'),(67,'192.168.43.238','0A0027000002','Lucas','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantCurriculum'),(68,'192.168.43.238','0A0027000002','Lucas','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantJornada'),(69,'192.168.43.238','0A0027000002','Lucas','RRHH','0000-00-00 00:00:00','Modificar','Frm_MantJornada'),(70,'192.168.43.238','0A0027000002','Lucas','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantJornada'),(71,'192.168.43.238','0A0027000002','Lucas','RRHH','0000-00-00 00:00:00','Guardar','Frm_ManteDepartamento'),(72,'192.168.43.238','0A0027000002','Lucas','RRHH','0000-00-00 00:00:00','Modificar','Frm_ManteDepartamento'),(73,'','','Lucas','HRM','0000-00-00 00:00:00','Modificar','Frm_MantMeta'),(74,'','','Lucas','HRM','0000-00-00 00:00:00','Modificar','Frm_MantMeta'),(75,'','','Lucas','HRM','0000-00-00 00:00:00','Modificar','Frm_MantMeta'),(76,'','','Lucas','HRM','0000-00-00 00:00:00','Eliminar','Frm_MantMeta'),(77,'','','','HRM','0000-00-00 00:00:00','Guardar','Frm_EvaluacionMeta'),(78,'','','','HRM','0000-00-00 00:00:00','Guardar','Frm_DesempeñodeEmpleado'),(79,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Guardar','Frm_Despido'),(80,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Guardar','Frm_MediodeComunicacion'),(81,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Guardar','Frm_MediodeComunicacion'),(82,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Guardar','Frm_MediodeComunicacion'),(83,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Guardar','Frm_MediodeComunicacion'),(84,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Modificar','Frm_MediodeComunicacion'),(85,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantTipoContratacion'),(86,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantTipoContratacion'),(87,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Modificar','Frm_MediodeComunicacion'),(88,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Modificar','Frm_MediodeComunicacion'),(89,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantTipoContratacion'),(90,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantTipoContratacion'),(91,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Modificar','Frm_MantTipoContratacion'),(92,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Modificar','Frm_ManteDepartamento'),(93,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Guardar','Frm_ManteDepartamento'),(94,'','','LPERICO','HRM','0000-00-00 00:00:00','Modificar','Frm_MantMeta'),(95,'','','LPERICO','HRM','0000-00-00 00:00:00','Modificar','Frm_MantMeta'),(96,'','','LPERICO','HRM','0000-00-00 00:00:00','Modificar','Frm_MantMeta'),(97,'','','LPERICO','HRM','0000-00-00 00:00:00','Modificar','Frm_MantMeta'),(98,'','','','HRM','0000-00-00 00:00:00','Guardar','Frm_EvaluacionMeta'),(99,'','','','HRM','0000-00-00 00:00:00','Guardar','Frm_EvaluacionMeta'),(100,'','','','HRM','0000-00-00 00:00:00','Guardar','Frm_EvaluacionMeta'),(101,'','','','HRM','0000-00-00 00:00:00','Guardar','Frm_EvaluacionMeta'),(102,'','','','HRM','0000-00-00 00:00:00','Guardar','Frm_DesempeñodeEmpleado'),(103,'','','','HRM','0000-00-00 00:00:00','Guardar','Frm_DesempeñodeEmpleado'),(104,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantTipoContratacion'),(105,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantJornada'),(106,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Modificar','Frm_MantJornada'),(107,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantCurriculum'),(108,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantCurriculum'),(109,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantPercepciones'),(110,'192.168.43.238','0A0027000002','LPERICO','RRHH','0000-00-00 00:00:00','Modificar','Frm_MantPercepciones'),(111,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantPercepciones'),(112,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Modificar','Frm_MantPercepciones'),(113,'192.168.1.25','0A0027000002','','MRP','0000-00-00 00:00:00','Guardar','Frm_MantProductoFormula'),(114,'192.168.1.25','0A0027000002','','MRP','0000-00-00 00:00:00','Guardar','Frm_MantProductoFormula'),(115,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantEmpleado'),(116,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Guardar','Frm_MediodeComunicacion'),(117,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantTipoContratacion'),(118,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantTipoContratacion'),(119,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantTipoContratacion'),(120,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Eliminar','Frm_MantTipoContratacion'),(121,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantCurriculum'),(122,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantCurriculum'),(123,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantJornada'),(124,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Modificar','Frm_MantJornada'),(125,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Modificar','Frm_MantJornada'),(126,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Modificar','Frm_MantJornada'),(127,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Guardar','Frm_ManteDepartamento'),(128,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Guardar','Frm_ManteDepartamento'),(129,'192.168.1.25','0A0027000002','JOSE','RRHH','0000-00-00 00:00:00','Modificar','Frm_ManteDepartamento'),(130,'','','JOSE','HRM','0000-00-00 00:00:00','Modificar','Frm_MantMeta'),(131,'','','JOSE','HRM','0000-00-00 00:00:00','Modificar','Frm_MantMeta'),(132,'','','JOSE','HRM','0000-00-00 00:00:00','Modificar','Frm_MantMeta'),(133,'','','JOSE','HRM','0000-00-00 00:00:00','Modificar','Frm_MantMeta'),(134,'','','','HRM','0000-00-00 00:00:00','Guardar','Frm_EvaluacionMeta'),(135,'','','','HRM','0000-00-00 00:00:00','Guardar','Frm_DesempeñodeEmpleado');
/*!40000 ALTER TABLE `bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bodega`
--

DROP TABLE IF EXISTS `bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bodega` (
  `pkidBodega` int NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Telefono` int DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `StockMaximo` int DEFAULT NULL,
  `StockMinimo` int DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkidBodega`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bodega`
--

LOCK TABLES `bodega` WRITE;
/*!40000 ALTER TABLE `bodega` DISABLE KEYS */;
INSERT INTO `bodega` VALUES (1,'Bodega Central','20 calle de la zona 1',22361495,'BodegaC@gmail.com',50,5,'1'),(2,'Bodega Norte','16 avenida complejo B zon 14',22356242,'BodegaN@gmail.com',100,50,'1'),(3,'Bodega Sur','Residencial el pino zona 5',22647936,'BodegaS@gmail.com',250,100,'1');
/*!40000 ALTER TABLE `bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `candidatos_internos`
--

DROP TABLE IF EXISTS `candidatos_internos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `candidatos_internos` (
  `pkcodigocandidato` int NOT NULL AUTO_INCREMENT,
  `pksolicitudempleado` int NOT NULL,
  `pkcodperfil` int NOT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkcodigocandidato`,`pksolicitudempleado`,`pkcodperfil`),
  KEY `fk_candidatos_internos_tbl_solicitud_empleado_encabezado1_idx` (`pksolicitudempleado`),
  KEY `fk_candidatos_internos_perfil_encabezado1_idx` (`pkcodperfil`),
  CONSTRAINT `fk_candidatos_internos_perfil_encabezado1` FOREIGN KEY (`pkcodperfil`) REFERENCES `perfil_encabezado` (`pkcodperfil`),
  CONSTRAINT `fk_candidatos_internos_tbl_solicitud_empleado_encabezado1` FOREIGN KEY (`pksolicitudempleado`) REFERENCES `tbl_solicitud_empleado_encabezado` (`pksolicitudempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `candidatos_internos`
--

LOCK TABLES `candidatos_internos` WRITE;
/*!40000 ALTER TABLE `candidatos_internos` DISABLE KEYS */;
INSERT INTO `candidatos_internos` VALUES (1,1,1,1),(2,2,2,1),(3,3,3,1);
/*!40000 ALTER TABLE `candidatos_internos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria` (
  `pkcodcategoria` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkcodcategoria`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'Categoria 1'),(2,'Categoria 2'),(3,'Categoria 3');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `concepto`
--

DROP TABLE IF EXISTS `concepto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `concepto` (
  `pkcodigoconcepto` int NOT NULL,
  `nombreconcepto` varchar(45) DEFAULT NULL,
  `tipo_concepto` tinyint DEFAULT NULL,
  `saldo` double DEFAULT NULL,
  `tipo_accion` tinyint DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkcodigoconcepto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `concepto`
--

LOCK TABLES `concepto` WRITE;
/*!40000 ALTER TABLE `concepto` DISABLE KEYS */;
INSERT INTO `concepto` VALUES (1,'Maquinaria',1,699,1,1),(2,'Muebes',1,450,0,1),(3,'Bono 14',0,250,1,1),(4,'Bonificacion',0,612,0,1);
/*!40000 ALTER TABLE `concepto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conceptos_empleado`
--

DROP TABLE IF EXISTS `conceptos_empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `conceptos_empleado` (
  `pkconceptoempleado` int NOT NULL AUTO_INCREMENT,
  `pknombreconcepto` varchar(25) DEFAULT NULL,
  `Total_monto` int DEFAULT NULL,
  PRIMARY KEY (`pkconceptoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conceptos_empleado`
--

LOCK TABLES `conceptos_empleado` WRITE;
/*!40000 ALTER TABLE `conceptos_empleado` DISABLE KEYS */;
INSERT INTO `conceptos_empleado` VALUES (1,'1',250),(2,'2',423),(3,'3',951);
/*!40000 ALTER TABLE `conceptos_empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `costodefabricacion`
--

DROP TABLE IF EXISTS `costodefabricacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `costodefabricacion` (
  `pkidcostodefabricacion` int NOT NULL,
  `pkidprocesoproduccion` int DEFAULT NULL,
  `pkidmerma` int DEFAULT NULL,
  `costototal` double DEFAULT NULL,
  PRIMARY KEY (`pkidcostodefabricacion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `costodefabricacion`
--

LOCK TABLES `costodefabricacion` WRITE;
/*!40000 ALTER TABLE `costodefabricacion` DISABLE KEYS */;
INSERT INTO `costodefabricacion` VALUES (1,1,1,555),(2,2,2,472),(3,3,3,951);
/*!40000 ALTER TABLE `costodefabricacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuentas_contable`
--

DROP TABLE IF EXISTS `cuentas_contable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cuentas_contable` (
  `pkcodigocuenta` int NOT NULL,
  `nombre_cuenta` varchar(45) DEFAULT NULL,
  `monto` int DEFAULT NULL,
  `debe_haber` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkcodigocuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuentas_contable`
--

LOCK TABLES `cuentas_contable` WRITE;
/*!40000 ALTER TABLE `cuentas_contable` DISABLE KEYS */;
INSERT INTO `cuentas_contable` VALUES (121,'ALQUILERES',2500,1),(141,'SUMINISTROS',9666,1),(191,'MATERIALES INDIRECTOS',1235,0);
/*!40000 ALTER TABLE `cuentas_contable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamentos`
--

DROP TABLE IF EXISTS `departamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departamentos` (
  `pkcodigodepto` int NOT NULL,
  `nombredepto` varchar(45) DEFAULT NULL,
  `descripciondepto` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkcodigodepto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamentos`
--

LOCK TABLES `departamentos` WRITE;
/*!40000 ALTER TABLE `departamentos` DISABLE KEYS */;
INSERT INTO `departamentos` VALUES (1,'RRHH','Recurso Humano',1),(2,'IT','Tencologia',1),(3,'Finanzas','Finanzas',1);
/*!40000 ALTER TABLE `departamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `despidoempleado`
--

DROP TABLE IF EXISTS `despidoempleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `despidoempleado` (
  `pkcodigodespidoempleado` int NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int NOT NULL,
  `razondespido` varchar(45) DEFAULT NULL,
  `descripciondespido` varchar(45) DEFAULT NULL,
  `fechadespido` date DEFAULT NULL,
  `indemnizacion` double DEFAULT NULL,
  PRIMARY KEY (`pkcodigodespidoempleado`),
  KEY `fk_despidoempleado_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_despidoempleado_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `despidoempleado`
--

LOCK TABLES `despidoempleado` WRITE;
/*!40000 ALTER TABLE `despidoempleado` DISABLE KEYS */;
INSERT INTO `despidoempleado` VALUES (1,4,'Incumplimiemto de obligaciones','El empleado presento serias faltas al reglame','2020-01-01',1027.4);
/*!40000 ALTER TABLE `despidoempleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_produccion`
--

DROP TABLE IF EXISTS `detalle_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalle_produccion` (
  `pkidencabezadop` int NOT NULL,
  `pkidformula` int DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidencabezadop`),
  CONSTRAINT `fk_detalle_produccion_encabezado_produccion1` FOREIGN KEY (`pkidencabezadop`) REFERENCES `encabezado_produccion` (`pkidencabezadop`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_produccion`
--

LOCK TABLES `detalle_produccion` WRITE;
/*!40000 ALTER TABLE `detalle_produccion` DISABLE KEYS */;
INSERT INTO `detalle_produccion` VALUES (1,1,1),(2,2,1),(3,3,1);
/*!40000 ALTER TABLE `detalle_produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `devoluciones`
--

DROP TABLE IF EXISTS `devoluciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `devoluciones` (
  `pkcodigodev` int NOT NULL,
  `pkidEncabezadoFacturaP` int NOT NULL,
  `pkcodigoempleado` int DEFAULT NULL,
  `fkIdOrdenCompra` int DEFAULT NULL,
  `numerofactura` varchar(45) DEFAULT NULL,
  `total` varchar(45) DEFAULT NULL,
  `motivo` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkcodigodev`),
  KEY `fk_devoluciones1_idx` (`pkcodigoempleado`),
  KEY `fk_devoluciones_ordenComrpaEncabezado1_idx` (`fkIdOrdenCompra`),
  CONSTRAINT `fk_devoluciones_empleado1` FOREIGN KEY (`pkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`),
  CONSTRAINT `fk_devoluciones_ordenComrpaEncabezado1` FOREIGN KEY (`fkIdOrdenCompra`) REFERENCES `ordencomrpaencabezado` (`pkIdOrdenCompraEncabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devoluciones`
--

LOCK TABLES `devoluciones` WRITE;
/*!40000 ALTER TABLE `devoluciones` DISABLE KEYS */;
INSERT INTO `devoluciones` VALUES (1,5,1,1,'Factura  ff 12','4','No cumplia'),(2,5,1,1,'Factura  ff 12','4','Falta la calidad'),(3,6,1,1,'Factura  gf 122','10','No funciono');
/*!40000 ALTER TABLE `devoluciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleado` (
  `pkcodigoempleado` int NOT NULL,
  `fkcodigojornada` int NOT NULL,
  `primernombre` varchar(45) DEFAULT NULL,
  `segundonombre` varchar(45) DEFAULT NULL,
  `primerapellido` varchar(45) DEFAULT NULL,
  `segundoapellido` varchar(45) DEFAULT NULL,
  `fechadecontratacion` date DEFAULT NULL,
  `celular` int DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `fechanacimiento` date DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  `TipoContratacion_pkcodigocontratacion` int DEFAULT NULL,
  `nit` int DEFAULT NULL,
  PRIMARY KEY (`pkcodigoempleado`),
  KEY `fk_empleado_jornada_idx` (`fkcodigojornada`),
  CONSTRAINT `fk_empleado_jornada` FOREIGN KEY (`fkcodigojornada`) REFERENCES `jornada` (`pkcodigojornada`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES (1,1,'Lucas','Ambrocio','Fernandez','Lopez','2015-05-05',46253515,'lucas58@gmail.com','15 calle zona 5','1998-05-06',1,1,65351524),(2,1,'Palito','Ortega','De Leon','Aguirre','2020-01-01',16321542,'pablito@gmail.com','16calle zona 1','1980-06-11',1,1,74125896),(3,2,'Jose','Alejandro','Gonzalez','Teo','2016-01-01',16824578,'jose@gmail.com','zona 7 de la capital','1998-01-05',1,1,13265489),(4,2,'Josue ','Alonso','Galvez ','Ochoa','2019-05-05',56324115,'josue@gmail.com','zona 6 de villa nueva','1998-05-05',0,2,96325874);
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleadocontable`
--

DROP TABLE IF EXISTS `empleadocontable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleadocontable` (
  `pkcodigolinea` int NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int DEFAULT NULL,
  `fkcodigoconcepto` int DEFAULT NULL,
  PRIMARY KEY (`pkcodigolinea`),
  KEY `fk_empleadocontable_empleado1_idx` (`fkcodigoempleado`),
  KEY `fk_empleadocontable_concepto1_idx` (`fkcodigoconcepto`),
  CONSTRAINT `fk_empleadocontable_concepto1` FOREIGN KEY (`fkcodigoconcepto`) REFERENCES `concepto` (`pkcodigoconcepto`),
  CONSTRAINT `fk_empleadocontable_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleadocontable`
--

LOCK TABLES `empleadocontable` WRITE;
/*!40000 ALTER TABLE `empleadocontable` DISABLE KEYS */;
INSERT INTO `empleadocontable` VALUES (1,1,1),(2,1,2),(3,2,1);
/*!40000 ALTER TABLE `empleadocontable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `encabezado_produccion`
--

DROP TABLE IF EXISTS `encabezado_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `encabezado_produccion` (
  `pkidencabezadop` int NOT NULL,
  `pkidpedido` int DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `total` double DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidencabezadop`),
  KEY `fk_encabezado_produccion_pedido1_idx` (`pkidpedido`),
  CONSTRAINT `fk_encabezado_produccion_pedido1` FOREIGN KEY (`pkidpedido`) REFERENCES `pedido` (`pkidpedido`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `encabezado_produccion`
--

LOCK TABLES `encabezado_produccion` WRITE;
/*!40000 ALTER TABLE `encabezado_produccion` DISABLE KEYS */;
INSERT INTO `encabezado_produccion` VALUES (1,7,'Produccion para el cliente CX',4,1),(2,1,'Produccion Urgente',25,1),(3,5,'Produccion con acabados especiales',15,1);
/*!40000 ALTER TABLE `encabezado_produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entradas_salidas`
--

DROP TABLE IF EXISTS `entradas_salidas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `entradas_salidas` (
  `pkidentradaysalida` int NOT NULL,
  `pkidmaestroactivos` int DEFAULT NULL,
  `movimiento` tinyint DEFAULT NULL,
  `pkcodigoempleado` int DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `pkidencabezadop` int DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkidentradaysalida`),
  KEY `fk_entradas_salidas_maestroactivos1_idx` (`pkidmaestroactivos`),
  KEY `fk_entradas_salidas_empleado1_idx` (`pkcodigoempleado`),
  KEY `fk_entradas_salidas_encabezado_produccion1_idx` (`pkidencabezadop`),
  CONSTRAINT `fk_entradas_salidas_empleado1` FOREIGN KEY (`pkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`),
  CONSTRAINT `fk_entradas_salidas_encabezado_produccion1` FOREIGN KEY (`pkidencabezadop`) REFERENCES `encabezado_produccion` (`pkidencabezadop`),
  CONSTRAINT `fk_entradas_salidas_maestroactivos1` FOREIGN KEY (`pkidmaestroactivos`) REFERENCES `maestroactivos` (`pkidmaestroactivos`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entradas_salidas`
--

LOCK TABLES `entradas_salidas` WRITE;
/*!40000 ALTER TABLE `entradas_salidas` DISABLE KEYS */;
INSERT INTO `entradas_salidas` VALUES (1,1,0,1,25,1,'Salida'),(2,2,1,2,15,2,'Entrada'),(3,1,1,1,5,1,'Entrada');
/*!40000 ALTER TABLE `entradas_salidas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estacion`
--

DROP TABLE IF EXISTS `estacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estacion` (
  `pkidestacion` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `pkcodigoempleado` int DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidestacion`),
  KEY `fk_estacion_empleado1_idx` (`pkcodigoempleado`),
  CONSTRAINT `fk_estacion_empleado1` FOREIGN KEY (`pkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estacion`
--

LOCK TABLES `estacion` WRITE;
/*!40000 ALTER TABLE `estacion` DISABLE KEYS */;
INSERT INTO `estacion` VALUES (1,'Costura',1,1),(2,'Ensamble',2,1),(3,'Pegado',3,1);
/*!40000 ALTER TABLE `estacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estandardecalidad`
--

DROP TABLE IF EXISTS `estandardecalidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estandardecalidad` (
  `pkidestandardecalidad` int NOT NULL,
  `categoria` varchar(45) DEFAULT NULL,
  `descripcion` varchar(90) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidestandardecalidad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estandardecalidad`
--

LOCK TABLES `estandardecalidad` WRITE;
/*!40000 ALTER TABLE `estandardecalidad` DISABLE KEYS */;
INSERT INTO `estandardecalidad` VALUES (1,'Costura','Costura con calidad',1),(2,'Pegado','Pegado segun norma',1),(3,'Ensamble ','Ensamble en orden',1);
/*!40000 ALTER TABLE `estandardecalidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facturaproveedordetalle`
--

DROP TABLE IF EXISTS `facturaproveedordetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `facturaproveedordetalle` (
  `pkidDetalleFactura` int NOT NULL AUTO_INCREMENT,
  `fkidEncabezadoFactura` int DEFAULT NULL,
  `fkidProducto` int DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `precioUnitario` double DEFAULT NULL,
  `subTotal` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidDetalleFactura`),
  KEY `fk_facturaProveedorDetalle_facturaProveedorEncabezado1_idx` (`fkidEncabezadoFactura`),
  KEY `fk_facturaProveedorDetalle_producto1_idx` (`fkidProducto`),
  CONSTRAINT `fk_facturaProveedorDetalle_facturaProveedorEncabezado1` FOREIGN KEY (`fkidEncabezadoFactura`) REFERENCES `facturaproveedorencabezado` (`pkidEncabezadoFacturaP`),
  CONSTRAINT `fk_facturaProveedorDetalle_producto1` FOREIGN KEY (`fkidProducto`) REFERENCES `producto` (`pkidProducto`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturaproveedordetalle`
--

LOCK TABLES `facturaproveedordetalle` WRITE;
/*!40000 ALTER TABLE `facturaproveedordetalle` DISABLE KEYS */;
INSERT INTO `facturaproveedordetalle` VALUES (13,5,1,1,1,1,1),(14,5,2,1,2,1,1),(15,6,1,1,1,1,1),(16,6,2,1,2,2,1);
/*!40000 ALTER TABLE `facturaproveedordetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facturaproveedorencabezado`
--

DROP TABLE IF EXISTS `facturaproveedorencabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `facturaproveedorencabezado` (
  `pkidEncabezadoFacturaP` int NOT NULL,
  `fkIdOrdenCompra` int DEFAULT NULL,
  `pkcodigoempleado` int DEFAULT NULL,
  `segun` varchar(45) DEFAULT NULL,
  `serieFactura` varchar(45) DEFAULT NULL,
  `numeroFactura` varchar(45) DEFAULT NULL,
  `fechaEntrega` date DEFAULT NULL,
  `fkIdImpuesto` int DEFAULT NULL,
  `totalImpuesto` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `descuento` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidEncabezadoFacturaP`),
  KEY `fk_facturaProveedorEncabezado_empleado1_idx` (`pkcodigoempleado`),
  KEY `fk_facturaproveedorencabezado_ordenComrpaEncabezado1_idx` (`fkIdOrdenCompra`),
  KEY `fk_facturaproveedorencabezado_impuestos1_idx` (`fkIdImpuesto`),
  CONSTRAINT `fk_facturaProveedorEncabezado_empleado1` FOREIGN KEY (`pkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`),
  CONSTRAINT `fk_facturaproveedorencabezado_impuestos1` FOREIGN KEY (`fkIdImpuesto`) REFERENCES `impuestos` (`pkidImpuesto`),
  CONSTRAINT `fk_facturaproveedorencabezado_ordenComrpaEncabezado1` FOREIGN KEY (`fkIdOrdenCompra`) REFERENCES `ordencomrpaencabezado` (`pkIdOrdenCompraEncabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturaproveedorencabezado`
--

LOCK TABLES `facturaproveedorencabezado` WRITE;
/*!40000 ALTER TABLE `facturaproveedorencabezado` DISABLE KEYS */;
INSERT INTO `facturaproveedorencabezado` VALUES (1,1,1,'Factura  ss 22','ss','22','2020-04-15',1,2,4,0,1),(2,1,1,'Factura  df 12','df','12','2020-04-15',1,2,4,0,1),(3,1,1,'Factura  bb 12','bb','12','2020-04-15',1,2,4,0,1),(4,1,1,'Factura  ff 12','ff','12','2020-04-15',1,2,4,0,1),(5,1,1,'Factura  ff 12','ff','12','2020-04-15',1,2,4,0,1),(6,1,1,'Factura  gf 122','gf','122','2020-04-15',1,5,10,0,1),(7,2,1,'Factura  A5 123','A5','123','2020-04-22',1,7,70,12,1);
/*!40000 ALTER TABLE `facturaproveedorencabezado` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tgr_desactivar_ordenc` AFTER INSERT ON `facturaproveedorencabezado` FOR EACH ROW begin
UPDATE ordencomrpaencabezado
SET estado='0' WHERE pkIdOrdenCompraEncabezado=New.fkIdOrdenCompra; 
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `formaspago`
--

DROP TABLE IF EXISTS `formaspago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `formaspago` (
  `pkIdFormaPago` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkIdFormaPago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formaspago`
--

LOCK TABLES `formaspago` WRITE;
/*!40000 ALTER TABLE `formaspago` DISABLE KEYS */;
INSERT INTO `formaspago` VALUES (1,'Efectivo','Efectivo unicamente',1),(2,'Credito','Credito de 15 dias',1),(3,'Cheque','Verificar fondos',1);
/*!40000 ALTER TABLE `formaspago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formula_detalle`
--

DROP TABLE IF EXISTS `formula_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `formula_detalle` (
  `pkidformulaencabezado` int NOT NULL,
  `linea` int NOT NULL,
  `pkidProducto` int DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `medida` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`linea`,`pkidformulaencabezado`),
  KEY `fk_formula_detalle_formula_encabezado1_idx` (`pkidformulaencabezado`),
  CONSTRAINT `fk_formula_detalle_formula_encabezado1` FOREIGN KEY (`pkidformulaencabezado`) REFERENCES `formula_encabezado` (`pkidformulaencabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formula_detalle`
--

LOCK TABLES `formula_detalle` WRITE;
/*!40000 ALTER TABLE `formula_detalle` DISABLE KEYS */;
INSERT INTO `formula_detalle` VALUES (1,1,5,15,'c',1),(2,1,2,13,'c',1),(3,1,2,13,'g',1),(1,2,6,5,'g',1),(2,2,3,1,'g',1);
/*!40000 ALTER TABLE `formula_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formula_encabezado`
--

DROP TABLE IF EXISTS `formula_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `formula_encabezado` (
  `pkidformulaencabezado` int NOT NULL,
  `pkidProducto` int DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidformulaencabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formula_encabezado`
--

LOCK TABLES `formula_encabezado` WRITE;
/*!40000 ALTER TABLE `formula_encabezado` DISABLE KEYS */;
INSERT INTO `formula_encabezado` VALUES (1,2,'Realizar bajo supervision',1),(2,1,'Utilizar mucha agua',1),(3,3,'Anadir mas colorante',1);
/*!40000 ALTER TABLE `formula_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gastos_indirectos`
--

DROP TABLE IF EXISTS `gastos_indirectos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gastos_indirectos` (
  `pkidgastos_indirectos` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `valor` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidgastos_indirectos`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gastos_indirectos`
--

LOCK TABLES `gastos_indirectos` WRITE;
/*!40000 ALTER TABLE `gastos_indirectos` DISABLE KEYS */;
INSERT INTO `gastos_indirectos` VALUES (1,'Agua',150,1),(2,'Luz',263,1),(3,'Internet',852,1);
/*!40000 ALTER TABLE `gastos_indirectos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horasextras`
--

DROP TABLE IF EXISTS `horasextras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `horasextras` (
  `pkcodigohorasextras` int NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int NOT NULL,
  `cantidad` varchar(45) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkcodigohorasextras`),
  KEY `fk_horasextras_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_horasextras_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horasextras`
--

LOCK TABLES `horasextras` WRITE;
/*!40000 ALTER TABLE `horasextras` DISABLE KEYS */;
INSERT INTO `horasextras` VALUES (1,1,'12','2020-05-05',1),(2,2,'5','2020-04-04',1),(3,3,'1','2020-01-01',1);
/*!40000 ALTER TABLE `horasextras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `impuestos`
--

DROP TABLE IF EXISTS `impuestos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `impuestos` (
  `pkidImpuesto` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `valor` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidImpuesto`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `impuestos`
--

LOCK TABLES `impuestos` WRITE;
/*!40000 ALTER TABLE `impuestos` DISABLE KEYS */;
INSERT INTO `impuestos` VALUES (1,'IVA','Aplicable ',12.5,1),(2,'Armas','De juguete o reales',62.3,1),(3,'Juguetes','Todos',20.3,1);
/*!40000 ALTER TABLE `impuestos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jornada`
--

DROP TABLE IF EXISTS `jornada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jornada` (
  `pkcodigojornada` int NOT NULL,
  `nombrejornada` varchar(45) DEFAULT NULL,
  `horasjornada` int DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkcodigojornada`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jornada`
--

LOCK TABLES `jornada` WRITE;
/*!40000 ALTER TABLE `jornada` DISABLE KEYS */;
INSERT INTO `jornada` VALUES (1,'Matutina',8,1),(2,'Vespertina',4,1),(3,'Mixta',5,1);
/*!40000 ALTER TABLE `jornada` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kpi`
--

DROP TABLE IF EXISTS `kpi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kpi` (
  `pkcodigokpi` int NOT NULL AUTO_INCREMENT,
  `fechadeasignacion` date DEFAULT NULL,
  `puntuacion` int DEFAULT NULL,
  `fkcodempleado` int DEFAULT NULL,
  `fkcodigo_meta` int DEFAULT NULL,
  `estado_completado` varchar(45) DEFAULT NULL,
  `fecha_realizacion` date DEFAULT NULL,
  PRIMARY KEY (`pkcodigokpi`),
  KEY `fk_kpi_meta1_idx` (`fkcodigo_meta`),
  KEY `fk_kpi_empleado1_idx` (`fkcodempleado`),
  CONSTRAINT `fk_kpi_empleado1` FOREIGN KEY (`fkcodempleado`) REFERENCES `empleado` (`pkcodigoempleado`),
  CONSTRAINT `fk_kpi_meta1` FOREIGN KEY (`fkcodigo_meta`) REFERENCES `meta` (`pkcodigo_meta`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kpi`
--

LOCK TABLES `kpi` WRITE;
/*!40000 ALTER TABLE `kpi` DISABLE KEYS */;
INSERT INTO `kpi` VALUES (1,'2020-05-18',55,2,1,'1','2020-05-18'),(2,'2020-04-05',90,1,2,'1','2020-04-05'),(3,'2020-01-06',66,3,3,'1','2020-01-06');
/*!40000 ALTER TABLE `kpi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `libro_diario`
--

DROP TABLE IF EXISTS `libro_diario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `libro_diario` (
  `pkidlibrodiario` int NOT NULL,
  `nombredelmovimiento` varchar(90) DEFAULT NULL,
  `fechadelmovimiento` date DEFAULT NULL,
  `debehaber` tinyint DEFAULT NULL,
  `valor` double DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidlibrodiario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `libro_diario`
--

LOCK TABLES `libro_diario` WRITE;
/*!40000 ALTER TABLE `libro_diario` DISABLE KEYS */;
INSERT INTO `libro_diario` VALUES (1,'Cobro de Factura 1','2020-04-01',0,250,1),(2,'Reembolso Factura 2','2020-03-15',1,642,1),(3,'Cobro Cliente','2020-01-05',0,148,1);
/*!40000 ALTER TABLE `libro_diario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maestroactivos`
--

DROP TABLE IF EXISTS `maestroactivos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `maestroactivos` (
  `pkidmaestroactivos` int NOT NULL,
  `pkidProducto` int DEFAULT NULL,
  `existencia_actual` double DEFAULT NULL,
  `stock_minimo` double DEFAULT NULL,
  `stock_maximo` double DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidmaestroactivos`),
  KEY `fk_maestroactivos_producto1_idx` (`pkidProducto`),
  CONSTRAINT `fk_maestroactivos_producto1` FOREIGN KEY (`pkidProducto`) REFERENCES `producto` (`pkidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maestroactivos`
--

LOCK TABLES `maestroactivos` WRITE;
/*!40000 ALTER TABLE `maestroactivos` DISABLE KEYS */;
INSERT INTO `maestroactivos` VALUES (1,2,25,20,100,1),(2,1,16,10,20,1),(3,5,55,10,75,1);
/*!40000 ALTER TABLE `maestroactivos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mediodecomunicacion`
--

DROP TABLE IF EXISTS `mediodecomunicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mediodecomunicacion` (
  `pkmediodecomunicacion` int NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Telefono` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkmediodecomunicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mediodecomunicacion`
--

LOCK TABLES `mediodecomunicacion` WRITE;
/*!40000 ALTER TABLE `mediodecomunicacion` DISABLE KEYS */;
INSERT INTO `mediodecomunicacion` VALUES (1,'tv azteca','Avenida de los arboles zona 15','22365266',1),(2,'Prensa','Avenida Las Americas zona 10','22361452',1),(3,'Revista Nosotros','Los alamos norte zona 4','22146385',1);
/*!40000 ALTER TABLE `mediodecomunicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `merma`
--

DROP TABLE IF EXISTS `merma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `merma` (
  `pkidmerma` int NOT NULL,
  `pkidtipomerma` int DEFAULT NULL,
  `pkidProducto` int DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `valor` double DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidmerma`),
  KEY `fk_merma_tipomerma1_idx` (`pkidtipomerma`),
  KEY `fk_merma_producto1_idx` (`pkidProducto`),
  CONSTRAINT `fk_merma_producto1` FOREIGN KEY (`pkidProducto`) REFERENCES `producto` (`pkidProducto`),
  CONSTRAINT `fk_merma_tipomerma1` FOREIGN KEY (`pkidtipomerma`) REFERENCES `tipomerma` (`pkidtipomerma`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `merma`
--

LOCK TABLES `merma` WRITE;
/*!40000 ALTER TABLE `merma` DISABLE KEYS */;
INSERT INTO `merma` VALUES (1,1,1,15,250,1),(2,2,2,16,355,1),(3,3,3,24,100,1);
/*!40000 ALTER TABLE `merma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `meta`
--

DROP TABLE IF EXISTS `meta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `meta` (
  `pkcodigo_meta` int NOT NULL AUTO_INCREMENT,
  `nombre_meta` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `plazo_meta` varchar(45) DEFAULT NULL,
  `puntaje` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkcodigo_meta`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `meta`
--

LOCK TABLES `meta` WRITE;
/*!40000 ALTER TABLE `meta` DISABLE KEYS */;
INSERT INTO `meta` VALUES (1,'Meta12','Companerismo','3','25',1),(2,'Meta 2','Alcanzable por cubrir todos los lineamientos','2','75',1),(3,'Meta Politicas','Politicas Alcanzadas','3','66',1);
/*!40000 ALTER TABLE `meta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento_detalle`
--

DROP TABLE IF EXISTS `movimiento_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimiento_detalle` (
  `Linea` int NOT NULL AUTO_INCREMENT,
  `pkidMovimiento` int NOT NULL,
  `pkidmovimiento_general` int NOT NULL,
  PRIMARY KEY (`Linea`,`pkidMovimiento`,`pkidmovimiento_general`),
  KEY `fk_movimiento_detalle_movimiento_encabezado1_idx` (`pkidMovimiento`),
  KEY `fk_movimiento_detalle_movimiento_general1_idx` (`pkidmovimiento_general`),
  CONSTRAINT `fk_movimiento_detalle_movimiento_encabezado1` FOREIGN KEY (`pkidMovimiento`) REFERENCES `movimiento_encabezado` (`pkidMovimiento`),
  CONSTRAINT `fk_movimiento_detalle_movimiento_general1` FOREIGN KEY (`pkidmovimiento_general`) REFERENCES `movimiento_general` (`pkidmovimiento_general`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento_detalle`
--

LOCK TABLES `movimiento_detalle` WRITE;
/*!40000 ALTER TABLE `movimiento_detalle` DISABLE KEYS */;
INSERT INTO `movimiento_detalle` VALUES (1,1,1),(2,2,2),(3,3,3);
/*!40000 ALTER TABLE `movimiento_detalle` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `actualizarExistencias` AFTER INSERT ON `movimiento_detalle` FOR EACH ROW BEGIN

DECLARE x INT;
DECLARE x2 INT;
  SET x = (SELECT MAX(pkidProducto) FROM movimiento_general WHERE concepto = 'Factura Compra');
  SET x2 = (SELECT MAX(cantidad) FROM movimiento_general WHERE concepto = 'Factura Compra');
      Update productoenbodega set productoenbodega.Existencias = productoenbodega.Existencias + x2
      where productoenbodega.pkidProducto = x;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `movimiento_encabezado`
--

DROP TABLE IF EXISTS `movimiento_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimiento_encabezado` (
  `pkidMovimiento` int NOT NULL,
  `pkcodigoempleado` int NOT NULL,
  `Fecha` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidMovimiento`,`pkcodigoempleado`),
  KEY `fk_movimiento_encabezado_empleado1_idx` (`pkcodigoempleado`),
  CONSTRAINT `fk_movimiento_encabezado_empleado1` FOREIGN KEY (`pkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento_encabezado`
--

LOCK TABLES `movimiento_encabezado` WRITE;
/*!40000 ALTER TABLE `movimiento_encabezado` DISABLE KEYS */;
INSERT INTO `movimiento_encabezado` VALUES (1,1,'2020-05-05',1),(2,2,'2020-04-06',1),(3,3,'2020-05-08',1);
/*!40000 ALTER TABLE `movimiento_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento_general`
--

DROP TABLE IF EXISTS `movimiento_general`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimiento_general` (
  `pkidmovimiento_general` int NOT NULL AUTO_INCREMENT,
  `pkidProducto` int DEFAULT NULL,
  `concepto` varchar(45) DEFAULT NULL,
  `documento` varchar(45) DEFAULT NULL,
  `cantidad` int DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`pkidmovimiento_general`),
  KEY `fk_movimiento_general_producto1_idx` (`pkidProducto`),
  CONSTRAINT `fk_movimiento_general_producto1` FOREIGN KEY (`pkidProducto`) REFERENCES `producto` (`pkidProducto`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento_general`
--

LOCK TABLES `movimiento_general` WRITE;
/*!40000 ALTER TABLE `movimiento_general` DISABLE KEYS */;
INSERT INTO `movimiento_general` VALUES (1,1,'Factura R 123','Factura ',25,'2020-05-06'),(2,2,'Factura H 321','Factura',63,'2020-01-05'),(3,3,'Factura L 963','Factura ',10,'2020-02-03');
/*!40000 ALTER TABLE `movimiento_general` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nomina_encabezado`
--

DROP TABLE IF EXISTS `nomina_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nomina_encabezado` (
  `pkcodigonomina` int NOT NULL,
  `tipo_nomina` tinyint DEFAULT NULL,
  `fechainicio` date DEFAULT NULL,
  `fechafin` date DEFAULT NULL,
  `fkcodigoempleado` int DEFAULT NULL,
  `Observaciones` varchar(45) DEFAULT NULL,
  `saldo_total` double DEFAULT '0',
  PRIMARY KEY (`pkcodigonomina`),
  KEY `fk_nomina_encabezado_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_nomina_encabezado_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nomina_encabezado`
--

LOCK TABLES `nomina_encabezado` WRITE;
/*!40000 ALTER TABLE `nomina_encabezado` DISABLE KEYS */;
INSERT INTO `nomina_encabezado` VALUES (1,0,'2020-01-01','2020-01-31',1,'Sueldos generales',250),(2,0,'2020-02-07','2020-02-14',2,'Semanal',366),(3,0,'2020-03-15','2020-04-01',3,'Cada quince',751);
/*!40000 ALTER TABLE `nomina_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nominadetalle`
--

DROP TABLE IF EXISTS `nominadetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nominadetalle` (
  `pkcodigonomina` int NOT NULL,
  `cod_linea` int NOT NULL,
  `subtotal_percepcion` double DEFAULT NULL,
  `subtotal_deduccion` double DEFAULT NULL,
  `nominadetallecol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkcodigonomina`,`cod_linea`),
  CONSTRAINT `fk_nominadetalle_nomina_encabezado1` FOREIGN KEY (`pkcodigonomina`) REFERENCES `nomina_encabezado` (`pkcodigonomina`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nominadetalle`
--

LOCK TABLES `nominadetalle` WRITE;
/*!40000 ALTER TABLE `nominadetalle` DISABLE KEYS */;
INSERT INTO `nominadetalle` VALUES (1,1,250,250,'250'),(2,1,366,366,'366'),(3,1,751,751,'751');
/*!40000 ALTER TABLE `nominadetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orden_produccion`
--

DROP TABLE IF EXISTS `orden_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orden_produccion` (
  `pkidordenproduccion` int NOT NULL,
  `fecha_realizacion` date DEFAULT NULL,
  `fecha_entrega` date DEFAULT NULL,
  `detalle` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidordenproduccion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orden_produccion`
--

LOCK TABLES `orden_produccion` WRITE;
/*!40000 ALTER TABLE `orden_produccion` DISABLE KEYS */;
INSERT INTO `orden_produccion` VALUES (1,'2020-05-10','2020-05-10','Completar',1),(2,'2020-05-10','2020-05-10','Llenar para el lunes',1),(3,'2020-05-10','2020-05-10','Debe de ser rapido',1),(4,'2020-05-10','2020-05-10','Agregar dos elementos extras',1),(5,'2020-05-10','2020-05-10','94 lapiceros',1),(6,'2020-05-15','2020-05-15','50 camionetas rojas',1);
/*!40000 ALTER TABLE `orden_produccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordencompradetalle`
--

DROP TABLE IF EXISTS `ordencompradetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ordencompradetalle` (
  `pkIdCompraDetalle` int NOT NULL,
  `fkIdordenCompraEncabezado` int DEFAULT NULL,
  `codigoLinea` int NOT NULL AUTO_INCREMENT,
  `fkIdProducto` int DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `subTotal` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`codigoLinea`,`pkIdCompraDetalle`),
  KEY `fk_ordenCompraDetalle_ordenComrpaEncabezado1_idx` (`fkIdordenCompraEncabezado`),
  KEY `fk_ordenCompraDetalle_producto1_idx` (`fkIdProducto`),
  CONSTRAINT `fk_ordenCompraDetalle_ordenComrpaEncabezado1` FOREIGN KEY (`fkIdordenCompraEncabezado`) REFERENCES `ordencomrpaencabezado` (`pkIdOrdenCompraEncabezado`),
  CONSTRAINT `fk_ordenCompraDetalle_producto1` FOREIGN KEY (`fkIdProducto`) REFERENCES `producto` (`pkidProducto`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordencompradetalle`
--

LOCK TABLES `ordencompradetalle` WRITE;
/*!40000 ALTER TABLE `ordencompradetalle` DISABLE KEYS */;
INSERT INTO `ordencompradetalle` VALUES (1,1,1,1,25,150,1),(3,2,1,2,10,60,1),(5,3,1,1,20,72,1),(2,1,2,2,50,100,1),(4,2,2,3,15,60,1),(6,3,2,2,24,72,1);
/*!40000 ALTER TABLE `ordencompradetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordencomrpaencabezado`
--

DROP TABLE IF EXISTS `ordencomrpaencabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ordencomrpaencabezado` (
  `pkIdOrdenCompraEncabezado` int NOT NULL,
  `fkIdProveedor` int DEFAULT NULL,
  `fkIdFormaPago` int DEFAULT NULL,
  `fechaPedido` date DEFAULT NULL,
  `fechaRequerida` date DEFAULT NULL,
  `pkcodigoempleado` int DEFAULT NULL,
  `observaciones` varchar(45) DEFAULT NULL,
  `totalImpuesto` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `descuento` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkIdOrdenCompraEncabezado`),
  KEY `fk_ordenComrpaEncabezado_formasPago1_idx` (`fkIdFormaPago`),
  KEY `fk_ordenComrpaEncabezado_empleado1_idx` (`pkcodigoempleado`),
  KEY `fk_ordenComrpaEncabezado_proveedor1_idx` (`fkIdProveedor`),
  CONSTRAINT `fk_ordenComrpaEncabezado_empleado1` FOREIGN KEY (`pkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`),
  CONSTRAINT `fk_ordenComrpaEncabezado_formasPago1` FOREIGN KEY (`fkIdFormaPago`) REFERENCES `formaspago` (`pkIdFormaPago`),
  CONSTRAINT `fk_ordenComrpaEncabezado_proveedor1` FOREIGN KEY (`fkIdProveedor`) REFERENCES `proveedor` (`pkidProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordencomrpaencabezado`
--

LOCK TABLES `ordencomrpaencabezado` WRITE;
/*!40000 ALTER TABLE `ordencomrpaencabezado` DISABLE KEYS */;
INSERT INTO `ordencomrpaencabezado` VALUES (1,1,1,'2020-05-18','2020-05-24',1,'Debe de cumplir con los estaandares de calida',50,250,0.1,1),(2,2,2,'2020-04-20','2020-05-30',2,'Lo mas rapido posible ',60,120,0.1,1),(3,3,3,'2020-03-25','2020-04-01',3,'Rapido',10,152,0.15,1);
/*!40000 ALTER TABLE `ordencomrpaencabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido`
--

DROP TABLE IF EXISTS `pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedido` (
  `pkidpedido` int NOT NULL,
  `pkidProducto` int DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  `pkcodigoempleado` int DEFAULT NULL,
  `cantidad` int DEFAULT NULL,
  `pkidordenproduccion` int DEFAULT NULL,
  PRIMARY KEY (`pkidpedido`),
  KEY `fk_pedido_producto1_idx` (`pkidProducto`),
  KEY `fk_pedido_empleado1_idx` (`pkcodigoempleado`),
  KEY `fk_pedido_orden_produccion1_idx` (`pkidordenproduccion`),
  CONSTRAINT `fk_pedido_empleado1` FOREIGN KEY (`pkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`),
  CONSTRAINT `fk_pedido_orden_produccion1` FOREIGN KEY (`pkidordenproduccion`) REFERENCES `orden_produccion` (`pkidordenproduccion`),
  CONSTRAINT `fk_pedido_producto1` FOREIGN KEY (`pkidProducto`) REFERENCES `producto` (`pkidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
INSERT INTO `pedido` VALUES (1,1,1,1,5,1),(2,2,1,1,5,1),(3,1,1,1,5,1),(4,1,1,1,2,2),(5,2,1,1,3,2),(6,1,1,1,5,6),(7,2,0,1,4,6);
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil_detalle`
--

DROP TABLE IF EXISTS `perfil_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `perfil_detalle` (
  `fkcodperfil` int NOT NULL,
  `primaria` tinyint(1) DEFAULT NULL,
  `secundaria` tinyint(1) DEFAULT NULL,
  `bachillerato` tinyint(1) DEFAULT NULL,
  `estudiante_U` tinyint(1) DEFAULT NULL,
  `graduado_U` tinyint(1) DEFAULT NULL,
  `curso_extra` tinyint(1) DEFAULT NULL,
  `descripcion_curso` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`fkcodperfil`),
  CONSTRAINT `fk_perfil_detalle_perfil_encabezado1` FOREIGN KEY (`fkcodperfil`) REFERENCES `perfil_encabezado` (`pkcodperfil`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil_detalle`
--

LOCK TABLES `perfil_detalle` WRITE;
/*!40000 ALTER TABLE `perfil_detalle` DISABLE KEYS */;
INSERT INTO `perfil_detalle` VALUES (1,1,1,1,1,1,1,'c++',1),(2,1,1,1,1,0,0,'Ninguno',1),(3,1,1,0,0,0,0,'Ninguno',1),(4,1,1,1,1,0,1,'Desarrollo Web',1);
/*!40000 ALTER TABLE `perfil_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil_encabezado`
--

DROP TABLE IF EXISTS `perfil_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `perfil_encabezado` (
  `pkcodperfil` int NOT NULL,
  `fkcodigopuesto` int DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkcodperfil`),
  KEY `fk_perfil_encabezado_puesto1_idx` (`fkcodigopuesto`),
  CONSTRAINT `fk_perfil_encabezado_puesto1` FOREIGN KEY (`fkcodigopuesto`) REFERENCES `puesto` (`pkcodigopuesto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil_encabezado`
--

LOCK TABLES `perfil_encabezado` WRITE;
/*!40000 ALTER TABLE `perfil_encabezado` DISABLE KEYS */;
INSERT INTO `perfil_encabezado` VALUES (1,1,1),(2,2,1),(3,3,1),(4,1,1);
/*!40000 ALTER TABLE `perfil_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `poliza_detalle`
--

DROP TABLE IF EXISTS `poliza_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `poliza_detalle` (
  `cod_linea` int NOT NULL AUTO_INCREMENT,
  `pkcodigopoliza` int NOT NULL,
  `cuentas` varchar(25) DEFAULT NULL,
  `Debe` int DEFAULT NULL,
  `Haber` int DEFAULT NULL,
  PRIMARY KEY (`cod_linea`,`pkcodigopoliza`),
  KEY `fk_poliza_detalle_poliza_encabezado1` (`pkcodigopoliza`),
  CONSTRAINT `fk_poliza_detalle_poliza_encabezado1` FOREIGN KEY (`pkcodigopoliza`) REFERENCES `poliza_encabezado` (`pkcodigopoliza`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `poliza_detalle`
--

LOCK TABLES `poliza_detalle` WRITE;
/*!40000 ALTER TABLE `poliza_detalle` DISABLE KEYS */;
INSERT INTO `poliza_detalle` VALUES (1,1,'Banco',0,250),(2,2,'Caja',0,365),(3,3,'IVA POR PAGAR',250,0);
/*!40000 ALTER TABLE `poliza_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `poliza_encabezado`
--

DROP TABLE IF EXISTS `poliza_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `poliza_encabezado` (
  `pkcodigopoliza` int NOT NULL,
  `pkcodigonomina` int NOT NULL,
  `fechainicio` int DEFAULT NULL,
  `fechafin` int DEFAULT NULL,
  PRIMARY KEY (`pkcodigopoliza`,`pkcodigonomina`),
  KEY `fk_poliza_encabezado_nomina_encabezado1_idx` (`pkcodigonomina`),
  CONSTRAINT `fk_poliza_encabezado_nomina_encabezado1` FOREIGN KEY (`pkcodigonomina`) REFERENCES `nomina_encabezado` (`pkcodigonomina`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `poliza_encabezado`
--

LOCK TABLES `poliza_encabezado` WRITE;
/*!40000 ALTER TABLE `poliza_encabezado` DISABLE KEYS */;
INSERT INTO `poliza_encabezado` VALUES (1,1,2025,2020),(2,2,2020,2020),(3,3,2020,2020);
/*!40000 ALTER TABLE `poliza_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `polizadetalle_mrp`
--

DROP TABLE IF EXISTS `polizadetalle_mrp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `polizadetalle_mrp` (
  `cod_linea` int NOT NULL AUTO_INCREMENT,
  `pkidpolizaencabezado_MRP` int NOT NULL,
  `pkcodigocuenta` int DEFAULT NULL,
  `debe` double DEFAULT NULL,
  `haber` double DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`cod_linea`,`pkidpolizaencabezado_MRP`),
  KEY `fk_polizadetalle_mrp_polizaencabezado_mrp1_idx` (`pkidpolizaencabezado_MRP`),
  CONSTRAINT `fk_polizadetalle_mrp_polizaencabezado_mrp1` FOREIGN KEY (`pkidpolizaencabezado_MRP`) REFERENCES `polizaencabezado_mrp` (`pkidpolizaencabezado_MRP`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `polizadetalle_mrp`
--

LOCK TABLES `polizadetalle_mrp` WRITE;
/*!40000 ALTER TABLE `polizadetalle_mrp` DISABLE KEYS */;
INSERT INTO `polizadetalle_mrp` VALUES (1,1,1,0,263,1),(1,3,1,0,25,1),(2,1,2,50,0,1),(2,3,2,256,0,1),(3,2,1,0,563,1),(4,2,3,0,63,1);
/*!40000 ALTER TABLE `polizadetalle_mrp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `polizaencabezado_mrp`
--

DROP TABLE IF EXISTS `polizaencabezado_mrp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `polizaencabezado_mrp` (
  `pkidpolizaencabezado_MRP` int NOT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `tipo` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidpolizaencabezado_MRP`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `polizaencabezado_mrp`
--

LOCK TABLES `polizaencabezado_mrp` WRITE;
/*!40000 ALTER TABLE `polizaencabezado_mrp` DISABLE KEYS */;
INSERT INTO `polizaencabezado_mrp` VALUES (1,'2020-04-10','2020-04-25','Poliza quincenal','Quincenal',1),(2,'2020-03-01','2020-03-30','Poliza mensual','Mensual',1),(3,'2020-01-01','2020-01-07','Poliza semanal','Semanal',1);
/*!40000 ALTER TABLE `polizaencabezado_mrp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `procesoproduccion`
--

DROP TABLE IF EXISTS `procesoproduccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `procesoproduccion` (
  `linea` int NOT NULL AUTO_INCREMENT,
  `pkidprocesoproduccion` int NOT NULL,
  `pkidencabezadop` int DEFAULT NULL,
  `pkidestacion` int DEFAULT NULL,
  PRIMARY KEY (`linea`,`pkidprocesoproduccion`),
  KEY `fk_procesoproduccion_encabezado_produccion1_idx` (`pkidencabezadop`),
  KEY `fk_procesoproduccion_estacion1_idx` (`pkidestacion`),
  CONSTRAINT `fk_procesoproduccion_encabezado_produccion1` FOREIGN KEY (`pkidencabezadop`) REFERENCES `encabezado_produccion` (`pkidencabezadop`),
  CONSTRAINT `fk_procesoproduccion_estacion1` FOREIGN KEY (`pkidestacion`) REFERENCES `estacion` (`pkidestacion`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `procesoproduccion`
--

LOCK TABLES `procesoproduccion` WRITE;
/*!40000 ALTER TABLE `procesoproduccion` DISABLE KEYS */;
INSERT INTO `procesoproduccion` VALUES (1,1,1,1),(1,2,2,1),(1,3,3,1),(2,1,1,2),(2,2,2,2),(2,3,3,2);
/*!40000 ALTER TABLE `procesoproduccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `pkidProveedor` int NOT NULL,
  `pkidProducto` int NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Precio` decimal(3,0) DEFAULT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Presentacion` varchar(45) DEFAULT NULL,
  `Costo` int DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  `pktipo_producto` int NOT NULL,
  PRIMARY KEY (`pkidProducto`,`pkidProveedor`),
  KEY `fk_Producto_Tipo Producto1_idx` (`pktipo_producto`),
  KEY `fk_Producto_Proveedor1_idx` (`pkidProveedor`),
  CONSTRAINT `fk_Producto_Proveedor1` FOREIGN KEY (`pkidProveedor`) REFERENCES `proveedor` (`pkidProveedor`),
  CONSTRAINT `fk_Producto_Tipo Producto1` FOREIGN KEY (`pktipo_producto`) REFERENCES `tipo_producto` (`pktipo_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,1,'1',1,'1','1',1,1,1),(1,2,'1',11,'1','1',1,1,1),(1,3,'Arroz',24,'Costal de papa','Costal',12,1,1),(1,4,'Papas',22,'hggh','lb',21,1,1),(1,5,'llantas',45,'jfjfj','kg',0,1,2),(1,6,'leche',5,'dfdf','g',2,1,2);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto_control_calidad`
--

DROP TABLE IF EXISTS `producto_control_calidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto_control_calidad` (
  `pkidproducto_control_calidad` int NOT NULL,
  `pkidprocesoproduccion` int DEFAULT NULL,
  `pkidestandardecalidad` int DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado_aprobacion` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidproducto_control_calidad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto_control_calidad`
--

LOCK TABLES `producto_control_calidad` WRITE;
/*!40000 ALTER TABLE `producto_control_calidad` DISABLE KEYS */;
INSERT INTO `producto_control_calidad` VALUES (1,1,1,'Mayor calidad soldado',1),(2,2,2,'Menor estandar de calidad',0),(3,3,3,'Mas estandar',1);
/*!40000 ALTER TABLE `producto_control_calidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productoenbodega`
--

DROP TABLE IF EXISTS `productoenbodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productoenbodega` (
  `pkidBodega` int NOT NULL,
  `pkidProducto` int NOT NULL,
  `Existencias` int DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkidBodega`,`pkidProducto`),
  KEY `fk_ProductoenBodega_Bodega1_idx` (`pkidBodega`),
  KEY `fk_productoenbodega_producto1_idx` (`pkidProducto`),
  CONSTRAINT `fk_productoenbodega_bodega1` FOREIGN KEY (`pkidBodega`) REFERENCES `bodega` (`pkidBodega`),
  CONSTRAINT `fk_productoenbodega_producto1` FOREIGN KEY (`pkidProducto`) REFERENCES `producto` (`pkidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productoenbodega`
--

LOCK TABLES `productoenbodega` WRITE;
/*!40000 ALTER TABLE `productoenbodega` DISABLE KEYS */;
INSERT INTO `productoenbodega` VALUES (1,1,25,'1'),(2,2,60,'1'),(3,3,50,'1');
/*!40000 ALTER TABLE `productoenbodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedor` (
  `pkidProveedor` int NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Nit` int DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Telefono` int DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,'Jose',45455236,'15 calle zona 1',22365878,'jose@gmail.com',1),(2,'La salinita',45632178,'Avenida de los Arboles zona 12',22365478,'salinitas@gmail.com',1),(3,'Maranatatata',52362418,'Zona industrial zona 12',22103657,'maratata@gmail.com',1);
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `puesto`
--

DROP TABLE IF EXISTS `puesto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `puesto` (
  `pkcodigopuesto` int NOT NULL,
  `fkcodigoempleado` int NOT NULL,
  `fkcodigodepto` int NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `sueldo` double DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkcodigopuesto`),
  KEY `fk_puesto_empleado1_idx` (`fkcodigoempleado`),
  KEY `fk_puesto_departamentos1_idx` (`fkcodigodepto`),
  CONSTRAINT `fk_puesto_departamentos1` FOREIGN KEY (`fkcodigodepto`) REFERENCES `departamentos` (`pkcodigodepto`),
  CONSTRAINT `fk_puesto_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `puesto`
--

LOCK TABLES `puesto` WRITE;
/*!40000 ALTER TABLE `puesto` DISABLE KEYS */;
INSERT INTO `puesto` VALUES (1,1,1,'Jefe de IT',8500,'1'),(2,2,2,'Programador',3500,'1'),(3,3,3,'Auditor',4500,'1');
/*!40000 ALTER TABLE `puesto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reportes`
--

DROP TABLE IF EXISTS `reportes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reportes` (
  `pkidreporte` int NOT NULL,
  `ubicacion` varchar(90) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidreporte`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reportes`
--

LOCK TABLES `reportes` WRITE;
/*!40000 ALTER TABLE `reportes` DISABLE KEYS */;
INSERT INTO `reportes` VALUES (101,'C:/Empresa_Bienestar/Reportes/Factura.rpt',1),(102,'C:/Empresa_Bienestar/Reportes/ordencomprarpt.rpt',1),(103,'C:/Empresa_Bienestar/Reportes/Devolucion.rpt',1),(104,'C:/Empresa_Bienestar/Reportes/impuestos.rpt',1),(105,'C:/Empresa_Bienestar/Reportes/productos.rpt',1),(106,'C:/Empresa_Bienestar/Reportes/proveedor.rpt',1),(201,'C:/Empresa_Bienestar/Reportes/cosoproduccion.rpt',1),(202,'C:/Empresa_Bienestar/Reportes/listaPedidos.rpt',1),(203,'C:/Empresa_Bienestar/Reportes/ordenProduccion.rpt',1);
/*!40000 ALTER TABLE `reportes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reuniones`
--

DROP TABLE IF EXISTS `reuniones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reuniones` (
  `pkcodigoreuniones` int NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int NOT NULL,
  `nombrereunion` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `fechainicio` time DEFAULT NULL,
  `fechafinal` time DEFAULT NULL,
  `horainicio` datetime DEFAULT NULL,
  `horafinal` datetime DEFAULT NULL,
  `cantidadempleados` int DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkcodigoreuniones`),
  KEY `fk_reuniones_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_reuniones_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reuniones`
--

LOCK TABLES `reuniones` WRITE;
/*!40000 ALTER TABLE `reuniones` DISABLE KEYS */;
INSERT INTO `reuniones` VALUES (1,1,'Capacitacion','Capacitacion de GitHub','00:20:20','00:20:20','0000-00-00 00:00:00','0000-00-00 00:00:00',10,1),(2,2,'Capacitacion','Desarrollo Web','00:20:20','00:20:20','0000-00-00 00:00:00','0000-00-00 00:00:00',5,1),(3,3,'Almuerzo','Almuerzo','00:20:20','00:20:20','0000-00-00 00:00:00','0000-00-00 00:00:00',50,1);
/*!40000 ALTER TABLE `reuniones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ruta`
--

DROP TABLE IF EXISTS `ruta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ruta` (
  `pkidruta` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidruta`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ruta`
--

LOCK TABLES `ruta` WRITE;
/*!40000 ALTER TABLE `ruta` DISABLE KEYS */;
INSERT INTO `ruta` VALUES (1,'Atlantico','Agarre recto',1),(2,'Sur','Tomar carretera mas conveniente',1),(3,'Norte','Acticar GPS',1);
/*!40000 ALTER TABLE `ruta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sancionempleado`
--

DROP TABLE IF EXISTS `sancionempleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sancionempleado` (
  `pkcodigosansionempleado` int NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descipcion` varchar(45) DEFAULT NULL,
  `fechainicio` date DEFAULT NULL,
  `fechafinal` date DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkcodigosansionempleado`),
  KEY `fk_sancionempleado_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_sancionempleado_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sancionempleado`
--

LOCK TABLES `sancionempleado` WRITE;
/*!40000 ALTER TABLE `sancionempleado` DISABLE KEYS */;
INSERT INTO `sancionempleado` VALUES (1,1,'Hora de llegada','Llego tarde','2020-05-06','2020-05-06',1),(2,2,'Vestimenta','Mala vestimenta','2020-01-01','2020-01-01',1),(3,3,'Llegada tarde','Llego tarde','2020-03-03','2020-03-03',1);
/*!40000 ALTER TABLE `sancionempleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `solicitudactivos`
--

DROP TABLE IF EXISTS `solicitudactivos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `solicitudactivos` (
  `pkidsolicitudactivos` int NOT NULL,
  `cantidad` double DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `pkidProducto` int DEFAULT NULL,
  `fechadesolicitud` date DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidsolicitudactivos`),
  KEY `fk_solicitudactivos_producto1_idx` (`pkidProducto`),
  CONSTRAINT `fk_solicitudactivos_producto1` FOREIGN KEY (`pkidProducto`) REFERENCES `producto` (`pkidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `solicitudactivos`
--

LOCK TABLES `solicitudactivos` WRITE;
/*!40000 ALTER TABLE `solicitudactivos` DISABLE KEYS */;
INSERT INTO `solicitudactivos` VALUES (1,50,'Lo mas rapido posible',1,'2020-03-25',1),(2,150,'Verificar el estado',2,'2020-04-06',1),(3,75,'Tomar en cuenta la calidad',3,'2020-01-01',1);
/*!40000 ALTER TABLE `solicitudactivos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sucursal`
--

DROP TABLE IF EXISTS `sucursal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sucursal` (
  `pkidsucursal` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidsucursal`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sucursal`
--

LOCK TABLES `sucursal` WRITE;
/*!40000 ALTER TABLE `sucursal` DISABLE KEYS */;
INSERT INTO `sucursal` VALUES (1,'C.C. Metronorte','zona 18 carretera al atlantico',1),(2,'C.C. Proceres','Zona 10 Avenida las Americas',1),(3,'C.C. Gran Real','zona 1 la sexta avenida',1);
/*!40000 ALTER TABLE `sucursal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_bancotalento`
--

DROP TABLE IF EXISTS `tbl_bancotalento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_bancotalento` (
  `pkBancoTalento` int NOT NULL AUTO_INCREMENT,
  `fkCurriculum` int NOT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkBancoTalento`,`fkCurriculum`),
  KEY `FK_Curriculum_BancoT` (`fkCurriculum`),
  CONSTRAINT `FK_Curriculum_BancoT` FOREIGN KEY (`fkCurriculum`) REFERENCES `tbl_curriculums` (`pkidCurriculum`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bancotalento`
--

LOCK TABLES `tbl_bancotalento` WRITE;
/*!40000 ALTER TABLE `tbl_bancotalento` DISABLE KEYS */;
INSERT INTO `tbl_bancotalento` VALUES (1,1,1),(2,2,1),(3,3,1);
/*!40000 ALTER TABLE `tbl_bancotalento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_curriculums`
--

DROP TABLE IF EXISTS `tbl_curriculums`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_curriculums` (
  `pkidCurriculum` int NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Apellido` varchar(45) DEFAULT NULL,
  `Numero` varchar(45) DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Correo_Electronico` varchar(45) DEFAULT NULL,
  `Primaria` tinyint(1) DEFAULT NULL,
  `Secundaria` tinyint(1) DEFAULT NULL,
  `Bachillerato` tinyint(1) DEFAULT NULL,
  `Estudiante_Universitario` tinyint(1) DEFAULT NULL,
  `GraduadoU` tinyint(1) DEFAULT NULL,
  `CursoExtra` tinyint(1) DEFAULT NULL,
  `DescripcionCursos` varchar(100) DEFAULT NULL,
  `Experiencia_Previa` varchar(45) DEFAULT NULL,
  `SueldoEsperado` double DEFAULT NULL,
  `fksolicitudempleado` int DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidCurriculum`),
  KEY `FK_solicitud_empleado_encabezado_Curriculums` (`fksolicitudempleado`),
  CONSTRAINT `FK_solicitud_empleado_encabezado_Curriculums` FOREIGN KEY (`fksolicitudempleado`) REFERENCES `tbl_solicitud_empleado_encabezado` (`pksolicitudempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_curriculums`
--

LOCK TABLES `tbl_curriculums` WRITE;
/*!40000 ALTER TABLE `tbl_curriculums` DISABLE KEYS */;
INSERT INTO `tbl_curriculums` VALUES (1,'Juan Alberto','Moreno Salazara','52364123','15 calle A zona 4','juan@gmail.com',1,1,1,1,1,1,'C++','Trabajo en Pepsi',2500,1,1),(2,'Angel','Del Cid','45361425','19 calle zona 9','angel@gmail.com',1,1,1,1,1,1,'Desarrollo Web ','Trabjo en UMG',5000,1,1),(3,'Felipe','Zamora','61354269','18 calle zona 1','felipe@gmail.com',1,1,1,0,0,0,'No tiene','No tiene',2500,1,1);
/*!40000 ALTER TABLE `tbl_curriculums` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_solicitud_empleado_detalle`
--

DROP TABLE IF EXISTS `tbl_solicitud_empleado_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_solicitud_empleado_detalle` (
  `pksolicitudempleado` int NOT NULL,
  `primaria` tinyint(1) DEFAULT NULL,
  `secundaria` tinyint(1) DEFAULT NULL,
  `bachillerato` tinyint(1) DEFAULT NULL,
  `estudiante_U` tinyint(1) DEFAULT NULL,
  `grado_U` tinyint(1) DEFAULT NULL,
  `curso_extra` tinyint(1) DEFAULT NULL,
  `descripcion_curso` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pksolicitudempleado`),
  CONSTRAINT `fk_tbl_solicitud_empleado_detalle_tbl_solicitud_empleado_enca1` FOREIGN KEY (`pksolicitudempleado`) REFERENCES `tbl_solicitud_empleado_encabezado` (`pksolicitudempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_solicitud_empleado_detalle`
--

LOCK TABLES `tbl_solicitud_empleado_detalle` WRITE;
/*!40000 ALTER TABLE `tbl_solicitud_empleado_detalle` DISABLE KEYS */;
INSERT INTO `tbl_solicitud_empleado_detalle` VALUES (1,1,1,1,1,1,1,'C++',1),(2,1,1,1,0,0,0,'Ninguno',1),(3,1,1,1,1,1,0,'Ninguno',1);
/*!40000 ALTER TABLE `tbl_solicitud_empleado_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_solicitud_empleado_encabezado`
--

DROP TABLE IF EXISTS `tbl_solicitud_empleado_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_solicitud_empleado_encabezado` (
  `pksolicitudempleado` int NOT NULL,
  `fkcodigoempleado` int DEFAULT NULL,
  `fkcodigocontratacion` int DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pksolicitudempleado`),
  KEY `fk_tbl_solicitud_empleado_encabezado_empleado1_idx` (`fkcodigoempleado`),
  KEY `fk_tbl_solicitud_empleado_encabezado_tipocontratacion1_idx` (`fkcodigocontratacion`),
  CONSTRAINT `fk_tbl_solicitud_empleado_encabezado_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`),
  CONSTRAINT `fk_tbl_solicitud_empleado_encabezado_tipocontratacion1` FOREIGN KEY (`fkcodigocontratacion`) REFERENCES `tipocontratacion` (`pkcodigocontratacion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_solicitud_empleado_encabezado`
--

LOCK TABLES `tbl_solicitud_empleado_encabezado` WRITE;
/*!40000 ALTER TABLE `tbl_solicitud_empleado_encabezado` DISABLE KEYS */;
INSERT INTO `tbl_solicitud_empleado_encabezado` VALUES (1,1,1,'2020-05-18',1),(2,2,2,'2020-04-20',1),(3,3,3,'2020-03-20',1);
/*!40000 ALTER TABLE `tbl_solicitud_empleado_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_producto`
--

DROP TABLE IF EXISTS `tipo_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_producto` (
  `pktipo_producto` int NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pktipo_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_producto`
--

LOCK TABLES `tipo_producto` WRITE;
/*!40000 ALTER TABLE `tipo_producto` DISABLE KEYS */;
INSERT INTO `tipo_producto` VALUES (1,'venta','Unicamente venta',1),(2,'fabricacion','Unicamente fabricacion',1),(3,'Venta','Para vender',1);
/*!40000 ALTER TABLE `tipo_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_usuario`
--

DROP TABLE IF EXISTS `tipo_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_usuario` (
  `pktipousuario` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  `guardar` tinyint DEFAULT NULL,
  `modificar` tinyint DEFAULT NULL,
  `eliminar` tinyint DEFAULT NULL,
  `consultar` tinyint DEFAULT NULL,
  PRIMARY KEY (`pktipousuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_usuario`
--

LOCK TABLES `tipo_usuario` WRITE;
/*!40000 ALTER TABLE `tipo_usuario` DISABLE KEYS */;
INSERT INTO `tipo_usuario` VALUES (1,'ADM','1',1,1,1,1,1),(2,'Cajero','Cajero de ventanilla',1,1,0,0,1),(3,'Gerente de Cajeros','Gerente de ventas',1,1,1,1,1);
/*!40000 ALTER TABLE `tipo_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipobodega`
--

DROP TABLE IF EXISTS `tipobodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipobodega` (
  `pkidtipobodega` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `capacidad` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidtipobodega`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipobodega`
--

LOCK TABLES `tipobodega` WRITE;
/*!40000 ALTER TABLE `tipobodega` DISABLE KEYS */;
INSERT INTO `tipobodega` VALUES (1,'Grande','Bodega para producto para vender','250',1),(2,'Mediana ','Bodega unicamente para materia prima','375',1),(3,'Grande ','Bodega de materia prima','123',1);
/*!40000 ALTER TABLE `tipobodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipocontratacion`
--

DROP TABLE IF EXISTS `tipocontratacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipocontratacion` (
  `pkcodigocontratacion` int NOT NULL,
  `PorContrato` varchar(45) DEFAULT NULL,
  `PorMeses` varchar(45) DEFAULT NULL,
  `PorProyecto` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkcodigocontratacion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipocontratacion`
--

LOCK TABLES `tipocontratacion` WRITE;
/*!40000 ALTER TABLE `tipocontratacion` DISABLE KEYS */;
INSERT INTO `tipocontratacion` VALUES (1,'1','0','0',1),(2,'0','0','0',0),(3,'0','1','0',1);
/*!40000 ALTER TABLE `tipocontratacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipomerma`
--

DROP TABLE IF EXISTS `tipomerma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipomerma` (
  `pkidtipomerma` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidtipomerma`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipomerma`
--

LOCK TABLES `tipomerma` WRITE;
/*!40000 ALTER TABLE `tipomerma` DISABLE KEYS */;
INSERT INTO `tipomerma` VALUES (1,'Merma solida','Merma del producto',1),(2,'Merma liquida','Manejar con proteccion',1),(3,'Merma solida desechable','Puede desecharse',1);
/*!40000 ALTER TABLE `tipomerma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipotransporte`
--

DROP TABLE IF EXISTS `tipotransporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipotransporte` (
  `pkidtipotransporte` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `capacidad` float DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidtipotransporte`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipotransporte`
--

LOCK TABLES `tipotransporte` WRITE;
/*!40000 ALTER TABLE `tipotransporte` DISABLE KEYS */;
INSERT INTO `tipotransporte` VALUES (1,'Camion',245,1),(2,'Camion de despacho',150,1),(3,'Trailer',450,1);
/*!40000 ALTER TABLE `tipotransporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transporte`
--

DROP TABLE IF EXISTS `transporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transporte` (
  `pkidtransporte` int NOT NULL AUTO_INCREMENT,
  `fkidruta` int NOT NULL,
  `fkidtipotransporte` int NOT NULL,
  `placa` varchar(45) DEFAULT NULL,
  `chasis` varchar(45) DEFAULT NULL,
  `motor` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidtransporte`),
  KEY `fk_transporte_ruta1_idx` (`fkidruta`),
  KEY `fk_transporte_tipotransporte1_idx` (`fkidtipotransporte`),
  CONSTRAINT `fk_transporte_ruta1` FOREIGN KEY (`fkidruta`) REFERENCES `ruta` (`pkidruta`),
  CONSTRAINT `fk_transporte_tipotransporte1` FOREIGN KEY (`fkidtipotransporte`) REFERENCES `tipotransporte` (`pkidtipotransporte`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transporte`
--

LOCK TABLES `transporte` WRITE;
/*!40000 ALTER TABLE `transporte` DISABLE KEYS */;
INSERT INTO `transporte` VALUES (1,1,1,'P-123ASD','12356487','Grande',1),(2,2,2,'T-852ASD','84563215','Mediano',1),(3,3,3,'U-127PES','32165465151','Grande',1);
/*!40000 ALTER TABLE `transporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `pkusuario` int NOT NULL AUTO_INCREMENT,
  `pktipousuario` int NOT NULL,
  `nombreusuario` varchar(45) DEFAULT NULL,
  `passusuario` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  `correo` varchar(45) DEFAULT NULL,
  `foto_ubicacion` varchar(90) DEFAULT NULL,
  PRIMARY KEY (`pkusuario`,`pktipousuario`),
  KEY `fk_usuario_tipo_usuario1_idx` (`pktipousuario`),
  CONSTRAINT `fk_usuario_tipo_usuario1` FOREIGN KEY (`pktipousuario`) REFERENCES `tipo_usuario` (`pktipousuario`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,1,'JGONZALEZ','123',1,'jose.ale.gt.umg@gmail.com','C:/Empresa_Bienestar/Personal/jose.jpg'),(2,1,'IMOGOLLON','456',1,'mogo@gmail.com','C:/Empresa_Bienestar/Personal/ivan.jpg'),(3,1,'ISISDIAZ12','789',1,'isis@gmail.com','C:/Empresa_Bienestar/Personal/isis.jpg'),(4,1,'CONNYBAR','123',1,'conny@gmail.com','C:/Empresa_Bienestar/Personal/conny.jpg'),(5,1,'FREDYELI1','123',1,'fredy@gmail.com','C:/Empresa_Bienestar/Personal/fredy.jpg'),(6,1,'ASOLARES','123',1,'angel@gmail.com','C:/Empresa_Bienestar/Personal/angel.jpg'),(7,1,'PAULAVAS','123',1,'paula@gmail.com','C:/Empresa_Bienestar/Personal/paula.jpg');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'mydb'
--

--
-- Dumping routines for database 'mydb'
--
/*!50003 DROP PROCEDURE IF EXISTS `cuentasenpolizadetalle` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `cuentasenpolizadetalle`(
IN  nombrecuenta VARCHAR(45))
BEGIN
DECLARE x INT;
DECLARE x2 INT;
  SET x = (SELECT MAX(pkcodigoconcepto) FROM concepto WHERE nombreconcepto=nombrecuenta);
   SET x2 = (SELECT MAX(nombreconcepto) FROM concepto WHERE nombreconcepto=nombrecuenta);
 Update poliza_detalle set cuentas =x WHERE cuentas =nombrecuenta;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-24 22:30:43
