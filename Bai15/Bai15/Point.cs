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
        public int X_234 { get; set; }
        public int Y_234 { get; set; }
        public PointColor Color_234 { get; set; }

        public Point(int x_234, int y_234, PointColor color_234)
        {
            X_234 = x_234;
            Y_234 = y_234;
            Color_234 = color_234;
        }


        public void DisplayStatus()
        {
            Console.WriteLine($"Point({X_234}, {Y_234}) - Color: {Color_234}");
        }
    }
   
}
