using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Repositories
{
    public interface IEmployeeRepository
    {
        public List<Employees> GetAllEmployees();

        public void AddEmployee(Employees employee);

        public Employees GetEmployeeById(int employeeId);
        public Employees Login(string username, string password);
    }
}
