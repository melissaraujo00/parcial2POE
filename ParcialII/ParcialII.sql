CREATE DATABASE SuperMarket;
GO

USE SuperMarket;
go

CREATE TABLE category(
idCategory INT IDENTITY(1,1) PRIMARY KEY,
nameCategory VARCHAR(50) NOT NULL
);

CREATE TABLE product(
idProduct INT IDENTITY(1,1) PRIMARY KEY,
nameProducto VARCHAR(50) NOT NULL,
stock INT NOT NULL,
price decimal(15,2) NOT NULL,
idCategory INT NULL
CONSTRAINT FK_Product_Category
FOREIGN KEY (idCategory) REFERENCES category(idCategory) ON DELETE SET NULL
)

SELECT p.idProduct N, p.nameProducto Nombre , p.stock, p.price Precio, c.nameCategory categoria FROM product p INNER JOIN category c ON p.idCategory = c.idCategory;