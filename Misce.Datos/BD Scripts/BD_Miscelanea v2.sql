CREATE DATABASE MISCELANEA_v2

CREATE TABLE Tipo_Usuario(
	Id_TipoUsuario INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
	Descripcion VARCHAR(100) NOT NULL,
	Estado BIT DEFAULT (1)
);

CREATE TABLE Categoria(
	Id_Categoria INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
	Descripcion VARCHAR(100) NOT NULL,
	Estado BIT DEFAULT (1)
);

CREATE TABLE Estado(
	Id_Estado INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
	Nombre_Corto VARCHAR(5) NOT NULL,
	Estado BIT DEFAULT (1)
);

CREATE TABLE Ciudad(
	Id_Ciudad INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
	Id_Estado INT, --Llave foranea
	FOREIGN KEY (Id_Estado) REFERENCES Estado (Id_Estado),
	Estado BIT DEFAULT (1)
);

CREATE TABLE Colonia(
	Id_Colonia INT PRIMARY KEY IDENTITY  (1, 1) NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
	Codigo_Postal VARCHAR(10),
	Id_Ciudad INT, --Llave foranea
	FOREIGN KEY (Id_Ciudad) REFERENCES Ciudad (Id_Ciudad),
	Estado BIT DEFAULT (1)
);

CREATE TABLE Sucursal(
	Id_Sucursal INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
	Direccion VARCHAR(250) NOT NULL,
	Fecha_Alta DATE DEFAULT (GETDATE()) NOT NULL,
	Id_Ciudad INT, --Llave foranea
	Estado BIT DEFAULT(1),
	FOREIGN KEY (Id_Ciudad) REFERENCES Ciudad (Id_Ciudad)
);

CREATE TABLE Usuario(
	Id_Usuario INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Nombre VARCHAR(100) NOT NULL, 
	Apellido_Paterno VARCHAR(100) NOT NULL,
	Apellido_Materno VARCHAR(100) NOT NULL,
	Nombre_Usuario VARCHAR(250) NOT NULL,
	Clave VARBINARY(MAX) NOT NULL,
	Correo VARCHAR(100) NOT NULL,
	Telefono VARCHAR(100) NOT NULL,
	Fecha_Nacimiento DATE NOT NULL,
	Id_TipoUsuario INT NOT NULL, --Llave foranea
	Id_Sucursal INT NOT NULL, --Llave foranea
	Fecha_Alta DATE DEFAULT (GETDATE()) NOT NULL,
	Fecha_Baja DATE DEFAULT (''),
	Foto VARCHAR(100),
	Estado BIT DEFAULT (1),
	FOREIGN KEY (Id_TipoUsuario) REFERENCES Tipo_Usuario (Id_TipoUsuario)
);

CREATE TABLE Tipo_Pago(
	Id_TipoPago INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
	Estado BIT DEFAULT (1)
);

CREATE TABLE Producto(
	Id_Producto INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Nombre VARCHAR(100) NOT NULL, 
	Descripcion VARCHAR(100) NOT NULL,
	Id_Categoria INT NOT NULL,
	Stock INT NOT NULL,
	Precio DECIMAL (18, 2) NOT NULL,
	Fecha_Alta DATE DEFAULT (GETDATE()) NOT NULL,
	Imagen VARCHAR(100),
	Estado INT DEFAULT (1),
	FOREIGN KEY (Id_Categoria) REFERENCES Categoria (Id_Categoria)
);

CREATE TABLE Cliente(
	Id_Cliente INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Nombre VARCHAR(100) NOT NULL, 
	Apellido_Paterno VARCHAR(100) NOT NULL,
	Apellido_Materno VARCHAR(100) NOT NULL,
	Correo VARCHAR(100) NOT NULL,
	Telefono VARCHAR(100) NOT NULL,
	Fecha_Nacimiento DATETIME NOT NULL,
	Fecha_Alta DATE DEFAULT (GETDATE()) NOT NULL,
	Foto VARCHAR(100),
	Estado BIT DEFAULT (1),
);

CREATE TABLE Proveedor(
	Id_Proveedor INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Nombre VARCHAR(100) NOT NULL, 
	Fecha_Alta DATE DEFAULT (GETDATE()) NOT NULL,
	Estado BIT DEFAULT (1)
);

CREATE TABLE Venta(
	Id_Venta INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Id_Usuario INT NOT NULL,
	Id_Cliente INT,
	Id_TipoPago INT NOT NULL,
	Fecha_Venta DATE DEFAULT (GETDATE()) NOT NULL,
	Total DECIMAL(18, 2) NOT NULL,
	FOREIGN KEY (Id_Usuario) REFERENCES Usuario (Id_Usuario),
	FOREIGN KEY (Id_Cliente) REFERENCES Cliente (Id_Cliente),
	FOREIGN KEY (Id_TipoPago) REFERENCES Tipo_Pago (Id_TipoPago),
);

CREATE TABLE Venta_Detalle(
	Id_VentaDetalle INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Id_Venta INT NOT NULL,
	Id_Producto INT NOT NULL,
	Cantidad INT NOT NULL,
	Precio DECIMAL(18, 2) NOT NULL,
	Fecha_VentaDetalle DATE DEFAULT (GETDATE()) NOT NULL,
	FOREIGN KEY (Id_Venta) REFERENCES Venta (Id_Venta),
	FOREIGN KEY (Id_Producto) REFERENCES Producto (Id_Producto),
);


CREATE TABLE Estado_Credito(
	Id_EstadoCredito INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Estado VARCHAR(50) NOT NULL
);

-----------------------------------
CREATE TABLE Credito(
	Id_Credito INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Id_Cliente INT NOT NULL,
	Id_Venta INT NOT NULL,
	Fecha_Inicio DATE NOT NULL,
	Fecha_Limite DATE DEFAULT(GETDATE()) NOT NULL,
	Fecha_Pago DATE NOT NULL,
	Id_EstadoCredito INT NOT NULL
);
-----------------------------------

CREATE TABLE Ingreso(
	Id_Ingreso INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Id_Usuario INT NOT NULL,
	Id_TipoPago INT NOT NULL,
	Fecha_Ingreso DATE DEFAULT(GETDATE()) NOT NULL,
	Total DECIMAL (18, 2) NOT NULL,
	FOREIGN KEY (Id_Usuario) REFERENCES Usuario(Id_Usuario),
	FOREIGN KEY (Id_TipoPago) REFERENCES Tipo_Pago(Id_TipoPago)
);

CREATE TABLE Ingreso_Detalle(
	Id_IngresoDetalle INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	Id_Ingreso INT NOT NULL,
	Id_Producto INT NOT NULL,
	Cantidad INT NOT NULL,
	Precio DECIMAL (18, 2) NOT NULL,
	FOREIGN KEY (Id_Ingreso) REFERENCES Ingreso (Id_Ingreso),
	FOREIGN KEY (Id_Producto) REFERENCES Producto (Id_Producto)
);

--falta tablas para ingresos
