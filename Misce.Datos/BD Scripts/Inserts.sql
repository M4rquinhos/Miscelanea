INSERT INTO Tipo_Usuario (Nombre, Descripcion) VALUES
('ADMIN', 'Administrador de Sistema'),
('CAJERO', Encargado de realizar todo tipo de ventas.'),
('ALMACENISTA', 'Encargado de Almacen');

INSERT INTO Categoria (Nombre, Descripcion) VALUES
('LIMPIEZA', 'Productos de limpieza en general'),
('REFRESCOS', 'Refrescos y bebidas mineralizadas en general'),
('LACTEOS', 'Productos lacteos y derivados');

INSERT INTO Estado (Nombre, Nombre_Corto) VALUES
('DURANGO', 'DGO'),
('COAHUILA', 'COAH');

INSERT INTO Ciudad (Nombre, Id_Estado) VALUES
('GOMEZ PALACIO', 1),
('TORREON', 2);

INSERT INTO Colonia (Nombre, Codigo_Postal, Id_Ciudad) VALUES
('FIDEL VELAZQUEZ', '35025', 1),
('COL. CENTRO', '27000', 2);

INSERT INTO Sucursal (Nombre, Direccion, Id_Ciudad, Id_Colonia) VALUES
('SUCURSAL MATRIZ', 'Calle 18 andador 23 #317', 1, 1),
('SUCURSAL FALCON CENTRO', '', 2, 2);