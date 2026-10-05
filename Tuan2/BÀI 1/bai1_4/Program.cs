using System;

class PhanSo
{
    // Field: tử số và mẫu số
    private int tu;
    private int mau;

    // Constructor mặc định: khởi tạo phân số 0/1
    public PhanSo()
    {
        tu = 0;
        mau = 1;
    }

    // Constructor 1 tham số: khởi tạo phân số tu/1
    public PhanSo(int tu)
    {
        this.tu = tu;
        mau = 1;
    }

    // Constructor 2 tham số: khởi tạo phân số tu/mau
    public PhanSo(int tu, int mau)
    {
        this.tu = tu;
        this.mau = mau;
    }

    // Copy Constructor: sao chép một phân số
    public PhanSo(PhanSo p)
    {
        tu = p.tu;
        mau = p.mau;
    }

    // ToString(): dùng để xuất phân số
    public override string ToString()
    {
        return tu + "/" + mau;
    }

    // Một ngôi +: giữ nguyên phân số
    public static PhanSo operator +(PhanSo p)
    {
        return new PhanSo(p);
    }

    // Một ngôi -: đổi dấu phân số
    public static PhanSo operator -(PhanSo p)
    {
        return new PhanSo(-p.tu, p.mau);
    }

    // Hai ngôi +: cộng hai phân số
    public static PhanSo operator +(PhanSo a, PhanSo b)
    {
        return new PhanSo(
            a.tu * b.mau + b.tu * a.mau,
            a.mau * b.mau
        );
    }

    // Hai ngôi -: trừ hai phân số
    public static PhanSo operator -(PhanSo a, PhanSo b)
    {
        return new PhanSo(
            a.tu * b.mau - b.tu * a.mau,
            a.mau * b.mau
        );
    }

    // Hai ngôi *: nhân hai phân số
    public static PhanSo operator *(PhanSo a, PhanSo b)
    {
        return new PhanSo(
            a.tu * b.tu,
            a.mau * b.mau
        );
    }

    // Hai ngôi /: chia hai phân số
    public static PhanSo operator /(PhanSo a, PhanSo b)
    {
        return new PhanSo(
            a.tu * b.mau,
            a.mau * b.tu
        );
    }

    // > : so sánh hai phân số
    public static bool operator >(PhanSo a, PhanSo b)
    {
        return a.tu * b.mau > b.tu * a.mau;
    }

    // < : so sánh hai phân số
    public static bool operator <(PhanSo a, PhanSo b)
    {
        return a.tu * b.mau < b.tu * a.mau;
    }

    // >= : lớn hơn hoặc bằng
    public static bool operator >=(PhanSo a, PhanSo b)
    {
        return a.tu * b.mau >= b.tu * a.mau;
    }

    // <= : nhỏ hơn hoặc bằng
    public static bool operator <=(PhanSo a, PhanSo b)
    {
        return a.tu * b.mau <= b.tu * a.mau;
    }

    // == : bằng nhau
    public static bool operator ==(PhanSo a, PhanSo b)
    {
        return a.tu * b.mau == b.tu * a.mau;
    }

    // != : khác nhau
    public static bool operator !=(PhanSo a, PhanSo b)
    {
        return a.tu * b.mau != b.tu * a.mau;
    }

    // Main(): hàm chính để chạy chương trình
    static void Main()
    {
        PhanSo a = new PhanSo(1, 2);
        PhanSo b = new PhanSo(2, 3);
        //Một ngôi
        Console.WriteLine("Mot ngoi: ");
        Console.WriteLine("a: " + a);
        Console.WriteLine("b: " + b);
        Console.WriteLine("+a: " + (+a));
        Console.WriteLine("-a: " + (-a));
        //Hai ngôi
        
        Console.WriteLine("\nHai ngoi: ");
        Console.WriteLine("a + b   = " + (a + b));
        Console.WriteLine("a - b   = " + (a - b));
        Console.WriteLine("a * b   = " + (a * b));
        Console.WriteLine("a / b   = " + (a / b));
        //So sánh
        Console.WriteLine("\nSo sanh: ");
        Console.WriteLine("a > b   : " + (a > b));
        Console.WriteLine("a < b   : " + (a < b));
        Console.WriteLine("a >= b  : " + (a >= b));
        Console.WriteLine("a <= b  : " + (a <= b));
        Console.WriteLine("a == b  : " + (a == b));
        Console.WriteLine("a != b  : " + (a != b));
    }
}