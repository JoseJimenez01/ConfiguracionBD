CREATE DATABASE InventarioConfiguracion

USE InventarioConfiguracion

CREATE TABLE dbo.Articulo
(
	id INT IDENTITY(1, 1) PRIMARY KEY
	, Nombre VARCHAR(128) NOT NULL
	, Precio MONEY NOT NULL
);

CREATE TABLE dbo.EventLog
(
	id INT PRIMARY KEY NOT NULL
	, LogDescription VARCHAR(2000) NOT NULL
	, PostTime DATETIME NOT NULL
);

INSERT INTO dbo.Articulo(Nombre, Precio)
VALUES('Martillo', 2500.00)
INSERT INTO dbo.Articulo(Nombre, Precio)
VALUES('Escoba', 1500.00)
INSERT INTO dbo.Articulo(Nombre, Precio)
VALUES('Palopiso', 500.00)
INSERT INTO dbo.Articulo(Nombre, Precio)
VALUES('Clavos', 500.00)
INSERT INTO dbo.Articulo(Nombre, Precio)
VALUES('Guantes', 4000.00)
INSERT INTO dbo.Articulo(Nombre, Precio)
VALUES('Pistola de clavos', 1750.00)
INSERT INTO dbo.Articulo(Nombre, Precio)
VALUES('Cegueta', 5000.00)
INSERT INTO dbo.Articulo(Nombre, Precio)
VALUES('Soldadura', 2000.00)


