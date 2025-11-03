drop database if exists comisionaequipo2;
create database comisionaequipo2;
use comisionaequipo2;

DELIMITER $$
DROP PROCEDURE IF EXISTS IngresoLogin $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoLogin`(in Usuario varchar(20),in Pass varchar(15))
begin
  /* proyecto en la consulta el rol que tiene el usuario que ingresa */
  
  select NomRol
	from usuario u inner join roles r on u.RolUsuario = r.RolUsuario
		where NombreUsuario = Usuario and PassUsuario = Pass /* se compara con los parametros */
			and Activo = 1; /* el usuario debe estar activo */


end $$
DELIMITER ;


DELIMITER $$
DROP PROCEDURE IF EXISTS NuevaCuota $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `NuevaCuota`(in carnetNumero int, in fechaVencimiento date,in precio float, out rta int)
BEGIN
	insert into cuota(carnetNumero,fechaVencimiento,precio,estado ) values(carnetNumero,fechaVencimiento,precio,0);
	SET rta = LAST_INSERT_ID();
END $$
DELIMITER ;


DELIMITER $$
DROP PROCEDURE IF EXISTS NuevaPagoActividad $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `NuevaPagoActividad`(in carnetTemporal int,in nroActividad int,in precio float, out rta int)
BEGIN
	insert into pagoactividad(carnetTemporal,nroActividad,precio,estado ) values(carnetTemporal,nroActividad,precio,0);
	SET rta = LAST_INSERT_ID();
END $$
DELIMITER ;


DELIMITER $$
DROP PROCEDURE IF EXISTS NuevoNoSocio $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `NuevoNoSocio`(in idPersona int, out rta int)
BEGIN
 declare filas int default 0;
	 declare existe int default 0;
    
     set filas = (select count(*) from nosocio);
     if filas = 0 then
		set filas = 1000; /* consideramos a este numero como el primer numero de persona */
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo numero de persona almacenado para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
   ___________________________________________________________________________ */
		set filas = (select max(carnetTemporal) + 1 from nosocio);
     end if;
     
	 insert into nosocio values(filas,idPersona);
	 set rta  = filas;
		 
END $$
DELIMITER ;


DELIMITER $$
DROP PROCEDURE IF EXISTS NuevoPago $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `NuevoPago`(in carnetNumero int,in tipoPersona int,in precio float,in fecha date, in medioPago int,in tipoActividad int,in idRegistroaPagar int,  out rta int)
BEGIN
	 insert into pago(carnetNumero,tipoPersona,precio,fecha,medioPago ) values(carnetNumero,tipoPersona,precio,fecha,medioPago);
	 SET rta = LAST_INSERT_ID();
     if tipoActividad =1 then
		update cuota set estado=1 where idcuota=idRegistroaPagar;
	 else 
       update pagoactividad set estado=1 where idPagoActividad=idRegistroaPagar;
     end if;
END $$
DELIMITER ;


DELIMITER $$
DROP PROCEDURE IF EXISTS NuevoPersona $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `NuevoPersona`(in  Nombre varchar(30),in apellido varchar(40),in fechaNacimiento date, in direccion varchar(40), in documento int,  telefono varchar(20),
aptoFisico boolean, out rta int)
BEGIN
 declare filas int default 0;
	 declare existe int default 0;
    
     set filas = (select count(*) from persona);
     if filas = 0 then
		set filas = 1000; /* consideramos a este numero como el primer numero de persona */
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo numero de persona almacenado para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
   ___________________________________________________________________________ */
		set filas = (select max(idPersona) + 1 from persona);
		
		/* ---------------------------------------------------------
			para saber si ya esta almacenado la persona
		------------------------------------------------------- */	
		set existe = (select count(*) from persona where  dni = documento);
     end if;
	 
	  if existe = 0 then	 
		 insert into persona values(filas,Nombre,apellido,fechaNacimiento,direccion,documento,telefono,true);
		 set rta  = filas;
	  else
		 set rta = existe;
      end if;		 
END $$
DELIMITER ;


DELIMITER $$
DROP PROCEDURE IF EXISTS NuevoSocio $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `NuevoSocio`(in idPersona int, in fechaInscripcion date, out rta int)
BEGIN
 declare filas int default 0;
	 declare existe int default 0;
    
     set filas = (select count(*) from socio);
     if filas = 0 then
		set filas = 1000; /* consideramos a este numero como el primer numero de persona */
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo numero de persona almacenado para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
   ___________________________________________________________________________ */
		set filas = (select max(carnetNumero) + 1 from socio);
     end if;
     
	 insert into socio values(filas,idPersona,fechaInscripcion,true);
	 set rta  = filas;
		 
END $$
DELIMITER ;


DROP TABLE IF EXISTS actividad;
CREATE TABLE `actividad` (
  `NroActividad` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(40) DEFAULT NULL,
  `precio` float DEFAULT NULL,
  PRIMARY KEY (`NroActividad`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES actividad WRITE;
INSERT INTO actividad VALUES
 (1,'Todas',25000),
 (2,'Natacion',2600),
 (3,'Basquet',3000);
UNLOCK TABLES;

DROP TABLE IF EXISTS cuota;
CREATE TABLE `cuota` (
  `idCuota` int NOT NULL AUTO_INCREMENT,
  `carnetNumero` int DEFAULT NULL,
  `fechaVencimiento` date DEFAULT NULL,
  `precio` float DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idCuota`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS nosocio;
