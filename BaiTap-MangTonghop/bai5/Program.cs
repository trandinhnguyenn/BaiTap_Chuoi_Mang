using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ho ten: Tran Dinh Nguyen");
        Console.WriteLine("MSV: 2415053122225");
        Console.WriteLine("-------------------");
        Console.Write("Nhap so phan tu n: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Mang rong hoac khong hop le. Khong xu ly.");
            return;
        }
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap arr[{i}]: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        int max = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("Gia tri lon nhat trong mang la: " + max);
    }
}
