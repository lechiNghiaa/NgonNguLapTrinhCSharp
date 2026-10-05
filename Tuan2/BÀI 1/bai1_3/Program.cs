using System;

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

    // Copy Constructor: tạo Person mới bằng cách sao chép Person có sẵn
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
        Console.WriteLine("-------------------");
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Ten: " + name);
        Console.WriteLine("Nam sinh: " + yob);
        Console.WriteLine("Nam mat: " + yod);
    }

    // IsLiving(): kiểm tra người đó còn sống hay đã mất
    // yod = 0  → còn sống → true
    // yod != 0 → đã mất   → false
    public bool IsLiving()
    {
        return yod == 0;
    }

    // Main(): hàm chính để chạy chương trình
    static void Main()
    {
        // Tạo đối tượng Person
        Person p1 = new Person();

        // Nhập thông tin
        p1.Input();

        // Xuất thông tin
        Console.WriteLine("\nThong tin Person:");
        p1.Output();

        // Kiểm tra còn sống hay không
        if (p1.IsLiving())
            Console.WriteLine("Dang con song!");
        else
            Console.WriteLine("Da mat!");
    }
}