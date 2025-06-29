CREATE TABLE Product (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);
INSERT INTO Product (ProductID, ProductName, Category, Price) VALUES
(1, 'Laptop A', 'Electronics', 1200.00),
(2, 'Laptop B', 'Electronics', 1100.00),
(3, 'Laptop C', 'Electronics', 1100.00),
(4, 'TV A', 'Electronics', 1500.00),
(5, 'Phone A', 'Electronics', 800.00),

(6, 'Chair A', 'Furniture', 150.00),
(7, 'Chair B', 'Furniture', 120.00),
(8, 'Sofa A', 'Furniture', 600.00),
(9, 'Table A', 'Furniture', 600.00),
(10, 'Shelf A', 'Furniture', 250.00),

(11, 'Shirt A', 'Clothing', 40.00),
(12, 'Shirt B', 'Clothing', 50.00),
(13, 'Jacket A', 'Clothing', 100.00),
(14, 'Jacket B', 'Clothing', 100.00),
(15, 'Pants A', 'Clothing', 60.00);

SELECT *
FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Product
) AS Ranked
WHERE RowNum <= 3;


SELECT *
FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum
    FROM Product
) AS Ranked
WHERE RankNum <= 3;

SELECT *
FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankNum
    FROM Product
) AS Ranked
WHERE DenseRankNum <= 3;