CREATE TABLE `nosocio` (
  `carnetTemporal` int NOT NULL,
  `idPersona` int DEFAULT NULL,
  PRIMARY KEY (`carnetTemporal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS pago;
CREATE TABLE `pago` (
  `idPago` int NOT NULL AUTO_INCREMENT,
  `carnetNumero` int DEFAULT NULL,
  `tipoPersona` int DEFAULT NULL,
  `precio` float DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `medioPago` int DEFAULT NULL,
  PRIMARY KEY (`idPago`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS pagoactividad;
CREATE TABLE `pagoactividad` (
  `idPagoActividad` int NOT NULL AUTO_INCREMENT,
  `NroActividad` int DEFAULT NULL,
  `carnetTemporal` int DEFAULT NULL,
  `precio` float DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idPagoActividad`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS persona;
CREATE TABLE `persona` (
  `idPersona` int NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `apellido` varchar(40) DEFAULT NULL,
  `fechaNacimiento` date DEFAULT NULL,
  `direccion` varchar(40) DEFAULT NULL,
  `dni` int DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `aptoFisico` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idPersona`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS roles;
CREATE TABLE `roles` (
  `RolUsuario` int NOT NULL,
  `NomRol` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`RolUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES roles WRITE;
INSERT INTO roles VALUES
 (120,'Administrador'),
 (121,'Empleado');
UNLOCK TABLES;

DROP TABLE IF EXISTS socio;
CREATE TABLE `socio` (
  `carnetNumero` int NOT NULL,
  `idPersona` int DEFAULT NULL,
  `fechaInscripcion` date DEFAULT NULL,
  `estadoMembresia` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`carnetNumero`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


DROP TABLE IF EXISTS usuario;
CREATE TABLE `usuario` (
  `CodUsuario` int NOT NULL AUTO_INCREMENT,
  `NombreUsuario` varchar(20) DEFAULT NULL,
  `PassUsuario` varchar(15) DEFAULT NULL,
  `RolUsuario` int DEFAULT NULL,
  `Activo` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`CodUsuario`),
  KEY `fk_usuario` (`RolUsuario`),
  CONSTRAINT `fk_usuario` FOREIGN KEY (`RolUsuario`) REFERENCES `roles` (`RolUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES usuario WRITE;
INSERT INTO usuario VALUES
 (26,'Admin2025','123456',120,1);
UNLOCK TABLES;
