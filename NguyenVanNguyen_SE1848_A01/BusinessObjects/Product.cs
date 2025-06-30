using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsStock { get; set; }
        public override string ToString()
        {
            return Id + "\t" + Name + "\t" + CategoryId + "\t" + UnitPrice + "\t" + UnitsStock;
        }
    }
}
