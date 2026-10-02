using System;
namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0; 
            int choice; 
            do
            {
                Console.WriteLine("--MENU--");
                Console.WriteLine("1. Nhap x va y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");
                choice = int.Parse(Console.ReadLine()); 
                switch (choice)
                {
                    case 1: 
                        Console.Write("Nhap x: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Nhap y: ");
                        y = double.Parse(Console.ReadLine());
                        break;
                    case 2: 
                        Console.WriteLine($"Ket qua {x}^{y} = {Math.Pow(x, y)}");
                        break;
                    case 3: 
                        Console.WriteLine($"Can bac 2 cua {x} = {Math.Sqrt(x)}");
                        Console.WriteLine($"Can bac 2 cua {y} = {Math.Sqrt(y)}");
                        break;
                    case 4: 
                        Console.WriteLine("Thoat chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                        break;
                }
            }while (choice != 4); 
        }
    }
}