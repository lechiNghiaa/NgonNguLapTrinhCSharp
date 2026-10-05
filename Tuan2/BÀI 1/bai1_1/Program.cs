using System;
class bai1_1
{
    // Field: lưu thông tin của sinh viên
    private string hoTen;
    private int namSinh;
    // Constructor: dùng để khởi tạo giá trị ban đầu
    public bai1_1()
    {
        hoTen = "";
        namSinh = 0;
    }
    // Property: dùng để lấy và gán giá trị cho Field
    public string HoTen
    {
        get { return hoTen; }       // Lấy họ tên
        set { hoTen = value; }      // Gán họ tên
    }
    public int NamSinh
    {
        get { return namSinh; }     // Lấy năm sinh
        set { namSinh = value; }    // Gán năm sinh
    }
    // Input(): dùng để nhập họ tên và năm sinh
    public void Input()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();

        Console.Write("Nhap nam sinh: ");
        namSinh = int.Parse(Console.ReadLine());
    }
    // TinhTuoi(): dùng để tính tuổi của sinh viên
    public int TinhTuoi()
    {
        return DateTime.Now.Year - namSinh;
    }
    // Output(): dùng để xuất thông tin sinh viên
    public void Output()
    {
        Console.WriteLine("---------------------");
        Console.WriteLine("Tuoi: " + TinhTuoi());
    }
    // Main(): hàm chính, dùng để chạy chương trình
    static void Main()
    {
        // Tạo đối tượng sinh viên
        bai1_1 sv = new bai1_1();

        // Gọi hàm nhập thông tin
        sv.Input();

        // Gọi hàm xuất thông tin
        sv.Output();
    }
}