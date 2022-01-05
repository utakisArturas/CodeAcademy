using System;

namespace CodeAcademyLesson0103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two even digits : ");
            int numb, numb1;
            numb = Convert.ToInt32(Console.ReadLine());
            numb1 = Convert.ToInt32(Console.ReadLine());
            if (numb%2 == 0 && numb1%2 == 0)
            {
                Console.WriteLine($"TRUE : {numb} {numb1}");
            }
            else
            {
                Console.WriteLine($"FALSE : {numb} {numb1}");
            }
            Console.ReadLine(); 
        }
    }
}
