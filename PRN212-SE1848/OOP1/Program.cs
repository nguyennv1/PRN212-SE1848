using System.Text;
using OOP1;
Console.OutputEncoding = Encoding.UTF8; 
// tao doi tuong Category
Category c1 = new Category();
c1.Id = 1;
c1.Name = "nuoc mam";
c1.PrintInfor();
//giasu tao ta doi gia tri o o nho do;
c1.Name = "Thuoc tri hoi nach";
Console.WriteLine("Sau khi doi gia tri:");
c1.PrintInfor();
//su dung employee
Console.WriteLine("-----------EMPLOYEE-----------");
Employee emp = new Employee();
emp.Id = 1;// goi setter cua employee
emp.IdCard = "001";
emp.Name = "Teo";
emp.Email = "Teo@gamil.com";
emp.Phone = "000001010";
//xuat thog tin
emp.printInfor();
Employee emp2 = new Employee()
{
    Id = 2,
    IdCard = "002",
    Name = "Ty",
    Email = "Ty@gmail.com",
    Phone = "00010000"
};
Console.WriteLine("---------EMPLOYEE2------------");
emp2.printInfor();
Employee emp3 = new Employee();
Console.WriteLine("--------EMP3----------");
emp3.printInfor();
/// tao emp4
Console.WriteLine("---------EMPLOYEE4------------");
Employee emp4 = new Employee(4, "004", "Tun", "Tun@mlm.com", "00009000");
emp4.printInfor();
//goi emp4 cach 2
Console.WriteLine("---------EMPLOYEE4 cach 2------------");
Console.WriteLine(emp4);//tu goi ham ToString
Customer cus1 = new Customer()
{
    Id = 1,
    Name = "Nguyen Thi Lung Linh",
    Email = "Lungling@gmail",
    Phone = "000000010",
    Address = "So1 Ding Tien Hoang",
};
cus1.printInfor();
cus1.Address = "So2 Hoan Kiem";
Console.WriteLine("Customer sau khi doi dia chi");
cus1.printInfor();