using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0125._2
{
    internal class Cuboid : Rectangle
    {
        public double Height;

        public Cuboid(double height) : base(Width, Leanth)
        {
            Height = height;
            

        }

        public double getHeight()
        {
            return Height;
        }
        public double getVolume()
        {
            return getArea() * Height;
        }
    }
}
