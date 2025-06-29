--qn1
-- get employees by department
CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT 
        EmployeeID,
        FirstName,
        LastName,
        Salary,
        JoinDate
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO



--  insert new employee
CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;
GO

-- Testing
EXEC sp_InsertEmployee
    @FirstName = 'Alex',
    @LastName = 'Brown',
    @DepartmentID = 3,
    @Salary = 6500.00,
    @JoinDate = '2022-06-01';
GO

-- Step 5: Test retrieving employees by department
EXEC sp_GetEmployeesByDepartment @DepartmentID = 3;
