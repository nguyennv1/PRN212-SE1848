using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;

namespace Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        EmployeeDAO employeeDAO = new EmployeeDAO();
        public void AddEmployee(Employees employee)
        {
            employeeDAO.AddEmployee(employee);
        }

        public List<Employees> GetAllEmployees()
        {
            return employeeDAO.GetAllEmployees();
        }

        public Employees GetEmployeeById(int employeeId)
        {
            return employeeDAO.GetEmployeeById(employeeId);
        }

        public Employees Login(string username, string password)
        {
            return employeeDAO.Login(username, password);
        }
    }
}
