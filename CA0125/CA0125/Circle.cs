using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0125
{
    internal class Circle
    {

        public double Radius;

        public double Area => getArea();
        public Circle()
        {

        }

        public Circle(double radius)
        {   
            Radius = radius;
            if (radius < 0)
            {
                Radius = 0;
            }
        }
        public  double getArea()
        {
            var Area = Radius * Radius * Math.PI;
            return Area;
        }

    }
    
}
