
/* se cambia el delimitador de linea para poder almacenar en
el sistema gestor el código del procedimiento
Se puede utilizar cualquier caracater 
*************************************************   */

delimiter //  
create procedure IngresoLogin(in Usuario varchar(20),in Pass varchar(15))

/* =============================================================================
Se colocan dos parametros de entrada por eso son in
uno para el nombre de usuario y el otro para la contraseña
observar que la longitud debe ser igual que la longitud del atributo de la tabla
===================================================================================  */
begin
  /* proyecto en la consulta el rol que tiene el usuario que ingresa */
  
  select NomRol
	from usuario u inner join roles r on u.RolUsuario = r.RolUsuario
		where NombreUsuario = Usuario and PassUsuario = Pass /* se compara con los parametros */
			and Activo = 1; /* el usuario debe estar activo */


end 
//

/* ==========================
si queremos probar el procedure se usa call
====================================================== */

call IngresoLogin('dato1', 'dato2')//

/* ===============================
si los datos de los parametros existen la consulta arroja 1 FILA
si los datos de los parametros NO EXISTEN la consulta arroja 0 FILAS
============================================================================= */