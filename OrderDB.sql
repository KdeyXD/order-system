-- =============================================
-- Drop database if it already exists
-- =============================================
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'OrderDB')
BEGIN
    ALTER DATABASE OrderDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE OrderDB;
END
GO

-- =============================================
-- Create Database
-- =============================================
CREATE DATABASE OrderDB;
GO

USE OrderDB;
GO

-- =============================================
-- Create Tables
-- =============================================

-- Users Table
CREATE TABLE tbUser(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(40) NOT NULL,
    Password VARCHAR(50) NOT NULL
);

-- Drinks Table
CREATE TABLE tbDrinks(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(40) NOT NULL,
    Price DECIMAL(5,2) NOT NULL
);

-- Order Table
CREATE TABLE tbOrder(
    Id INT PRIMARY KEY IDENTITY(1,1),
    OrderDate DATETIME NOT NULL DEFAULT GETDATE(),
    TotalAmount DECIMAL(10,2) NOT NULL
);

-- Order Items Table
CREATE TABLE tbOrderItem(
    Id INT PRIMARY KEY IDENTITY(1,1),
    OrderId INT NOT NULL,
    DrinkName VARCHAR(100) NOT NULL,
    UnitPrice DECIMAL(10,2) NOT NULL,
    Quantity INT NOT NULL,
    TotalPrice DECIMAL(10,2) NOT NULL,

    CONSTRAINT FK_OrderItem_Order
        FOREIGN KEY (OrderId) REFERENCES tbOrder(Id)
        ON DELETE CASCADE
);

-- Payment Table
CREATE TABLE tbPayment(
    Id INT PRIMARY KEY IDENTITY(1,1),
    OrderId INT NOT NULL,
    PaymentType VARCHAR(20) NOT NULL,
    Amount DECIMAL(10,2) NOT NULL,
    PaymentDate DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_Payment_Order
        FOREIGN KEY (OrderId) REFERENCES tbOrder(Id)
        ON DELETE CASCADE
);

-- =============================================
-- Insert Seed Data
-- =============================================

INSERT INTO tbUser (Username, Password) 
VALUES
    ('kdeyxd', 'kxdey123'),
    ('cashier', 'cashier123'),
    ('user', '12345');

INSERT INTO tbDrinks (Name, Price)
VALUES 
    ('Vanilla Latte', 4.75),
    ('Caramel Macchiato', 5.25),
    ('Cappuccino', 4.25),
    ('Cold Brew', 4.50),
    ('Matcha Latte', 5.50),
    ('Americano', 3.50),
    ('Mocha Frappe', 5.75),
    ('Chai Tea Latte', 4.95);

-- =============================================
-- Done
-- =============================================
PRINT 'OrderDB database created successfully.';