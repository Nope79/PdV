-- SCRIPT QUE CREA LA BASE DE DATOS DEL PUNTO DE VENTA. TODOS LOS DERECHOS RESERVADOS.

drop database PuntoDeVenta;
create database PuntoDeVenta;
use PuntoDeVenta;

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
    cod varchar(19),
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

INSERT INTO clientes (nombre, telefono, edad, sexo) VALUES
('Pedro Sánchez', '5559876543', 30, 'M'),
('Laura Fernández', '5558765432', 28, 'F'),
('Ricardo Gómez', '5557654321', 40, 'M'),
('Sofía Ruiz', '5556543210', 35, 'F'),
('José García', '5555432109', 50, 'M');

-- INSERTAR PRODUCTOS EN LA BASE DE DATOS (ID, COD, NOMBRE, PRECIO, IVA, STOCK, MARCA, DESCRIPCION, PESO, IMG)

INSERT INTO productos (cod, nombre, precio, iva, stock, marca, descripcion, peso) VALUES
('P1234567', 'Laptop Lenovo', 850.50, 21.00, 25, 'Lenovo', 'Laptop portátil de 15.6 pulgadas', 2.5),
('A4567890', 'Mouse Logitech', 25.99, 21.00, 150, 'Logitech', 'Mouse ergonómico inalámbrico', 0.1),
('B9876543', 'Teclado Mecánico', 55.75, 21.00, 60, 'Corsair', 'Teclado mecánico RGB', 1.2),
('C3214567', 'Smartphone Xiaomi', 299.99, 21.00, 100, 'Xiaomi', 'Smartphone con cámara de 48MP', 0.25),
('D2345678', 'Monitor Samsung', 220.45, 21.00, 30, 'Samsung', 'Monitor LED 24 pulgadas', 3.0),
('E9876543', 'Auriculares Sony', 75.25, 21.00, 40, 'Sony', 'Auriculares inalámbricos', 0.2),
('F1122334', 'Router TP-Link', 50.80, 21.00, 80, 'TP-Link', 'Router Wi-Fi 6', 0.5),
('G6655443', 'Disco Duro Seagate', 110.90, 21.00, 50, 'Seagate', 'Disco duro de 1TB', 0.8),
('H4455667', 'Cámara Nikon', 400.00, 21.00, 15, 'Nikon', 'Cámara DSLR de 24MP', 1.5),
('I9988776', 'Smartwatch Garmin', 199.99, 21.00, 60, 'Garmin', 'Reloj inteligente con GPS', 0.35),
('J1234987', 'Lámpara LED', 18.99, 21.00, 200, 'Philips', 'Lámpara de escritorio LED', 0.3),
('K8765432', 'Impresora HP', 120.45, 21.00, 45, 'HP', 'Impresora láser monocromática', 4.5),
('L5678901', 'Tablet Apple', 550.99, 21.00, 30, 'Apple', 'Tablet iPad Pro 11 pulgadas', 0.5),
('M4321098', 'Micrófono USB', 50.00, 21.00, 80, 'Blue', 'Micrófono USB para grabación', 0.3),
('N6543210', 'Cargador Rápido', 22.99, 21.00, 120, 'Anker', 'Cargador rápido USB-C', 0.1),
('O1234567', 'Proyector Epson', 300.00, 21.00, 20, 'Epson', 'Proyector Full HD 1080p', 3.0),
('P2345678', 'Silla Gamer', 150.75, 21.00, 15, 'DXRacer', 'Silla ergonómica para gamers', 12.5),
('Q3456789', 'Cámara Web Logitech', 49.99, 21.00, 200, 'Logitech', 'Cámara web Full HD 1080p', 0.1),
('R4567890', 'Teclado Logitech', 85.50, 21.00, 60, 'Logitech', 'Teclado mecánico RGB', 1.3),
('S5678901', 'Bocinas JBL', 129.99, 21.00, 100, 'JBL', 'Bocinas bluetooth portátiles', 1.0),
('T6789012', 'Almacenamiento SanDisk', 70.50, 21.00, 200, 'SanDisk', 'Tarjeta SD 128GB', 0.1),
('U7890123', 'Silla Oficina', 110.00, 21.00, 90, 'OfficeMax', 'Silla ergonómica para oficina', 7.5),
('V8901234', 'Disco SSD Kingston', 120.00, 21.00, 75, 'Kingston', 'Disco SSD 500GB', 0.4),
('W9012345', 'Gafas VR', 250.00, 21.00, 30, 'Oculus', 'Gafas de realidad virtual', 0.7),
('X1023456', 'Cámara de Seguridad', 80.00, 21.00, 100, 'Ring', 'Cámara de seguridad Wi-Fi', 0.3),
('Y2134567', 'Power Bank Anker', 40.99, 21.00, 150, 'Anker', 'Power Bank 10000mAh', 0.2),
('Z3245678', 'Botella Térmica', 25.00, 21.00, 250, 'Contigo', 'Botella de agua aislante térmica', 0.5),
('AA4356789', 'Mochila Laptop', 55.50, 21.00, 60, 'SwissGear', 'Mochila para laptop de 15.6 pulgadas', 1.0),
('BB5467890', 'Papel A4', 7.99, 21.00, 500, 'OfficeMax', 'Papel A4 500 hojas', 2.0),
('CC6578901', 'Lentes de Sol', 15.99, 21.00, 100, 'Ray-Ban', 'Lentes de sol con protección UV', 0.2),
('DD7689012', 'Lentes de Realidad Aumentada', 180.00, 21.00, 10, 'Microsoft', 'Lentes de realidad aumentada HoloLens', 0.5);

