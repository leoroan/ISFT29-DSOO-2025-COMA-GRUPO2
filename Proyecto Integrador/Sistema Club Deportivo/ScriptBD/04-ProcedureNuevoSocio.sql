delimiter // 
CREATE DEFINER=`root`@`localhost` PROCEDURE `NuevoSocio`(in fechaInscripcion date, out rta int)
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
     
	 insert into socio values(filas,fechaInscripcion,true);
	 set rta  = filas;
		 
END//