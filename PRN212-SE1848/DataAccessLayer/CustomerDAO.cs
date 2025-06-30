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
        static List<Customer> customers  = new List<Customer>();
        public void GenerateSampleDataset()
        {
            customers.Add(new Customer() { Id=1, Name="Obama", Phone = "3333", Email="obama@gmail"});
            customers.Add(new Customer() { Id = 2, Name = "Obama2", Phone = "3333", Email = "obama@gmail" });
            customers.Add(new Customer() { Id = 3, Name = "Obama3", Phone = "3333", Email = "obama@gmail" });
            customers.Add(new Customer() { Id = 4, Name = "Obama4", Phone = "3333", Email = "obama@gmail" });
            customers.Add(new Customer() { Id = 5, Name = "Obama5", Phone = "3333", Email = "obama@gmail" });
        }
        public List<Customer> GetCustomers()
        {
            return customers;
        }
    }
    
}
