namespace Bai11
{
    internal class Program
    {
        public static double TinhLuong(string ten_234, int soGio_234, double luongMoiGio_234 = 50)
        {
            return soGio_234 * luongMoiGio_234;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap ten nhan vien: ");
            string tenNhanVien_234 = Console.ReadLine();

            Console.Write("Nhap so gio lam viec: ");
            int soGioLam_234 = int.Parse(Console.ReadLine());

            Console.Write("Nhap luong moi gio (hoac nhan Enter đe dung mac dinh 50): ");
            string inputLuong_234 = Console.ReadLine();

            double luong_234;
            if (string.IsNullOrWhiteSpace(inputLuong_234))
            {
                luong_234 = TinhLuong(tenNhanVien_234, soGioLam_234);
            }
            else
            {
                double luongMoiGio = double.Parse(inputLuong_234);
                luong_234 = TinhLuong(tenNhanVien_234, soGioLam_234, luongMoiGio);
            }
            Console.WriteLine($"\nNhan vien {tenNhanVien_234} co tong luong: {luong_234} VND");
        }
    }
}