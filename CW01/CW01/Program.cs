using System;
using System.Linq;
namespace CW01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] newArray = new int[10];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = i;
            }
            Console.WriteLine(newArray);
        }
    }
}
