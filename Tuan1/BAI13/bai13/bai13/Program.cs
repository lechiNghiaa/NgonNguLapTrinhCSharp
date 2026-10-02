using System;
namespace bai13
{
    class SinhVien
    {
        // các thuộc tính lưu thông tin sinh viên
        public string MaSV { get; set; }
        public string HoTen { get; set; } 
        public string DiaChi { get; set; } 
        public int NamHoc { get; set; } 
        public void NhapThongTin()
        {
            Console.Write("Nhap ma sinh vien: ");
            MaSV = Console.ReadLine(); // nhập mã sinh viên
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine(); // nhập họ tên sinh viên
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();// nhập địa chỉ sinh viên
            Console.Write("Nhap nam thu may: ");
            NamHoc = int.Parse(Console.ReadLine()); // nhập năm thứ mấy
        }
        public void XuatThongTin()// xuất thông tin sinh viên
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Ma sinh vien: " + MaSV);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("Nam thu may: " + NamHoc);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien(); // tạo đối tượng sinh viên
            sv.NhapThongTin(); // gọi phương thức nhập thông tin sinh viên
            sv.XuatThongTin(); // gọi phương thức xuất thông tin sinh viên
        }
    }
}
