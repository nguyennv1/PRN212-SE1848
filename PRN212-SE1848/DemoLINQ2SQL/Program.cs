using System.ComponentModel;
using System.Text;
using DemoLINQ2SQL;
Console.OutputEncoding = System.Text.Encoding.UTF8;
//Khai bao chuoi ket noi
string connectionString = "server=THAO\\SQLEXPRESS; database=MyStore; uid=sa; pwd=12345";
MyStoreDataContext context = new MyStoreDataContext(connectionString);
//cau1: truy van toan bo danh muc.
var dsdm = context.Categories.ToList();
Console.WriteLine("DanhSachDanhMuc");
foreach (var d in dsdm)
    Console.WriteLine( d.CategoryID+"\t" + d.CategoryName);
//cau2: lay thong tin chi tiet danh muc khi biet ma
int madm = 7;
Category cate = new context.Categpry().FirstOrderDefault(c => c.CategoryID == madm);
if(cate == null)
{
    Console.WriteLine( "Khong tim that muc co ma= "+madm);
}
else
{
    Console.WriteLine( "Tim thay danh muc co ma=" + madm);
    Console.WriteLine( cate.CategoryID + "\t" + cate.CategoryName);
}
//cau3: Dung Query Systax truy van sp
var dssp= from p in  context.Products
          select p;
Console.WriteLine( "Danh sach san pham");
foreach (var d in dssp)
{
    Console.WriteLine(p.ProductID + "\t" + p.ProductName + "\t" p.UnitPrice);
}
//cau4: Dung Query Syntax va Anonymous type de loc ra cac sp
// nhung chi lay ma san pham va don gia. Dong thoi sap xep giam dan.
 var dssp4  = from p in context.Products
              orderby p.UnitPrice descending
              select new {p.ProductID, p.UnitPrice};
Console.WriteLine( "Danh sach san pham theo cau 4");
foreach ( var p in dssp4)
{
    Console.WriteLine( p.ProductID + "\t" + p.UnitPrice);
}
//Cau5: sua cau 4 thoi Extention method(Method syntax)
var dssp5 = context.Products
    .OrderByDescending(p=> p.UnitPrice)
    .Select(p=>new { p.productID,p.UnitPrice});
Console.WriteLine("Danh sach san pham cau 5")
foreach(var p in dssp5)
{
    Console.WriteLine( p.ProductID+ "\t"+ p.UnitPrice);
}
//Cau6: Loc ra TOP3 san pham co gia lon nhat he thong
var dssptop3 = context.Products
    .OrderByDescending(p => p.UnitPrice)
    .Take(3);
Console.WriteLine("Top 3 sp co gia lon nhat");
foreach(var p in dssptop3)
{
    Console.WriteLine( p.ProductID+ "\t" + p.ProductName+ "\t" + p.UnitPrice);
}
//Cau7: sua ten danh muc khi biet ma
int madm_edit = 16;
Category cate_edit = context.Categories.FirstOrderDefault(c => c.CategoryID == madm_edit);
if(cate_edit == null)
{
    cate_edit.CategoryName = "Hang troi noi";
    context.SubmitChange();//xac nhan luu thay doi.
}
//cau8: xoa danh muc khi biet ma.
int madm_xoa = 15;
Category cate_remove = context.Categories.FirstOrderDefault(c=> c.CategoryID == madm_xoa);
if(cate_remove == null)
{
    context.Categories.DeleteOnSubmit(cate_remove);
    context.SubmitChange();//xac nhan thay doi du lieu
}
//cau9: xoa danh muc neu khong co sp nao.
//luu y: xoa cung mot luc nhieu danh muc ma cac danh muc nay k co chua bat ki sp nao.
var dsdm_empty_product = context.Categoties.Where(c=> c.Products.Count() == 0).ToList();
context.Categories.DeleteAllOnSubmit(dsdm_empty_product)
context.SubmitChange();
//cau10. them moi 1 dah muc.
CategoryAttribute c_new = new Category();
c_new.CategoryName = "Hang lau tu China";
context.Categories.InsertOnSubmit(c_new);
context.SubmitChange();
//cau 11: them moi nhieu danh muc
List<Catefory> list = new List<Categoty>();
list.Add(new Category() { CategoryName = "Hang Gia Dung" });
list.Add(new Category() { CategoryName = "Hang Nhai" });
list.Add(new Category() { CategoryName = "Hang Dien Tu" });
context.Categories.InsertOnSubmit(list);
context.SubmitChange();