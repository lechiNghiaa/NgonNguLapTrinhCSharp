using System;
class DonThuc
{
    // Field: a là hệ số, n là số mũ
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

    // TinhGiaTri(): tính giá trị P(x) = a.x^n
    public double TinhGiaTri(double x)
    {
        return a * Math.Pow(x, n);
    }

    // DaoHam(): tính đạo hàm P'(x) = a.n.x^(n-1)
    public DonThuc DaoHam()
    {
        return new DonThuc(a * n, n - 1);
    }

    // ToString(): xuất đơn thức
    public override string ToString()
    {
        return a + "x^" + n;
    }

    // Main(): chạy chương trình
    static void Main()
    {
        // Nhập hệ số a
        Console.Write("Nhap a: ");
        double a = double.Parse(Console.ReadLine());

        // Nhập số mũ n
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        // Tạo đơn thức P(x)
        DonThuc P = new DonThuc(a, n);

        // Nhập x
        Console.Write("Nhap x: ");
        double x = double.Parse(Console.ReadLine());

        // Xuất đơn thức
        Console.WriteLine("\nP(x) = " + P);

        // Tính giá trị đơn thức
        Console.WriteLine("P(" + x + ") = " + P.TinhGiaTri(x));

        // Tính đạo hàm
        DonThuc Q = P.DaoHam();

        Console.WriteLine("P'(x) = " + Q);
    }
}
