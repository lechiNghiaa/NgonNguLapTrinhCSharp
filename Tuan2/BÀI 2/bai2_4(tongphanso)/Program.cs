using System;

class PhanSo
{
    // Field: tử số và mẫu số
    private int tu;
    private int mau;

    // Constructor mặc định
    public PhanSo()
    {
        tu = 0;
        mau = 1;
    }

    // Constructor có tham số
    public PhanSo(int tu, int mau)
    {
        this.tu = tu;
        this.mau = mau;
    }

    // Copy Constructor
    public PhanSo(PhanSo p)
    {
        tu = p.tu;
        mau = p.mau;
    }

    // Phép cộng 2 phân số
    public static PhanSo operator +(PhanSo a, PhanSo b)
    {
        return new PhanSo(
            a.tu * b.mau + b.tu * a.mau,
            a.mau * b.mau
        );
    }

    // ToString(): xuất phân số
    public override string ToString()
    {
        return tu + "/" + mau;
    }
}


class DayPhanSo
{
    // Field: mảng chứa các phân số
    private PhanSo[] ds;

    // Constructor mặc định
    public DayPhanSo()
    {
        ds = new PhanSo[0];
    }

    // Constructor có tham số: tạo dãy n phân số
    public DayPhanSo(int n)
    {
        ds = new PhanSo[n];

        for (int i = 0; i < n; i++)
        {
            ds[i] = new PhanSo();
        }
    }

    // Copy Constructor
    public DayPhanSo(DayPhanSo d)
    {
        ds = new PhanSo[d.ds.Length];

        for (int i = 0; i < ds.Length; i++)
        {
            ds[i] = new PhanSo(d.ds[i]);
        }
    }

    // Indexer: truy cập phân số thứ i
    public PhanSo this[int i]
    {
        get { return ds[i]; }
        set { ds[i] = value; }
    }

    // Input(): nhập các phân số
    public void Input()
    {
        for (int i = 0; i < ds.Length; i++)
        {
            Console.Write("Nhap phan so thu " + (i + 1) + ": ");

            string[] p = Console.ReadLine().Split('/');

            int tu = int.Parse(p[0]);
            int mau = int.Parse(p[1]);

            ds[i] = new PhanSo(tu, mau);
        }
    }

    // Output(): xuất các phân số
    public void Output()
    {
        for (int i = 0; i < ds.Length; i++)
        {
            Console.Write(ds[i] + " ");
        }

        Console.WriteLine();
    }

    // TinhTong(): tính tổng n phân số
    public PhanSo TinhTong()
    {
        PhanSo tong = new PhanSo();

        for (int i = 0; i < ds.Length; i++)
        {
            tong = tong + ds[i];
        }

        return tong;
    }


    // Main(): hàm chính để chạy chương trình
    static void Main()
    {
        // Nhập số lượng phân số
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        // Tạo dãy n phân số
        DayPhanSo ds = new DayPhanSo(n);

        // Nhập dãy phân số
        ds.Input();

        // Xuất dãy phân số
        Console.Write("\nDay phan so: ");
        ds.Output();

        // Tính và xuất tổng
        Console.WriteLine("Tong cac phan so = " + ds.TinhTong());
    }
}