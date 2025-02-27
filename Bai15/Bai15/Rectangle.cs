using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    public class Rectangle
    {
        public Point UpperLeft_234 { get; set; }
        public Point BottomRight_234 { get; set; }

        public Rectangle(Point upperLeft_234, Point bottomRight_234)
        {
            UpperLeft_234 = upperLeft_234;
            BottomRight_234 = bottomRight_234;
        }

        public void DisplayStatus()
        {
            Console.WriteLine("Rectangle Status:");
            Console.Write("Upper Left: ");
            UpperLeft_234.DisplayStatus();
            Console.Write("Bottom Right: ");
            BottomRight_234.DisplayStatus();
        }
    }
}
