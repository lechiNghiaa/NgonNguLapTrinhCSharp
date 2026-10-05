using System;
using System.Collections.Generic;

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
    // Phương thức tạo danh sách môn học
    public static List<MonHoc> DS_Mon()
    {
        List<MonHoc> ds = new List<MonHoc>();

        // Thêm các môn học vào danh sách
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
        // Gọi phương thức DS_Mon() để lấy danh sách môn học
        List<MonHoc> ds = DuLieu.DS_Mon();

        // Xuất danh sách môn học
        Console.WriteLine("DANH SACH MON HOC");
        Console.WriteLine("-----------------------------------------------");

        foreach (MonHoc mon in ds)
        {
            Console.WriteLine(
                "Ma mon: " + mon.MaMon +
                " | Ten mon: " + mon.TenMon +
                " | He: " + mon.He +
                " | So tiet: " + mon.SoTiet
            );
        }

        Console.ReadKey();
    }
}
