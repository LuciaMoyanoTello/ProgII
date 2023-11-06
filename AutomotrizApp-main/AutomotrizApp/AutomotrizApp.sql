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



--Tabla CLIENTES (id_cliente, nombre, apellido, dni, telefono, usuario, pass)
INSERT INTO CLIENTES VALUES (1, 'Juan', 'Pérez', '12345678', '123456789', 'test', '123');
INSERT INTO CLIENTES VALUES (2, 'María', 'López', '87654321', '987654321', 'maria', '456');
INSERT INTO CLIENTES VALUES (3, 'Pedro', 'Gómez', '56781234', '654321987', 'pedro', '789');
INSERT INTO CLIENTES VALUES (4, 'Ana', 'García', '98761234', '123456789', 'ana', '987');
INSERT INTO CLIENTES VALUES (5, 'Luis', 'Rodríguez', '65437890', '876543210', 'luis', '765');
INSERT INTO CLIENTES VALUES (6, 'Laura', 'Torres', '12345690', '109876543', 'laura', '543');
INSERT INTO CLIENTES VALUES (7, 'Javier', 'Fernández', '89012345', '987654321', 'javier', '321');
INSERT INTO CLIENTES VALUES (8, 'Elena', 'Sánchez', '56789012', '123456789', 'elena', '234');
INSERT INTO CLIENTES VALUES (9, 'Miguel', 'Martínez', '12345678', '987654321', 'miguel', '123');
INSERT INTO CLIENTES VALUES (10, 'Sara', 'López', '87654321', '654321987', 'sara', '456');
INSERT INTO CLIENTES VALUES (11, 'Diego', 'Pérez', '56781234', '123456789', 'diego', '789');
INSERT INTO CLIENTES VALUES (12, 'Carmen', 'Gómez', '98761234', '987654321', 'carmen', '987');
INSERT INTO CLIENTES VALUES (13, 'Carlos', 'Torres', '65437890', '876543210', 'carlos', '765');
INSERT INTO CLIENTES VALUES (14, 'Marta', 'Fernández', '12345690', '109876543', 'marta', '543');
INSERT INTO CLIENTES VALUES (15, 'Isabel', 'Sánchez', '89012345', '987654321', 'isabel', '321');
INSERT INTO CLIENTES VALUES (16, 'Jorge', 'Martínez', '56789012', '123456789', 'jorge', '234');
INSERT INTO CLIENTES VALUES (17, 'Natalia', 'López', '12345678', '987654321', 'natalia', '123');
INSERT INTO CLIENTES VALUES (18, 'Roberto', 'Pérez', '87654321', '654321987', 'roberto', '456');
INSERT INTO CLIENTES VALUES (19, 'Patricia', 'Gómez', '56781234', '123456789', 'patricia', '789');
INSERT INTO CLIENTES VALUES (20, 'Alejandro', 'García', '98761234', '987654321', 'alejandro', '987');
INSERT INTO CLIENTES VALUES (21, 'Lucía', 'Torres', '65437890', '876543210', 'lucia', '765');
INSERT INTO CLIENTES VALUES (22, 'Víctor', 'Fernández', '12345690', '109876543', 'victor', '543');
INSERT INTO CLIENTES VALUES (23, 'Sofía', 'Sánchez', '89012345', '987654321', 'sofia', '321');
INSERT INTO CLIENTES VALUES (24, 'Raúl', 'Martínez', '56789012', '123456789', 'raul', '234');
INSERT INTO CLIENTES VALUES (25, 'Marina', 'López', '12345678', '987654321', 'marina', '123');
INSERT INTO CLIENTES VALUES (26, 'Antonio', 'Pérez', '87654321', '654321987', 'antonio', '456');
INSERT INTO CLIENTES VALUES (27, 'Teresa', 'Gómez', '56781234', '123456789', 'teresa', '789');
INSERT INTO CLIENTES VALUES (28, 'Andrés', 'García', '98761234', '987654321', 'andres', '987');
INSERT INTO CLIENTES VALUES (29, 'Cristina', 'Torres', '65437890', '876543210', 'cristina', '765');
INSERT INTO CLIENTES VALUES (30, 'Hugo', 'Fernández', '12345690', '109876543', 'hugo', '543');


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


--Tabla PRESUPUESTOS (id_presupuesto, id_cliente, fecha, total, fecha_baja)
INSERT INTO PRESUPUESTOS VALUES (1, 1, '05/10/2023', 49000, NULL);
INSERT INTO PRESUPUESTOS VALUES (2, 2, '02/12/2022', 15500, NULL);
INSERT INTO PRESUPUESTOS VALUES (3, 3, '02/11/2022', 31400, NULL);
INSERT INTO PRESUPUESTOS VALUES (4, 4, '02/05/2022', 94000, NULL);
INSERT INTO PRESUPUESTOS VALUES (5, 5, '02/06/2022', 74000, NULL);
INSERT INTO PRESUPUESTOS VALUES (6, 6, '04/11/2022', 310000, NULL);
INSERT INTO PRESUPUESTOS VALUES (7, 7, '10/01/2022', 216000, NULL);
INSERT INTO PRESUPUESTOS VALUES (8, 8, '08/09/2022', 95000, NULL);
INSERT INTO PRESUPUESTOS VALUES (9, 9, '02/04/2023', 77000, NULL);
INSERT INTO PRESUPUESTOS VALUES (10, 10, '22/04/2023', 212000, NULL);


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
go
--exec [SP_CONSULTAR_LOGIN] @input_usuario = '', @input_pass = ''

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para conocer el id del proximo presupuesto
create proc [SP_PROXIMO_ID_PRESUPUESTO]
		@next int OUTPUT
