CREATE DEFINER=`root`@`localhost` PROCEDURE `NuevoSocio`(in  Nombre varchar(30),in apellido varchar(40),in fecha_nacimiento date, in direccion varchar(40), in documento int,  telefono varchar(20),
aptoFisico boolean, fecha_inscripcion date, out rta int)
BEGIN
 declare filas int default 0;
	 declare existe int default 0;
    
     set filas = (select count(*) from socio);
     if filas = 0 then
		set filas = 1000; /* consideramos a este numero como el primer numero de socio */
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo numero de socio almacenado para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
   ___________________________________________________________________________ */
		set filas = (select max(carnet_numero) + 1 from socio);
		
		/* ---------------------------------------------------------
			para saber si ya esta almacenado el socio
		------------------------------------------------------- */	
		set existe = (select count(*) from socio where  dni = documento);
     end if;
	 
	  if existe = 0 then	 
		 insert into socio values(filas,Nombre,apellido,fecha_nacimiento,direccion,dni,telefono,aptoFisico,fecha_inscripcion,true);
		 set rta  = filas;
	  else
		 set rta = existe;
      end if;		 
END