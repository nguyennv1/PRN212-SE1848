/*
 * su dung Generic List de quan ly nhan su voi day du CRUD
 * C-> Create
 * R->Read/Retrieve => xem, loc, tim kiem, sapxep...
 * U-> Update
 * D-> Delete
 */
//cau 1 : tao 5 nhan vien , 3 nhan vien fulltime va 2 nv thoi vu
using OOP2;
List<Employee> employees = new List<Employee>();
FulltimeEmployee fe1 = new FulltimeEmployee()
{
    Id = 1,
    IdCard = "123",
    Name = "name1",
    Birthday = new DateTime(1999, 12, 25)
};
employees.Add(fe1);

FulltimeEmployee fe2 = new FulltimeEmployee()
{
    Id = 2,
    IdCard = "234",
    Name = "name2",
    Birthday = new DateTime(1988, 11, 15)
};
employees.Add(fe2);

FulltimeEmployee fe3 = new FulltimeEmployee()
{
    Id = 3,
    IdCard = "345",
    Name = "name3",
    Birthday = new DateTime(1989, 10, 15)
};


employees.Add(fe3);

ParttimeEmployee pe1 = new ParttimeEmployee()
{
    Id = 4,
    IdCard = "456",
    Name = "name4",
    Birthday = new DateTime(2000, 12, 11)
};
employees.Add(pe1);

ParttimeEmployee pe2 = new ParttimeEmployee()
{
    Id = 5,
    IdCard = "567",
    Name = "name5",
    Birthday = new DateTime(2002, 9, 11)
};
employees.Add(pe2);

//cau 2: xuat toan bo nhan su
Console.WriteLine("cau 2: xuat toan bo nhan su:");
employees.ForEach(e => Console.WriteLine(e));
//cau 3: loc ra nhan su chinh thuc
List<FulltimeEmployee> fe_list = employees.OfType<FulltimeEmployee>().ToList();
foreach (FulltimeEmployee fe in fe_list)
    Console.WriteLine(fe);
//cau 4: tinh luong nv chinh thuc
double fe_sum_salary = fe_list.Sum(e => e.calSalary));
Console.WriteLine("cau 4: Tong luong nhan vien chinh thuc:");
Console.WriteLine(fe_sum_salary);
//cau 5: 
double pe_sum_salary = employees.