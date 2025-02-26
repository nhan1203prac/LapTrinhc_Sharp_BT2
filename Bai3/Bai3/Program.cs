internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhap so nguyen duong n: ");
        int n_234 = int.Parse(Console.ReadLine());

        while (n_234 <= 0)
        {
            Console.Write("N phai lon hon 0 , vui long nhap lai: ");
            n_234 = int.Parse(Console.ReadLine());
        }
       
            int sum_234 = 0;
            for (int i_234 = 2; i_234 <= n_234; i_234 += 2) 
            {
                if (n_234 % i_234 == 0) 
                {
                    sum_234 += i_234;
                }
            }
            Console.WriteLine($"Tong cac uoc so chan cua {n_234} la: {sum_234}");
        
    }
}