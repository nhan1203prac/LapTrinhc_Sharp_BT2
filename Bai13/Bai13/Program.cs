enum MonAn
{
    Pho = 1,
    BunBo = 2,
    ComTam = 3,
    HuTieu = 4
}

internal class Program
{
    static double TinhGiaMonAn(MonAn monAn, int soLuong = 1)
    {
        double giaTien = 0;
        switch (monAn)
        {
            case MonAn.Pho:
                giaTien = 40000; break;
            case MonAn.BunBo:
                giaTien = 45000; break;
            case MonAn.ComTam:
                giaTien = 50000; break;
            case MonAn.HuTieu:
                giaTien = 35000; break;
        }
        return giaTien * soLuong;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Chọn món ăn:");
        Console.WriteLine("1. Phở\n2. Bún Bò\n3. Cơm Tấm\n4. Hủ Tiếu");
        if (int.TryParse(Console.ReadLine(), out int luaChon) && Enum.IsDefined(typeof(MonAn), luaChon))
        {
            MonAn monAnDuocChon = (MonAn)luaChon;
            Console.Write("Nhập số lượng (Nhấn Enter để mặc định là 1): ");
            string inputSoLuong = Console.ReadLine();
            double tongTien;
            if (string.IsNullOrWhiteSpace(inputSoLuong)) 
            {
                tongTien = TinhGiaMonAn(monAnDuocChon);
            }
            else
            {
                int soLuong = int.Parse(inputSoLuong);
                tongTien = TinhGiaMonAn(monAnDuocChon, soLuong);
            }

            Console.WriteLine($"\nMón {monAnDuocChon} - Tổng tiền: {tongTien} VND");
        }
        else
        {
            Console.WriteLine("Lựa chọn không hợp lệ!");
        }
    }
}