using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ho ten: Tran Dinh Nguyen");
        Console.WriteLine("MSV: 2415053122225");
        Console.WriteLine("-------------------");
        Console.Write("Nhap mot cau: ");
        string s = Console.ReadLine();
        if (s == null)
        {
            Console.WriteLine("Chuoi null. Khong xu ly.");
            return;
        }
        string[] arr = s.Trim().Split(' ');
        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("Khong co tu de xu ly.");
            return;
        }
        string tuDaiNhat = "";
        int maxLen = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != "" && arr[i].Length > maxLen)
            {
                maxLen = arr[i].Length;
                tuDaiNhat = arr[i];
            }
        }
        Console.WriteLine("Tu dai nhat la: " + tuDaiNhat);
        Console.WriteLine("Do dai: " + maxLen);
    }
}
