using System;

class DaySo
{
    // Field: mảng chứa các số nguyên
    private int[] a;

    // Constructor mặc định: tạo dãy rỗng
    public DaySo()
    {
        a = new int[0];
    }

    // Constructor có tham số: tạo dãy có n phần tử
    public DaySo(int n)
    {
        a = new int[n];
    }

    // Copy Constructor: sao chép một dãy số
    public DaySo(DaySo d)
    {
        a = new int[d.a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = d.a[i];
        }
    }

    // Indexer: dùng để truy cập phần tử thứ i
    public int this[int i]
    {
        get { return a[i]; }
        set { a[i] = value; }
    }

    // Input(): nhập các phần tử của dãy
    public void Input()
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("Nhap a[" + i + "]: ");
            a[i] = int.Parse(Console.ReadLine());
        }
    }

    // Output(): xuất các phần tử của dãy
    public void Output()
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();
    }

    // TimSoChan(): tìm và xuất các số chẵn trong dãy
    public void TimSoChan()
    {
        Console.Write("Cac so chan: ");

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0)
            {
                Console.Write(a[i] + " ");
            }
        }

        Console.WriteLine();
    }


    // Main(): hàm chính để chạy chương trình
    static void Main()
    {
        // Nhập số lượng phần tử
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        // Tạo dãy có n phần tử
        DaySo ds = new DaySo(n);

        // Nhập dãy
        ds.Input();

        // Thử Indexer
        Console.WriteLine("Phan tu thu 0: " + ds[0]);

        // Xuất dãy
        Console.Write("Day so: ");
        ds.Output();

        // Tìm các số chẵn
        ds.TimSoChan();
    }
}