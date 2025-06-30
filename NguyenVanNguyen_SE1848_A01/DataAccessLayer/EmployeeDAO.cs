using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class EmployeeDAO
    {
        private DataContextSingleton context = DataContextSingleton.Instance;
        public List<Employees> GetAllEmployees()
        {
            return context.Employees;
        }

        public void AddEmployee(Employees employee)
        {
            employee.EmployeeID = context.Employees.Count > 0 ? context.Employees.Max(e => e.EmployeeID) + 1 : 1;
            context.Employees.Add(employee);
        }

        public Employees GetEmployeeById(int employeeId)
        {
            return context.Employees.FirstOrDefault(e => e.EmployeeID == employeeId);
        }

        public Employees Login(string username, string password)
        {
            return context.Employees.FirstOrDefault(e =>
        e.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
        && e.Password == password); ;
        }
    }
}
