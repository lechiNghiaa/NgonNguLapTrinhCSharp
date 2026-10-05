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

public class He
{
    // Khai báo các thuộc tính của hệ
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";
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
        List<MonHoc> dsMon = DuLieu.DS_Mon();
        List<He> dsHe = DuLieu.DS_He();

        // a. Dùng Join để lấy Tên hệ, Mã môn, Tên môn
        Console.WriteLine("a. JOIN:");

        var cauA = dsHe.Join(
            dsMon,
            h => h.MaHe,
            m => m.He,
            (h, m) => new
            {
                TenHe = h.TenHe,
                MaMon = m.MaMon,
                TenMon = m.TenMon
            });

        foreach (var x in cauA)
        {
            Console.WriteLine(
                x.TenHe + " - " +
                x.MaMon + " - " +
                x.TenMon
            );
        }


        // b. Left outer join, lấy cả hệ chưa có môn học
        Console.WriteLine();
        Console.WriteLine("b. LEFT OUTER JOIN:");

        var cauB = dsHe.GroupJoin(
            dsMon,
            h => h.MaHe,
            m => m.He,
            (h, mon) => new
            {
                He = h,
                MonHoc = mon
            })
            .SelectMany(
                x => x.MonHoc.DefaultIfEmpty(),
                (x, m) => new
                {
                    TenHe = x.He.TenHe,
                    MaMon = m?.MaMon,
                    TenMon = m?.TenMon
                });

        foreach (var x in cauB)
        {
            Console.WriteLine(
                x.TenHe + " - " +
                (x.MaMon ?? "Khong co") + " - " +
                (x.TenMon ?? "Khong co")
            );
        }


        // c. Lấy cả hệ chưa có môn và môn chưa khai báo hệ
        Console.WriteLine();
        Console.WriteLine("c. HE CHUA CO MON VA MON CHUA KHAI BAO HE:");

        var phanHe = dsHe.GroupJoin(
            dsMon,
            h => h.MaHe,
            m => m.He,
            (h, mon) => new
            {
                He = h,
                MonHoc = mon
            })
            .SelectMany(
                x => x.MonHoc.DefaultIfEmpty(),
                (x, m) => new
                {
                    MaHe = x.He.MaHe,
                    TenHe = x.He.TenHe,
                    MaMon = m?.MaMon,
                    TenMon = m?.TenMon
                });

        foreach (var x in phanHe)
        {
            Console.WriteLine(
                x.TenHe + " - " +
                (x.MaMon ?? "Khong co mon")
            );
        }

        var monChuaHe = dsMon
            .Where(m => !dsHe.Any(h => h.MaHe == m.He));

        foreach (var m in monChuaHe)
        {
            Console.WriteLine(
                "Khong co he - " +
                m.MaMon + " - " +
                m.TenMon
            );
        }


        // d. Chỉ lấy hệ chưa có môn và môn chưa khai báo hệ
        Console.WriteLine();
        Console.WriteLine("d. HE CHUA CO MON VA MON CHUA KHAI BAO HE:");

        var heChuaMon = dsHe
            .Where(h => !dsMon.Any(m => m.He == h.MaHe));

        foreach (var h in heChuaMon)
        {
            Console.WriteLine(
                "He chua co mon: " +
                h.MaHe + " - " + h.TenHe
            );
        }

        foreach (var m in monChuaHe)
        {
            Console.WriteLine(
                "Mon chua khai bao he: " +
                m.MaMon + " - " + m.TenMon
            );
        }


        // e. Lấy 5 môn có số tiết giảm dần
        Console.WriteLine();
        Console.WriteLine("e. 5 MON CO SO TIET CAO NHAT:");

        var cauE = dsMon
            .OrderByDescending(m => m.SoTiet)
            .Take(5)
            .Join(
                dsHe,
                m => m.He,
                h => h.MaHe,
                (m, h) => new
                {
                    TenHe = h.TenHe,
                    MaMon = m.MaMon,
                    TenMon = m.TenMon,
                    SoTiet = m.SoTiet
                });

        foreach (var x in cauE)
        {
            Console.WriteLine(
                x.TenHe + " - " +
                x.MaMon + " - " +
                x.TenMon + " - " +
                x.SoTiet + " tiet"
            );
        }


        // f. Tổng số môn học của mỗi hệ
        Console.WriteLine();
        Console.WriteLine("f. TONG SO MON CUA MOI HE:");

        var cauF = dsHe.GroupJoin(
            dsMon,
            h => h.MaHe,
            m => m.He,
            (h, mon) => new
            {
                MaHe = h.MaHe,
                TenHe = h.TenHe,
                TongSoMon = mon.Count()
            });

        foreach (var x in cauF)
        {
            Console.WriteLine(
                x.MaHe + " - " +
                x.TenHe + " - " +
                x.TongSoMon
            );
        }


        // g. Đếm số loại số tiết khác nhau
        Console.WriteLine();
        Console.WriteLine("g. SO LOAI SO TIET KHAC NHAU:");

        int cauG = dsMon
            .Select(m => m.SoTiet)
            .Distinct()
            .Count();

        Console.WriteLine(cauG);


        // h. Tìm môn đầu tiên bắt đầu bằng "Lap trinh"
        Console.WriteLine();
        Console.WriteLine("h. MON DAU TIEN BAT DAU BANG 'Lap trinh':");

        var cauH = dsMon
            .FirstOrDefault(m => m.TenMon.StartsWith("Lap trinh"));

        if (cauH != null)
        {
            Console.WriteLine(
                cauH.MaMon + " - " +
                cauH.TenMon
            );
        }


        // i. Liệt kê môn theo từng hệ và đánh số thứ tự
        Console.WriteLine();
        Console.WriteLine("i. CAC MON THEO TUNG HE:");

        var cauI = dsMon
            .Where(m => dsHe.Any(h => h.MaHe == m.He))
            .GroupBy(m => m.He);

        foreach (var nhom in cauI)
        {
            var he = dsHe.First(h => h.MaHe == nhom.Key);

            Console.WriteLine();
            Console.WriteLine("He: " + he.TenHe);

            int stt = 1;

            foreach (var mon in nhom.OrderBy(m => m.MaMon))
            {
                Console.WriteLine(
                    stt + ". " +
                    mon.MaMon + " - " +
                    mon.TenMon
                );

                stt++;
            }
        }

        Console.ReadKey();
    }
}

