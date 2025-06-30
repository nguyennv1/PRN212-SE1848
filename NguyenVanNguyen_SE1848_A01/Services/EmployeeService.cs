using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Repositories;

namespace Services
{
    public class EmployeeService : IEmployeeService
    {
        EmployeeRepository employeeRepository;
        public EmployeeService()
        {
            employeeRepository = new EmployeeRepository();
        }
        public List<Employees> GetAllEmployees()
        {
            return employeeRepository.GetAllEmployees();
        }

        public Employees Login(string username, string password)
        {
            return employeeRepository.Login(username, password);
        }
    }
}
