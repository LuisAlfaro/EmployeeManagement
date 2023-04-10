using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly DataContext _context;

        public UnitOfWork(DataContext context) => _context = context;
        public Task<int> SaveChanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}
