

USE master;

GO

CREATE DATABASE Actividad14_DB;

GO

USE Actividad14_DB;

GO

CREATE TABLE Tickets (
    Id INT PRIMARY KEY IDENTITY,
	Nombre NVARCHAR(100) NOT NULL,
    CUIT NVARCHAR(11) NOT NULL,
    Telefono NVARCHAR(11) NOT NULL,
    Tarjeta NVARCHAR(11) NOT NULL,
    Fecha DATETIME NOT NULL,
    PrecioFinal NUMERIC(12,3),
    Destino NVARCHAR(50),
    Transporte NVARCHAR(50)
);

GO

USE master;