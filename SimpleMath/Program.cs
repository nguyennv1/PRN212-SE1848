using System.Text;

String do_math(double a, double b,string op)
{
    String result = "";
        switch (op)
    {
        case "+":
            result = $"{a} + {b}={a + b}";
            break;
        case "-":
            result = $"{a} - {b} = {a - b}";
            break;
        case "*":
            result = $"{a} * {b} = {a * b}";
            break;
        case "/":
            if (b == 0) result = "mẫu số khác 0";
            else result = $"{a} / {b} = {a / b}";
            break;
        default:
            result = "Nhap phep toan tao lao qua";
            break;
    }
    return result;
}
Console.OutputEncoding = Encoding.UTF8;
double a, b;
Console.WriteLine("Nhập a:");
a=double.Parse(Console.ReadLine());
Console.WriteLine("Nhập b:");
b =double.Parse(Console.ReadLine());
Console.WriteLine("Nhập phép toán + - * /: ");
String op = Console.ReadLine();
String result = do_math(a,b,op);
Console.WriteLine(result);
