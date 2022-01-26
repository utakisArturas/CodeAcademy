using System;

namespace eveningWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] newArray = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                newArray[i] = random.Next(3,7);
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
               
            }

        }
    }
}
