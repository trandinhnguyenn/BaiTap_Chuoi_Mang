using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Ho ten: Tran Dinh Nguyen");
        Console.WriteLine("MSV: 2415053122225");
        Console.WriteLine("-------------------");
        // Khai bao mang string (code san)
        string[] arr = {
            "Toi"," ", null, "Dinh", null, "Bac",""
        };
        int dem = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != null && arr[i] != "")
            {
                dem++;
            }
        }
        Console.WriteLine("So chuoi khac null va khac rong: " + dem);
    }
}
