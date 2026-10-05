using System;

class SinhVien : IComparable<SinhVien>
{
    // Field
    private string hoTen;
    private int namSinh;

    // Constructor
    public SinhVien(string hoTen, int namSinh)
    {
        this.hoTen = hoTen;
        this.namSinh = namSinh;
    }

    // Input(): nhập thông tin sinh viên
    public void Input()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();

        Console.Write("Nhap nam sinh: ");
        namSinh = int.Parse(Console.ReadLine());
    }

    // Output(): xuất thông tin sinh viên
    public void Output()
    {
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Nam sinh: " + namSinh);
    }

    // CompareTo(): sắp xếp sinh viên theo họ tên
    public int CompareTo(SinhVien other)
    {
        return hoTen.CompareTo(other.hoTen);
    }
}


class Program
{
    static void Main()
    {
        // Nhập số lượng sinh viên
        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine());

        // Tạo mảng sinh viên
        SinhVien[] ds = new SinhVien[n];

        // Nhập danh sách sinh viên
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nNhap sinh vien thu " + (i + 1) + ":");

            ds[i] = new SinhVien("", 0);
            ds[i].Input();
        }

        // Xuất danh sách trước khi sắp xếp
        Console.WriteLine("\nDanh sach truoc khi sap xep: ");
        Console.WriteLine("----------------------------");

        foreach (SinhVien sv in ds)
        {
            sv.Output();
            Console.WriteLine();
        }

        // Sắp xếp danh sách
        Array.Sort(ds);

        // Xuất danh sách sau khi sắp xếp
        Console.WriteLine("Danh sach sau khi sap xep: ");
        Console.WriteLine("----------------------------");

        foreach (SinhVien sv in ds)
        {
            sv.Output();
            Console.WriteLine();
        }
    }
}