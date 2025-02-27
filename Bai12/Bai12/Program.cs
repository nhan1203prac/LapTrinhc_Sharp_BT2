
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
        foreach (MonAn mon in Enum.GetValues(typeof(MonAn)))
        {
            Console.WriteLine($"{(int)mon}. {mon}");
        }
        Console.Write("\nNhập số tương ứng với món ăn bạn muốn chọn: ");
        if (int.TryParse(Console.ReadLine(), out int luaChon) && Enum.IsDefined(typeof(MonAn), luaChon))
        {
            MonAn monDaChon = (MonAn)luaChon;
            Console.WriteLine($"Bạn đã chọn món: {monDaChon}");
        }
        else
        {
            Console.WriteLine("Lựa chọn không hợp lệ!");
        }
    }
}