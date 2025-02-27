using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    public class Point
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
    }
   
}
