USE `instituto`;
DROP procedure IF EXISTS `NuevaInsc`;

DELIMITER $$
USE `instituto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `NuevaInsc`(in Legajo int,in idEdicion int,in fecha date, out rta int)
begin
     declare filas int default 0;
	 declare primer int default 0;
	 declare existe int default 0;
    
     set filas = (select count(*) from inscripcion);
     if filas = 0 then
		set filas = 620; /* consideramos a este numero como el primer numero de inscripcion */
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo numero de inscripcion almacenada para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
		Lo mismo hacemos para alumno
   ___________________________________________________________________________ */
		set filas = (select max(idInscri) + 1 from inscripcion);
		
		/* ---------------------------------------------------------
			para saber si ya esta almacenado el postulante
		------------------------------------------------------- */	
		set existe = (select count(*) from inscripcion I where I.Legajo = Legajo and I.idEdicion = idEdicion);
     end if;
	 
	  if existe = 0 then	 
		 insert into inscripcion values(filas,Legajo,idEdicion,NOW(),0);
		 set rta  = primer;
	  else
		 set rta = existe;
      end if;		 
    
     end$$

DELIMITER ;
;
