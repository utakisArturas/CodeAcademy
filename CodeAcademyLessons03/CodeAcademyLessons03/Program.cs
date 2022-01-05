using System;

namespace CodeAcademyLessons03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite grupes nariu skaiciu :");
            int numb;
            numb = Convert.ToInt32(Console.ReadLine());
            if(numb == 1)
            {
                Console.WriteLine("Solo atlikejas");
            }
            else if(numb == 2)
            {
                Console.WriteLine("Duetas");
            }
            else if (numb > 2 && numb < 10)
            {
                Console.WriteLine("Tai ansamblis");
            }
            else
            {
                Environment.Exit(1);
            }
        }
    }
}
