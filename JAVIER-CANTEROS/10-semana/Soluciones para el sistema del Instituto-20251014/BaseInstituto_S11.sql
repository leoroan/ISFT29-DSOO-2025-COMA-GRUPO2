drop database if exists Instituto;
create database Instituto;
use Instituto;

create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(120,'Administrador'),
(121,'Empleado');

create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

insert into usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
(26,'Mari2023','123456',120),
('1','UsuarioPrueba','Usu2023',120);

/*  a partir de la semana 10  */


create table docente(
NDocente int,
NombreD varchar(30),
ApellidoD varchar(40),
TDocD varchar(20),
DocD int,
DomiD varchar(60),
constraint pk_docente primary key(NDocente)
);

insert into docente values
(2059,"Nilda","Perez","DNI",21021021,"Yerbal 3456 Ramos Mejia Pcia Bs.As."),
(2060,"Carlos","Lipis","DNI",19452452,"Ramon Falcon 784 CABA"),
(2063,"Walter","Rodriguez","DNI",12123123,"Cucha Cucha 2345 CABA"),
(2034,"Marai Olivia","Quiroz","DNI",23120120,"Av. Rivadavia 10120 CABA"),
(2035,"Marianela Ines","Urtufart","DNI",24111000,"Laprida 152 Florida Pcia Bs. As."),
(2036,"Miriam","Rojas","DNI",21000000,"Nueva Cruz 203 Haedo  Pcia Bs. As."),
(2037,"Josefina","Juarez","DNI",35896698,"Olmos 1250 CABA");

create table postulante(
NPostu int,
NombreP varchar(30),
ApellidoP varchar(40),
TDocP varchar(20),
DocP int,
constraint pk_postulante primary key(NPostu)
);

create table alumno(
Legajo int auto_increment,
NPostu int,
constraint pk_alumno primary key(Legajo),
constraint fk_alumno foreign key(NPostu) references postulante(NPostu)
);

create table curso(
NCurso int,
Nombre varchar(40),
cupo int,
precio float,
constraint pk_curso primary key(NCurso)
);

insert into curso values
(4189,"Programacion I",20,18000),
(4190,"Programacion II",25,20000),
(4191,"Programacion III",20,25000),
(3258,"Calculo numerico",15,14000),
(3893,"Analisis Matematico I",15,21000),
(3894,"Analisis Matematico II",20,21500),
(2581,"Algebra I",18,19500),
(2582,"Algebra II",18,18000),
(3751,"Ingles Basico",15,14000),
(3752,"Ingles medio",15,18000),
(3753,"Ingles avanzado",15,20000);



create table edicion(
idEdicion int auto_increment,
NCurso int,
fecha date,
docente int,
constraint pk_edicion primary key(idEdicion),
constraint pk_edicion_docente foreign key(docente) references docente(NDocente),
constraint fk_edicion_curso foreign key (NCurso) references curso(NCurso)
);

insert into edicion values
(845,4189,'2023/09/04',2060),
('1',4190,'2023/09/04',2034),
('2',4191,'2023/09/06',2060),
('3',3258,'2023/09/04',2036),
('4',3893,'2023/09/11',2036),
('6',3894,'2023/10/09',2059),
('8',2581,'2023/10/09',2063),
('9',2582,'2023/10/16',2063),
('5',3751,'2023/10/09',2037),
('10',3752,'2023/10/09',2037),
('11',3753,'2023/10/09',2035),
('12',3893,'2023/11/06',2036),
('13',2581,'2023/11/06',2059);




create table lista(
idLista int,
Legajo int,
idEdicion int,
constraint pk_lista primary key(idlista),
constraint fk_lista_alumno foreign key (Legajo) references alumno(Legajo),
constraint fk_lista_curso foreign key (idEdicion) references edicion(idEdicion)
);


create table inscripcion(
idInscri int,
Legajo int,
idEdicion int,
fecha date,
pagado boolean default false,
constraint pk_inscripcion primary key(idInscri),
constraint fk_inscripcion_alumno foreign key (Legajo) references alumno(Legajo),
constraint fk_inscripcion_curso foreign key (idEdicion) references edicion(idEdicion)
);

create table pago(
idPago int auto_increment,
idInscri int,
monto float,
fecha date,
constraint pk_pago primary key(idPago),
constraint fk_pago foreign key (idInscri) references inscripcion(idInscri)
);

/* ============================================================================== */


delimiter // 
drop procedure if exists IngresoLogin//
 
create procedure IngresoLogin(in Usu varchar(20),in Pass varchar(15))
begin
  /* proyecto en la consulta el rol que tiene el usuario que ingresa */
  
  select NomRol
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass /* se compara con los parametros */
			and Activo = 1; /* el usuario debe estar activo */


end 
//

/* ====================================================================== */


 drop procedure if exists NuevoPos;	
 create procedure NuevoPos(in Nom varchar(30),in Ape varchar(40),in Tip varchar(20), in Doc int, out rta int)
 begin
     declare filas int default 0;
	 declare primer int default 0;
	 declare existe int default 0;
    
     set filas = (select count(*) from postulante);
     if filas = 0 then
		set filas = 452; /* consideramos a este numero como el primer numero de postulante */
		set primer = 1420;
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo numero de postulante almacenado para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
		Lo mismo hacemos para alumno
   ___________________________________________________________________________ */
		set filas = (select max(NPostu) + 1 from postulante);
		set primer =(select max(legajo) + 1 from alumno);
		
		/* ---------------------------------------------------------
			para saber si ya esta almacenado el postulante
		------------------------------------------------------- */	
		set existe = (select count(*) from postulante where TdocP = Tip and DocP = Doc);
     end if;
	 
	  if existe = 0 then	 
		 insert into postulante values(filas,Nom,Ape,Tip,Doc);
		 
		 /* --------------  SE LE ASIGNA UN NÚMERO DE ALUMNO ----------------    */
		 insert into alumno values(primer,filas);
		 set rta  = primer;
	  else
		 set rta = existe;
      end if;		 
    
     end //
