USE master
GO
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Shop')
BEGIN
	CREATE DATABASE [Shop]
END
GO
USE [Shop]
GO
IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
BEGIN
	CREATE TABLE [Products](
	[id] int PRIMARY KEY IDENTITY,
	[name] varchar(100) NULL
	)
END
GO
IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Categories]') AND type in (N'U'))
BEGIN
	CREATE TABLE [Categories](
	[id] int PRIMARY KEY IDENTITY,
	[name] varchar(100) NULL
	)
END
GO
IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[ProductsCategories]') AND type in (N'U'))
BEGIN
	CREATE TABLE [ProductsCategories](
	[id] int PRIMARY KEY IDENTITY,
	[ProductId] int FOREIGN KEY REFERENCES [Products]([id]) NOT NULL,
	[CategoriesId] int FOREIGN KEY REFERENCES [Categories]([id]) NOT NULL
	)
END
GO
INSERT INTO Products 
VALUES ('Свиной окорок'),
('Окунь'),
('Сметана'),
('Огурцы'),
('Сладкий йогурт'),
('Телевизор'),
('Телефон')
INSERT INTO Categories
VALUES ('Овощи'),
('Молочные продукты'),
('Мясо'),
('Рыба'),
('Сладости'),
('Фрукты')
INSERT INTO ProductsCategories
VALUES (1, 3),
(2, 4),
(3, 2),
(4, 1),
(5, 2),
(5, 5)
GO
SELECT p.name, c.name FROM Products p
LEFT JOIN ProductsCategories pc on pc.ProductId = p.id  
LEFT JOIN Categories c on c.id = pc.CategoriesId 