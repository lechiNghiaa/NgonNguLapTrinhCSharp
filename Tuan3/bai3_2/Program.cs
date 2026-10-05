using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Khai báo mảng món ăn
        string[] monAn =
        {
            "Bun bo Hue",
            "Hu tieu heo",
            "Banh canh",
            "Banh mi",
            "Nuoc Ca phe",
            "Mi quang",
            "Com tam",
            "Nuoc Chanh day",
            "Mi xao",
            "Bun rieu",
            "Banh cuon",
            "Mi goi",
            "Bun cha",
            "Hu tieu Nam vang"
        };

        // a. Tìm món ăn có tên ngắn nhất và dài nhất

        int doDaiNhoNhat = monAn.Min(x => x.Length);
        int doDaiLonNhat = monAn.Max(x => x.Length);

        var monNganNhat = monAn.Where(x => x.Length == doDaiNhoNhat);
        var monDaiNhat = monAn.Where(x => x.Length == doDaiLonNhat);

        Console.WriteLine("a. Mon an ngan nhat:");
        foreach (var mon in monNganNhat)
        {
            Console.WriteLine(mon);
        }

        Console.WriteLine();

        Console.WriteLine("Mon an dai nhat:");
        foreach (var mon in monDaiNhat)
        {
            Console.WriteLine(mon);
        }


        // b. Gom nhom mon an theo tu dau tien

        var nhomMonAn = monAn.GroupBy(x => x.Split(' ')[0]);

        Console.WriteLine();
        Console.WriteLine("b. Gom nhom mon an theo tu dau:");

        foreach (var nhom in nhomMonAn)
        {
            Console.WriteLine();
            Console.WriteLine("Nhom " + nhom.Key + ":");

            foreach (var mon in nhom)
            {
                Console.WriteLine(mon);
            }
        }


        // c. Dem so mon an bat dau bang "Banh"

        int soMonBanh = monAn.Count(x => x.StartsWith("Banh "));

        Console.WriteLine();
        Console.WriteLine("c. So mon an bat dau bang 'Banh': " + soMonBanh);

        Console.ReadKey();
    }
}