-- INSERTAR EMPLEADOS EN LA BASE DE DATOS (ID, NOMBRE, USUARIO, CONTRASENA, CORREO, TELEFONO)

INSERT INTO empleados (nombre, usuario, contrasena, correo, telefono) VALUES
('Juan Pérez', 'juanp', 'password123', 'juan@example.com', '5551234567'),
('María López', 'marial', 'password456', 'maria@example.com', '5552345678'),
('Carlos González', 'carlosg', 'password789', 'carlos@example.com', '5553456789'),
('Ana Ramírez', 'anar', 'password101', 'ana@example.com', '5554567890'),
('Luis Martínez', 'luism', 'password112', 'luis@example.com', '5555678901');

-- PRIMERO QUE NADA, HACEMOS UN TRIGGER PARA HACER QUE CON CADA VENTA, REDUZCA EL INVENTARIO DE LOS PRODUCTOS VENDIDOS, CONTROLANDO EL CASO EN EL QUE SE VENDA MÁS DE LO QUE SE TIENE.

delimiter //
 create trigger val_inv_prod
	before insert on detalles_venta
    for each row
    begin
    
		-- USAMOS VARIABLES PARA TRABAJAR DE FORMA MAS CLARA, LA PRIMERA ES PARA LA CANTIDAD DE PRODUCTOS QUE SE VENDEN, LA SEGUNDA ES LA CANTIDAD DE PRODUCTOS CON LA QUE SE CUENTA
		declare dif_inv int;
        declare cant int;
        set dif_inv = new.cantidad_producto;
        set cant = (select stock from productos where id = new.id_producto);
        
        -- SI NOS PIDEN MAS DE LO QUE TENEMOS, NO PODEMOS HACER LA VENTA.
		if cant - dif_inv < 0 then
			signal sqlstate '45000'
            set message_text = 'No puedes realizar la venta puesto que no disponemos de esa cantidad de artículos.';
		else	
			-- EN CASO DE TENER SUFICIENTE INVENTARIO, ACTUALIZAMOS LA TABLA DE PRODUCTOS PARA RESTARLE AL INVENTARIO LO QUE SE HAN LLEVADO CON LA VENTA
			update productos
            set stock = stock - dif_inv
            where productos.id = new.id_producto;
		
		end if;
    end //

