using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        static List<Product> products = new List<Product>();

        public void GenerateSampleDataset()
        {
            products.Add(new Product() { Id = 1, Name = "Coca", CategoryId = 1, UnitPrice = 20, UnitsStock = 100 });
            products.Add(new Product() { Id = 2, Name = "Pepsi", CategoryId = 1, UnitPrice = 30, UnitsStock = 100 });
            products.Add(new Product() { Id = 3, Name = "RedBull", CategoryId = 1, UnitPrice = 25, UnitsStock = 100 });
            products.Add(new Product() { Id = 4, Name = "Tiger", CategoryId = 2, UnitPrice = 15, UnitsStock = 100 });
            products.Add(new Product() { Id = 5, Name = "Heineken", CategoryId = 2, UnitPrice = 20, UnitsStock = 100 });
        }
        public List<Product> GetProducts()
        {
            return products;
        }

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
        public bool UpdateProduct(Product product)
        {
            //B1 tim product muon sua co ton tai k
            Product old = products.FirstOrDefault(p => p.Id == product.Id);
            if (old == null)// khong tim thay
                return false;
            old.Name = product.Name;
            old.CategoryId = product.CategoryId;
            old.UnitPrice = product.UnitPrice;
            old.UnitsStock = product.UnitsStock;
            return true;
        }
        public bool SaveProduct(Product product)
        {
            Product old = products.FirstOrDefault(p => p.Id == product.Id);
            if (old != null)
                return false;
            products.Add(product);
            return true;
        }

        public bool DeleteProduct(int id)
        {
            Product p = GetProduct(id);
            if (p != null)
            {
                products.Remove(p);
                return true;
            }
            return false;
        }
        public bool DeleteProduct(Product product)
        {
            if (product == null) // neu product null
                return false;
            return DeleteProduct(product.Id); // goi ham xoa theo id
        }
    }
}
