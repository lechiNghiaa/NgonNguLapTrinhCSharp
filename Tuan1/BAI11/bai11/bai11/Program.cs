using System;
namespace bai11
{
    public class Program
    {
        public static string ChuoiDaoNguoc(string str)
        {
            char[] charArray = str.ToCharArray(); // Chuyển chuỗi thành mảng kí tự
            Array.Reverse(charArray); // Hàm tự động đảo ngược mảng
            return new string(charArray); // trả về mảng kí tự đã đảo ngược thành chuỗi
        }

        public static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string str = Console.ReadLine();
            str = ChuoiDaoNguoc(str); // Gọi phương thức để đảo ngược chuỗi
            Console.WriteLine("Chuoi dao nguoc: " + str); //in ra chuỗi đảo ngược
        }
    }
}