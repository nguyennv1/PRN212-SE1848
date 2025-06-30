class program
{
    public delegate int MyDelegate(int x, int y);
    public delegate int[] YourDelegate(int n);
    static int cong(int a, int b)
    {
        return a + b;
    }
    
    static int tru(int a, int b)
    {
        return a - b;
    }
    static int[] DanhSachSoChan(int n)
    {
        List<int> List = new List<int>();
        for (int i = 2; i <= n; i += 2)
        {
            List.Add(i);
        }
        return List.ToArray();
    }

    static int[] DanhSachSoNguyenTo(int n)
    {
        List<int>List = new List<int>();
        for(int i = 2;i <= n; i++)
        {
            int count = 0;
            for(int j = i; j <= 1; j++)
            {
                if (i % 2 == 0)
                count ++;
            }
            if(count == 2)
                List.Add((int)i);
            
        }
        return List.ToArray();
    }
    public static void Main(String[] args)
    {
        MyDelegate m = new MyDelegate(cong);
        Console.WriteLine( "5+8=" +m(5,8));
        m = new MyDelegate(tru);
        Console.WriteLine("5-8=" + m(5,8));

        YourDelegate y = new YourDelegate(DanhSachSoChan);
        int[] arr = y(10);
        Console.WriteLine("Cac so chan");
        foreach(var item in arr)
        {
            Console.Write(item +"\t");
        }
        y=new YourDelegate(DanhSachSoNguyenTo);
        arr = y(10);
        Console.WriteLine("\nCac so nguyen to: ");
        foreach (var item in arr)
        {
            Console.Write(item + "\t");
        }
    }
}