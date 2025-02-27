using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    public class Rectangle
    {
        public Point UpperLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle(Point upperLeft, Point bottomRight)
        {
            UpperLeft = upperLeft;
            BottomRight = bottomRight;
        }

        public void DisplayStatus()
        {
            Console.WriteLine("Rectangle Status:");
            Console.Write("Upper Left: ");
            UpperLeft.DisplayStatus();
            Console.Write("Bottom Right: ");
            BottomRight.DisplayStatus();
        }
    }
}
