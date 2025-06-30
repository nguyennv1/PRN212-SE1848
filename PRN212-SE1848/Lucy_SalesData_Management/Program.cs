using System.ComponentModel;
using System.Text;
using Lucy_SalesData_Management;
Console.OutputEncoding = System.Text.Encoding.UTF8;
//Khai bao chuoi ket noi
string connectionString = "server=THAO\\SQLEXPRESS; database=Lucy_SalesData; uid=sa; pwd=12345";
Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);

//câu 1: lọc ra toàn bộ khách hàng
var dskh = context.Customers.ToList();
Console.WriteLine("---danh sách khách hàng---");
foreach (var d in dskh)
{
    Console.WriteLine(d.CustomerID + "\t" + d.ContactName);
}
//câu 2 tìm chi tiết thông tin khách hàng 
//khi biết mã khách hàng
int makh = 10;
Customer cust = context.Customers.FirstOrDefault(c => c.CustomerID == makh);
if (cust != null)
{
    Console.WriteLine("--- chi tiết khachs hàng");
    Console.WriteLine(cust.CustomerID + "\t" + cust.ContactName);
}

//câu 3 từ kết quả của câu 3 lọc ra sanh sách các hóa đơn của khách hàng
//các cột dữ liệu gồn: mã hóa đơn  + ngày hóa đơn
if(cust != null)
{
    var dshd = cust.Orders.Select(od => new { od.OrderID, od.OrderDate });
    var dshd2 = from od in cust.Orders
                select new {od.OrderID, od.OrderDate };
    Console.WriteLine( "Danh sach hoa don cua khac hang:");
    foreach (var od in dshd)
    {
        Console.WriteLine( od.OrderID + "\t" + od.OrderDate.ToString("dd/MM/yyyy"));
    }
}
//cau4: tu kqua cau 3, bo sung them tri gia cua don hang cho moi hoa don
if (cust != null)
{
    var dshd = cust.Orders.
        Select(od => new { od.OrderID, od.OrderDate, TotalValue=od.Order_Details
        .Sum(odd=> odd.Quantity*odd.UnitPrice*(1-(decimal)odd.Discount)) });
    Console.WriteLine("Danh sach hoa don cua khac hang:");
    foreach (var od in dshd)
    {
        Console.WriteLine(od.OrderID + "\t" + od.OrderDate.ToString("dd/MM/yyyy") + "\t" + od.TotalValue);
    }
}