as
begin
        SET @next = (SELECT MAX(p.id_presupuesto)+1  FROM PRESUPUESTOS p);
end
go
--exec [SP_PROXIMO_ID] @next = output

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para consultar tipos sin parametros de entrada (sirve para los combo box)
create proc [SP_CONSULTAR_TIPOS]
as
begin

        SELECT t.id_tipo 'ID', t.tipo 'Tipo'
		FROM TIPOS t
end
go
--exec [SP_CONSULTAR_TIPOS]

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
go
--exec [SP_CONSULTAR_PRODUCTOS] @input_nombre = '', @input_precio_min = 0, @input_precio_max = 999999, @input_id_tipo = 1

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para consultar productos sin parametros de entrada (sirve para los combo box)
create proc [SP_INSERTAR_PRODUCTOS]
		@input_id_producto int,
		@input_nombre varchar(50),
		@input_precio money,
		@input_id_tipo int
as
begin
		INSERT INTO PRODUCTOS
		VALUES (@input_id_producto, @input_nombre, @input_precio, @input_id_tipo);
end
go
--exec [SP_CONSULTAR_PRODUCTOS] @input_nombre = '', @input_precio_min = 0, @input_precio_max = 999999, @input_id_tipo = 1

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para eliminar un presupuesto ingresando el id (cambia la fecha de baja)
create proc [SP_ELIMINAR_PRESUPUESTO]
		@input_id_presupuesto int = 0
as
begin
        UPDATE PRESUPUESTOS
		SET fecha_baja = GETDATE()
        WHERE id_presupuesto = @input_id_presupuesto;
end
go
--exec [SP_ELIMINAR_PRESUPUESTO] @input_id_presupuesto = 0

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
go
--exec [SP_CONSULTAR_PRESUPUESTOS] @input_dni_cliente = '', @input_fecha_min = '01/01/2000', @input_fecha_max = '01/01/3000', @input_total_min = 0, @input_total_max = 9999999

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para insertar maestro
create proc [SP_INSERTAR_MAESTRO]
        @input_id_cliente int = '',
        @input_total money = 0,
        @output_id_presupuesto int OUTPUT
as
begin
        INSERT INTO PRESUPUESTOS(fecha, id_cliente, total)
		VALUES (GETDATE(), @input_id_cliente, @input_total);
		SET @output_id_presupuesto = SCOPE_IDENTITY();
end
go
--exec [SP_INSERTAR_MAESTRO] @input_id_cliente = '', @input_total = 0, @output_id_presupuesto = output

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para modificar un presupuesto
create proc [SP_ACTUALIZAR_MAESTRO]
        @input_id_cliente int = 0,
        @input_total money = 0,
        @input_id_presupuesto int = 0
as
begin
        UPDATE PRESUPUESTOS SET id_cliente = @input_id_cliente, total = @input_total
        WHERE id_presupuesto = @input_id_presupuesto;

        DELETE DETALLES
        WHERE id_presupuesto = @input_id_presupuesto;
end
go
--exec [SP_ACTUALIZAR_MAESTRO] @input_id_cliente = '', @input_total = 0, @input_id_presupuesto = 0

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para insertar detalle
create proc [SP_INSERTAR_DETALLE]
        @input_id_presupuesto int,
        @input_id_detalle int,
        @input_id_producto int,
        @input_cantidad int
as
begin
        INSERT INTO DETALLES(id_presupuesto,id_detalle, id_producto, cantidad)
		VALUES (@input_id_presupuesto, @input_id_detalle, @input_id_producto, @input_cantidad);
end
go
--exec [SP_INSERTAR_DETALLE] @input_id_presupuesto = 0, @input_id_detalle = 0, @input_id_producto = 0,@input_cantidad = 0

-----------------------------------------------------------------------------------------------------------------------------------------------

go
--SP para consultar detalle presupuesto   (Para que sirve este?)
create proc [SP_CONSULTAR_DETALLES_PRESUPUESTO]
        @id_presupuesto int
as
begin
        SELECT t.*, t2.id_producto, t2.precio, t3.id_cliente, t3.fecha, t3.total
        FROM DETALLES t, PRODUCTOS t2, PRESUPUESTOS t3
        WHERE t.id_producto = t2.id_producto
        AND t.id_presupuesto = t3.id_presupuesto
        AND t.id_presupuesto = @id_presupuesto;
end
go













