delimiter // 
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
END//