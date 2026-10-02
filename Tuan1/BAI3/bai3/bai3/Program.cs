using System;
namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            int y = int.Parse(Console.ReadLine());
            double result = Math.Pow(x, y);
            Console.WriteLine($"Ket qua {x} mu {y} la {result}");
        }
    }
}
