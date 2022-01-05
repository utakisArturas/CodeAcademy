using System;

namespace homeWorks5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrayOfNumbers = new int[5];
            Console.WriteLine("Fill array with numbers :");
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in arrayOfNumbers)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
            //min Value paieska
            Console.WriteLine("Min value search");
            var minValue = arrayOfNumbers[0];
            foreach(var number in arrayOfNumbers)
            {
                if (minValue > number)
                {
                    minValue = number;
                }
            }
            Console.WriteLine(minValue);
        }
    }
}
