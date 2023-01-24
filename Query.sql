CREATE TABLE Products (
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(100) NOT NULL
);

CREATE TABLE Categories (
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(100) NOT NULL
);

CREATE TABLE Product_Category (
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[ProductId] INT NOT NULL FOREIGN KEY REFERENCES Products(Id),
	[CategoryId] INT NOT NULL FOREIGN KEY REFERENCES Categories(Id)
);


INSERT INTO [Products] VALUES ('Visual Studio'),
	('Ford Mustang'),
	('C# via CLR');

INSERT INTO [Categories] VALUES ('Book'),
	('Car'),
	('Computer programme');

INSERT INTO [Product_Category] VALUES (1, 3),
	(2, 2),
	(3, 1);



SELECT P.[Name], C.[Name]
FROM Products P
LEFT JOIN Product_Category PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;
