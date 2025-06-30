using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class DataContextSingleton
    {
        private static DataContextSingleton _instance;
        public static DataContextSingleton Instance => _instance ??= new DataContextSingleton();

        public List<Customers> Customers { get; set; }
        public List<Employees> Employees { get; set; }
        public List<Categories> Categories { get; set; }

        private DataContextSingleton()
        {
            SeedData();
        }

        private void SeedData()
        {
            Customers = new List<Customers>
            {
                new Customers { CustomerID = 1, CompanyName = "VNG company", ContactName = "Nguyễn Văn An", ContactTitle = "Manager", Address = "123 Le Loi", Phone = "0909123456", Password = "123" },
                new Customers { CustomerID = 2, CompanyName = "Mailisa", ContactName = "Trần Thị Bình", ContactTitle = "Director", Address = "456 Tran Hung Dao", Phone = "0911222333", Password = "123" },
                new Customers { CustomerID = 3, CompanyName = "Vinamilk", ContactName = "Hoàng Thị Thảo", ContactTitle = "Purchasing", Address = "789 Nguyen Trai", Phone = "0909888777", Password = "123" },
                new Customers { CustomerID = 4, CompanyName = "FPT Software", ContactName = "Lê Văn Cường", ContactTitle = "Lead", Address = "88 Ton Duc Thang", Phone = "0911000000", Password = "123" }
            };

            Employees = new List<Employees>
            {
                new Employees { EmployeeID = 1, Name = "Nguyễn Văn Nguyên", UserName = "nguyen", Password = "123", JobTitle = "Admin" },
                new Employees { EmployeeID = 2, Name = "Nguyễn Văn Cường", UserName = "cuong", Password = "123", JobTitle = "Admin" },
                new Employees { EmployeeID = 3, Name = "Trần Thị Lan", UserName = "lan", Password = "123", JobTitle = "Admin" },
                new Employees { EmployeeID = 4, Name = "Đỗ Thanh Tùng", UserName = "tung", Password = "123", JobTitle = "Admin" }
            };

            Categories = new List<Categories>
            {
                new Categories { CategoryID = 1, CategoryName = "Nước ngọt", Description = "Drinks and beverages" },
                new Categories { CategoryID = 2, CategoryName = "Bia", Description = "Snack foods" },
                new Categories { CategoryID = 3, CategoryName = "Bánh", Description = "Bread and cakes" }
            };
        }
    }
}
