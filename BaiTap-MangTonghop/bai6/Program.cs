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
        int[] arr = null;
        if (n > 0)
        {
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap arr[{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        if (arr == null)
        {
            Console.WriteLine("So phan tu chan: 0");
            return;
        }
        int dem = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                dem++;
            }
        }
        Console.WriteLine("So phan tu chan trong mang la: " + dem);
    }
}
