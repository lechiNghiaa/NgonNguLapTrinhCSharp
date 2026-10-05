using System;
using System.Collections;

class Point
{
    private double x;
    private double y;

    public Point()
    {
        x = 0;
        y = 0;
    }

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

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

    public override string ToString()
    {
        return "(" + x + ", " + y + ")";
    }
}


class ArrayPoint
{
    // Field: ArrayList dùng để lưu các Point
    private ArrayList dsPoint;

    // Constructor: tạo ArrayList rỗng
    public ArrayPoint()
    {
        dsPoint = new ArrayList();
    }

    // Method: thêm một Point vào ArrayList
    public void Add(Point p)
    {
        dsPoint.Add(p);
    }

    // Indexer: cho phép truy cập Point thứ i bằng arr[i]
    public Point this[int i]
    {
        get { return (Point)dsPoint[i]; }
        set { dsPoint[i] = value; }
    }

    // Main(): chạy chương trình
    static void Main()
    {
        ArrayPoint arr = new ArrayPoint();

        // Thêm các Point vào ArrayList
        arr.Add(new Point(1, 2));
        arr.Add(new Point(3, 4));
        arr.Add(new Point(5, 6));

        // Truy cập Point bằng Indexer
        Console.WriteLine("Point 0: " + arr[0]);
        Console.WriteLine("Point 1: " + arr[1]);
        Console.WriteLine("Point 2: " + arr[2]);
    }
}