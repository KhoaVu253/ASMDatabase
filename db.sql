CREATE DATABASE ASM_SE07203;
GO

USE ASM_SE07203;
GO

CREATE TABLE [dbo]."Category"
(
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE [dbo]."Product"
(
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductCode NVARCHAR(50) NOT NULL,
    ProductName NVARCHAR(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
	InventoryQuantity INT NOT NULL,
    ProductImage NVARCHAR(MAX),
    CategoryID INT,
    FOREIGN KEY (CategoryID) REFERENCES [dbo]."Category"(CategoryID)
);
GO

CREATE TABLE [dbo]."Employee"
(
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeCode NVARCHAR(50) NOT NULL,
    EmployeeName NVARCHAR(100) NOT NULL,
    Position NVARCHAR(100),
	AuthorityLevel NVARCHAR(50) NOT NULL,
    Username NVARCHAR(50) NOT NULL UNIQUE,
	Password NVARCHAR(255) NOT NULL,
    PasswordChanged BIT DEFAULT 0
);
GO

CREATE TABLE [dbo]."Customer"
(
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    CustomerCode NVARCHAR(50) NOT NULL,
    CustomerName NVARCHAR(100) NOT NULL,
    PhoneNumber NVARCHAR(20),
    Address NVARCHAR(255)
);
GO

CREATE TABLE [dbo]."Orders"
(
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    OrderDate DATETIME NOT NULL,
    EmployeeID INT,
    CustomerID INT,
    FOREIGN KEY (EmployeeID) REFERENCES [dbo]."Employee"(EmployeeID),
    FOREIGN KEY (CustomerID) REFERENCES [dbo]."Customer"(CustomerID)
);
GO

CREATE TABLE [dbo]."OrderDetail"
(
    OrderDetailID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT,
    ProductID INT,
    QuantitySolid INT NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES [dbo]."Orders"(OrderID),
    FOREIGN KEY (ProductID) REFERENCES [dbo]."Product"(ProductID)
);
GO

CREATE TABLE [dbo]."Import"
(
    ImportID INT PRIMARY KEY IDENTITY(1,1),
    ImportDate DATETIME NOT NULL,
    EmployeeID INT,
    FOREIGN KEY (EmployeeID) REFERENCES [dbo]."Employee"(EmployeeID)
);
GO

CREATE TABLE [dbo]."ImportDetails"
(
    ImportDetailID INT PRIMARY KEY IDENTITY(1,1),
    ImportID INT,
    ProductID INT,
    QuantityImported INT NOT NULL,
    ImportCost DECIMAL(10,2),
    FOREIGN KEY (ImportID) REFERENCES [dbo]."Import"(ImportID),
    FOREIGN KEY (ProductID) REFERENCES [dbo]."Product"(ProductID)
);
GO

insert into [dbo]."Employee" VALUES ('Emp1', 'Nguyen Van A', 'Admin','Admin', 'admin1', '123456',1),
('Emp2', 'Nguyen Van B', 'Warehouse Manager','Warehouse Manager', 'warehousemanager1', '123456',1),
('Emp3', 'Nguyen Van C', 'Sale','Sale', 'sale1', '123456',1)