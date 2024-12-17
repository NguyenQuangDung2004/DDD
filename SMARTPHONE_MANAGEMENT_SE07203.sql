CREATE DATABASE SMARTPHONE_MANAGEMENT_SE07203
GO
USE [SMARTPHONE_MANAGEMENT_SE07203]
GO
CREATE TABLE Category (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(100) NOT NULL
);

CREATE TABLE Smartphone (
    SmartphoneID INT PRIMARY KEY IDENTITY(1,1),
    SmartphoneCode NVARCHAR(50) NOT NULL,
    SmartphoneName NVARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    InventoryQuantity INT NOT NULL,
    SmartphoneImage NVARCHAR(MAX),
    CategoryID INT,
    FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
);
CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeCode NVARCHAR(50) NOT NULL,
    EmployeeName NVARCHAR(100) NOT NULL,
    Position NVARCHAR(50),
    AuthorityLevel NVARCHAR(50),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
);
ALTER TABLE Employee ADD PasswordChanged BIT NOT NULL

INSERT INTO Employee 
VALUES ('Emp1', 'Nguyen Van A', 'Manager', 'Admin', 'admin1', '123', 1),
('Emp2', 'Nguyen Van B', 'Staff', 'Warehouse Manager', 'warehousemanager1', '123456', 1), 
('Emp3', 'Nguyen Van C', 'Staff', 'Sale', 'salel', '123456', 0);

INSERT INTO Employee VALUES('Emp4', 'Nguyen Thi E', 'Manager', 'Admin', 'admin2', '1234', 1);

SELECT * FROM Employee
UPDATE Employee SET	Password = '123' WHERE EmployeeID = 1
UPDATE Employee SET	Password = '23456' WHERE EmployeeID = 3

DELETE FROM Employee WHERE EmployeeCode = 'Emp2'
SELECT EmployeeCode AS Ma_NV FROM Employee

CREATE TABLE Customer (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    CustomerCode NVARCHAR(50) NOT NULL,
    CustomerName NVARCHAR(100) NOT NULL,
    PhoneNumber NVARCHAR(20),
    Address NVARCHAR(255)
);
SELECT * FROM Customer

CREATE TABLE Sale (
    SaleID INT PRIMARY KEY IDENTITY(1,1),
    SaleDate DATETIME NOT NULL,
    EmployeeID INT,
    CustomerID INT,
    TotalAmount DECIMAL(10, 2),
    Profit DECIMAL(10, 2),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);
CREATE TABLE SaleDetail (
    SaleDetailID INT PRIMARY KEY IDENTITY(1,1),
    SaleID INT,
    SmartphoneID INT,
    QuantitySold INT NOT NULL,
    FOREIGN KEY (SaleID) REFERENCES Sale(SaleID),
    FOREIGN KEY (SmartphoneID) REFERENCES Smartphone(SmartphoneID)
);

SELECT * FROM Import

CREATE TABLE Import (
    ImportID INT PRIMARY KEY IDENTITY(1,1),
    ImportDate DATETIME NOT NULL,
    EmployeeID INT,
    TotalQuantity INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);
CREATE TABLE ImportDetail (
    ImportDetailID INT PRIMARY KEY IDENTITY(1,1),
    ImportID INT,
    SmartphoneID INT,
    QuantityImported INT NOT NULL,
    ImportCost DECIMAL(10, 2),
    FOREIGN KEY (ImportID) REFERENCES Import(ImportID),
    FOREIGN KEY (SmartphoneID) REFERENCES Smartphone(SmartphoneID)
);

INSERT INTO Category (CategoryName) VALUES 
('Gaming'),
('5G'),
('Foldable'),
('Camera-Centric');

SELECT * FROM Category

INSERT INTO Smartphone (SmartphoneCode, SmartphoneName, Price, InventoryQuantity, SmartphoneImage, CategoryID) VALUES 
    ('SM001', 'Google Pixel 8', 999.99, 50, 'googlepixel8.jpg', 1),
    ('SM002', 'Xiaomi Redmi Note 12', 899.99, 30, 'redminote12.jpg', 2),
    ('SM003', 'Samsung Galaxy Z Fold 6', 799.99, 25, 'samsungzfold6.jpg', 3),
    ('SM004', 'OnePlus 11', 729.99, 20, 'oneplus11.jpg', 4),
	('SM005', 'Samsung Galaxy S24', 999.99, 50, 'samsunggalaxys24.jpg', 1),
    ('SM006', 'iPhone 15', 899.99, 30, 'iphone15.jpg', 2),
    ('SM007', 'Huawei Mate XT', 999.99, 25, 'huaweimatext.jpg', 3),
    ('SM008', 'iPhone 16', 729.99, 20, 'iphone16.png', 4);

SELECT * FROM Smartphone

UPDATE Smartphone SET SmartphoneName = 'Samsung Z Fold 6' WHERE SmartphoneID = 'SM003';

DELETE FROM Smartphone

SELECT 
    s.SaleDate,
    e.EmployeeName,
    c.CustomerName
FROM 
    Sale s
JOIN 
    Employee e ON s.EmployeeID = e.EmployeeID
JOIN 
    Customer c ON s.CustomerID = c.CustomerID
ORDER BY 
    s.SaleDate DESC;

INSERT INTO Customer (CustomerCode, CustomerName, PhoneNumber, Address)
VALUES ('004', 'Justin', '0987456321', 'Toronto');

SELECT * FROM Customer

-- Insert into Sale (make sure EmployeeID and CustomerID exist)
INSERT INTO Sale (SaleDate, EmployeeID, CustomerID, TotalAmount, Profit)
VALUES ('2024-12-15', 5, 003, 1200.00, 200.00);

-- Insert into SaleDetail (make sure SaleID and SmartphoneID exist)
INSERT INTO SaleDetail (SaleID, SmartphoneID, QuantitySold)
VALUES (3, 1, 2);  -- SaleID = 1, SmartphoneID = 1, 2 items sold

SELECT * FROM Sale

ALTER TABLE SaleDetail
ADD TotalAmount DECIMAL(10, 2),
    Profit DECIMAL(10, 2);

-- Check if EmployeeID = 1 exists in the Employee table
SELECT * FROM Employee WHERE EmployeeID = 5;

