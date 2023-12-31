create database carrera
use carrera

--TABLAS
create table Asignatura(
id_asignatura int,
nombre varchar(100)
CONSTRAINT pk_asignatura PRIMARY KEY(id_asignatura))

create table Carrera(
id_carrera int,
nombre varchar(100),
titulo varchar(100)
CONSTRAINT pk_carrera PRIMARY KEY(id_carrera))

CREATE TABLE DetalleCarrera(
id_detalle int,
id_carrera int,
anioCursado int,
cuatrimestre int,
id_asignatura int
CONSTRAINT pk_detalle PRIMARY KEY(id_detalle),
CONSTRAINT fk_carrera_detalle FOREIGN KEY(id_carrera)
	REFERENCES carrera(id_carrera),
CONSTRAINT fk_asignatura_detalle FOREIGN KEY(id_asignatura)
	REFERENCES asignatura (id_asignatura)
)

--INSERT
INSERT INTO Asignatura(id_asignatura,nombre)
VALUES (1,'Laboratorio I')
INSERT INTO Asignatura(id_asignatura,nombre)
VALUES (2, 'Laboratorio II')
INSERT INTO Asignatura(id_asignatura,nombre)
VALUES (3, 'Programaci�n I')
INSERT INTO Asignatura(id_asignatura,nombre)
VALUES (4, 'Programaci�n II')

--PROCEDIMIENTOS ALMACENADOS
create procedure SP_PROXIMO_ID
@next int output
as
begin
	set @next = (select max(id_carrera)+1 from carrera)
end

create procedure SP_CONSULTAR_ASIGNATURA
as
begin
	select * from Asignatura
end

create procedure SP_INSERTAR_DETALLE
@detalle int,
@carrera int,
@a�o int,
@cuatrimestre int,
@asignatura int
as
begin
	insert into DetalleCarrera(id_detalle,id_carrera,anioCursado,cuatrimestre,id_asignatura)
	values (@detalle,@carrera,@a�o,@cuatrimestre,@asignatura)
end

create procedure SP_INSERTAR_MAESTRO
@id_carrera int OUTPUT,
@nombre varchar(100),
@titulo varchar(100)
as
begin
	insert into carrera (id_carrera,nombre,titulo)
	values(@id_carrera,@nombre,@titulo);
	SET @id_carrera = SCOPE_IDENTITY();
end