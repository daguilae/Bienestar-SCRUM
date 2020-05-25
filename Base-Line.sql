CREATE DATABASE  IF NOT EXISTS `mydb` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `mydb`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mydb
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.34-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `asistencia`
--

DROP TABLE IF EXISTS `asistencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `asistencia` (
  `pkcodigoasistencia` int(11) NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int(11) NOT NULL,
  `fechaentrada` date DEFAULT NULL,
  `fechasalida` date DEFAULT NULL,
  `horaentrada` time DEFAULT NULL,
  `horasalida` time DEFAULT NULL,
  PRIMARY KEY (`pkcodigoasistencia`),
  KEY `fk_asistencia_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_asistencia_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asistencia`
--

LOCK TABLES `asistencia` WRITE;
/*!40000 ALTER TABLE `asistencia` DISABLE KEYS */;
INSERT INTO `asistencia` VALUES (1,1,'2020-03-25','2020-03-25','19:34:03','22:34:03');
/*!40000 ALTER TABLE `asistencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ayudas`
--

DROP TABLE IF EXISTS `ayudas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ayudas` (
  `pkcodigoayuda` int(11) NOT NULL,
  `rutayuda` varchar(190) DEFAULT NULL,
  `indicedeayuda` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigoayuda`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ayudas`
--

LOCK TABLES `ayudas` WRITE;
/*!40000 ALTER TABLE `ayudas` DISABLE KEYS */;
INSERT INTO `ayudas` VALUES (1,'Ayudas Mant/ayudasrrhh.chm','Conceptos.html',1),(2,'Ayudas Mant/ayudasrrhh.chm','Curriculum.html',1),(3,'Ayudas Mant/ayudasrrhh.chm','Despido.html',1),(4,'Ayudas Mant/ayudasrrhh.chm','MantenimientoDepartamentos.html',1),(5,'Ayudas Mant/ayudasrrhh.chm','ReuniónEliminar.html',1),(6,'Ayudas Mant/ayudasrrhh.chm','SanciónEliminar.html',1),(7,'Ayudas Mant/ayudasrrhh.chm','Empleados.html',1),(8,'Ayudas Mant/ayudasrrhh.chm','ControlAsistencia.html',1),(9,'Ayudas Mant/ayudasrrhh.chm','Reunión.html',1),(10,'Ayudas Mant/ayudasrrhh.chm','Sanción.html',1),(11,'Ayudas Mant/ayudasrrhh.chm','Jornada.html',1),(12,'Ayudas Mant/ayudasrrhh.chm','Medio Comunicacion.html',1),(13,'Ayudas Mant/ayudasrrhh.chm','ReuniónModificar.html',1),(14,'Ayudas Mant/ayudasrrhh.chm','MantenimientoPerfiles.html',1),(15,'Ayudas Mant/ayudasrrhh.chm','Tipo Contratacion.html',1),(16,'Ayudas Mant/ayudasrrhh.chm','asignacionempleado.html',1),(17,'Ayudas Mant/ayudasrrhh.chm','ProcesoBusquedaInterna.html',1),(18,'Ayudas Mant/ayudasrrhh.chm','Convocatoria.html',1),(19,'Ayudas Mant/ayudasrrhh.chm','Desempenio.html',1),(20,'Ayudas Mant/ayudasrrhh.chm','ProcesoBusquedaInterna',1),(21,'Ayudas Mant/ayudasrrhh.chm','PreSeleccion.html',1),(22,'Ayudas Mant/ayudasrrhh.chm','Metas.html',1),(23,'Ayudas Mant/ayudasrrhh.chm','Nomina.html',1),(24,'Ayudas Mant/ayudasrrhh.chm','PreSeleccion',1),(25,'Ayudas Mant/ayudasrrhh.chm','ProcesoSolicitudEmpleado',1),(26,'Ayudas Mant/ayudasrrhh.chm','Poliza _Nomina',1);
/*!40000 ALTER TABLE `ayudas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bitacora`
--

DROP TABLE IF EXISTS `bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bitacora` (
  `cod_bitacora` int(11) NOT NULL AUTO_INCREMENT,
  `ip` varchar(45) DEFAULT NULL,
  `MAC` varchar(45) DEFAULT NULL,
  `usuario` varchar(45) DEFAULT NULL,
  `departamento` varchar(45) DEFAULT NULL,
  `fecha_hora` datetime DEFAULT NULL,
  `accion` varchar(45) DEFAULT NULL,
  `formulario` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`cod_bitacora`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bitacora`
--

