using System;

namespace CA0119
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var palm = new Palm();
            palm.AddOneMonthToAge(9);
            Console.WriteLine($"Palm have made : {palm.NumberOfFruits} fruits");

            var woods = new Woods();
            Console.WriteLine("How many trees you want to plant ? ");
            var howMany = Convert.ToInt32(Console.ReadLine());
            woods.PlantATree(howMany);
        }
    }
}