delimiter ;

-- TODO
-- 1.- CREAR STORE PROCEDURE PARA INSERTAR, ELIMINAR Y ACTUALIZAR CLIENTES EN LUGAR DE USAR CONSULTAS NORMALES

-- STORE PROCEDURE PARA INSERTAR CLIENTES

delimiter //

create procedure insertar_clientes(
	-- PARAMETROS CON LOS QUE SE HARA LA INSERSION
	in p_nombre varchar(50),
    in p_telefono char(10),
    in p_edad int,
    in p_sexo char(1)
)
begin
	-- HACEMOS UNA INSERSION CON LOS PARAMETROS DEL STORE PROCEDURE
	insert into clientes (nombre, telefono, edad, sexo)
    values(p_nombre, p_telefono, p_edad, p_sexo);
end //

-- STORE PROCEDURE PARA ELIMINAR CLIENTES

create procedure eliminar_clientes(
	-- PARAMETRO PARA EL STORE PROCEDURE
	in p_id int
)
begin
	-- EN CASO DE QUE EXISTA EL ID DEL CLIENTE A BORRAR
    if exists (select 1 from clientes where id = p_id) then
		-- BORRAR CLIENTES
        delete from clientes
		where id = p_id;
	-- SI NO EXISTE, ARROJAMOS ERROR
	else
		-- MENSAJE DE ERROR
		signal sqlstate '45000'
		set message_text = 'No se encontró un cliente con el id especificado.';
	end if;
end //

-- STORE PROCEDURE PARA ACTUALIZAR CLIENTES

create procedure actualizar_clientes(
	-- PARAMETROS PARA EL PROCEDIMIENTO
	in p_id int,
	in p_nombre varchar(50),
    in p_telefono char(10),
    in p_edad int,
    in p_sexo char(1)
)
begin
	
    -- REALIZAMOS UNA VERIFICACION DE QUE EXISTE EL ID QUE NOS PASAN
    if exists (select 1 from clientes where id = p_id) then
		-- ACTUALIZAR CLIENTES
		update clientes
        set nombre = p_nombre, telefono = p_telefono, edad = p_edad, sexo = p_sexo
        where id = p_id;
	-- SI NO EXISTE, LANZAMOS ERROR
	else
		-- MENSAJE DE ERROR
		signal sqlstate '45000'
		set message_text = 'No se encontró un cliente con el id especificado.';
	end if;
end //

-- 2.- CREAR STORE PROCEDURE PARA INSERTAR UNA VENTA CON DATOS ALEATORIOS. RECIBE CANTIDAD DE VENTAS A INSERTAR Y SIMULA UNA VENTA REAL. DE ESTE AÑO, FECHA ALEATORIA