LOCK TABLES `bitacora` WRITE;
/*!40000 ALTER TABLE `bitacora` DISABLE KEYS */;
INSERT INTO `bitacora` VALUES (7,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantPercepciones'),(8,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantPercepciones'),(9,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Eliminar','Frm_MantPercepciones'),(10,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantPercepciones'),(11,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantPerfiles'),(12,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantIngresoControlAsistencia'),(13,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantIngresoSansion'),(14,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_MediodeComunicacion'),(15,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantTipoContratacion'),(16,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantCurriculum'),(17,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantJornada'),(18,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Modificar','Frm_MantJornada'),(19,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_ManteDepartamento'),(20,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantPercepciones'),(21,'192.168.0.17','0A0027000002','Usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_Asignaciondeconcepto'),(22,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_Nomina'),(23,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Modificar','Frm_MantJornada'),(24,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Modificar','Frm_MantPercepciones'),(25,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantEmpleado'),(26,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantEmpleado'),(27,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_MantEmpleado'),(28,'192.168.0.17','0A0027000002','usuario','RRHH','0000-00-00 00:00:00','Guardar','Frm_Nomina');
/*!40000 ALTER TABLE `bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `candidatos_internos`
--

DROP TABLE IF EXISTS `candidatos_internos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `candidatos_internos` (
  `pkcodigocandidato` int(11) NOT NULL AUTO_INCREMENT,
  `pksolicitudempleado` int(11) NOT NULL,
  `pkcodperfil` int(11) NOT NULL,
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
INSERT INTO `candidatos_internos` VALUES (1,1,1,1),(2,1,1,1),(3,1,1,1);
/*!40000 ALTER TABLE `candidatos_internos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria` (
  `pkcodcategoria` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkcodcategoria`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `concepto`
--

DROP TABLE IF EXISTS `concepto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `concepto` (
  `pkcodigoconcepto` int(11) NOT NULL,
  `nombreconcepto` varchar(45) DEFAULT NULL,
  `tipo_concepto` tinyint(4) DEFAULT NULL,
  `saldo` double DEFAULT NULL,
  `tipo_accion` tinyint(4) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigoconcepto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `concepto`
--

LOCK TABLES `concepto` WRITE;
/*!40000 ALTER TABLE `concepto` DISABLE KEYS */;
INSERT INTO `concepto` VALUES (1,'Bono Incentivo',1,250,0,0),(2,'Bono250',1,250,0,1);
/*!40000 ALTER TABLE `concepto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conceptos_empleado`
--

DROP TABLE IF EXISTS `conceptos_empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `conceptos_empleado` (
  `pkconceptoempleado` int(11) NOT NULL AUTO_INCREMENT,
  `pknombreconcepto` varchar(25) DEFAULT NULL,
  `Total_monto` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkconceptoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conceptos_empleado`
--

LOCK TABLES `conceptos_empleado` WRITE;
/*!40000 ALTER TABLE `conceptos_empleado` DISABLE KEYS */;
INSERT INTO `conceptos_empleado` VALUES (1,'Bono250',251),(2,'',0);
/*!40000 ALTER TABLE `conceptos_empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuentas_contable`
--

DROP TABLE IF EXISTS `cuentas_contable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cuentas_contable` (
  `pkcodigocuenta` int(11) NOT NULL,
  `nombre_cuenta` varchar(45) DEFAULT NULL,
  `monto` int(11) DEFAULT NULL,
  `debe_haber` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkcodigocuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuentas_contable`
--

LOCK TABLES `cuentas_contable` WRITE;
/*!40000 ALTER TABLE `cuentas_contable` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuentas_contable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamentos`
--

DROP TABLE IF EXISTS `departamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departamentos` (
  `pkcodigodepto` int(11) NOT NULL,
  `nombredepto` varchar(45) DEFAULT NULL,
  `descripciondepto` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigodepto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamentos`
--

LOCK TABLES `departamentos` WRITE;
/*!40000 ALTER TABLE `departamentos` DISABLE KEYS */;
INSERT INTO `departamentos` VALUES (1,'ADIO','CHULA',0),(2,'PRUEBA','INSERTAR',0),(3,'NUEVO','NUEVO2',1);
/*!40000 ALTER TABLE `departamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `despidoempleado`
--

DROP TABLE IF EXISTS `despidoempleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `despidoempleado` (
  `pkcodigodespidoempleado` int(11) NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int(11) NOT NULL,
  `razondespido` varchar(45) DEFAULT NULL,
  `descripciondespido` varchar(45) DEFAULT NULL,
  `fechadespido` date DEFAULT NULL,
  PRIMARY KEY (`pkcodigodespidoempleado`),
  KEY `fk_despidoempleado_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_despidoempleado_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `despidoempleado`
--

LOCK TABLES `despidoempleado` WRITE;
/*!40000 ALTER TABLE `despidoempleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `despidoempleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleado` (
  `pkcodigoempleado` int(11) NOT NULL,
  `fkcodigojornada` int(11) NOT NULL,
  `primernombre` varchar(45) DEFAULT NULL,
  `segundonombre` varchar(45) DEFAULT NULL,
  `primerapellido` varchar(45) DEFAULT NULL,
  `segundoapellido` varchar(45) DEFAULT NULL,
  `telefono` int(11) DEFAULT NULL,
  `celular` int(11) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `fechanacimiento` date DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  `TipoContratacion_pkcodigocontratacion` int(11) DEFAULT NULL,
  `nit` int(11) DEFAULT NULL,
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
INSERT INTO `empleado` VALUES (1,1,'asd','asd','asd','asd',123,123,'asd','asd','1998-04-01',1,1,123);
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleadocontable`
--

DROP TABLE IF EXISTS `empleadocontable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleadocontable` (
  `pkcodigolinea` int(11) NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int(11) DEFAULT NULL,
  `fkcodigoconcepto` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkcodigolinea`),
  KEY `fk_empleadocontable_empleado1_idx` (`fkcodigoempleado`),
  KEY `fk_empleadocontable_concepto1_idx` (`fkcodigoconcepto`),
  CONSTRAINT `fk_empleadocontable_concepto1` FOREIGN KEY (`fkcodigoconcepto`) REFERENCES `concepto` (`pkcodigoconcepto`),
  CONSTRAINT `fk_empleadocontable_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleadocontable`
--

LOCK TABLES `empleadocontable` WRITE;
/*!40000 ALTER TABLE `empleadocontable` DISABLE KEYS */;
INSERT INTO `empleadocontable` VALUES (1,1,2);
/*!40000 ALTER TABLE `empleadocontable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horasextras`
--

DROP TABLE IF EXISTS `horasextras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `horasextras` (
  `pkcodigohorasextras` int(11) NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int(11) NOT NULL,
  `cantidad` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigohorasextras`),
  KEY `fk_horasextras_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_horasextras_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horasextras`
--

LOCK TABLES `horasextras` WRITE;
/*!40000 ALTER TABLE `horasextras` DISABLE KEYS */;
INSERT INTO `horasextras` VALUES (1,1,'3',1);
/*!40000 ALTER TABLE `horasextras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jornada`
--

DROP TABLE IF EXISTS `jornada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jornada` (
  `pkcodigojornada` int(11) NOT NULL,
  `nombrejornada` varchar(45) DEFAULT NULL,
  `horasjornada` int(11) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigojornada`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jornada`
--

LOCK TABLES `jornada` WRITE;
/*!40000 ALTER TABLE `jornada` DISABLE KEYS */;
INSERT INTO `jornada` VALUES (1,'Matutina',15,1);
/*!40000 ALTER TABLE `jornada` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kpi`
--

DROP TABLE IF EXISTS `kpi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kpi` (
  `pkcodigokpi` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `puntuacion` int(11) DEFAULT NULL,
  `desempeño` varchar(45) DEFAULT NULL,
  `fkcodcategoria` int(11) DEFAULT NULL,
  `fkcodempleado` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkcodigokpi`),
  KEY `fk_kpi_categoria1_idx` (`fkcodcategoria`),
  KEY `fk_kpi_empleado1` (`fkcodempleado`),
  CONSTRAINT `fk_kpi_categoria1` FOREIGN KEY (`fkcodcategoria`) REFERENCES `categoria` (`pkcodcategoria`),
  CONSTRAINT `fk_kpi_empleado1` FOREIGN KEY (`fkcodempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kpi`
--

LOCK TABLES `kpi` WRITE;
/*!40000 ALTER TABLE `kpi` DISABLE KEYS */;
/*!40000 ALTER TABLE `kpi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mediodecomunicacion`
--

DROP TABLE IF EXISTS `mediodecomunicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mediodecomunicacion` (
  `pkmediodecomunicacion` int(11) NOT NULL,
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
INSERT INTO `mediodecomunicacion` VALUES (1,'1','1','1',1);
/*!40000 ALTER TABLE `mediodecomunicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `meta`
--

DROP TABLE IF EXISTS `meta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `meta` (
  `codigo_meta` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_meta` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `plazo_meta` tinyint(1) DEFAULT NULL,
  `puntaje` varchar(45) DEFAULT NULL,
  `fecha_realizacion` datetime DEFAULT NULL,
  `completado` tinyint(1) DEFAULT NULL,
  `fkcodigoempleado` int(11) DEFAULT NULL,
  PRIMARY KEY (`codigo_meta`),
  KEY `fk_meta_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_meta_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `meta`
--

LOCK TABLES `meta` WRITE;
/*!40000 ALTER TABLE `meta` DISABLE KEYS */;
/*!40000 ALTER TABLE `meta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nomina_encabezado`
--

DROP TABLE IF EXISTS `nomina_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nomina_encabezado` (
  `pkcodigonomina` int(11) NOT NULL,
  `tipo_nomina` tinyint(4) DEFAULT NULL,
  `fechainicio` date DEFAULT NULL,
  `fechafin` date DEFAULT NULL,
  `fkcodigoempleado` int(11) DEFAULT NULL,
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
INSERT INTO `nomina_encabezado` VALUES (1,0,'2020-03-24','2020-03-25',1,'Nomina realizada a fin de mes',-2501);
/*!40000 ALTER TABLE `nomina_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nominadetalle`
--

DROP TABLE IF EXISTS `nominadetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nominadetalle` (
  `pkcodigonomina` int(11) NOT NULL,
  `cod_linea` int(11) NOT NULL,
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
/*!40000 ALTER TABLE `nominadetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil_detalle`
--

DROP TABLE IF EXISTS `perfil_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `perfil_detalle` (
  `fkcodperfil` int(11) NOT NULL,
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
INSERT INTO `perfil_detalle` VALUES (1,1,0,0,0,0,1,'xD',1),(2,1,1,1,1,1,1,'dX',1),(3,1,0,0,1,1,0,'Curso MYSQL',1);
/*!40000 ALTER TABLE `perfil_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil_encabezado`
--

DROP TABLE IF EXISTS `perfil_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `perfil_encabezado` (
  `pkcodperfil` int(11) NOT NULL,
  `fkcodigopuesto` int(11) DEFAULT NULL,
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
INSERT INTO `perfil_encabezado` VALUES (1,1,1),(2,1,1),(3,1,1);
/*!40000 ALTER TABLE `perfil_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `poliza_detalle`
--

DROP TABLE IF EXISTS `poliza_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `poliza_detalle` (
  `cod_linea` int(11) NOT NULL AUTO_INCREMENT,
  `pkcodigopoliza` int(11) NOT NULL,
  `cuentas` varchar(25) DEFAULT NULL,
  `Debe` int(11) DEFAULT NULL,
  `Haber` int(11) DEFAULT NULL,
  PRIMARY KEY (`cod_linea`,`pkcodigopoliza`),
  KEY `fk_poliza_detalle_poliza_encabezado1` (`pkcodigopoliza`),
  CONSTRAINT `fk_poliza_detalle_poliza_encabezado1` FOREIGN KEY (`pkcodigopoliza`) REFERENCES `poliza_encabezado` (`pkcodigopoliza`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `poliza_detalle`
--

LOCK TABLES `poliza_detalle` WRITE;
/*!40000 ALTER TABLE `poliza_detalle` DISABLE KEYS */;
INSERT INTO `poliza_detalle` VALUES (1,1,'',0,0),(2,1,'Bono250',251,0),(3,1,'BANCOS',0,-2501),(4,1,'SUELDOS',-2752,0);
/*!40000 ALTER TABLE `poliza_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `poliza_encabezado`
--

DROP TABLE IF EXISTS `poliza_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `poliza_encabezado` (
  `pkcodigopoliza` int(11) NOT NULL,
  `pkcodigonomina` int(11) NOT NULL,
  `fechainicio` int(21) DEFAULT NULL,
  `fechafin` int(21) DEFAULT NULL,
  PRIMARY KEY (`pkcodigopoliza`,`pkcodigonomina`),
  KEY `fk_poliza_encabezado_nomina_encabezado1_idx` (`pkcodigonomina`),
  CONSTRAINT `fk_poliza_encabezado_nomina_encabezado1` FOREIGN KEY (`pkcodigonomina`) REFERENCES `nomina_encabezado` (`pkcodigonomina`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `poliza_encabezado`
--

LOCK TABLES `poliza_encabezado` WRITE;
/*!40000 ALTER TABLE `poliza_encabezado` DISABLE KEYS */;
INSERT INTO `poliza_encabezado` VALUES (1,1,2020,2020);
/*!40000 ALTER TABLE `poliza_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `puesto`
--

DROP TABLE IF EXISTS `puesto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `puesto` (
  `pkcodigopuesto` int(11) NOT NULL,
  `fkcodigoempleado` int(11) NOT NULL,
  `fkcodigodepto` int(11) NOT NULL,
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
INSERT INTO `puesto` VALUES (1,1,1,'1',1,'1');
/*!40000 ALTER TABLE `puesto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reuniones`
--

DROP TABLE IF EXISTS `reuniones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reuniones` (
  `pkcodigoreuniones` int(11) NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int(11) NOT NULL,
  `nombrereunion` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `fechainicio` time DEFAULT NULL,
  `fechafinal` time DEFAULT NULL,
  `horainicio` datetime DEFAULT NULL,
  `horafinal` datetime DEFAULT NULL,
  `cantidadempleados` int(11) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigoreuniones`),
  KEY `fk_reuniones_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_reuniones_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reuniones`
--

LOCK TABLES `reuniones` WRITE;
/*!40000 ALTER TABLE `reuniones` DISABLE KEYS */;
/*!40000 ALTER TABLE `reuniones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sancionempleado`
--

DROP TABLE IF EXISTS `sancionempleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sancionempleado` (
  `pkcodigosansionempleado` int(11) NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descipcion` varchar(45) DEFAULT NULL,
  `fechainicio` date DEFAULT NULL,
  `fechafinal` date DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigosansionempleado`),
  KEY `fk_sancionempleado_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_sancionempleado_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sancionempleado`
--

LOCK TABLES `sancionempleado` WRITE;
/*!40000 ALTER TABLE `sancionempleado` DISABLE KEYS */;
INSERT INTO `sancionempleado` VALUES (1,1,'No sabia de BD','no recibio el curso','2020-03-25','2020-03-27',1);
/*!40000 ALTER TABLE `sancionempleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_bancotalento`
--

DROP TABLE IF EXISTS `tbl_bancotalento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_bancotalento` (
  `pkBancoTalento` int(11) NOT NULL AUTO_INCREMENT,
  `fkCurriculum` int(11) NOT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkBancoTalento`,`fkCurriculum`),
  KEY `FK_Curriculum_BancoT` (`fkCurriculum`),
  CONSTRAINT `FK_Curriculum_BancoT` FOREIGN KEY (`fkCurriculum`) REFERENCES `tbl_curriculums` (`pkidCurriculum`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bancotalento`
--

LOCK TABLES `tbl_bancotalento` WRITE;
/*!40000 ALTER TABLE `tbl_bancotalento` DISABLE KEYS */;
INSERT INTO `tbl_bancotalento` VALUES (4,1,1);
/*!40000 ALTER TABLE `tbl_bancotalento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_curriculums`
--

DROP TABLE IF EXISTS `tbl_curriculums`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_curriculums` (
  `pkidCurriculum` int(11) NOT NULL,
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
  `fksolicitudempleado` int(11) DEFAULT NULL,
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
INSERT INTO `tbl_curriculums` VALUES (1,'Jose','Gonzaleez','','wwewe','jdsjosj@gmail.com',1,0,1,0,0,0,'SQL','sin exp',2500,1,1);
/*!40000 ALTER TABLE `tbl_curriculums` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_solicitud_empleado_detalle`
--

DROP TABLE IF EXISTS `tbl_solicitud_empleado_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_solicitud_empleado_detalle` (
  `pksolicitudempleado` int(11) NOT NULL,
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
INSERT INTO `tbl_solicitud_empleado_detalle` VALUES (1,1,0,0,0,0,1,'xD',1),(3,1,0,0,0,0,1,'xD',1);
/*!40000 ALTER TABLE `tbl_solicitud_empleado_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_solicitud_empleado_encabezado`
--

DROP TABLE IF EXISTS `tbl_solicitud_empleado_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_solicitud_empleado_encabezado` (
  `pksolicitudempleado` int(11) NOT NULL,
  `fkcodigoempleado` int(11) DEFAULT NULL,
  `fkcodigocontratacion` int(11) DEFAULT NULL,
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
INSERT INTO `tbl_solicitud_empleado_encabezado` VALUES (1,1,1,'1998-02-03',1),(2,1,1,'1998-02-05',1),(3,1,1,'2020-03-19',1);
/*!40000 ALTER TABLE `tbl_solicitud_empleado_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipocontratacion`
--

DROP TABLE IF EXISTS `tipocontratacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipocontratacion` (
  `pkcodigocontratacion` int(11) NOT NULL,
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
INSERT INTO `tipocontratacion` VALUES (1,'1','1','1',1);
/*!40000 ALTER TABLE `tipocontratacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'mydb'
--

--
-- Dumping routines for database 'mydb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-03-29  9:04:23
