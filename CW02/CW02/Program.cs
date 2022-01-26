using System;
using System.Linq;
using System.Collections.Generic;

namespace CW02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new();
            students.Add("student4");
            students.Add("student3");
            students.Add("student2");
            students.Add("student1");

            List<string> lateStudents = new();
            lateStudents.Add("student8");
            lateStudents.Add("student7");
            lateStudents.Add("student6");
            lateStudents.Add("student5");

            List<string> allStudents = new();
            allStudents.AddRange(students);
            allStudents.AddRange(lateStudents);

            allStudents.Sort();
        }
    }
}
