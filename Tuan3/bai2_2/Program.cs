using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Khai báo mảng chuỗi
        string[] mangChuoi =
        {
            "dau", "long", "hai", "a", "to", "nga",
            "Thuy", "Kieu", "la", "chi", "em", "la",
            "Thuy", "Van"
        };

        // a. Liệt kê các phần tử có 4 ký tự và sắp xếp tăng dần
        var cauA = mangChuoi
            .Where(x => x.Length == 4)
            .OrderBy(x => x[0]);

        Console.WriteLine("a. Cac phan tu co 4 ky tu:");
        Console.WriteLine(string.Join(", ", cauA));


        // b. Biến đổi thành: chữ thường - CHỮ HOA
        var cauB = mangChuoi
            .Select(x => x.ToLower() + " - " + x.ToUpper());

        Console.WriteLine("\nb. Chuyen doi chuoi:");
        foreach (var x in cauB)
        {
            Console.WriteLine(x);
        }


        // c. Liệt kê các phần tử có chứa ký tự u
        var cauC = mangChuoi
            .Where(x => x.ToLower().Contains("u"));

        Console.WriteLine("\nc. Cac phan tu chua ky tu u:");
        Console.WriteLine(string.Join(", ", cauC));


        // d. Liệt kê các từ bắt đầu bằng chữ in hoa
        var cauD = mangChuoi
            .Where(x => char.IsUpper(x[0]));

        Console.WriteLine("\nd. Cac tu bat dau bang chu in hoa:");
        Console.WriteLine(string.Join(" ", cauD));
    }
}
