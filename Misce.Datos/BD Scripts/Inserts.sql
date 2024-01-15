--INSERT INTO Tipo_Usuario (Nombre, Descripcion) VALUES
--('ADMIN', 'Administrador de Sistema'),
--('CAJERO', 'Encargado de realizar todo tipo de ventas.'),
--('ALMACENISTA', 'Encargado de Almacen')
--;

--INSERT INTO Categoria (Nombre, Descripcion) VALUES
--('LIMPIEZA', 'Productos de limpieza en general'),
--('REFRESCOS', 'Refrescos y bebidas mineralizadas en general'),
--('LACTEOS', 'Productos lacteos y derivados');

--INSERT INTO Estado (Nombre, Nombre_Corto) VALUES
--('DURANGO', 'DGO'),
--('COAHUILA', 'COAH');

--INSERT INTO Ciudad (Nombre, Id_Estado) VALUES
--('GOMEZ PALACIO', 1),
--('TORREON', 2);

--INSERT INTO Colonia (Nombre, Codigo_Postal, Id_Ciudad) VALUES
--('FIDEL VELAZQUEZ', '35025', 1),
--('COL. CENTRO', '27000', 2);

--INSERT INTO Sucursal (Nombre, Direccion, Id_Colonia, Id_Ciudad) VALUES
--('SUCURSAL MATRIZ', 'Calle 18 andador 23 #317', 1, 1),
--('SUCURSAL FALCON CENTRO', '', 2, 2);

INSERT INTO Usuario 
(
Nombre, Apellido_Paterno, Apellido_Materno, Nombre_Usuario, Clave, Correo, Telefono, Fecha_Nacimiento,
Id_TipoUsuario, Id_Sucursal
) 
VALUES
(
'David', 'De Lara', 'Garcia', 'Deivid', HASHBYTES('SHA2_256', '87654321'), 'deivid@gmail.com', '8711121143',
'1999-07-11', 2, 2 
)