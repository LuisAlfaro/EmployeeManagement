CREATE PROCEDURE [dbo].[GetAllEmployees]
	@IdEmployee AS INT = NULL
AS
	SELECT e.Name EmployeeName, e.Telephone,e.EmploymentDate, et.Name, et.Salary
	FROM Employee e
	INNER JOIN EmployeeType et on et.Id = e.IdType	
	WHERE (e.Id = @IdEmployee or @IdEmployee is null)
RETURN 0
