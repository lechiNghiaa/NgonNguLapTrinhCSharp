using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Khai báo mảng số nguyên
        int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };

        // a. Liệt kê các phần tử chia hết cho 4 và 3
        var cauA = mangSo.Where(x => x % 4 == 0 && x % 3 == 0);

        Console.WriteLine("a. Cac phan tu chia het cho 4 va 3:");
        Console.WriteLine(string.Join(", ", cauA));


        // b. Liệt kê các phần tử nhỏ hơn hoặc bằng 3
        var cauB = mangSo.Where(x => x <= 3);

        Console.WriteLine("\nb. Cac phan tu nho hon hoac bang 3:");
        Console.WriteLine(string.Join(", ", cauB));


        // c. Số chẵn chia đôi, số lẻ giữ nguyên
        var cauC = mangSo.Select(x => x % 2 == 0 ? x / 2 : x);

        Console.WriteLine("\nc. Day moi:");
        Console.WriteLine(string.Join(", ", cauC));
    }
}
