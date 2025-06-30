using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Services
{
    public interface ICustomerService
    {
        public List<Customers> GetAllCustomers();
        public void AddCustomer(Customers customer);
        public Customers GetCustomerById(int customerId);
        public Customers LoginByCustomer(string phone, string password);
    }
}
