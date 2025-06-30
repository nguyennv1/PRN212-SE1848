using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        CustomerDAO customerDAO = new CustomerDAO();
        public void AddCustomer(Customers customer)
        {
            customerDAO.AddCustomer(customer);
        }

        public List<Customers> GetAllCustomers()
        {
            return customerDAO.GetAllCustomers();
        }

        public Customers GetCustomerById(int customerId)
        {
            return customerDAO.GetCustomerById(customerId);
        }

        public Customers LoginByCustomer(string phone, string password)
        {
            return customerDAO.LoginByCustomer(phone, password);
        }
    }
}
