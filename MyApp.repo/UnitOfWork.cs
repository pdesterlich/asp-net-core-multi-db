using System.Collections.Generic;
using System.Linq;
using MyApp.models;

namespace MyApp.repo
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public void Dispose()
        {
            _context.Dispose();
        }

        public ICollection<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }
    }
}