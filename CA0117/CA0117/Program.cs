using System;
using System.Collections.Generic;

namespace CA0117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rec1 = new Rectangle();
            var rec2 = new Rectangle();
            var rec3 = new Rectangle();


            Console.WriteLine(rec1.Area(10, 10));
            Console.WriteLine(rec2.Area(3, 8));
            Console.WriteLine(rec3.Area(14, 6));

        }
    }
}
