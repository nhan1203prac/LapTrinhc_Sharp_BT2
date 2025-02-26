internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhap x: ");
        double x_234 = double.Parse(Console.ReadLine());

        Console.Write("Nhap n: ");
        int n_234 = int.Parse(Console.ReadLine());

        double sum_234 = 0;
        double term_234 = 1; 

        for (int i_234 = 1; i_234 <= n_234; i_234++)
        {
            term_234 *= x_234 / i_234;
            sum_234 += term_234;
        }
       
        Console.WriteLine($"S({n_234}) = {sum_234}");
    }
}