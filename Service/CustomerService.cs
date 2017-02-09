using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace Service
{
    public class CustomerService : ICustomerService
    {
        private IRepository<Customer> customerRepository;
        private IRepository<Meter> meterRepository;

        public CustomerService(IRepository<Customer> customerRepository, IRepository<Meter> meterRepository)
        {
            this.customerRepository = customerRepository;
            this.meterRepository = meterRepository;
        }
        public void DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            return customerRepository.GetById(id);
        }

        public IQueryable<Customer> GetCustomers()
        {
            return customerRepository.Table;
        }

        public void InsertCustomer(Customer customer)
        {
            customerRepository.Insert(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            customerRepository.Update(customer);
        }
    }
}
