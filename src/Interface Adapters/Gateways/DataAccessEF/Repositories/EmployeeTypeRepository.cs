using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessEF.Repositories
{
    public class EmployeeTypeRepository : IEmployeeTypeRepository
    {
        readonly DataContext Context;

        public EmployeeTypeRepository(DataContext context) => Context = context;

        public EmployeeType GetEmployeeType(int idEmployeeType)
        {
            return Context.EmployeeType
                .First(e => e.Id == idEmployeeType);
        }

        public IEnumerable<EmployeeType> GetEmployeeTypes()
        {
            return  Context.EmployeeType.ToList();            
        }
        public void CreateEmployeeType(EmployeeType employeeType)
        {
            Context.EmployeeType.Add(employeeType);            
        }

        public void UpdateEmployeeType(EmployeeType employeeType)
        {
            var oldEmployeeType  = Context.EmployeeType.Find(employeeType.Id);
            if (oldEmployeeType != null)
            {
                Context.EmployeeType.Update(employeeType);
            }
        }

        public void DeleteEmployeeType(int idEmployeeType)
        {
            var employeeType = Context.EmployeeType.Find(idEmployeeType);
            if (employeeType != null)
            {
                Context.EmployeeType.Remove(employeeType);
            }
        }
        
    }
}
