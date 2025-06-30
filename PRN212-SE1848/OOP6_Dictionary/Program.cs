using System.Text;
using OOP6_Dictionary;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nuoc ngot";

Product p1 = new Product();
p1.Id = 1;
p1.Name = "Pepsi";
p1.Quantity = 10;
p1.Price = 20;
c1.AddProduct(p1);

Product p2 = new Product();
p2.Id = 2;
p2.Name = "Coca";
p2.Quantity = 10;
p2.Price = 40;
c1.AddProduct(p2);

Product p3 = new Product();
p3.Id = 3;
p3.Name = "Xa xi";
p3.Quantity = 10;
p3.Price = 12;
c1.AddProduct(p3);

Product p4 = new Product();
p4.Id = 4;
p4.Name = "Siting";
p4.Quantity = 10;
p4.Price = 20;
c1.AddProduct(p4);

Product p5 = new Product();
p5.Id = 5;
p5.Name = "RedBull";
p5.Quantity = 10;
p5.Price = 30;
c1.AddProduct(p5);

Console.WriteLine("Thong tin danh muc");
Console.WriteLine(c1);
Console.WriteLine("----------------------------");
c1.PrintAllProduct();

double min_price = 10;
double max_price = 20;
Dictionary<int, Product> product_by_price = c1.FillterProductsByPrice(min_price, max_price);
Console.WriteLine($"Danh sach san pham co gia tu {min_price} toi {max_price}:");
foreach(KeyValuePair<int, Product>kvp in product_by_price)
{
    Product p=kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> sorted_products = c1.SortProductByPrice();
Console.WriteLine("------sau khi sort tang dan-------");
foreach (KeyValuePair<int, Product> kvp in sorted_products)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}


Dictionary<int, Product> sorted_complex = c1.SortComplex();
Console.WriteLine("------sau khi sort complex-------");
foreach (KeyValuePair<int, Product> kvp in sorted_complex)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

//p2.Name = "Fanta";
//p2.Price = 80;
//p2.Quantity = 17;
//bool ret=c1.UpdateProduct(p2);
//Console.WriteLine("san pham sau khi sua");
//c1.PrintAllProduct();

//int id = 5;
//ret=c1.RemoveProduct(id);
//if(ret==false) 
//    Console.WriteLine($"ko tim thay ma {id} de xoa");
//else
//{
//    Console.WriteLine($"Da xoa thanh cong san pham co ma {id}");
//    Console.WriteLine("----San pham sau khoi xoa---");
//    c1.PrintAllProduct();
//}
LinkedList<Category> categories = new LinkedList<Category>();
categories.AddLast(c1);

Category c2 = new Category();
c2.Id = 2;
c2.Name = "Bia";
c2.AddProduct(new Product() { Id = 6, Name = "Tiger", Quantity = 10, Price= 30});
c2.AddProduct(new Product() { Id = 7, Name = "333", Quantity = 10, Price = 50 });
c2.AddProduct(new Product() { Id = 8, Name = "Ken", Quantity = 10, Price = 40 });
categories.AddFirst(c2);
Console.WriteLine("Danh sach taon bo sp theo danh muc");
foreach(Category c in categories)
{
    Console.WriteLine(c);
    Console.WriteLine("------------------------");
    c.PrintAllProduct();
    Console.WriteLine("------------------------");
}

