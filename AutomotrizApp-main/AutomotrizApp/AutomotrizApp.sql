CREATE DATABASE [AutomotrizApp]
USE [AutomotrizApp]


--Comandos
--Drop de tablas
DROP TABLE DETALLES
DROP TABLE PRESUPUESTOS
DROP TABLE PRODUCTOS
DROP TABLE CLIENTES
DROP TABLE TIPOS

--Drop de SP
DROP PROC [SP_CONSULTAR_LOGIN]
DROP PROC [SP_CONSULTAR_CLIENTES]
DROP PROC [SP_PROXIMO_ID_PRODUCTOS]
DROP PROC [SP_CONSULTAR_TIPOS]
DROP PROC [SP_CONSULTAR_PRODUCTOS]
DROP PROC [SP_INSERTAR_PRODUCTOS]
DROP PROC [SP_ACTUALIZAR_PRODUCTOS]
DROP PROC [SP_ELIMINAR_PRODUCTOS]
DROP PROC [SP_CONSULTAR_PRESUPUESTOS]
DROP PROC [SP_INSERTAR_PRESUPUESTOS]
DROP PROC [SP_ACTUALIZAR_PRESUPUESTOS]
DROP PROC [SP_ELIMINAR_PRESUPUESTOS]
DROP PROC [SP_INSERTAR_DETALLES]


--Cambio de formatos
set dateformat dmy

-- Notas:

-- Gabi (03/11):
-- 1. Use el like en los SP para poder tomar parametros vacios o "incompletos" sin que tire error, ej: DNIs que contengan 123
-- 2. Especifico los campos de las consultas para no usar el *
-- 3. Modifico los inserts grupales a inserts independientes para que sean mas faciles de manejar
-- 4. Cambio algunos SPs, campos como total es money (no numeric) e id_cliente es int (no varchar)
-- 5. Agregue "SP_CONSULTAR_TIPOS" que faltaba para poder hacer carga de los combo box
-- 6. Modifique SP_CONSULTAR_PRODUCTOS para que acepte parametros de entrada y filtre


-- Gabi (06/11)
-- 1. Agregue "SP_INSERTAR_PRODUCTO" como parte del ABMC
-- 2. Falta "SP_ACTUALIZAR_PRODUCTO"



--Creacion de tablas (por orden)
-- ========================================================================================================================================== --
--N# de Orden: 1
CREATE TABLE TIPOS
(id_tipo int,
tipo varchar(50)
CONSTRAINT pk_id_tipo PRIMARY KEY (id_tipo))


