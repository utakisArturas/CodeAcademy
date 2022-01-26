using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0113
{
    internal class Kmi
    {
        public double CoutBodyMass(double x,double y)
        {
            double kmi = x/(y*y);
            Console.WriteLine(kmi);
            return x/(y*y);
        }



    }
}
