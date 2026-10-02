using System;
namespace bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thuc thu nhat: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc thu hai: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc thu ba: ");
            double c = double.Parse(Console.ReadLine());
            double max, min; //khai báo biến max và min để lưu giá trị lớn nhất và nhỏ nhất
            FindMaxMin(a, b, c, out max, out min); //gọi phương thức FindMaxMin để tìm giá trị lớn nhất và nhỏ nhất
            Console.WriteLine($"Gia tri lon nhat: {max}");
            Console.WriteLine($"Gia tri nho nhat: {min}");
        }
        static void FindMaxMin(double x, double y, double z, out double max, out double min)
        //phương thức FindMaxMin nhận vào 3 số thực và trả về giá trị lớn nhất và nhỏ nhất thông qua tham chiếu out
        {
            max = Math.Max(x, Math.Max(y, z));
            min = Math.Min(x, Math.Min(y, z));
        }
    }
}