CREATE TABLE CLIENTES
(id_cliente int identity(1, 1),
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
(id_presupuesto int identity(1, 1),
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
INSERT INTO TIPOS VALUES (1, 'Frenos');
INSERT INTO TIPOS VALUES (2, 'Aceite');
INSERT INTO TIPOS VALUES (3, 'Filtros');
INSERT INTO TIPOS VALUES (4, 'Suspensión');
INSERT INTO TIPOS VALUES (5, 'Motor'); --
INSERT INTO TIPOS VALUES (6, 'Transmisión'); --
INSERT INTO TIPOS VALUES (7, 'Luces');
INSERT INTO TIPOS VALUES (8, 'Neumáticos');
INSERT INTO TIPOS VALUES (9, 'Carrocería');
INSERT INTO TIPOS VALUES (10, 'Interior');
INSERT INTO TIPOS VALUES (11, 'Sistema de escape');
INSERT INTO TIPOS VALUES (12, 'Sistema de enfriamiento');
INSERT INTO TIPOS VALUES (13, 'Dirección');
INSERT INTO TIPOS VALUES (14, 'Electrónica');



--Tabla CLIENTES (id_cliente IDENTITY, nombre, apellido, dni, telefono, usuario, pass)
INSERT INTO CLIENTES VALUES ('Juan', 'Pérez', '12345678', '123456789', 'test', '123');
INSERT INTO CLIENTES VALUES ('Gabriel', 'De Maussion', '42979978', '3516169575', ' ', ' ');
INSERT INTO CLIENTES VALUES ('Pedro', 'Gómez', '56781234', '654321987', 'pedro', '789879');
INSERT INTO CLIENTES VALUES ('Ana', 'García', '98761234', '123456789', 'ana', '987987');
INSERT INTO CLIENTES VALUES ('Luis', 'Rodríguez', '65437890', '876543210', 'luis', '765765');
INSERT INTO CLIENTES VALUES ('Laura', 'Torres', '12345690', '109876543', 'laura', '543543');
INSERT INTO CLIENTES VALUES ('Javier', 'Fernández', '89012345', '987654321', 'javier', '321321');
INSERT INTO CLIENTES VALUES ('Elena', 'Sánchez', '56789012', '123456789', 'elena', '234234');
INSERT INTO CLIENTES VALUES ('Miguel', 'Martínez', '12345678', '987654321', 'miguel', '123123');
INSERT INTO CLIENTES VALUES ('Sara', 'López', '87654321', '654321987', 'sara', '456456');
INSERT INTO CLIENTES VALUES ('Diego', 'Pérez', '56781234', '123456789', 'diego', '789789');
INSERT INTO CLIENTES VALUES ('Carmen', 'Gómez', '98761234', '987654321', 'carmen', '987987');
INSERT INTO CLIENTES VALUES ('Carlos', 'Torres', '65437890', '876543210', 'carlos', '765765');
INSERT INTO CLIENTES VALUES ('Marta', 'Fernández', '12345690', '109876543', 'marta', '543543');
INSERT INTO CLIENTES VALUES ('Isabel', 'Sánchez', '89012345', '987654321', 'isabel', '321321');
INSERT INTO CLIENTES VALUES ('Jorge', 'Martínez', '56789012', '123456789', 'jorge', '234234');
INSERT INTO CLIENTES VALUES ('Natalia', 'López', '12345678', '987654321', 'natalia', '123123');
INSERT INTO CLIENTES VALUES ('Roberto', 'Pérez', '87654321', '654321987', 'roberto', '456456');
INSERT INTO CLIENTES VALUES ('Patricia', 'Gómez', '56781234', '123456789', 'patricia', '789789');
INSERT INTO CLIENTES VALUES ('Alejandro', 'García', '98761234', '987654321', 'alejandro', '987987');
INSERT INTO CLIENTES VALUES ('Lucía', 'Torres', '65437890', '876543210', 'lucia', '765765');
INSERT INTO CLIENTES VALUES ('Víctor', 'Fernández', '12345690', '109876543', 'victor', '543543');
INSERT INTO CLIENTES VALUES ('Sofía', 'Sánchez', '89012345', '987654321', 'sofia', '321321');
INSERT INTO CLIENTES VALUES ('Raúl', 'Martínez', '56789012', '123456789', 'raul', '234234');
INSERT INTO CLIENTES VALUES ('Marina', 'López', '12345678', '987654321', 'marina', '123123');
INSERT INTO CLIENTES VALUES ('Antonio', 'Pérez', '87654321', '654321987', 'antonio', '456456');
INSERT INTO CLIENTES VALUES ('Teresa', 'Gómez', '56781234', '123456789', 'teresa', '789789');
INSERT INTO CLIENTES VALUES ('Andrés', 'García', '98761234', '987654321', 'andres', '987987');
INSERT INTO CLIENTES VALUES ('Cristina', 'Torres', '65437890', '876543210', 'cristina', '765765');
INSERT INTO CLIENTES VALUES ('Hugo', 'Fernández', '12345690', '109876543', 'hugo', '543543');


--Tabla PRODUCTOS (id_producto, nombre, precio, id_tipo)
INSERT INTO PRODUCTOS VALUES (1, 'Kit de frenos de alto rendimiento', 16000, 1);
INSERT INTO PRODUCTOS VALUES (2, 'Aceite de motor sintético premium', 8000, 2);
INSERT INTO PRODUCTOS VALUES (3, 'Filtro de aire de alto flujo', 17000, 3);
INSERT INTO PRODUCTOS VALUES (4, 'Amortiguadores deportivos ajustables', 15500, 4);
INSERT INTO PRODUCTOS VALUES (5, 'Batería de alto rendimiento', 78000, 8);
INSERT INTO PRODUCTOS VALUES (6, 'Escape deportivo de acero inoxidable', 56000, 11);
INSERT INTO PRODUCTOS VALUES (7, 'Radiador de enfriamiento de alto flujo', 7800, 12);
INSERT INTO PRODUCTOS VALUES (8, 'Dirección asistida eléctrica', 16000, 13);
INSERT INTO PRODUCTOS VALUES (9, 'Sistema de sonido premium', 18000, 14);
INSERT INTO PRODUCTOS VALUES (10, 'Kit de iluminación LED', 37000, 7);
INSERT INTO PRODUCTOS VALUES (11, 'Neumáticos de alto desempeño', 76000, 8);
INSERT INTO PRODUCTOS VALUES (12, 'Parachoques delantero de fibra de carbono', 82000, 9);
INSERT INTO PRODUCTOS VALUES (13, 'Asientos deportivos de cuero', 108000, 10);
INSERT INTO PRODUCTOS VALUES (14, 'Sistema de escape de alto rendimiento', 106000, 11);
INSERT INTO PRODUCTOS VALUES (15, 'Sistema de enfriamiento líquido premium', 95000, 12);
INSERT INTO PRODUCTOS VALUES (16, 'Sistema de dirección asistida hidráulica', 96000, 13);
INSERT INTO PRODUCTOS VALUES (17, 'Unidad de control del motor reprogramable', 77000, 14);
INSERT INTO PRODUCTOS VALUES (18, 'Faros LED delanteros', 16000, 7);
INSERT INTO PRODUCTOS VALUES (19, 'Neumáticos todoterreno', 106000, 8);
INSERT INTO PRODUCTOS VALUES (20, 'Puerta delantera de fibra de vidrio', 64000, 9);


--Tabla PRESUPUESTOS (id_presupuesto IDENTITY, id_cliente, fecha, total, fecha_baja)
INSERT INTO PRESUPUESTOS VALUES (1, '05/10/2023', 49000, NULL);
INSERT INTO PRESUPUESTOS VALUES (11, '02/12/2022', 15500, NULL);
INSERT INTO PRESUPUESTOS VALUES (3, '02/11/2022', 31400, NULL);
INSERT INTO PRESUPUESTOS VALUES (4, '02/05/2022', 94000, NULL);
INSERT INTO PRESUPUESTOS VALUES (5, '02/06/2022', 74000, NULL);
INSERT INTO PRESUPUESTOS VALUES (6, '04/11/2022', 310000, NULL);
INSERT INTO PRESUPUESTOS VALUES (7, '10/01/2022', 216000, NULL);
INSERT INTO PRESUPUESTOS VALUES (8, '08/09/2022', 95000, NULL);
INSERT INTO PRESUPUESTOS VALUES (9, '02/04/2023', 77000, NULL);
INSERT INTO PRESUPUESTOS VALUES (10, '22/04/2023', 212000, NULL);


--Tabla DETALLES (id_presupuesto, id_detalle, id_producto, cantidad)
INSERT INTO DETALLES VALUES (1, 1, 1, 2);
INSERT INTO DETALLES VALUES (1, 2, 3, 1);
INSERT INTO DETALLES VALUES (2, 1, 4, 1);
INSERT INTO DETALLES VALUES (3, 1, 2, 1);
INSERT INTO DETALLES VALUES (3, 2, 7, 3);
INSERT INTO DETALLES VALUES (4, 1, 5, 1);
INSERT INTO DETALLES VALUES (4, 2, 8, 2);
INSERT INTO DETALLES VALUES (5, 2, 10, 2);
INSERT INTO DETALLES VALUES (6, 1, 11, 3);
INSERT INTO DETALLES VALUES (6, 2, 12, 1);
INSERT INTO DETALLES VALUES (7, 1, 13, 2);
INSERT INTO DETALLES VALUES (8, 1, 15, 1);
INSERT INTO DETALLES VALUES (9, 1, 17, 1);
INSERT INTO DETALLES VALUES (10, 1, 19, 2);


-- ========================================================================================================================================== --


--Procedimientos almacenados
-- ========================================================================================================================================== --
go
--SP para consultar la existencia de un cliente con un nombre de usuario y contraseña especifico
create proc [SP_CONSULTAR_LOGIN]
		@input_usuario varchar(50) = '',
		@input_pass varchar(50) = ''
as
begin
		SELECT top(1) c.nombre + ' ' + c.apellido 'Nombre Completo', c.dni 'DNI', c.telefono 'Telefono'
		FROM CLIENTES c
		WHERE c.usuario = @input_usuario and c.pass = @input_pass
end
--exec [SP_CONSULTAR_LOGIN] @input_usuario = 'test', @input_pass = '123'
go

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para consultar la existencia de un cliente con un DNI, devuelve el/los ID (+ resto de datos) de los que coincidan para iniciar la transaccion
create proc [SP_CONSULTAR_CLIENTES]
		@input_dni_cliente varchar(50) = ''
as
begin
		SELECT id_cliente 'ID', c.nombre + ' ' + c.apellido 'Nombre Completo', c.dni 'DNI', c.telefono 'Telefono'
		FROM CLIENTES c
		WHERE c.dni = @input_dni_cliente
end
--exec [SP_CONSULTAR_CLIENTE] @input_dni_cliente = '12345678'
go

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para conocer el id del proximo producto a insertar
create proc [SP_PROXIMO_ID_PRODUCTOS]
as
begin
        SELECT MAX(p.id_producto)+1 'Nueva ID'
		FROM PRODUCTOS p;
end
--exec [SP_PROXIMO_ID_PRODUCTOS]
go

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para consultar tipos sin parametros de entrada (sirve para los combo box)
create proc [SP_CONSULTAR_TIPOS]
as
begin
        SELECT t.id_tipo 'ID', t.tipo 'Tipo'
		FROM TIPOS t
end
--exec [SP_CONSULTAR_TIPOS]
go

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para consultar productos sin parametros de entrada (sirve para los combo box)
create proc [SP_CONSULTAR_PRODUCTOS]
		@input_nombre varchar(50) = '',
		@input_precio_min money = null,
		@input_precio_max money = null,
		@input_id_tipo int = null
as
begin
        SELECT p.id_producto 'ID', p.nombre 'Nombre', round (p.precio, 2) 'Precio', t.tipo 'Tipo'
		FROM PRODUCTOS p join TIPOS t on p.id_tipo = t.id_tipo
		WHERE (p.nombre like '%' + @input_nombre + '%')
        AND (p.precio between isnull(@input_precio_min, p.precio) and isnull(@input_precio_max, p.precio))
        AND p.id_tipo = isnull(@input_id_tipo, p.id_tipo);
end
--exec [SP_CONSULTAR_PRODUCTOS] @input_nombre = '', @input_precio_min = 0, @input_precio_max = 999999, @input_id_tipo = 1
go

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para cargar un nuevo producto tomando todos los parametros de entrada
create proc [SP_INSERTAR_PRODUCTOS]
		@input_id_producto int = null,
		@input_nombre varchar(50) = null,
		@input_precio money = null,
		@input_id_tipo int = null
as
begin
		INSERT INTO PRODUCTOS
		VALUES (@input_id_producto, @input_nombre, @input_precio, @input_id_tipo);
end
--exec [SP_CONSULTAR_PRODUCTOS] @input_nombre = '', @input_precio_min = 0, @input_precio_max = 999999, @input_id_tipo = 1
go

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para actualizar los datos de un producto, toma como entrada el id a editar y los campos a actualizar
create proc [SP_ACTUALIZAR_PRODUCTOS]
		@input_id_producto int = null,
		@input_nombre varchar(50) = null,
		@input_precio money = null,
		@input_id_tipo int = null
as
begin
		UPDATE PRODUCTOS
		SET 
		nombre = isnull(@input_nombre, nombre),
		precio = isnull(@input_precio, precio),
		id_tipo = isnull(@input_id_tipo, id_tipo)
		WHERE id_producto = @input_id_producto
end
--exec [SP_ACTUALIZAR_PRODUCTOS] @input_id_producto = 1, @input_nombre = null, @input_precio = 17000, @input_id_tipo = 1 
go

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para eliminar productos, toma el id como parametro para eliminar dicho producto
create proc [SP_ELIMINAR_PRODUCTOS]
		@input_id_producto int = null
as
begin
		DELETE FROM PRODUCTOS
		WHERE id_producto = @input_id_producto
end
--exec [SP_ELIMINAR_PRODUCTOS] @input_id_producto = 0
go

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para consultar presupuestos ingresando un rango de fechas y posible dni del cliente
create proc [SP_CONSULTAR_PRESUPUESTOS]
		@input_dni_cliente varchar(50) = '',
        @input_fecha_min datetime = null,
		@input_fecha_max datetime = null,
		@input_total_min money = null,
		@input_total_max money = null
as
begin
        SELECT id_presupuesto 'ID', c.nombre + ' '+ apellido 'Cliente', c.dni 'DNI', fecha 'Fecha', total 'Total'
        FROM PRESUPUESTOS p join CLIENTES c on p.id_cliente=c.id_cliente
        WHERE (c.dni like '%' + @input_dni_cliente + '%')
		AND (p.fecha between isnull(@input_fecha_min, p.fecha) and isnull(@input_fecha_max, p.fecha))
        AND (p.total between isnull(@input_total_min, p.total) and isnull(@input_total_max, p.total))
        AND p.fecha_baja is null;
end
--exec [SP_CONSULTAR_PRESUPUESTOS] @input_dni_cliente = '', @input_fecha_min = '01/01/2000', @input_fecha_max = '01/01/3000', @input_total_min = 0, @input_total_max = 9999999
go

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para crear un nuevo presupuesto
create proc [SP_INSERTAR_PRESUPUESTOS]
		@input_id_cliente int = null,
		@input_total money = null,
		@output_id_presupuesto int OUTPUT
as
begin
		INSERT INTO PRESUPUESTOS(id_cliente, fecha, total, fecha_baja)
		VALUES (@input_id_cliente, GETDATE(), @input_total, null);
		SET @output_id_presupuesto = SCOPE_IDENTITY();
end
--exec [SP_INSERTAR_PRESUPUESTO] @input_id_cliente = 0, @input_total = 0, @output_id_presupuesto = output
go

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para modificar un presupuesto (Este no lo vamos a usar, los presupuestos no se deberian de modificar nunca)
create proc [SP_ACTUALIZAR_PRESUPUESTOS]
        @input_id_cliente int = null,
        @input_total money = null,
        @input_id_presupuesto int = null
as
begin
        UPDATE PRESUPUESTOS
		SET 
		id_cliente = isnull(@input_id_cliente, id_cliente),
		total = isnull(@input_total, total)
        WHERE id_presupuesto = @input_id_presupuesto;
end
--exec [SP_ACTUALIZAR_MAESTRO] @input_id_cliente = '', @input_total = 0, @input_id_presupuesto = 0
go

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para eliminar un presupuesto ingresando el id (cambia la fecha de baja)
create proc [SP_ELIMINAR_PRESUPUESTOS]
		@input_id_presupuesto int = null
as
begin
        UPDATE PRESUPUESTOS
		SET fecha_baja = GETDATE()
        WHERE id_presupuesto = @input_id_presupuesto;
end
--exec [SP_ELIMINAR_PRESUPUESTO] @input_id_presupuesto = 0
go

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para insertar detalle
create proc [SP_INSERTAR_DETALLES]
        @input_id_presupuesto int = null,
        @input_id_detalle int = null,
        @input_id_producto int = null,
        @input_cantidad int = null
as
begin
        INSERT INTO DETALLES(id_presupuesto,id_detalle, id_producto, cantidad)
		VALUES (@input_id_presupuesto, @input_id_detalle, @input_id_producto, @input_cantidad);
end
--exec [SP_INSERTAR_DETALLE] @input_id_presupuesto = 0, @input_id_detalle = 0, @input_id_producto = 0,@input_cantidad = 0
go

-----------------------------------------------------------------------------------------------------------------------------------------------











