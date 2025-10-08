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
('','UsuarioPrueba','Usu2023',120);

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

create table postulante(
NPostu int,
NombreP varchar(30),
ApellidoP varchar(40),
TDocP varchar(20),
DocP int,
constraint pk_postulante primary key(NPostu)
);

create table alumno(
Legajo int,
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

create table edicion(
idEdicion int auto_increment,
NCurso int,
fecha date,
constraint pk_edicion primary key(idEdicion),
constraint fk_edicion foreign key (NCurso) references curso(NCurso)
);

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
constraint pk_inscripcion primary key(idInscri),
constraint fk_inscripcion_alumno foreign key (Legajo) references alumno(Legajo),
constraint fk_inscripcion_curso foreign key (idEdicion) references edicion(idEdicion)
);

create table pago(
idPago int,
idInscri int,
monto float,
fecha date,
constraint pk_pago primary key(idPago),
constraint fk_pago foreign key (idInscri) references inscripcion(idInscri)
);
