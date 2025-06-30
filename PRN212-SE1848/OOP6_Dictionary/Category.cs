using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP6_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }
        public Category() 
        {
            Products = new Dictionary<int, Product>();
        }
        public override string ToString()
        {
            return $"{Id}\t{Name}";
        }
        /* khi quan ly moi doi tuong la phai dap ung day du CRUD*/
        public void AddProduct(Product p)
        {
            if (p == null)
            {
                return;// du lieu dau vao null
            }
            if (Products.ContainsKey(p.Id))
            {
                return; // Id da ton tai thi k them
            }
            
         
        }
        // xuat toan bo Product
        public void PrintAllProduct()
        {
            foreach(KeyValuePair<int,Product> kvp in Products)
            {
                Product p = kvp.Value;
                Console.WriteLine(p);
            }
                   
        }
        //Loc san pham theo gia
        public Dictionary<int, Product>
            FillterProductsByPrice(double min, double max)
        {
            return Products.Where(item => item.Value.Price >= min && item.Value.Price <= max).ToDictionary<int,Product>();
        }
        //sap xep sp theo don gia tang dan
        public Dictionary <int, Product> SortProductByPrice()
        {
            return Products.OrderBy(item => item.Value.Price).ToDictionary<int,Product>();
        }
        //
        public Dictionary<int, Product> SortComplex()
        {
            return Products
                .OrderByDescending(item => item.Value.Quantity)
                .OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();
        }
        // sua product
        public bool UpdateProduct(Product p)
        {
            if(p== null)
                { return false; }// nhap null sao ma sua
            if (Products.ContainsKey(p.Id) == false)
            {
                return false;// ko thay sao ma sua
            }
            // cap nhat gia tri o nho chua p.Id
            Products[p.Id] = p;
            return true;// danh dau la sua thanh cong
        }
        //xoa product
        public bool RemoveProduct(int id)
        {
            if (Products.ContainsKey(id) == false)
                { return false; }//Ko tim thay sao xoa
            Products.Remove(id);
            return true;
        }
        // xoa san pham co so luong tu a->b

            
    }
}
