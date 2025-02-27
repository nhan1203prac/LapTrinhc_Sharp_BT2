
enum MonAn
{
    Pho ,
    BunBo,
    ComTam,
    HuTieu,
    BanhMi
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===== MENU =====");
        foreach (MonAn mon_234 in Enum.GetValues(typeof(MonAn)))
        {
            Console.WriteLine($"{(int)mon_234}. {mon_234}");
        }
        Console.Write("\nNhap so tuong ung voi mon an ban muon chon: ");
        if (int.TryParse(Console.ReadLine(), out int luaChon_234) && Enum.IsDefined(typeof(MonAn), luaChon_234))
        {
            MonAn monDaChon = (MonAn)luaChon_234;
            Console.WriteLine($"Ban đa chon mon: {monDaChon}");
        }
        else
        {
            Console.WriteLine("Lua chon khong hop le!");
        }
    }
}