using System;

namespace CA0125._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine("rectangle.width= " + rectangle.Width);
            Console.WriteLine("rectangle.width= " + rectangle.getWidth());
            Console.WriteLine("rectangle.length= " + rectangle.getLeanth());
            Console.WriteLine("rectangle.area= " + rectangle.getArea());
            Cuboid cuboid = new Cuboid(5, 10, 5);
            Console.WriteLine("cuboid.width= " + cuboid.getWidth());
            Console.WriteLine("cuboid.length= " + cuboid.getLeanth());
            Console.WriteLine("cuboid.area= " + cuboid.getArea());
            Console.WriteLine("cuboid.height= " + cuboid.getHeight());
            Console.WriteLine("cuboid.volume= " + cuboid.getVolume());

        }
    }
}
