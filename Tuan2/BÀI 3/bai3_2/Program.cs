using System;

class SapXep
{
    // Sort(): sắp xếp các phần tử trong mảng
    public static void Sort<T>(T[] a) where T : IComparable<T>
    {
        // Duyệt từng phần tử
        for (int i = 0; i < a.Length - 1; i++)
        {
            // So sánh phần tử a[i] với các phần tử phía sau
            for (int j = i + 1; j < a.Length; j++)
            {
                // Nếu a[i] lớn hơn a[j] thì đổi chỗ
                if (a[i].CompareTo(a[j]) > 0)
                {
                    T temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
    }

    static void Main()
    {
        // Nhập số lượng phần tử
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        // Tạo mảng
        int[] a = new int[n];

        // Nhập các phần tử
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap phan tu thu {0}: ", i + 1);
            a[i] = int.Parse(Console.ReadLine());
        }

        // Xuất mảng ban đầu
        Console.Write("\nMang ban dau: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }

        // Gọi hàm Sort tự viết
        SapXep.Sort(a);

        // Xuất mảng sau khi sắp xếp
        Console.Write("\nMang sau khi sap xep: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();
    }
}