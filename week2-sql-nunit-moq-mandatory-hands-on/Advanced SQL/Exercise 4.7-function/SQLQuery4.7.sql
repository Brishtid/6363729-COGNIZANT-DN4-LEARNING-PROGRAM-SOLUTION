--qn7
CREATE PROCEDURE sp_UpdateEmployeeSalary
    @EmployeeID INT,
    @NewSalary DECIMAL(10,2)
AS
BEGIN
    UPDATE Employees
    SET Salary = @NewSalary
    WHERE EmployeeID = @EmployeeID;
END;
EXEC sp_UpdateEmployeeSalary 2, 7500.00;
SELECT * FROM Employees WHERE EmployeeID = 2;
