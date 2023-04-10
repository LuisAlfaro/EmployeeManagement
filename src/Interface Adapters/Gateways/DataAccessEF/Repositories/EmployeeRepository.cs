using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessEF.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        readonly DataContext Context;

        public EmployeeRepository(DataContext context) => Context = context;

        public Employee GetEmployee(int idEmployee)
        {
            return Context.Employee
                .First(e => e.Id == idEmployee);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return  Context.Employee.ToList();            
        }
        public void CreateEmployee(Employee employee)
        {
            Context.Employee.Add(employee);            
        }

        public void UpdateEmployee(Employee employee)
        {
            var oldEmployee  = Context.Employee.Find(employee.Id);
            if (oldEmployee != null)
            {
                Context.Employee.Update(employee);
            }
        }

        public void DeleteEmployee(int idEmployee)
        {
            var employee = Context.Employee.Find(idEmployee);
            if (employee != null)
            {
                Context.Employee.Remove(employee);
            }
        }
        
    }
}
