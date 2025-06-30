Console.OutputEncoding =  System.Text.Encoding.UTF8;
int[] arr = { 100, 51, 120, 13, 80, 70, 123, 237 };
//cau1: DUng LINQ de loc so chan
//Cach method Syntax
var result = arr.Where(x => x %2 == 0).ToArray();
//Cach Query
var result2= from x in arr
             where x %2 == 0
             select x;
Console.WriteLine( "DanhSachSoChan:");
result2.ToList().ForEach(x => Console.WriteLine( x));
//Cau2: sap xep tag dan:
var result3 = arr.OrderBy(x => x);
var result4 = from x in arr
              orderby x
              select x;
Console.WriteLine( "\n Danh sach sap xep tang dan");
foreach (var item in result3)
Console.Write( item + "\t");
//Cau4:Dem so lg so le
//int dem = arr.Where((x => x %2 != 0).Count();
// Cau5: tim chi tiet san pham khi biet id.



//cau6 : Viet ham loc ra TOP N san pham co tri gia lon nhat