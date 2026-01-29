using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so phan tu n: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = null;

        if (n > 0)
        {
            a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // Check null
        if (a == null)
        {
            Console.WriteLine("Ho ten: Tran Dinh Nguyen");
            Console.WriteLine("MSV: 2415053122225");
            Console.WriteLine("-------------------");
            Console.WriteLine("Loi: Mang chua duoc khoi tao");
            return;
        }

        // Tinh tong
        int tong = 0;
        for (int i = 0; i < a.Length; i++)
        {
            tong += a[i];
        }
        Console.WriteLine("Ho ten: Tran Dinh Nguyen");
        Console.WriteLine("MSV: 2415053122225");
        Console.WriteLine("-------------------");
        Console.WriteLine("Tong cac phan tu trong mang: " + tong);
    }
}
