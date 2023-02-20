using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            decimal area = (decimal)Math.PI * radius * radius;
            return (double)area;
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            decimal area = length * width;
            return (double)area;
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            decimal area = 0.5m * ground * h;
            return (double)area;
        }
    }
}
