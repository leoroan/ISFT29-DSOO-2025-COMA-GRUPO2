

 create procedure NuevoPos(in Nom varchar(30),in Ape varchar(40),in Tip varchar(20), in Doc int, out rta int)
 begin
     declare filas int default 0;
	 declare existe int default 0;
    
     set filas = (select count(*) from postulante);
     if filas = 0 then
		set filas = 452; /* consideramos a este numero como el primer numero de postulante */
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo numero de postulante almacenado para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
   ___________________________________________________________________________ */
		set filas = (select max(NroPostulante) + 1 from postulante);
		
		/* ---------------------------------------------------------
			para saber si ya esta almacenado el postulante
		------------------------------------------------------- */	
		set existe = (select count(*) from postulante where TipoDoc= Tip and Documento = Doc);
     end if;
	 
	  if existe = 0 then	 
		 insert into postulante values(filas,Nom,Ape,Tip,Doc);
		 set rta  = filas;
	  else
		 set rta = existe;
      end if;		 
    
     end //
