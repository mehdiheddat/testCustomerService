using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static testCustomerService.Core;
using static testCustomerService.Entities;

namespace testCustomerService
{
    public class Business
    {
        public class CustomerService : ICustomerService
        {
            private readonly ICustomerRepository _repository;

            public CustomerService(ICustomerRepository repository)
            {
                _repository = repository;
            }

            public Customer AddCustomer(Customer customer)
            {
                if (customer == null)
                    throw new ArgumentNullException(nameof(customer));
                if (string.IsNullOrWhiteSpace(customer.Name))
                    throw new ArgumentException("Customer name is required", nameof(customer.Name));
                if (string.IsNullOrWhiteSpace(customer.Familly))
                    throw new ArgumentException("Customer familly is required", nameof(customer.Familly));

                _repository.Add(customer);

                return _repository.Get(customer.ID);
            }

            public void DeleteCustomer(int customerId)
            {
                _repository.Delete(customerId);
            }

            public Customer GetCustomer(int customerId)
            {
                return _repository.Get(customerId);
            }

            public IList<Customer> GetCustomers()
            {
                return _repository.GetAll();
            }

            public void UpdateCustomer(Customer customer)
            {
                if (customer == null)
                    throw new ArgumentNullException(nameof(customer));
                if (string.IsNullOrWhiteSpace(customer.Name))
                    throw new ArgumentException("Customer name is required", nameof(customer.Name));
                if (string.IsNullOrWhiteSpace(customer.Familly))
                    throw new ArgumentException("Customer familly is required", nameof(customer.Familly));

                _repository.Update(customer);
            }
        }
    }
}
