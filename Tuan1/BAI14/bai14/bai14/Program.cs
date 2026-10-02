using System;
namespace bai14
{
    class NhanVien
    {
        // các thuộc tính lưu thông tin nhân viên
        public string HoTen;
        public double MucLuong;
        public int SoNgayVang;
        public void Nhap()
        {
            Console.Write("Nhap ho ten nhan vien: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap muc luong (VNĐ): ");
            MucLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay vang: ");
            SoNgayVang = int.Parse(Console.ReadLine());
        }

        // tính lương thực nhận
        public double TinhLuong()
        {
            return MucLuong - (SoNgayVang * 100000);
        }

        // phương thức thành viên: Xuất thông tin
        public void Xuat()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Ho ten nhan vien: {HoTen}");
            Console.WriteLine($"Muc luong ban dau: {MucLuong:N0} VNĐ"); //N0 để định dạng số với dấu phân cách hàng nghìn
            Console.WriteLine($"So ngay vang: {SoNgayVang}");
            Console.WriteLine($"Luong nhan duoc: {TinhLuong():N0} VNĐ");
        }
    }
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            NhanVien nv = new NhanVien();// khởi tạo đối tượng và gọi phương thức
            nv.Nhap();
            nv.Xuat();
        }
    }
}