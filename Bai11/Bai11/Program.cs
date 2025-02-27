namespace Bai11
{
    internal class Program
    {
        public static double TinhLuong(string ten, int soGio, double luongMoiGio = 50)
        {
            return soGio * luongMoiGio;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhập tên nhân viên: ");
            string tenNhanVien = Console.ReadLine();

            Console.Write("Nhập số giờ làm việc: ");
            int soGioLam = int.Parse(Console.ReadLine());

            Console.Write("Nhập lương mỗi giờ (hoặc nhấn Enter để dùng mặc định 50): ");
            string inputLuong = Console.ReadLine();

            double luong;
            if (string.IsNullOrWhiteSpace(inputLuong))
            {
                luong = TinhLuong(tenNhanVien, soGioLam);
            }
            else
            {
                double luongMoiGio = double.Parse(inputLuong);
                luong = TinhLuong(tenNhanVien, soGioLam, luongMoiGio);
            }
            Console.WriteLine($"\nNhân viên {tenNhanVien} có tổng lương: {luong} VND");
        }
    }
}