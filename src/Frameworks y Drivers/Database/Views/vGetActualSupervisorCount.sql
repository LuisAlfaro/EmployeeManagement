CREATE VIEW [dbo].[vGetActualSupervisorCount]
	AS 

	SELECT esp.Name, COUNT(es.id) as count
	FROM EmployeeShop essp
	INNER JOIN Employee esp ON esp.Id = essp.IdEmployee
	LEFT JOIN EmployeeShop es ON es.IdShop = essp.IdShop AND es.Date = essp.Date AND es.IsSupervisor = 0
	WHERE essp.IsSupervisor = 1
	AND essp.date = CAST( GETDATE() AS Date )
	GROUP BY esp.Name

