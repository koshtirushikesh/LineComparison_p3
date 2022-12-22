using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison_p3
{
    public class Line
    {
        public double LengthOfLine(int x1,int y1,int x2,int y2)
        {
            double X1 = Math.Pow((x2 - x1), 2);
            double Y1 = Math.Pow((y2 - y1), 2);
            double length = Math.Sqrt(X1 + Y1);
            Console.WriteLine(length);
            return length;
        }
    }
}
