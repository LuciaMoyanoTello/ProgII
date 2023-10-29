CREATE DATABASE [AutomotrizApp]
USE [AutomotrizApp]


--Comandos
--Drop de tablas
DROP TABLE DETALLES
DROP TABLE PRESUPUESTOS
DROP TABLE PRODUCTOS
DROP TABLE CLIENTES
DROP TABLE TIPOS







--Cambio de formatos
set dateformat dmy

-- Notas:

-- 1. 
-- 2. 
-- 3. 
-- 4. 


--Creacion de tablas (por orden)
-- ========================================================================================================================================== --
--N# de Orden: 1
CREATE TABLE TIPOS
(id_tipo int,
tipo varchar(50)
CONSTRAINT pk_id_tipo PRIMARY KEY (id_tipo))


CREATE TABLE CLIENTES
(id_cliente int,
nombre varchar(50),
apellido varchar(50),
dni varchar(50),
telefono varchar(50),
usuario varchar(50),
pass varchar(50)
CONSTRAINT pk_id_cliente PRIMARY KEY (id_cliente))



--N# de Orden: 2
CREATE TABLE PRODUCTOS
(id_producto int,
nombre varchar(50),
precio money,
id_tipo int
CONSTRAINT pk_id_producto PRIMARY KEY (id_producto),
CONSTRAINT fk_id_tipo FOREIGN KEY (id_tipo)
REFERENCES TIPOS (id_tipo))


CREATE TABLE PRESUPUESTOS
(id_presupuesto int,
id_cliente int,
fecha datetime,
total money,
fecha_baja datetime
CONSTRAINT pk_id_presupuesto PRIMARY KEY (id_presupuesto),
CONSTRAINT fk_id_cliente FOREIGN KEY (id_cliente)
REFERENCES CLIENTES (id_cliente))



--N# de Orden: 3
CREATE TABLE DETALLES
(id_presupuesto int,
id_detalle int,
id_producto int,
cantidad int
CONSTRAINT pk_id_detalle_id_presupuesto PRIMARY KEY (id_presupuesto, id_detalle),
CONSTRAINT fk_id_producto FOREIGN KEY (id_producto)
REFERENCES PRODUCTOS (id_producto),
CONSTRAINT fk_id_presupuesto FOREIGN KEY (id_presupuesto)
REFERENCES PRESUPUESTOS (id_presupuesto))

-- ========================================================================================================================================== --


--Inserts
-- ========================================================================================================================================== --
--Tabla TIPOS (id_tipo, tipo)
INSERT INTO TIPOS VALUES (1, 'Filtros');


--Tabla CLIENTES (id_cliente, nombre, apellido, dni, telefono, usuario, pass)
INSERT INTO CLIENTES VALUES (1, 'Juan', 'Pérez', '12345678A', '123456789', 'test', '123');


--Tabla PRODUCTOS (id_producto, nombre, precio, id_tipo)
INSERT INTO PRODUCTOS VALUES (1, 'Filtro de Aceite', 200.0, 1);


--Tabla PRESUPUESTOS (id_presupuesto, id_cliente, fecha, total, fecha_baja)
INSERT INTO PRESUPUESTOS VALUES (1, 1, '28/10/2023', 500.00, NULL);


--Tabla DETALLES (id_presupuesto, id_detalle, id_producto, cantidad)
INSERT INTO DETALLES VALUES (1, 1, 1, 2);


-- ========================================================================================================================================== --


--Procedimientos almacenados
-- ========================================================================================================================================== --
--SP para consultar la existencia de un cliente con un nombre de usuario y contraseña especifico
go
create proc [SP_Consultar_Login]
@input_usuario varchar(50) = '',
@input_pass varchar(50) = ''
as
SELECT top(1) c.nombre + c.apellido 'Nombre Completo', c.dni 'DNI', c.telefono 'Telefono'
FROM CLIENTES c
WHERE c.usuario = @input_usuario and c.pass = @input_pass
go
--Ejecutable
exec [SP_Consultar_Login] @input_usuario = '', @input_pass = ''



go
create proc [SP_Consultar_Login]
@input_usuario varchar(50) = '',
@input_pass varchar(50) = ''
as
SELECT top(1) c.nombre + c.apellido 'Nombre Completo', c.dni 'DNI', c.telefono 'Telefono'
FROM CLIENTES c
WHERE c.usuario = @input_usuario and c.pass = @input_pass
go
--Ejecutable
exec [SP_Consultar_Login] @input_usuario = '', @input_pass = ''