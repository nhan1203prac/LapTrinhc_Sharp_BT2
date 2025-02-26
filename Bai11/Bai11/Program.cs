namespace Bai11
{
    internal class Program
    {

        static void BookInfo(string title, string author, int year = -1, double price = 0)
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Year: {(year == -1 ? "Unknown" : year.ToString())}");
            Console.WriteLine($"Price: {(price == 0 ? "Free" : "$" + price)}");
            Console.WriteLine("----------------------");
        }
        private static void Main(string[] args)
        {
            BookInfo("Harry Porter", "J.K Rowling", 1980, 10.99);
            BookInfo("To Kill a Mockingbird", "Harper Lee", price: 12.5);
            BookInfo(" Peter Pan", "J. M. Barrie");
        }
    }
}