create procedure ventas_random(
	-- NUMERO DE VENTAS ALEATORIAS QUE SE INSERTARAN 
	in n int
)
begin
	
    -- DECLARACION DE VARIABLES QUE SE ESTARAN OCUPANDO CONSTANTEMENTE
    
    -- VARIABLES PARA CONTROLAR EL BUCLE WHILE
    declare i int default 1;
    declare j int;
    
    -- VARIABLES PARA OBTENER ID'S DE LAS TABLAS, LOS PRIMEROS 3 ALEATORIOS, EL ULTIMO, DE LA ULTIMA VENTA SEGUN EL AUTO_INCREMENT
    declare r_id_cliente int;
    declare r_id_empleado int;
    declare r_id_producto int;
    declare id_v int;
    
    -- VARIABLES QUE SE RELACIONAN LA TABLA VENTA Y DETALLES DE VENTA
    declare cantdet int;				-- PRODUCTOS UNICOS POR VENTA
    declare subtot_v decimal(10, 2);	-- SUBTOTAL DE LA VENTA (SUMA DE LOS SUBTOTALES POR PRODUCTO, QUE ES LA CANTIDAD DE PRODUCTOS POR SU PRECIO UNITARIO)
    declare tot_v decimal(10, 2); 		-- APLICAR IMPUESTOS A LOS PRODUCTOS
    declare cantidad int;				-- CANTIDAD DEL MISMO PRODUCTO VENDIDO, VALOR ALEATORIO
    declare preciox decimal(10, 2);		-- PRECIO DEL J-ESIMO PRODUCTO
    declare precio_base decimal(10, 2);	-- VARIABLE PA' AHORRAR 3 BITS EN MEMORIA Y EN CALCULOS (DOS VARIABLES OCUPABAN LA MISMA CONSULTA, PARA ESO ESTA DICHA VARIABLE)
    declare met_pago varchar(30);		-- GENERAR UN METODO DE PAGO ALEATORIO
    
    declare repetido int;				-- USADA PARA EVITAR REGISTROS CON EL MISMO ID DE VENTA, DE PRODUCTO Y DE DETALLES DE VENTA EN DETALLES DE VENTA Y EVITAR INCONCISTENCIAS
    
    -- LOGICA
    while i <= n do
        
        -- GENERAMOS ID´S ALEATORIOS DE SUS RESPECTIVAS TABLAS AL ORDENARLO DE FORMA ALEATORIA Y TOMANDO EL PRIMER RENGLON DE LA CONSULTA
        set r_id_cliente = (select id from clientes order by rand() limit 1);
        set r_id_empleado = (select id from empleados order by rand() limit 1);
        
        -- 	TRUNCAMOS EL VALOR GENERADO DE MULTIPLICAR UN NUMERO ALEATORIO ENTRE 0 Y 1
        --  POR EL RANGO MAXIMO MENOS EL RANGO MINIMO MAS 1, Y AL RESULTADO LE SUMAMOS EL RANGO MINIMO
        set cantdet = floor(rand() * (15 - 1 + 1)) + 1;
        
        -- PUESTO QUE NO TENEMOS VALORES EN VENTAS AUN, TENEMOS QUE HACER ESTO DE FORMA MANUAL, POR ASI DECIRLO, PARA EVITAR QUE MET_PAGO SEA NULL
        set met_pago = (select 
							case floor(rand() * 5)
								when 0 then 'Efectivo'
                                when 1 then 'Tarjeta de Crédito'
                                when 2 then 'Tarjeta de Débito'
                                when 3 then 'Transferencia Bancaria'
                                when 4 then 'Otro'
							end);
                            
        set j = 1;
        
        -- CONTAMOS LOS RENGLONES DE LAS VENTAS, Y PREPARAMOS EL ID_V PARA QUE GUARDE LA PRÓXIMA VENTA CON EL ID ADECUADO
        set id_v =  (
					select 
						case
						when (select count(*) from ventas) = 0 then 1
						else (select id from ventas order by id desc limit 1)
						end
		);
        
        -- PREPARAMOS LAS SUMATORIAS DE LA I-ESIMA VENTA
        set subtot_v = 0;
        set tot_v = 0;
        
        -- COMO PRIMERO VAMOS A MODIFICAR UNA TABLA QUE DEPENDE DE OTRA, APAGAMOS EL CHECK DE LOS FOREIGN KEYS PARA PODER HACER LA INSERCION
        set foreign_key_checks = 0;
        while j <= cantdet do
        
			-- LO MISMO QUE CON CLIENTE Y EMPLEADO, UN PRODUCTO ALEATORIO
			set r_id_producto = (select id from productos order by rand() limit 1);
            
            -- CONTAMOS CUANTOS RENGLONES HAY DUPLICADOS (0 O 1)
            set repetido = (select count(*) from detalles_venta where id_venta = id_v and id_producto = r_id_producto);
            
            -- SI NO HAY DUPLICADOS, HACEMOS EL PROCESO DE INSERCION Y TODO LO QUE INVOLUCRA, SOLO SI NO HAY DUPLICADOS, REPETIDO = 0
			if repetido = 0 then
            
				-- GENERAMOS UN VALOR ALEATORIO PARA LA CANTIDAD, ENTRE 1 Y 10, USANDO LA FORMULA ANTES VISTA
				set cantidad = floor(rand() * (10 - 1 + 1)) + 1;
                
                -- HACEMOS USO DE UNA VARIABLE PARA SIMPLIFICAR EL CODIGO QUE SE USARA EN LA INSERSION.
				set preciox = (select precio from productos where id = r_id_producto);
            
				-- PRIMERO HACEMOS LA INSERSION EN DETALLES DE VENTA PARA TRABAJAR DE FORMA MAS DIRECTA
				insert into detalles_venta(id_venta, id_producto, cantidad_producto, precio_unitario) values(id_v, r_id_producto, cantidad, preciox);
            
				-- IREMOS CALCULANDO LOS TOTALES PARA LA TABLA DE VENTAS
				set precio_base = cantidad * (select precio from productos where id = r_id_producto);
				set subtot_v = subtot_v + precio_base; 
				set tot_v = tot_v + precio_base + (precio_base * (select iva from productos where id = r_id_producto) / 100);
            
				-- AUMENTAMOS J
				set j = j + 1;
            end if;
        end while;
        
        -- NO OLVIDAR ENCENDER EL CHECKEO DE LAS FOREIGN KEYS PARA EVITAR POSIBLES INCONSISTENCIAS ACCIDENTALES SIN SIQUIERA ENTERARNOS
        set foreign_key_checks = 1;
        
        -- INSERCION DE LA VENTA
        insert into ventas(id_empleado, id_cliente, importe, subtotal, total, fecha, metodo_pago) 
        values(r_id_empleado, r_id_cliente, subtot_v, subtot_v, tot_v, (select date_add('2024-01-01', interval floor(rand() * 366) day)), met_pago);
        
        -- AUMENTAMOS I
        set i = i + 1;
    end while;
    
