using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        private static List<Product> listProducts;
        public ProductDAO()
        {
            Product chai = new Product(1, "Chai", 3, 12, 18);
            Product chang = new Product(2, "Chang", 1, 23, 19);
            Product aniseed = new Product(3, "Aniseed", 2, 23, 10);
            listProducts = new List<Product> { chai, chang, aniseed };
            //Product chef = new Product(4, "chef Anton's Cajun Seasoning", 2, 34, 22);
            //Product chefMix = new Product(5, "Chef Anton's Gumbo Mix", 2, 45, 34);
            //Product grandma = new Product(6, "Grandma's Boysenberry Spread", 2, 21, 25);
        }

        public List<Product> GetProducts()
        {
            return listProducts;
        }
        public void SaveProduct(Product p)
        {
            listProducts.Add(p);
        }

        public void UpdateProduct(Product product)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductID == product.ProductID)
                {
                    p.ProductID = product.ProductID;
                    p.ProductName = product.ProductName;
                    p.UnitPrice = product.UnitPrice;
                    p.UnitsInStock = product.UnitsInStock;
                    p.CategoryID = product.CategoryID;
                }

            }
        }
        public void DeleteProduct(Product product)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductID == product.ProductID)
                {
                    listProducts.Remove(p);
                }
            }
        }

        public Product GetProductById(int id)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductID == id)
                {
                    return p;
                }
            }
            return null;
        }
    }
}