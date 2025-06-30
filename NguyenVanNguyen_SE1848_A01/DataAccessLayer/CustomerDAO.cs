using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        private DataContextSingleton context = DataContextSingleton.Instance;
        public List<Customers> GetAllCustomers()
        {
            return context.Customers;
        }
        public void AddCustomer(Customers customer)
        {
            customer.CustomerID = context.Customers.Count > 0 ? context.Customers.Max(c => c.CustomerID) + 1 : 1;
            context.Customers.Add(customer);
        }
        public Customers GetCustomerById(int customerId)
        {
            return context.Customers.FirstOrDefault(c => c.CustomerID == customerId);
        }

        public Customers LoginByCustomer(string phone, string password)
        {
            return context.Customers.FirstOrDefault(e => e.Phone == phone && e.Password == password);
        }
    }
}
