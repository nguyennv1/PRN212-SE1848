﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Services
{
    public interface IEmployeeService
    {
        public Employees Login(string username, string password);
        public List<Employees> GetAllEmployees();
    }
}
