
public enum PointColor
{
    LightBlue,
    BloodRed,
    Gold
}

internal class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public PointColor Color { get; set; }

    public Point(int x, int y, PointColor color)
    {
        X = x;
        Y = y;
        Color = color;
    }
 

    public void DisplayStatus()
    {
        Console.WriteLine($"Point({X}, {Y}) - Color: {Color}");
    }
    private static void Main(string[] args)
    {
        Point p1 = new Point(1,5,PointColor.LightBlue);
        Point p2 = new Point(4, 2, PointColor.BloodRed);

        p1.DisplayStatus();
        p2.DisplayStatus();
    }
}