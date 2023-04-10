CREATE UNIQUE NONCLUSTERED INDEX UQ_Shop_Supervisor
ON Employee_Shop([IdShop],[Date],[IsSupervisor])
WHERE [IsSupervisor] = 1;
