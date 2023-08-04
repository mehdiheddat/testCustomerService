using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static testCustomerService.Core;
using static testCustomerService.Entities;
using static testCustomerService.Program;

namespace testCustomerService
{
    public class DataAccess
    {
        public class CustomerDbContext : DbContext
        {
            public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
            {
            }

            public DbSet<Customer> Customers { get; set; }
        }

        public class CustomerRepository : ICustomerRepository
        {
            private readonly CustomerDbContext _context;

            public CustomerRepository(CustomerDbContext context)
            {
                _context = context;
            }

            public void Add(Customer customer)
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
            }

            public void Delete(int customerId)
            {
                var customer = _context.Customers.FirstOrDefault(c => c.ID == customerId);
                if (customer != null)
                {
                    _context.Customers.Remove(customer);
                    _context.SaveChanges();
                }
            }

            public Customer Get(int customerId)
            {
                return _context.Customers.FirstOrDefault(c => c.ID == customerId);
            }

            public IList<Customer> GetAll()
            {
                return _context.Customers.ToList();
            }

            public void Update(Customer customer)
            {
                _context.Customers.Update(customer);
                _context.SaveChanges();
            }
        }
    }
}
