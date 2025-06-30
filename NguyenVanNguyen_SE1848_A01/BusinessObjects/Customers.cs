using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessObject
{
    public class Customers
    {
        //CustomerID, CompanyName, ContactName, ContactTitle, Address, Phone)
        public int CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return CustomerID + "\t" + CompanyName + "\t" + ContactName + "\t" + ContactTitle + "\t" + Address + "\t" + Phone ;
        }
    }
}