end //

 delimiter ;

-- 3.- EJECUTAR EL STORE PROCEDURA PARA HACER PRUEBAS, Y CUANDO FUNCIONE, INSERTAR 2000 A 5000 DATOS.

-- DIVIDIMOS POR LOTES LAS LLAMADAS PARA EVITAR SOBRECARGA EN EL SERVIDOR DE MYSQL
call ventas_random(500);
call ventas_random(500);
call ventas_random(500);
call ventas_random(500);
call ventas_random(500);

-- 4.- REPORTE DE VENTAS POR MES (FOLIO, FECHA, CLIENTE, EMPLEADO, TOTAL, CANTIDAD DE VENTAS HECHAS)
create view reporte_ventas_mes as
	select v.id as Folio, v.fecha, c.nombre as cliente, e.nombre as empleado, v.total, count(*) as cantidad_ventas
	from ventas v
	join clientes c
	on v.id_cliente = c.id
	join empleados e
	on v.id_empleado = e.id
	join detalles_venta dv
	on v.id = dv.id_venta
	group by v.id;
    -- PARA CONSEGUIR LOS DATOS, NECESITAMOS HACER UNIONES ENTRE TABLAS Y AGRUPAR TODO POR EL ID DE LA VENTA

-- 5.- REPORTE DE VENTAS POR EMPLEADO (NOMBRE, TOTAL, CANTIDADVENTAS)
create view ventas_por_empleado as
	select e.nombre, sum(v.total) as total, count(*)
    from empleados e
    join ventas v
    on e.id = v.id_empleado
    group by e.nombre;
    -- UNION ENTRE EMPLEADOS Y VENTAS, AGRUPAMOS TODO POR EL NOMBRE DEL EMPLEADO

-- 6.- REPORTE COMPARATIVO DE VENTAS POR UN DETERMINADO PRODUCTO A LO LARGO DE CADA UNO DE LOS TRIMESTRES DEL AÑO

