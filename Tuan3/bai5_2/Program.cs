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
        List<MonHoc> ds = DuLieu.DS_Mon();

        // a. Tổng số môn hiện có
        int cauA = ds.Count();

        Console.WriteLine("a. Tong so mon: " + cauA);


        // b. Đếm số môn có tên bắt đầu bằng "Lap trinh"
        int cauB = ds.Count(x => x.TenMon.StartsWith("Lap trinh"));

        Console.WriteLine("b. So mon bat dau bang 'Lap trinh': " + cauB);


        // c. Tính tổng số tiết của hệ KTV
        int cauC = ds
            .Where(x => x.He == "KTV")
            .Sum(x => x.SoTiet);

        Console.WriteLine("c. Tong so tiet cua he KTV: " + cauC);


        // d. Tổng số môn của mỗi hệ
        Console.WriteLine();
        Console.WriteLine("d. Tong so mon cua moi he:");

        var cauD = ds
            .GroupBy(x => x.He);

        foreach (var nhom in cauD)
        {
            Console.WriteLine(
                "He: " + nhom.Key +
                " - Tong so mon: " + nhom.Count()
            );
        }


        // e. Nhóm theo số tiết và sắp xếp giảm dần
        Console.WriteLine();
        Console.WriteLine("e. Thong ke theo so tiet:");

        var cauE = ds
            .GroupBy(x => x.SoTiet)
            .OrderByDescending(x => x.Key);

        foreach (var nhom in cauE)
        {
            Console.WriteLine(
                "So tiet: " + nhom.Key +
                " - Tong so mon: " + nhom.Count()
            );
        }


        // f. Tìm môn học có số tiết cao nhất
        Console.WriteLine();
        Console.WriteLine("f. Mon hoc co so tiet cao nhat:");

        byte soTietCaoNhat = ds.Max(x => x.SoTiet);

        var cauF = ds.Where(x => x.SoTiet == soTietCaoNhat);

        foreach (var mon in cauF)
        {
            Console.WriteLine(
                mon.MaMon + " - " +
                mon.TenMon + " - " +
                mon.He + " - " +
                mon.SoTiet + " tiet"
            );
        }


        // g. Thống kê theo hệ
        Console.WriteLine();
        Console.WriteLine("g. Thong ke theo He:");

        var cauG = ds
            .GroupBy(x => x.He);

        foreach (var nhom in cauG)
        {
            Console.WriteLine(
                "He: " + nhom.Key +
                " - Tong so mon: " + nhom.Count() +
                " - Tong so tiet: " + nhom.Sum(x => x.SoTiet) +
                " - Cao nhat: " + nhom.Max(x => x.SoTiet) +
                " - Thap nhat: " + nhom.Min(x => x.SoTiet)
            );
        }


        // h. Phân nhóm các môn học theo hệ
        Console.WriteLine();
        Console.WriteLine("h. Cac mon hoc phan nhom theo He:");

        var cauH = ds
            .GroupBy(x => x.He);

        foreach (var nhom in cauH)
        {
            Console.WriteLine();
            Console.WriteLine("He: " + nhom.Key);

            foreach (var mon in nhom)
            {
                Console.WriteLine(
                    mon.MaMon + " - " + mon.TenMon
                );
            }
        }


        // i. Phân nhóm theo số tiết và tăng dần theo số tiết
        Console.WriteLine();
        Console.WriteLine("i. Cac mon hoc phan nhom theo So tiet:");

        var cauI = ds
            .GroupBy(x => x.SoTiet)
            .OrderBy(x => x.Key);

        foreach (var nhom in cauI)
        {
            Console.WriteLine();
            Console.WriteLine("So tiet: " + nhom.Key);

            foreach (var mon in nhom)
            {
                Console.WriteLine(
                    mon.MaMon + " - " + mon.TenMon
                );
            }
        }


        // j. Với hệ KTV, phân nhóm theo HP2, HP3, HP4, HP5
        Console.WriteLine();
        Console.WriteLine("j. Phan nhom mon KTV theo HP2, HP3, HP4, HP5:");

        var cauJ = ds
            .Where(x => x.He == "KTV")
            .GroupBy(x => x.MaMon.Substring(0, 3))
            .OrderBy(x => x.Key);

        foreach (var nhom in cauJ)
        {
            Console.WriteLine();
            Console.WriteLine("Nhom " + nhom.Key + ":");

            foreach (var mon in nhom.OrderBy(x => x.MaMon))
            {
                Console.WriteLine(
                    mon.MaMon + " - " + mon.TenMon
                );
            }
        }


        // k. Phân nhóm theo hệ, chỉ lấy môn có số tiết > 40
        // Trong mỗi nhóm sắp xếp theo mã môn
        Console.WriteLine();
        Console.WriteLine("k. Phan nhom theo He, So tiet > 40:");

        var cauK = ds
            .Where(x => x.SoTiet > 40)
            .GroupBy(x => x.He);

        foreach (var nhom in cauK)
        {
            Console.WriteLine();
            Console.WriteLine("He: " + nhom.Key);

            foreach (var mon in nhom.OrderBy(x => x.MaMon))
            {
                Console.WriteLine(
                    mon.MaMon + " - " +
                    mon.TenMon + " - " +
                    mon.SoTiet + " tiet"
                );
            }
        }

        Console.ReadKey();
    }
}
