
using System;
namespace bai12
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Nhap chuoi: ");
            string text = Console.ReadLine();
            string chuoiThuong = text.ToLower();// Chuyển sang chữ thường và chữ hoa
            string chuoiHoa = text.ToUpper();
            string[] danhSachTu = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);// Cắt chuỗi dựa trên khoảng trắng và loại bỏ các khoảng trắng thừa
            int soTu = danhSachTu.Length;// Đếm số từ trong chuỗi
            Console.WriteLine($"Chuoi chu thuong {chuoiThuong}");
            Console.WriteLine($"Chuoi chu hoa:    {chuoiHoa}");
            Console.WriteLine($"So tu trong chuoi: {soTu}");
        }
    }
}