create view ventas_por_trimestre as
	select p.nombre as Producto,
    coalesce(sum(
				case
					when month(v.fecha) between 1 and 3 then dv.cantidad_producto
                    else 0
				end), 0) as Trim_1,
	coalesce(sum(
				case
					when month(v.fecha) between 4 and 6 then dv.cantidad_producto
                    else 0
				end), 0) as Trim_2,
	coalesce(sum(
				case
					when month(v.fecha) between 7 and 9 then dv.cantidad_producto
                    else 0
				end), 0) as Trim_3,
	coalesce(sum(
				case
					when month(v.fecha) between 10 and 12 then dv.cantidad_producto
                    else 0
				end), 0) as Trim_4
	from productos p
    left join detalles_venta dv
    on p.id = dv.id_producto
    left join 
    ventas v 
    on dv.id_venta = v.id
    group by p.nombre;
	-- ES IMPORTANTE ACLARAR VARIOS PUNTOS:
    -- LOS TRIMESTRES DIVIDEN AL AÑO Y SE ENCARGAN DE HACER LA SUMA DE LA TABLA DETALLES_VENTA, ESTO SE HACE POR EL MES DE LA FECHA, VIENDO A CUAL DE LOS TRIMESTRES PERTENECE.
    -- SE USA EL COALSESCE EN CASO DE QUE UN PRODUCTO NO HAYA SIDO VENDIDO NINGUNA VEZ EN EL AÑO, PARA MOSTRAR TODOS SUS RESULTADOS EN 0 Y QUE APAREZCA SU RENGLON.
    -- SE USA UN LEFT JOIN PARA QUE SE TOMEN EN CUANTA LOS RENGLONES DE LOS PRODUCTOS QUE NO TIENEN CONEXION CON NINGUN RENGLON EN LA TABLA DETALLES_VENTA.
    -- TODO SE AGRUPA POR EL NOMBRE DEL PRODUCTO.

-- 7.- CREAR UN TRIGGER DE AUDITORIA PARA REVISAR LOS CAMBIOS EN LA TABLA VENTAS AL INSERTAR, ACTUALIZAR Y BORRAR (CAMBIO, EMPLEADO, FECHA)

-- CREAMOS LA TABLA PARA GUARDAR LA INFORMACION DE LAS AUDITORIAS
create table auditoria_ventas(
	id int primary key auto_increment,
    accion enum('INSERT', 'UPDATE', 'DELETE') not null,
    usuario varchar(50),
    fecha timestamp default current_timestamp,
    datos_anteriores text,
    datos_nuevos text
);

delimiter //

-- INSERTAR, COMO TRABAJAMOS CON UN REGISTRO NUEVO, USAMOS NEW, Y SE VERIFICA DESPUES DE LA INSERSION

create trigger insert_venta
after insert on ventas
for each row
begin 
	insert into auditoria_ventas(accion, usuario, datos_nuevos)
    values('INSERT', 
    (select nombre from empleados where id = new.id_empleado), 
	concat("ID: ", new.id, ", ID_empleado: ", new.id_empleado, ", ID_cliente: ", new.id_cliente, ", Importe: ", new.importe, ", Subtotal: ", new.subtotal,
			", Total: ", new.total, ", Fecha: ", new.fecha, ", Met_pago: ", new.metodo_pago, ", Descripción: ", new.descripcion));
end //

-- BORRAR, COMO TRABAJAMOS CON UN REGISTRO VIEJO, USAMOS OLD, Y SE VERIFICA DESPUES DE LA ELIMINACION

create trigger borrar_venta
after delete on ventas
for each row
begin 
	insert into auditoria_ventas(accion, usuario, datos_anteriores)
    values('DELETE', 
    (select nombre from empleados where id = old.id_empleado), 
	concat("ID: ", old.id, ", ID_empleado: ", old.id_empleado, ", ID_cliente: ", old.id_cliente, ", Importe: ", old.importe, ", Subtotal: ", old.subtotal,
			", Total: ", old.total, ", Fecha: ", old.fecha, ", Met_pago: ", old.metodo_pago, ", Descripción: ", old.descripcion));
