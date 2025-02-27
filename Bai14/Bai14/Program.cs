internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhập số lượng học sinh: ");
        int soLuong = int.Parse(Console.ReadLine());

        double[] diemHocSinh = new double[soLuong];
        for (int i = 0; i < soLuong; i++)
        {
            Console.Write($"Nhập điểm của học sinh thứ {i + 1}: ");
            diemHocSinh[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nDanh sách điểm số:");
        foreach (double diem in diemHocSinh)
        {
            Console.WriteLine(diem);
        }
        double tongDiem = 0;
        foreach (double diem in diemHocSinh)
        {
            tongDiem += diem;
        }
        double diemTrungBinh = tongDiem / soLuong;

        Console.WriteLine($"\nĐiểm trung bình của lớp: {diemTrungBinh:F2}");
    }
}