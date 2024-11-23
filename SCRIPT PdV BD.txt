drop database pruebas;
create database pruebas;
use pruebas;
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
    subtotal decimal(10, 2) not null check (subtotal > 0),
    total decimal(10, 2) not null check(total > 0),
    fecha timestamp default current_timestamp,
    metodo_pago enum('Efectivo','Tarjeta de Crédito','Tarjeta de Débito','Transferencia Bancaria','Otro') not null,
    descripcion varchar(255) default 'Cliente satisfecho',
    foreign key (id_empleado) references empleados(id) on delete set null on update cascade,
    foreign key (id_cliente) references clientes(id) on delete set null on update cascade
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

create procedure ventas_random(
	in n int
)
begin
	
    declare i int default 1;
    declare j int;
    declare r_id_cliente int;
    declare r_id_empleado int;
    declare r_id_producto int;
    declare cantdet int;
    declare id_v int;
    declare subtot_v decimal(10, 2);
    declare tot_v decimal(10, 2);
    declare cantidad int;
    declare preciox decimal(10, 2);
    declare precio_base decimal(10, 2);
    declare met_pago varchar(30);
    
    while i <= n do
		-- logica
        
        set r_id_cliente = (select id from clientes order by rand() limit 1);
        set r_id_empleado = (select id from empleados order by rand() limit 1);
        
        -- 	TRUNCAMOS EL VALOR GENERADO DE MULTIPLICAR UN NUMERO ALEATORIO ENTRE 0 Y 1
        --  POR EL RANGO MAXIMO MENOS EL RANGO MINIMO MAS 1, Y AL RESULTADO LE SUMAMOS EL RANGO MINIMO
        set cantdet = floor(rand() * (15 - 1 + 1)) + 1;
        set met_pago = (select 
							case floor(rand() * 5)
								when 0 then 'Efectivo'
                                when 1 then 'Tarjeta de Crédito'
                                when 2 then 'Tarjeta de Débito'
                                when 3 then 'Transferencia Bancaria'
                                when 4 then 'Otro'
							end);
                            
        set j = 1;
        set id_v = (
					select 
						case
						when (select count(*) from ventas) = 0 then 1
						else (select id from ventas order by id desc limit 1)
						end
		);
        
        set subtot_v = 0;
        set tot_v = 0;
        
        -- COMO PRIMERO VAMOS A MODIFICAR UNA TABLA QUE DEPENDE DE OTRA, APAGAMOS EL CHECK DE LOS FOREIGN KEYS PARA PODER HACER LA INSERCION
        set foreign_key_checks = 0;
        while j <= cantdet do
			set r_id_producto = (select id from productos order by rand() limit 1);
            set cantidad = floor(rand() * (10 - 1 + 1)) + 1;
            set preciox = (select precio from productos where id = r_id_producto);
            
            insert into detalles_venta(id_venta, id_producto, cantidad_producto, precio_unitario) values(id_v, r_id_producto, cantidad, preciox);
            
            set precio_base = cantidad * (select precio from productos where id = r_id_producto);
            set subtot_v = subtot_v + precio_base; 
            set tot_v = tot_v + precio_base + (precio_base * (select iva from productos where id = r_id_producto) / 100);
            
            set j = j + 1;
        end while;
        
        -- NO OLVIDAR ENCENDER EL CHECKEO DE LAS FOREIGN KEYS PARA EVITAR POSIBLES INCONSISTENCIAS ACCIDENTALES SIN SIQUIERA ENTERARNOS
        set foreign_key_checks = 1;
        
        -- INSERCION DE LA VENTA
        insert into ventas(id_empleado, id_cliente, importe, subtotal, total, fecha, metodo_pago) 
        values(r_id_empleado, r_id_cliente, subtot_v, subtot_v, tot_v, 
        (select date_add('2024-01-01', interval floor(rand() * 366) day)),
        met_pago);
        
        set i = i + 1;
    end while;
    
end //

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
 delimiter ;

-- Error Code: 1093. You can't specify target table 'ventas' for update in FROM clause
-- Error Code: 1093. You can't specify target table 'ventas' for update in FROM clause

INSERT INTO productos (cod, nombre, precio, iva, stock, marca, descripcion, peso, img) VALUES
('P001', 'Laptop Acer', 800.00, 21.00, 50, 'Acer', 'Laptop de alto rendimiento', 2.5, null),
('P002', 'Smartphone Samsung', 600.00, 21.00, 100, 'Samsung', 'Smartphone con cámara de alta calidad', 0.3, null),
('P003', 'Teclado Logitech', 45.00, 21.00, 200, 'Logitech', 'Teclado mecánico para gamers', 1.2, null),
('P004', 'Auriculares Sony', 150.00, 21.00, 75, 'Sony', 'Auriculares con cancelación de ruido', 0.5, null),
('P005', 'Reloj Garmin', 250.00, 21.00, 30, 'Garmin', 'Reloj inteligente con GPS', 0.2, null);

INSERT INTO empleados (nombre, usuario, contrasena, correo, telefono) VALUES
('Juan Pérez', 'juanp', 'password123', 'juan@example.com', '5551234567'),
('María López', 'marial', 'password456', 'maria@example.com', '5552345678'),
('Carlos González', 'carlosg', 'password789', 'carlos@example.com', '5553456789'),
('Ana Ramírez', 'anar', 'password101', 'ana@example.com', '5554567890'),
('Luis Martínez', 'luism', 'password112', 'luis@example.com', '5555678901');

INSERT INTO clientes (nombre, telefono, edad, sexo) VALUES
('Pedro Sánchez', '5559876543', 30, 'M'),
('Laura Fernández', '5558765432', 28, 'F'),
('Ricardo Gómez', '5557654321', 40, 'M'),
('Sofía Ruiz', '5556543210', 35, 'F'),
('José García', '5555432109', 50, 'M');

call ventas_random(10);

select * from ventas;
select * from detalles_venta;