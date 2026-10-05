using System;

class DonThuc
{
    // Field: hệ số a và số mũ n
    private double a;
    private int n;

    // Constructor mặc định
    public DonThuc()
    {
        a = 0;
        n = 0;
    }

    // Constructor có tham số
    public DonThuc(double a, int n)
    {
        this.a = a;
        this.n = n;
    }

    // Property
    public double A
    {
        get { return a; }
        set { a = value; }
    }

    public int N
    {
        get { return n; }
        set { n = value; }
    }

    // Tính giá trị đơn thức a.x^n
    public double TinhGiaTri(double x)
    {
        return a * Math.Pow(x, n);
    }

    // Xuất đơn thức
    public override string ToString()
    {
        return a + "x^" + n;
    }
}


class DaThuc
{
    // Field: mảng chứa n+1 đơn thức
    private DonThuc[] ds;

    // Constructor mặc định
    public DaThuc()
    {
        ds = new DonThuc[0];
    }

    // Constructor có tham số: tạo đa thức bậc n
    public DaThuc(int n)
    {
        ds = new DonThuc[n + 1];

        for (int i = 0; i <= n; i++)
        {
            ds[i] = new DonThuc(0, i);
        }
    }

    // Copy Constructor: sao chép một đa thức
    public DaThuc(DaThuc p)
    {
        ds = new DonThuc[p.ds.Length];

        for (int i = 0; i < ds.Length; i++)
        {
            ds[i] = new DonThuc(p.ds[i].A, p.ds[i].N);
        }
    }

    // Indexer: truy cập đơn thức thứ i
    public DonThuc this[int i]
    {
        get { return ds[i]; }
        set { ds[i] = value; }
    }

    // Input(): nhập các hệ số của đa thức
    public void Input()
    {
        for (int i = 0; i < ds.Length; i++)
        {
            Console.Write("Nhap he so a" + i + ": ");
            double a = double.Parse(Console.ReadLine());

            ds[i] = new DonThuc(a, i);
        }
    }

    // Output(): xuất đa thức
    public void Output()
    {
        for (int i = ds.Length - 1; i >= 0; i--)
        {
            if (ds[i].A != 0)
            {
                if (i != ds.Length - 1 && ds[i].A > 0)
                    Console.Write("+");

                Console.Write(ds[i].A + "x^" + i);
            }
        }

        Console.WriteLine();
    }

    // TinhGiaTri(): tính giá trị P(x)
    public double TinhGiaTri(double x)
    {
        double result = 0;

        for (int i = 0; i < ds.Length; i++)
        {
            result += ds[i].TinhGiaTri(x);
        }

        return result;
    }


    // Main(): hàm chính để chạy chương trình
    static void Main()
    {
        // Nhập bậc của đa thức
        Console.Write("Nhap bac cua da thuc: ");
        int n = int.Parse(Console.ReadLine());

        // Tạo đa thức
        DaThuc p = new DaThuc(n);

        // Nhập đa thức
        p.Input();

        // Xuất đa thức
        Console.Write("\nP(x) = ");
        p.Output();

        // Nhập x
        Console.Write("\nNhap x: ");
        double x = double.Parse(Console.ReadLine());

        // Tính giá trị đa thức
        Console.WriteLine("P(" + x + ") = " + p.TinhGiaTri(x));

        // Thử Indexer
        Console.WriteLine("\nDon thuc thu 0: " + p[0]);
        Console.WriteLine("Don thuc thu 1: " + p[1]);
    }
}