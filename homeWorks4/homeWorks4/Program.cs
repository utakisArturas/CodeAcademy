using System;

namespace homeWorks4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Enter second number :");
            var userInput1 = Convert.ToInt32(Console.ReadLine());
            for(int j = 0;j <= userInput1; j++)
            {
                if (j%2 == 0)
                {
                    Console.WriteLine(j);
                }
                
            }
            Console.WriteLine("Enter text : ");
            var userText = Convert.ToString(Console.ReadLine());
            var newText = string.Empty;
            for (int i = userText.Length - 1; i >= 0; i--)
            {
                newText += userText[i];
            }
            Console.Write($"Text bacwards : {newText} ");
            Console.ReadLine();
            Console.WriteLine("Fill array with numbers (5)");
            var arrayOfNumbers = new int[5];
            arrayOfNumbers[0] = Convert.ToInt32(Console.ReadLine());
            arrayOfNumbers[1] = Convert.ToInt32(Console.ReadLine());
            arrayOfNumbers[2] = Convert.ToInt32(Console.ReadLine());
            arrayOfNumbers[3] = Convert.ToInt32(Console.ReadLine());
            arrayOfNumbers[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number of numbers in array :  {arrayOfNumbers.Length}");
            Console.WriteLine($"Last index of array : {arrayOfNumbers[4] }");
            Console.WriteLine($"First index of array : {arrayOfNumbers[0]}");
            foreach (var number in arrayOfNumbers)
            {
                Console.WriteLine(number);
            }
            var arrayOfNumbers2 = new int[]
            {
                1, 2, 3, 4, 5, 6, 7,
            };
            foreach (var number in arrayOfNumbers2)
            {
                Console.Write(number + " ");
            }

        }
    }
}
