using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessEF.Repositories
{
    public class EmployeeShopRepository : IEmployeeShopRepository
    {
        readonly DataContext Context;

        public EmployeeShopRepository(DataContext context) => Context = context;

        
        public IEnumerable<EmployeeShop> GetEmployeeShop()
        {
            return  Context.EmployeeShop.ToList();            
        }
        public void CreateEmployeeShop(EmployeeShop employeeShop)
        {
            Context.EmployeeShop.Add(employeeShop);            
        }

        public void UpdateEmployeeShop(EmployeeShop employeeShop)
        {
            var oldEmployeeShop  = Context.EmployeeShop
                .First(es => (es.IdEmployee == employeeShop.IdEmployee && es.IdShop == employeeShop.IdShop && es.Date == employeeShop.Date));
            if (oldEmployeeShop != null)
            {
                Context.EmployeeShop.Update(employeeShop);
            }
        }

        public void DeleteEmployeeShop(EmployeeShop employeeShop)
        {            
            Context.EmployeeShop.Remove(employeeShop);            
        }
        
    }
}
