using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IEmployeeTypeRepository
    {
        EmployeeType GetEmployeeType(int idEmployeeType);
        IEnumerable<EmployeeType> GetEmployeeTypes();
        void CreateEmployeeType(EmployeeType employeeType);
        void UpdateEmployeeType(EmployeeType employeeType);
        void DeleteEmployeeType(int idEmployeeType);

    }
}
