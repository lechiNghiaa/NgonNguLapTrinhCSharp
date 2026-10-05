using System;

class Point
{
    // Field: lưu tọa độ x, y
    private double x;
    private double y;

    // Property: dùng để lấy và gán giá trị x, y
    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    // Constructor: khởi tạo điểm ban đầu là (0, 0)
    public Point()
    {
        x = 0;
        y = 0;
    }

    // Input(): dùng để nhập tọa độ
    public void Input()
    {
        Console.Write("Nhap x: ");
        x = double.Parse(Console.ReadLine());

        Console.Write("Nhap y: ");
        y = double.Parse(Console.ReadLine());
    }

    // Output(): dùng để xuất tọa độ
    public void Output()
    {
        Console.WriteLine("(" + x + ", " + y + ")");
    }

    // ToString(): dùng để xuất Point dưới dạng (x, y)
    public override string ToString()
    {
        return "(" + x + ", " + y + ")";
    }

    // Phép cộng 2 điểm
    public static Point operator +(Point A, Point B)
    {
        Point C = new Point();

        C.X = A.X + B.X;
        C.Y = A.Y + B.Y;

        return C;
    }

    // Phép trừ 2 điểm
    public static Point operator -(Point A, Point B)
    {
        Point C = new Point();

        C.X = A.X - B.X;
        C.Y = A.Y - B.Y;

        return C;
    }

    // Lấy âm một điểm
    public static Point operator -(Point A)
    {
        Point C = new Point();

        C.X = -A.X;
        C.Y = -A.Y;

        return C;
    }

    // Khoảng cách - phương thức thành viên
    public double Distance(Point B)
    {
        return Math.Sqrt(
            Math.Pow(X - B.X, 2) +
            Math.Pow(Y - B.Y, 2)
        );
    }

    // Khoảng cách - phương thức tĩnh
    public static double Distance(Point A, Point B)
    {
        return Math.Sqrt(
            Math.Pow(A.X - B.X, 2) +
            Math.Pow(A.Y - B.Y, 2)
        );
    }

    // Trung điểm - phương thức thành viên
    public Point MidPoint(Point B)
    {
        Point I = new Point();

        I.X = (X + B.X) / 2;
        I.Y = (Y + B.Y) / 2;

        return I;
    }

    // Trung điểm - phương thức tĩnh
    public static Point MidPoint(Point A, Point B)
    {
        Point I = new Point();

        I.X = (A.X + B.X) / 2;
        I.Y = (A.Y + B.Y) / 2;

        return I;
    }

    // Main(): hàm chính để chạy chương trình
    static void Main()
    {
        Point A = new Point();
        Point B = new Point();

        Console.WriteLine("Nhap diem A:");
        A.Input();

        Console.WriteLine("Nhap diem B:");
        B.Input();

        Console.WriteLine("\nDiem A: " + A);
        Console.WriteLine("Diem B: " + B);

        // Khoảng cách bằng phương thức thành viên
        Console.WriteLine("Khoang cach (thanh vien): " + A.Distance(B));

        // Khoảng cách bằng phương thức tĩnh
        Console.WriteLine("Khoang cach (tinh): " + Point.Distance(A, B));

        // Trung điểm bằng phương thức thành viên
        Console.WriteLine("Trung diem (thanh vien): " + A.MidPoint(B));

        // Trung điểm bằng phương thức tĩnh
        Console.WriteLine("Trung diem (tinh): " + Point.MidPoint(A, B));
    }
}