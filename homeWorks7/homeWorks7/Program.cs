using System;

namespace homeWorks7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter grades for 5 students : ");
            var studentGrades = new double[5];

            for (int i = 0; i < studentGrades.Length; i++)
            {
                studentGrades[i] = Convert.ToDouble(Console.ReadLine());
            }
            foreach (var student in studentGrades)
            {
                Console.Write(student + " ");
            }
            Console.ReadLine();
            //* biggest grade ->
            var bigGrade = studentGrades[0];
            foreach (var grade in studentGrades)
            {
                if (grade>bigGrade)
                {
                    bigGrade = grade;
                }
            }
            Console.WriteLine($"Biggest grade in group : {bigGrade}");

            //* lowest grade ->
            var lowGrade = studentGrades[0];
            foreach (var grade in studentGrades)
            {
                if (grade < lowGrade)
                {
                    lowGrade = grade;
                }
            }
            Console.WriteLine($"Lowest grade in group : {lowGrade}");

            //*sum grade ->
            double sumGrade = 0;
            foreach (var grade in studentGrades)
            {
                sumGrade += grade;
            }
            var avgGrade = sumGrade / studentGrades.Length;
            Console.WriteLine($"Average grade is : {avgGrade}");
        }
    }
}
