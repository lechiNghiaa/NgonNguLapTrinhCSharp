using System;

// Delegate dùng cho sự kiện chọn chức năng
delegate void ChonChucNang(int x);

class ConsoleMenu
{
    // Event thông báo khi người dùng chọn chức năng
    public event ChonChucNang Choose;

    // Hiển thị menu
    public void Run()
    {
        int x;

        do
        {
            Console.WriteLine("-------- MENU --------");
            Console.WriteLine("1. Nhap he so");
            Console.WriteLine("2. Giai phuong trinh bac 2");
            Console.WriteLine("0. Thoat chuong trinh");
            Console.Write("Chon chuc nang: ");

            x = int.Parse(Console.ReadLine());

            if (x != 0)
            {
                // Gọi event khi người dùng chọn chức năng
                Choose?.Invoke(x);
            }

        } while (x != 0);
    }
}

// Lớp giải phương trình bậc 2 kế thừa ConsoleMenu
class PTBac2Console : ConsoleMenu
{
    private double a, b, c;

    // Nhập hệ số
    public void Nhap()
    {
        Console.Write("Nhap a: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Nhap c: ");
        c = double.Parse(Console.ReadLine());
    }

    // Giải phương trình ax^2 + bx + c = 0
    public void Giai()
    {
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("\nPhuong trinh vo so nghiem");
                else
                    Console.WriteLine("\nPhuong trinh vo nghiem");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine("\nPhuong trinh co 1 nghiem: x = " + x);
            }

            return;
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            Console.WriteLine("\nPhuong trinh vo nghiem");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("\nPhuong trinh co nghiem kep: x = " + x);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
    }
}

class Program
{
    static void Main()
    {
        // Tạo đối tượng menu
        PTBac2Console app = new PTBac2Console();

        // Đăng ký các chức năng vào event Choose
        app.Choose += (x) =>
        {
            if (x == 1)
            {
                app.Nhap();
            }
            else if (x == 2)
            {
                app.Giai();
            }
            else
            {
                Console.WriteLine("\nKhong co chuc nang nay!");
            }
        };

        // Chạy menu
        app.Run();
    }
}