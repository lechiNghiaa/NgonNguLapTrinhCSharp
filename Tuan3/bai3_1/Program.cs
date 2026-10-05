using System;
using System.Linq;
class Program
{
    static void Main()
    {
        // Khai báo mảng số nguyên
        int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

        // a. Cho biết tổng số phần tử, số phần tử chẵn và số phần tử lẻ
        int tongSoPhanTu = mangSo.Count();
        int soChan = mangSo.Count(x => x % 2 == 0);
        int soLe = mangSo.Count(x => x % 2 != 0);

        Console.WriteLine("a. Thong ke so phan tu:");
        Console.WriteLine("Tong so phan tu: " + tongSoPhanTu);
        Console.WriteLine("So phan tu chan: " + soChan);
        Console.WriteLine("So phan tu le: " + soLe);


        // b. Tính tổng các giá trị, giá trị lớn nhất và giá trị nhỏ nhất
        int tong = mangSo.Sum();
        int lonNhat = mangSo.Max();
        int nhoNhat = mangSo.Min();

        Console.WriteLine("\nb. Thong ke gia tri:");
        Console.WriteLine("Tong cac gia tri: " + tong);
        Console.WriteLine("Gia tri lon nhat: " + lonNhat);
        Console.WriteLine("Gia tri nho nhat: " + nhoNhat);


        // c. Cho biết có bao nhiêu giá trị khác nhau trong mảng
        int soGiaTriKhacNhau = mangSo.Distinct().Count();

        Console.WriteLine("\nc. So gia tri khac nhau:");
        Console.WriteLine(soGiaTriKhacNhau);


        // d. Phân nhóm các phần tử theo số dư khi chia cho 5
        var nhom = mangSo.GroupBy(x => x % 5);

        Console.WriteLine("\nd. Phan nhom theo so du khi chia cho 5:");

        foreach (var group in nhom.OrderBy(x => x.Key))
        {
            Console.WriteLine("So du " + group.Key + ": "
                + string.Join(", ", group));
        }
    }
}