end //

-- ACTUALIZAR, COMO TRABAJAMOS CON UN REGISTRO NUEVO PERO NECESITAMOS VER EL ANTERIOR, USAMOS TANTO NEW COMO OLD, Y SE VERIFICA DESPUES DE LA ACTUALIZACION

create trigger actualizar_venta
after update on ventas
for each row
begin 
	insert into auditoria_ventas(accion, usuario, datos_anteriores, datos_nuevos)
    values('UPDATE', 
    (select nombre from empleados where id = new.id_empleado), 
    concat("ID: ", old.id, ", ID_empleado: ", old.id_empleado, ", ID_cliente: ", old.id_cliente, ", Importe: ", old.importe, ", Subtotal: ", old.subtotal,
			", Total: ", old.total, ", Fecha: ", old.fecha, ", Met_pago: ", old.metodo_pago, ", Descripción: ", old.descripcion),
	concat("ID: ", new.id, ", ID_empleado: ", new.id_empleado, ", ID_cliente: ", new.id_cliente, ", Importe: ", new.importe, ", Subtotal: ", new.subtotal,
			", Total: ", new.total, ", Fecha: ", new.fecha, ", Met_pago: ", new.metodo_pago, ", Descripción: ", new.descripcion));
end //

-- 8.- CREAR UN TRIGGER DE VALIDACION PARA LA TABLA PRODUCTOS QUE VALIDE:
	-- A. LOS PRECIOS NO PUEDEN SER NEGATIVOS
    -- B. NO SE PERMITEN NOMBRES CON SOLO ESPACIOS COMO TEXTO.
    -- C. EL CODIGO PUEDE SER NULL, O TENER ENTRE 8 Y 13 CARACTERES.
    
    create trigger val_insersion_producto
	before insert on productos
    for each row
    begin
    
		-- PRIMERA VALIDACION
		if new.precio <= 0 then
			signal sqlstate '45000'
            set message_text = 'El producto tiene que tener un precio mayor a 0.';
		
        -- SEGUNDA VALIDACION
		elseif length(trim(new.nombre)) = 0 then
			signal sqlstate '45000'
            set message_text = 'El nombre del producto no acepta solo espacios.';
		
        -- TERCERA VALIDAION
        elseif new.cod is not null and (length(new.cod) > 13 or length(new.cod) < 8) then
			signal sqlstate '45000'
            set message_text = 'El código debe tener entre 8 y 13 caracteres.';
		end if;
        
        -- ESTAREMOS TRABAJANDO CON UN BEFORE, PARA VALIDAR LA INSERCION PRIMERO, Y CON NEW PORQUE SE VALIDA LA FILA NUEVA ANTES DE INSERTARLA EN LA TABLA
    end //
    
-- 9.- CALCULAR LA CANTIDAD DE PRODUCTOS QUE SE VENDEN POR VENTA, RECIBIENDO EL FOLIO (ID DE LA VENTA)

-- CUENTA SOLAMENTE LOS DETALLES UNICOS
create function detalles_productos_dv(id int)
returns int
deterministic
begin
	declare detalles int;
    
    set detalles = (select count(*) from detalles_venta
					where id_venta = id);
	return detalles;
end //

-- CUENTA EL TOTAL DE PRODUCTOS, INCLUYENDO LOS DUPLICADOS
create function cantidad_total_productos_dv(id int)
returns int
deterministic
begin
	declare detalles int;
    
    set detalles = (select sum(cantidad_producto) from detalles_venta
					where id_venta = id);
	return detalles;
end //

delimiter ;

-- Entregables:
-- Script documentado de la base de datos (debe incluir todas las ventas).
-- Diccionario de datos.
-- Código fuente DOCUMENTADO en GIT HUB (java, csharp, php etc).

