enum MonAn
{
    Pho = 1,
    BunBo = 2,
    ComTam = 3,
    HuTieu = 4
}

internal class Program
{
    static double TinhGiaMonAn(MonAn monAn_234, int soLuong_234 = 1)
    {
        double giaTien_234 = 0;
        switch (monAn_234)
        {
            case MonAn.Pho:
                giaTien_234 = 40000; break;
            case MonAn.BunBo:
                giaTien_234 = 45000; break;
            case MonAn.ComTam:
                giaTien_234 = 50000; break;
            case MonAn.HuTieu:
                giaTien_234 = 35000; break;
        }
        return giaTien_234 * soLuong_234;
    }
    private static void Main(string[] args_234)
    {
        Console.WriteLine("Chon mon an:");
        Console.WriteLine("1. Pho\n2. Bun Bo\n3. Com Tam\n4. Hu Tieu");
        if (int.TryParse(Console.ReadLine(), out int luaChon_234) && Enum.IsDefined(typeof(MonAn), luaChon_234))
        {
            MonAn monAnDuocChon_234 = (MonAn)luaChon_234;
            Console.Write("Nhap so luong (Nhan Enter de mac dinh la 1): ");
            string inputSoLuong_234 = Console.ReadLine();
            double tongTien_234;
            if (string.IsNullOrWhiteSpace(inputSoLuong_234))
            {
                tongTien_234 = TinhGiaMonAn(monAnDuocChon_234);
            }
            else
            {
                int soLuong_234 = int.Parse(inputSoLuong_234);
                tongTien_234 = TinhGiaMonAn(monAnDuocChon_234, soLuong_234);
            }

            Console.WriteLine($"\nMon {monAnDuocChon_234} - Tong tien: {tongTien_234} VND");
        }
        else
        {
            Console.WriteLine("Lua chon khong hop le!");
        }
    }
}
