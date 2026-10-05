using System;
using System.Collections;

class Person
{
    // Field: lưu thông tin của một người
    private int id;
    private string name;
    private int yob;
    private int yod;

    // Default Constructor: khởi tạo giá trị ban đầu
    public Person()
    {
        id = 0;
        name = "";
        yob = 0;
        yod = 0;
    }

    // Copy Constructor: sao chép thông tin Person
    public Person(Person p)
    {
        id = p.id;
        name = p.name;
        yob = p.yob;
        yod = p.yod;
    }

    // Input(): dùng để nhập thông tin Person
    public void Input()
    {
        Console.Write("Nhap ID: ");
        id = int.Parse(Console.ReadLine());

        Console.Write("Nhap ten: ");
        name = Console.ReadLine();

        Console.Write("Nhap nam sinh: ");
        yob = int.Parse(Console.ReadLine());

        Console.Write("Nhap nam mat (0 neu con song): ");
        yod = int.Parse(Console.ReadLine());
    }

    // Output(): dùng để xuất thông tin Person
    public void Output()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Ten: " + name);
        Console.WriteLine("Nam sinh: " + yob);

        // Kiểm tra Person còn sống hay đã mất
        if (IsLiving())
            Console.WriteLine("Dang con song!");
        else
            Console.WriteLine("Da mat!");
    }

    // IsLiving(): trả về true nếu yod = 0, ngược lại trả về false
    public bool IsLiving()
    {
        return yod == 0;
    }
}


class PersonList
{
    // Field: ArrayList dùng để lưu nhiều Person
    private ArrayList list;

    // Default Constructor: tạo danh sách rỗng
    public PersonList()
    {
        list = new ArrayList();
    }

    // Copy Constructor: sao chép một PersonList
    public PersonList(PersonList p)
    {
        list = new ArrayList();

        foreach (Person x in p.list)
        {
            list.Add(new Person(x));
        }
    }

    // Add(): thêm một Person vào danh sách
    public void Add(Person x)
    {
        list.Add(x);
    }

    // Input(): nhập danh sách Person
    public void Input()
    {
        Console.Write("Nhap so luong Person: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nNhap Person thu " + (i + 1) + ":");

            Person p = new Person();
            p.Input();

            Add(p);
        }
    }

    // Output(): xuất tất cả Person trong danh sách
    public void Output()
    {
        foreach (Person p in list)
        {
            p.Output();
            Console.WriteLine();
        }
    }

    // LivingPeople(): trả về danh sách những người còn sống
    public PersonList LivingPeople()
    {
        PersonList result = new PersonList();

        foreach (Person p in list)
        {
            if (p.IsLiving())
            {
                result.Add(p);
            }
        }

        return result;
    }


    // Main(): hàm chính để chạy chương trình
    static void Main()
    {
        // Tạo PersonList
        PersonList ds = new PersonList();

        // Nhập danh sách
        ds.Input();

        // Xuất danh sách tất cả
        Console.WriteLine("\n===== DANH SACH TAT CA =====");
        ds.Output();

        // Lấy danh sách người còn sống
        PersonList living = ds.LivingPeople();

        // Xuất danh sách người còn sống
        Console.WriteLine("===== NGUOI CON SONG =====");
        living.Output();
    }
}