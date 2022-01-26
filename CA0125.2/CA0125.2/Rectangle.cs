using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0125._2
{
    internal class Rectangle
    {
        public double Width;
        public double Leanth;

        public Rectangle(double width, double leanth)
        {
            Width = width;
            Leanth = leanth;
            if (width < 0 )
            {
                Width = 0;
                
            }
            else
            {
                Width = width;
            }

            if (leanth < 0 )
            {
                Leanth = 0;
            }
            else
            {
                Leanth = leanth;
            }
        }
        public double getWidth()
        {
            return Width;
        }
        public double getLeanth()
        {
            return Leanth;
        }
        public double getArea()
        {
            return Width * Leanth;
        }
    }
}
