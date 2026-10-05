using System;
using System.Collections.Generic;
using System.Linq;

public class MonHoc
{
    // Khai báo các thuộc tính của môn học
    public string MaMon { get; set; } = "";
    public string TenMon { get; set; } = "";
    public string He { get; set; } = "";
    public byte SoTiet { get; set; }
}

public class DuLieu
{
    // Tạo danh sách môn học
    public static List<MonHoc> DS_Mon()
    {
        List<MonHoc> ds = new List<MonHoc>();

        ds.Add(new MonHoc
        {
            MaMon = "HP2_1",
            TenMon = "Nen tang C#",
            He = "KTV",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "HP2_2",
            TenMon = "Cong nghe ADO.NET",
            He = "KTV",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "HP3_1",
            TenMon = "Lap trinh Windows Forms",
            He = "KTV",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "HP3_2",
            TenMon = "Xay dung ung dung Windows Forms",
            He = "KTV",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "HP4_1",
            TenMon = "Lap trinh Web voi HTML, CSS va JavaScript",
            He = "KTV",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "HP4_2",
            TenMon = "Xay dung ung dung Web voi ASP.NET",
            He = "KTV",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "HP5_1",
            TenMon = "Lap trinh CSDL SQL Server can ban",
            He = "KTV",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "HP5_2",
            TenMon = "Lap trinh CSDL SQL Server nang cao",
            He = "KTV",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "JLCB",
            TenMon = "Joomla co ban",
            He = "CD",
            SoTiet = 72
        });

        ds.Add(new MonHoc
        {
            MaMon = "LINQ",
            TenMon = "Language-Integrated Query",
            He = "CD",
            SoTiet = 64
        });

        ds.Add(new MonHoc
        {
            MaMon = "DAWEB",
            TenMon = "Do an thuc te Web voi ASP.NET",
            He = "CD",
            SoTiet = 40
        });

        ds.Add(new MonHoc
        {
            MaMon = "DAWIN",
            TenMon = "Do an thuc te Windows Forms",
            He = "CD",
            SoTiet = 40
        });

        ds.Add(new MonHoc
        {
            MaMon = "CC++",
            TenMon = "Lap trinh huong doi tuong voi C/C++",
            He = "CD",
            SoTiet = 128
        });

        ds.Add(new MonHoc
        {
            MaMon = "JQUE",
            TenMon = "JQuery",
            He = "CD",
            SoTiet = 22
        });

        ds.Add(new MonHoc
        {
            MaMon = "XML",
            TenMon = "Cong nghe XML",
            He = "CD",
            SoTiet = 32
        });

        ds.Add(new MonHoc
        {
            MaMon = "CRYS",
            TenMon = "Crystal Report trong Visual Studio",
            He = "CD",
            SoTiet = 32
        });

        ds.Add(new MonHoc
        {
            MaMon = "BWEB",
            TenMon = "HTML, CSS va JavaScript",
            He = "CD",
            SoTiet = 32
        });

        ds.Add(new MonHoc
        {
            MaMon = "XYZ",
            TenMon = "Chua dat ten mon",
            He = "",
            SoTiet = 0
        });

        return ds;
    }
}

class Program
{
    static void Main()
    {
        // Lấy danh sách môn học
        List<MonHoc> ds = DuLieu.DS_Mon();

        // a. Liệt kê tên môn bắt đầu bằng "Lap trinh"
        Console.WriteLine("a. Cac mon hoc bat dau bang 'Lap trinh':");

        var cauA = ds.Where(x => x.TenMon.StartsWith("Lap trinh"));

        foreach (var mon in cauA)
        {
            Console.WriteLine(mon.TenMon);
        }

        // b. Lọc hệ CD và sắp xếp số tiết giảm dần, mã môn tăng dần
        Console.WriteLine();
        Console.WriteLine("b. Cac mon thuoc he CD:");

        var cauB = ds
            .Where(x => x.He == "CD")
            .OrderByDescending(x => x.SoTiet)
            .ThenBy(x => x.MaMon);

        foreach (var mon in cauB)
        {
            Console.WriteLine(
                mon.MaMon + " - " +
                mon.TenMon + " - " +
                mon.SoTiet + " tiet"
            );
        }

        // c. Tìm môn có tên chứa "web", chỉ lấy Tên môn và Hệ
        Console.WriteLine();
        Console.WriteLine("c. Cac mon co ten chua tu 'web':");

        var cauC = ds
            .Where(x => x.TenMon.ToLower().Contains("web"))
            .Select(x => new
            {
                TenMon = x.TenMon,
                He = x.He
            });

        foreach (var mon in cauC)
        {
            Console.WriteLine(
                "Ten mon: " + mon.TenMon +
                " - He: " + mon.He
            );
        }

        // d. Lọc hệ KTV và sắp xếp mã môn tăng dần
        Console.WriteLine();
        Console.WriteLine("d. Cac mon thuoc he KTV:");

        var cauD = ds
            .Where(x => x.He == "KTV")
            .OrderBy(x => x.MaMon);

        foreach (var mon in cauD)
        {
            Console.WriteLine(
                mon.MaMon + " - " +
                mon.TenMon + " - " +
                mon.SoTiet + " tiet"
            );
        }

        Console.ReadKey();
    }
}