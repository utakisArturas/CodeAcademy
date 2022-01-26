using System;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[10];
            Random r = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(10,20);
            }
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();

            var count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {       for(int j = 0; j < 11; j++) 
                    if (numbers[0] == numbers[i])
                    {
                        count++;
                    }
            }

            Console.WriteLine($"Number {numbers[0]} repeated {count} times");
        }
    }
}
