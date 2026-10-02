using System;
namespace bai6
{
    class Program
    {
        public static int max(int a, int b, int c)
        {
            return (a > b && a > c) ? a : (b > c) ? b : c;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen thu nhat: ");
            int a = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap so ngyen thu hai: ");
            int b = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap so nguyen thu ba: ");
            int c = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Gia tri lon nhat la: {0}", max(a, b, c));
        }
    }
}
