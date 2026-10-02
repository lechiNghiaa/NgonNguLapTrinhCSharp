//Xây dựng lớp có phương thức hoán vị hai số thực.
using System;
namespace bai8
{
    class Program
    {
        public static void HoanVi(ref double a, ref double b) // Phương thức hoán vị hai số thực

        {
            double temp = a; // Lưu giá trị của a vào biến tạm thời
            a = b; // Gán giá trị của b cho a
            b = temp; // Gán giá trị của biến tạm thời cho b
        }
        public static void Main(string[] args)
        {
            Console.Write("Nhap so thuc thu nhat: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc thu hai: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Truoc khi hoan vi: " + num1 + " " + num2); // In ra giá trị trước khi hoán vị
            HoanVi(ref num1, ref num2);
            Console.WriteLine("Sau khi hoan vi: " + num1 + " " + num2); // In ra giá trị sau khi hoán vị
        }
    }
}