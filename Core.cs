using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static testCustomerService.Entities;

namespace testCustomerService
{
    public class Core
    {
        public interface ICustomerRepository
        {
            void Add(Customer customer);
            void Delete(int customerId);
            Customer Get(int customerId);
            IList<Customer> GetAll();
            void Update(Customer customer);
        }

        public interface ICustomerService
        {
            Customer AddCustomer(Customer customer);
            void DeleteCustomer(int customerId);
            Customer GetCustomer(int customerId);
            IList<Customer> GetCustomers();
            void UpdateCustomer(Customer customer);
        }
    }
}
