using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IEmployee_Shop
    {
        Employee_Shop CreateEmployee(Employee_Shop employeeShop);
        Employee_Shop UpdateEmployee(Employee_Shop employeeShop);
        void DeleteEmployee(Employee_Shop employeeShop);
    }
}
