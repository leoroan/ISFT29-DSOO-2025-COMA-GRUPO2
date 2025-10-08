drop database if exists ClubDeportivo;
create database ClubDeportivo;
use ClubDeportivo;

create table roles(
RolUsuario int,
NomRol varchar(30),
constraint primary key(RolUsuario)
);

insert into roles values
(120,'Administrador'),
(121,'Empleado');

create table usuario(
CodUsuario int auto_increment,
NombreUsuario varchar (20),
PassUsuario varchar (15),
RolUsuario int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsuario),
constraint fk_usuario foreign key(RolUsuario) references roles(RolUsuario)
);

insert into usuario(CodUsuario,NombreUsuario,PassUsuario,RolUsuario) values
(26,'Admin2025','123456',120);

## fase 5
create table socio(
carnet_numero int,
Nombre varchar(30),
apellido varchar(40),
fechaNacimiento date,
direccion varchar(40),
dni int,
telefono varchar(20),
aptoFisico boolean,
fecha_inscripcion date,
estadoMembresia boolean default true,
constraint pk_socio primary key(carnet_numero)
);