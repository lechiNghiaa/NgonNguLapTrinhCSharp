using System;

// Khai báo delegate dùng để so sánh 2 phần tử
delegate int SoSanh<T>(T a, T b);

class SapXep
{
    // Hàm Sort: sắp xếp mảng tổng quát
    // Delegate cmp quyết định thứ tự sắp xếp
    public static void Sort<T>(T[] a, SoSanh<T> cmp)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                // Nếu a[i] đứng sau a[j] thì đổi chỗ
                if (cmp(a[i], a[j]) > 0)
                {
                    T temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
    }
}

class Program
{
    // Hàm so sánh tăng dần
    static int TangDan(int a, int b)
    {
        return a.CompareTo(b);
    }

    // Hàm so sánh giảm dần
    static int GiamDan(int a, int b)
    {
        return b.CompareTo(a);
    }

    static void Main()
    {
        // Nhập số lượng phần tử
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        // Tạo mảng
        int[] a = new int[n];

        // Nhập mảng
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap phan tu thu {0}: ", i + 1);
            a[i] = int.Parse(Console.ReadLine());
        }

        // Xuất mảng ban đầu
        Console.Write("\nMang ban dau: ");
        for (int i = 0; i < n; i++)
            Console.Write(a[i] + " ");

        // Sắp xếp tăng dần bằng delegate
        SapXep.Sort(a, TangDan);

        Console.Write("\nMang tang dan: ");
        for (int i = 0; i < n; i++)
            Console.Write(a[i] + " ");

        // Sắp xếp giảm dần bằng delegate
        SapXep.Sort(a, GiamDan);

        Console.Write("\nMang giam dan: ");
        for (int i = 0; i < n; i++)
            Console.Write(a[i] + " ");

        Console.WriteLine();
    }
}
