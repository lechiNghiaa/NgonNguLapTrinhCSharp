using System;

class ThiSinh
{
    protected string sbd;
    protected string hoTen;
    protected double bai1;
    protected double bai2;
    protected double bai3;

    // Nhập thông tin chung
    public virtual void Nhap()
    {
        Console.Write("Nhap SBD: ");
        sbd = Console.ReadLine();

        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();

        Console.Write("Nhap diem bai 1: ");
        bai1 = double.Parse(Console.ReadLine());

        Console.Write("Nhap diem bai 2: ");
        bai2 = double.Parse(Console.ReadLine());

        Console.Write("Nhap diem bai 3: ");
        bai3 = double.Parse(Console.ReadLine());
    }

    // Tính tổng điểm - lớp con sẽ ghi đè
    public virtual double TinhTongDiem()
    {
        return bai1 + bai2 + bai3;
    }

    // Xuất thông tin
    public virtual void Xuat()
    {
        Console.WriteLine("SBD: " + sbd);
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Tong diem: " + TinhTongDiem());
    }
}


// Thí sinh Chuyên
class ThiSinhChuyen : ThiSinh
{
    private double tiengAnh;

    public override void Nhap()
    {
        // Nhập thông tin chung
        base.Nhap();

        Console.Write("Nhap diem tieng Anh: ");
        tiengAnh = double.Parse(Console.ReadLine());
    }

    // Tổng 3 bài lập trình + điểm thưởng tiếng Anh
    public override double TinhTongDiem()
    {
        double tong = bai1 + bai2 + bai3;

        if (tiengAnh >= 7 && tiengAnh <= 8)
        {
            tong += 1;
        }
        else if (tiengAnh >= 9 && tiengAnh <= 10)
        {
            tong += 2;
        }

        return tong;
    }

    public override void Xuat()
    {
        Console.WriteLine("Loai: Chuyen");
        base.Xuat();
    }
}


// Thí sinh Siêu cúp
class ThiSinhSieuCup : ThiSinh
{
    private double csdl;

    public override void Nhap()
    {
        // Nhập thông tin chung
        base.Nhap();

        Console.Write("Nhap diem CSDL: ");
        csdl = double.Parse(Console.ReadLine());
    }

    // Tổng 4 bài thi
    public override double TinhTongDiem()
    {
        return bai1 + bai2 + bai3 + csdl;
    }

    public override void Xuat()
    {
        Console.WriteLine("Loai: Sieu cup");
        base.Xuat();
    }
}


class Program
{
    static void Main()
    {
        Console.Write("Nhap so luong thi sinh: ");
        int n = int.Parse(Console.ReadLine());

        // Mảng lớp cha có thể chứa cả 2 loại thí sinh
        ThiSinh[] ds = new ThiSinh[n];

        // Nhập danh sách
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nThi sinh thu " + (i + 1));
            Console.WriteLine("1. Chuyen");
            Console.WriteLine("2. Sieu cup");
            Console.Write("Chon: ");

            int chon = int.Parse(Console.ReadLine());

            if (chon == 1)
            {
                ds[i] = new ThiSinhChuyen();
            }
            else
            {
                ds[i] = new ThiSinhSieuCup();
            }

            ds[i].Nhap();
        }

        // Xuất kết quả
        Console.WriteLine("\n---- KET QUA ----");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nThi sinh thu " + (i + 1) + ":");
            ds[i].Xuat();
        }
    }
}