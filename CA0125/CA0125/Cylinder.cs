using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0125
{   
    internal class Cylinder : Circle
    {
        public double Height;
        public Cylinder(double height)
        {
            Height = height;
            if (height < 0 )
            {
                Height = 0;
            }
        }
        public double getVolume()
        {  
           return Height * Area;
        }
    }
}
