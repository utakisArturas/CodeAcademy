using System;
using System.Collections.Generic;

namespace CA0118
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Random random = new Random();
            student.FirstSemester = new List<double> { 10, 5, 6, 8, 4 };
            student.SecondSemester = new List<double> { 7, 8, 8, 6, 7 };
            student.ThirdSemester = new List<double> { 9, 5, 4, 8, 7 };

            foreach (var item in student.FirstSemester)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Average grade of first semester : {student.FirstSemesterAverage()}");
            Console.WriteLine($"Average grade of second semester : {student.SecondSemesterAverage()}");
            Console.WriteLine($"Average grade of third semester : {student.ThirdSemesterAverage()}");

            Console.WriteLine($"Yearly grade is : {student.YearlyGrade()}");
        }
    }
}
