using System;

class NhanVien
{
    protected string maNV;
    protected string hoTen;

    // Nhập thông tin chung
    public virtual void Nhap()
    {
        Console.Write("\nNhap ma nhan vien: ");
        maNV = Console.ReadLine();

        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();
    }

    // Tính lương - lớp con sẽ ghi đè
    public virtual double TinhLuong()
    {
        return 0;
    }

    // Xuất thông tin
    public virtual void Xuat()
    {
        Console.WriteLine("Ma NV: " + maNV);
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Luong: " + TinhLuong());
    }
}

// Nhân viên kinh doanh
class NhanVienKinhDoanh : NhanVien
{
    private double luongCoBan;
    private int soHopDong;

    public override void Nhap()
    {
        // Nhập mã và họ tên từ lớp cha
        base.Nhap();

        Console.Write("Nhap luong co ban: ");
        luongCoBan = double.Parse(Console.ReadLine());

        Console.Write("Nhap so hop dong: ");
        soHopDong = int.Parse(Console.ReadLine());
    }

    // Lương = lương cơ bản + 500.000 * số hợp đồng
    public override double TinhLuong()
    {
        return luongCoBan + soHopDong * 500000;
    }
}

// Nhân viên sản xuất
class NhanVienSanXuat : NhanVien
{
    private int soSanPham;

    public override void Nhap()
    {
        // Nhập mã và họ tên từ lớp cha
        base.Nhap();

        Console.Write("Nhap so san pham: ");
        soSanPham = int.Parse(Console.ReadLine());
    }

    // Lương = số sản phẩm * 1000
    // Nếu trên 3000 sản phẩm thì thưởng thêm 5%
    public override double TinhLuong()
    {
        double luong = soSanPham * 1000;

        if (soSanPham > 3000)
        {
            luong = luong * 1.05;
        }

        return luong;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhap so luong nhan vien: ");
        int n = int.Parse(Console.ReadLine());

        // Mảng kiểu lớp cha để thể hiện đa hình
        NhanVien[] ds = new NhanVien[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nNhan vien thu " + (i + 1));
            Console.WriteLine("1. Nhan vien kinh doanh");
            Console.WriteLine("2. Nhan vien san xuat");
            Console.Write("Chon: ");

            int chon = int.Parse(Console.ReadLine());

            if (chon == 1)
            {
                ds[i] = new NhanVienKinhDoanh();
            }
            else
            {
                ds[i] = new NhanVienSanXuat();
            }

            // Gọi Nhap() của lớp con
            ds[i].Nhap();
        }

        // Xuất danh sách và tính lương
        Console.WriteLine("\nDanh sanh nhan vien: ");
        Console.WriteLine("----------------------");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nNhan vien thu " + (i + 1) + ":");
            ds[i].Xuat();
        }
    }
}