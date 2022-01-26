using System;
using System.Collections.Generic;


namespace CodeAcademy0105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var randomNUmbers = new List<int>();

            //var random = new Random();

            //for (int i = 0; i < 100; i++)
            //{
            //    randomNUmbers.Add(random.Next(1,10));
            //}
            //var usedNumbers = new List<int>();

            //foreach (int elementToCount in randomNUmbers)
            //{
            //    if (usedNumbers.Contains(elementToCount))
            //        continue;

            //    int repeatingNumberCount = 0;

            //    foreach (int element in randomNUmbers)
            //    {
            //        if (elementToCount == element)
            //        {
            //            repeatingNumberCount++;
            //        }
            //    }
            //    Console.WriteLine($"{elementToCount} repeated {repeatingNumberCount}");
            //    usedNumbers.Add(elementToCount);
            //}
            //foreach (var temp in randomNUmbers)
            //{
            //    Console.WriteLine(temp);
            //}
            //var randomNumbers = new List<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    randomNumbers.Add(i);
            //}
            //randomNumbers.ForEach(Console.WriteLine);
            //randomNumbers.Remove(2);
            //Console.WriteLine("Senas listas");
            //var newList = randomNumbers.GetRange(0, randomNumbers.Count);
            //newList.ForEach(Console.WriteLine);

            //var randomList = new List<int>();
            //for (int i = 1; i < 8; i++)
            //{
            //    randomList.Add(i);
            //}

            //randomList.ForEach(Console.WriteLine);

            //var maxNumber = randomList[0];
            //var secondBiggest = randomList[0];
            //foreach (int number in randomList)
            //{
            //    if (number > maxNumber)
            //    {   
            //        maxNumber = number;
            //    }
            //}
            //foreach (int number in randomList)
            //{
            //    if(number > secondBiggest && secondBiggest != maxNumber)
            //    {
            //        secondBiggest = number;
            //    }
            //}
            //Console.WriteLine($"Biggest number : {maxNumber}. Second biggest number is : {secondBiggest}");

            var newArray = new int[5];
            Random random = new Random();
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = 0;    
            }
            Console.WriteLine(newArray);

        }
    }
}
