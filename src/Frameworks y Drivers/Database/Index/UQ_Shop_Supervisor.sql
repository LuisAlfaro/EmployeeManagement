CREATE UNIQUE NONCLUSTERED INDEX UQ_Shop_Supervisor
ON EmployeeShop([IdShop],[Date],[IsSupervisor])
WHERE [IsSupervisor] = 1;
