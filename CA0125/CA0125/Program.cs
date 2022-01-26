using System;

namespace CA0125
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Circle circle = new Circle(3.75);
            Console.WriteLine(circle.getArea());
            Cylinder cylinder = new Cylinder(8.76);
            Console.WriteLine(cylinder.getVolume());

        }
    }
}
