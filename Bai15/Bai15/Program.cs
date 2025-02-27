

using Bai15;

internal class Program
{
 
    private static void Main(string[] args)
    {
        Point p1_234 = new Point(1, 5, PointColor.LightBlue);
        Point p2_234 = new Point(4, 2, PointColor.BloodRed);


        p1_234.DisplayStatus();
        p2_234.DisplayStatus();

        
        Rectangle rect = new Rectangle(p1_234, p2_234);

        rect.DisplayStatus();
    }
}