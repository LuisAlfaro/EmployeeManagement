using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IEmployeeShopRepository
    {
        IEnumerable<EmployeeShop> GetEmployeeShop();
        void CreateEmployeeShop(EmployeeShop employeeShop);
        void UpdateEmployeeShop(EmployeeShop employeeShop);
        void DeleteEmployeeShop(EmployeeShop employeeShop);
                       
    }
}
