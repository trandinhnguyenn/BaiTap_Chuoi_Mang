using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Ho ten: Tran Dinh Nguyen");
        Console.WriteLine("MSV: 2415053122225");
        Console.WriteLine("-------------------");
        Console.Write("Nhap ho ten: ");
        string hoten = Console.ReadLine();
        if (hoten == null)
        {
            Console.WriteLine("Chuoi null. Khong tach.");
            return;
        }
        string[] arr = hoten.Trim().Split(' ');
        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("Mang ket qua rong. Khong in.");
            return;
        }
        Console.WriteLine("Cac tu trong chuoi:");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != "")
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
