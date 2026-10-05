using System;
using System.Collections.Generic;

public class He
{
    // Khai báo các thuộc tính
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";
}

public class DuLieu
{
    // Tạo danh sách hệ
    public static List<He> DS_He()
    {
        List<He> ds = new List<He>();

        ds.Add(new He
        {
            MaHe = "KTV",
            TenHe = "Ky thuat vien"
        });

        ds.Add(new He
        {
            MaHe = "CD",
            TenHe = "Chuyen de"
        });

        ds.Add(new He
        {
            MaHe = "QT",
            TenHe = "Chung chi quoc te"
        });

        return ds;
    }
}

class Program
{
    static void Main()
    {
        // Lấy danh sách hệ
        List<He> ds = DuLieu.DS_He();

        // Xuất danh sách hệ
        Console.WriteLine("DANH SACH HE");

        foreach (He he in ds)
        {
            Console.WriteLine(
                "Ma he: " + he.MaHe +
                " - Ten he: " + he.TenHe
            );
        }

        Console.ReadKey();
    }
}