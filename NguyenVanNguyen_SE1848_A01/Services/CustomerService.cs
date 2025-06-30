using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Repositories;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepository customerRepository;
        public CustomerService()
        {
            customerRepository = new CustomerRepository();
        }
        public void AddCustomer(Customers customer)
        {
            customerRepository.AddCustomer(customer);
        }

        public List<Customers> GetAllCustomers()
        {
            return customerRepository.GetAllCustomers();
        }

        public Customers GetCustomerById(int customerId)
        {
            return customerRepository.GetCustomerById(customerId);
        }

        public Customers LoginByCustomer(string phone, string password)
        {
            return customerRepository.LoginByCustomer(phone, password);
        }
    }
}
