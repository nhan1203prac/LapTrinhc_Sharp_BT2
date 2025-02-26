namespace Bai1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Nhap n ");
            int n_234 =Convert.ToInt32(Console.ReadLine());
            while(n_234 < 1)
            {
                Console.Write("N phai lon hon 1, vui long nhap lai ");
                n_234 = Convert.ToInt32(Console.ReadLine());
            }
            double s_234 = 0;
            for (int i_234 = 0; i_234 < n_234; i_234++) {
                s_234 = s_234 + 1.0 / ((2 * i_234) + 1);
            }
            Console.WriteLine("Tong la {0}", s_234);
        }
    }
}