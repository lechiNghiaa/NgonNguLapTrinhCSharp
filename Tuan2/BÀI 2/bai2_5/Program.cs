using System;

class NhanVien
{
    // Field: thông tin nhân viên
    private string hoTen;
    private double luong;
    private int soNgayVang;

    // Constructor mặc định
    public NhanVien()
    {
        hoTen = "";
        luong = 0;
        soNgayVang = 0;
    }

    // Constructor có tham số
    public NhanVien(string hoTen, double luong, int soNgayVang)
    {
        this.hoTen = hoTen;
        this.luong = luong;
        this.soNgayVang = soNgayVang;
    }

    // Copy Constructor
    public NhanVien(NhanVien nv)
    {
        hoTen = nv.hoTen;
        luong = nv.luong;
        soNgayVang = nv.soNgayVang;
    }

    // TinhLuong(): tính lương thực nhận của nhân viên
    public double TinhLuong()
    {
        return luong - soNgayVang * 100000;
    }

    // Input(): nhập thông tin nhân viên
    public void Input()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();

        Console.Write("Nhap muc luong: ");
        luong = double.Parse(Console.ReadLine());

        Console.Write("Nhap so ngay vang: ");
        soNgayVang = int.Parse(Console.ReadLine());
    }

    // Output(): xuất thông tin nhân viên
    public void Output()
    {
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Luong thuc nhan: " + TinhLuong() + " VNĐ");
    }
}


class PhongBan
{
    // Field: mảng chứa các nhân viên
    private NhanVien[] ds;

    // Constructor mặc định
    public PhongBan()
    {
        ds = new NhanVien[0];
    }

    // Constructor có tham số: tạo phòng ban có n nhân viên
    public PhongBan(int n)
    {
        ds = new NhanVien[n];

        for (int i = 0; i < n; i++)
        {
            ds[i] = new NhanVien();
        }
    }

    // Copy Constructor
    public PhongBan(PhongBan p)
    {
        ds = new NhanVien[p.ds.Length];

        for (int i = 0; i < ds.Length; i++)
        {
            ds[i] = new NhanVien(p.ds[i]);
        }
    }

    // Indexer: truy cập nhân viên thứ i
    public NhanVien this[int i]
    {
        get { return ds[i]; }
        set { ds[i] = value; }
    }

    // Input(): nhập danh sách nhân viên
    public void Input()
    {
        for (int i = 0; i < ds.Length; i++)
        {
            Console.WriteLine("\nNhap nhan vien thu " + (i + 1) + ":");
            ds[i].Input();
        }
    }

    // Output(): xuất danh sách nhân viên
    public void Output()
    {
        for (int i = 0; i < ds.Length; i++)
        {
            Console.WriteLine("\nNhan vien thu " + (i + 1) + ":");
            ds[i].Output();
        }
    }

    // TinhTongLuong(): tính tổng lương của phòng ban
    public double TinhTongLuong()
    {
        double tong = 0;

        for (int i = 0; i < ds.Length; i++)
        {
            tong += ds[i].TinhLuong();
        }

        return tong;
    }


    // Main(): hàm chính để chạy chương trình
    static void Main()
    {
        // Nhập số lượng nhân viên
        Console.Write("Nhap so nhan vien: ");
        int n = int.Parse(Console.ReadLine());

        // Tạo phòng ban
        PhongBan pb = new PhongBan(n);

        // Nhập thông tin nhân viên
        pb.Input();

        // Xuất danh sách nhân viên
        Console.WriteLine("\n===== DANH SACH NHAN VIEN =====");
        pb.Output();

        // Tính tổng lương phòng ban
        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("Tong luong phong ban: "
            + pb.TinhTongLuong() + " VNĐ");
    }
}