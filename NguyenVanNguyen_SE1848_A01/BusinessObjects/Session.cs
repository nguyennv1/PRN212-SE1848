using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Session
    {
        public static Customers CurrentCustomer { get; set; }
        public static Employees CurrentEmployee { get; set; }
    }
}
