-- SCRIPT QUE CREA LA BASE DE DATOS DEL PUNTO DE VENTA. TODOS LOS DERECHOS RESERVADOS.

-- CREAR LA TABLA DE CLIENTES

create table clientes(
	
    id int primary key auto_increment,
    nombre varchar(50) not null, 
    telefono char(10) not null,
    edad int not null check (edad > 0),
    sexo enum('M', 'F') not null
);

-- CREAR LA TABLA DE PRODUCTOS

create table productos(
	id int primary key auto_increment,
    cod varchar(13),
    nombre varchar(40) not null,
    precio decimal(10, 2) not null check (precio > 0),
    iva decimal(4, 2) not null check (iva >= 0 && iva <= 100),
    stock int not null check (stock >= 0),
    marca varchar(30) not null,
    descripcion text,
    peso decimal(10, 3) not null check (peso > 0),
    img blob
);

-- CREAR TABLA DE EMPLEADOS

create table empleados(	
	id int primary key auto_increment,
    nombre varchar(80) not null,
    usuario varchar(50) not null,
    contrasena char(64) not null,
    correo varchar(50) not null,
    telefono char(10) not null
);

-- CREAR TABLA DE VENTAS

create table ventas(	
	id int primary key auto_increment,
    id_empleado int,
    id_cliente int,
    importe decimal(10, 2) not null check (importe > 0),
    subtotal decimal(10, 2) not null check (importe > 0),
    total decimal(10, 2) not null check(total > 0),
    fecha datetime default current_timestamp,
    metodo_pago enum('Efectivo','Tarjeta de Crédito','Tarjeta de Débito','Transferencia Bancaria','Otro') not null,
    descripcion varchar(255) default 'Cliente satisfecho',
    foreign key (id_empleado) references empleados(id) on delete set null on update cascade,
    foreign key (id_cliente) references cliente(id) on delete set null on update cascade
);

-- CREAR TABLA DETALLES DE VENTAS

create table detalles_venta(
	id int primary key auto_increment,
    id_venta int,
    id_producto int,
    cantidad_producto int not null check (cantidad_producto > 0),
    precio_unitario decimal(10, 2) not null check(precio_unitario > 0),
    foreign key (id_venta) references ventas(id) on delete set null on update cascade,
    foreign key (id_producto) references productos(id) on delete set null on update cascade
);

-- INSERTAR CLIENTES EN LA BASE DE DATOS (ID, NOMBRE, TELEFONO, EDAD, SEXO)

-- INSERTAR PRODUCTOS EN LA BASE DE DATOS (ID, COD, NOMBRE, PRECIO, IVA, STOCK, MARCA, DESCRIPCION, PESO, IMG)

-- INSERTAR EMPLEADOS EN LA BASE DE DATOS (ID, NOMBRE, USUARIO, CONTRASENA, CORREO, TELEFONO)

-- CREAR FUNCIÓN PARA INSERTAR VENTAS EN LA BASE DE DATOS

-- CREAR FUNCIÓN PARA INSERTAR DETALLES DE VENTAS EN LA BASE DE DATOS

-- CREAR FUNCIÓN PARA INSERTAR TANTO VENTAS COMO DETALLES DE VENTA

-- TODO
-- 1.- CREAR STORE PROCEDURE PARA INSERTAR, ELIMINAR Y ACTUALIZAR CLIENTES EN LUGAR DE USAR CONSULTAS NORMALES

-- STORE PROCEDURE PARA INSERTAR CLIENTES

delimiter //

create procedure insertar_clientes(
	in p_nombre varchar(50),
    in p_telefono char(10),
    in p_edad int,
    in p_sexo char(1)
)
begin
	insert into clientes (nombre, telefono, edad, sexo)
    values(p_nombre, p_telefono, p_edad, p_sexo);
end //

-- STORE PROCEDURE PARA ELIMINAR CLIENTES

create procedure eliminar_clientes(
	in p_id int
)
begin
	
    if exists (select 1 from clientes where id = p_id) then
		delete from clientes
		where id = p_id;
	else
		signal sqlstate '45000'
		set message_text = 'No se encontró un cliente con el id especificado.';
	end if;
end //

-- STORE PROCEDURE PARA ACTUALIZAR CLIENTES

create procedure actualizar_clientes(
	in p_id int,
	in p_nombre varchar(50),
    in p_telefono char(10),
    in p_edad int,
    in p_sexo char(1)
)
begin
	
    if exists (select 1 from clientes where id = p_id) then
		update clientes
        set nombre = p_nombre, telefono = p_telefono, edad = p_edad, sexo = p_sexo
        where id = p_id;
	else
		signal sqlstate '45000'
		set message_text = 'No se encontró un cliente con el id especificado.';
	end if;
end //
-- 2.- CREAR STORE PROCEDURE PARA INSERTAR UNA VENTA CON DATOS ALEATORIOS.RECIBE CANTIDAD DE VENTAS A INSERTAR Y SIMULAR UNA VENTA REAL. DE ESTE AÑO, FECHA ALEATORIA

-- 3.- EJECUTAR EL STORE PROCEDURA PARA HACER PRUEBAS, Y CUANDO FUNCIONE, INSERTAR 2000 A 5000 DATOS.

-- 4.- REPORTE DE VENTAS POR MES (FOLIO, FECHA, CLIENTE, EMPLEADO, TOTAL, CANTIDAD DE VENTAS HECHAS)

-- 5.- REPORTE DE VENTAS POR EMPLEADO (NOMBRE, TOTAL, CANTIDADVENTAS)

-- 6.- REPORTE COMPARATIVO DE VENTAS POR UN DETERMINADO PRODUCTO A LO LARGO DE CADA UNO DE LOS TRIMESTRES DEL AÑO

-- 7.- Crear un trigger de auditoría que revise los cambios en la tabla de ventas para insert, update y delete. El trigger debe registrar el cambio, quien y cuando lo realizó.

-- 8.- Crear un trigger de validación para la tabla productos. Debe validar lo siguiente:
	-- a. Los precios de los productos no deben ser negativos.
	-- b. No se deben permitir textos vacíos en el nombre de un producto, es decir, no permitir el
	-- nombre de un producto que tenga solamente espacios en blanco.
	-- c. Se permiten productos sin CÓDIGO DE BARRAS (es decir en null) pero cuando se inserta un
	-- código de barras, este siempre debe tener mínimo 8 y máximo 20 caracteres.
    
-- 9.- Crear una función que calcule la cantidad de productos (detalles de venta) que tiene una venta. Debe recibir como entrada el folio de la venta.


-- Entregables:
-- Script documentado de la base de datos (debe incluir todas las ventas).
-- Diccionario de datos.
-- Código fuente DOCUMENTADO en GIT HUB (java, csharp, php etc).