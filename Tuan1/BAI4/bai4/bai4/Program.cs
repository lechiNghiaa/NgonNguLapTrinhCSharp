using System;
namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap x: ");
            string x = Console.ReadLine();
            if (!int.TryParse(x, out int numx))
            {
                Console.WriteLine("x khong phai la so nguyen!");
                return;
            }

            Console.Write("Nhap y: ");
            string y = Console.ReadLine();
            if (!int.TryParse(y, out int numy))
            {
                Console.WriteLine("y khong phai la so nguyen!");
                return;
            }
            double result = Math.Pow(numx, numy);
            Console.WriteLine($"Ket qua {numx} mu {numy} la: {result}");
        }
    }
}