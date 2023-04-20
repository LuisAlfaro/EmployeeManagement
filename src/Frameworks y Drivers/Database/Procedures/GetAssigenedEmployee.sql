CREATE PROCEDURE [dbo].[GetAssigenedEmployee]
	@IdEmployee AS INT = NULL,
	@IdShop AS INT = NULL,
	@StartDate AS DATE = NULL,
	@EndDate AS DATE = NULL
AS
	SELECT 
		es.Id,
		e.Name NameEmployee,
		s.Name NameShop,
		s.Address AdressShop,
		es.Date, 
		sp.Name NameSupervisor
	FROM EmployeeShop es
	INNER JOIN Employee e ON e.Id = es.IdEmployee
	INNER JOIN Shop s ON s.Id = es.IdShop
	LEFT JOIN (
		SELECT essp.*,esp.Name 
		FROM EmployeeShop essp
		INNER JOIN Employee esp ON esp.Id = essp.IdEmployee
		WHERE essp.IsSupervisor = 1
	) AS sp ON sp.IdShop = es.IdShop AND sp.Date = es.Date 
	WHERE (es.IdEmployee = @IdEmployee OR @IdEmployee IS NULL)
	AND (es.IdShop = @IdShop OR @IdShop IS NULL)
	AND (es.Date >= @StartDate OR @StartDate IS NULL)
	AND (es.Date <= @EndDate OR @StartDate IS NULL)
	ORDER BY es.Date,s.Name		