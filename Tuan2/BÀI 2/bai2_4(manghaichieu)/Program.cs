using System;

class Mang2Chieu
{
    // Field: mảng 2 chiều
    private int[,] a;

    // Constructor mặc định: tạo mảng 0x0
    public Mang2Chieu()
    {
        a = new int[0, 0];
    }

    // Constructor có tham số: tạo mảng n dòng, m cột
    public Mang2Chieu(int n, int m)
    {
        a = new int[n, m];
    }

    // Copy Constructor: sao chép một mảng 2 chiều
    public Mang2Chieu(Mang2Chieu b)
    {
        int n = b.a.GetLength(0);
        int m = b.a.GetLength(1);

        a = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = b.a[i, j];
            }
        }
    }

    // Indexer: truy cập phần tử tại vị trí (i, j)
    public int this[int i, int j]
    {
        get { return a[i, j]; }
        set { a[i, j] = value; }
    }

    // Input(): nhập các phần tử của mảng
    public void Input()
    {
        int n = a.GetLength(0);
        int m = a.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Nhap a[" + i + "," + j + "]: ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Output(): xuất mảng
    public void Output()
    {
        int n = a.GetLength(0);
        int m = a.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(a[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }

    // KiemTraNguyenTo(): kiểm tra một số có phải số nguyên tố
    private bool KiemTraNguyenTo(int x)
    {
        if (x < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(x); i++)
        {
            if (x % i == 0)
                return false;
        }

        return true;
    }

    // TimSoNguyenTo(): tìm và xuất các số nguyên tố
    public void TimSoNguyenTo()
    {
        bool coSoNguyenTo = false;

        Console.Write("Cac so nguyen to trong mang: ");

        int n = a.GetLength(0);
        int m = a.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (KiemTraNguyenTo(a[i, j]))
                {
                    Console.Write(a[i, j] + " ");
                    coSoNguyenTo = true;
                }
            }
        }

        // Nếu không có số nguyên tố
        if (!coSoNguyenTo)
        {
            Console.Write("Khong co so nguyen to");
        }

        Console.WriteLine();
    }


    // Main(): hàm chính để chạy chương trình
    static void Main()
    {
        // Nhập kích thước mảng
        Console.Write("Nhap so dong n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Nhap so cot m: ");
        int m = int.Parse(Console.ReadLine());

        // Tạo mảng n x m
        Mang2Chieu ds = new Mang2Chieu(n, m);

        // Nhập mảng
        ds.Input();

        // Xuất mảng
        Console.WriteLine("\nMang 2 chieu:");
        ds.Output();

        // Tìm số nguyên tố
        ds.TimSoNguyenTo();
    }
}