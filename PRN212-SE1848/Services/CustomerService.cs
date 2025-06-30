﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Repositories;

namespace Services
{
    public class CustomerService : ICustomerRepository
    {
        ICustomerRepository iCustomerRepository;
        public CustomerService()
        {
            iCustomerRepository = new CustomerRepository();
        }

        public void GenerateSampleDataset()
        {
            iCustomerRepository.GenerateSampleDataset();
        }

        public List<Customer> GetCustomers()
        {
            return iCustomerRepository.GetCustomers();
        }
    }
}
