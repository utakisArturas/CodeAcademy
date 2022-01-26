using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0118
{
    internal struct Student
    {
        public List<double> FirstSemester;
        public List<double> SecondSemester;
        public List<double> ThirdSemester;


        public Student(List<double> firstSemester, List<double> secondSemester, List<double> thirdSemester)
        {
            FirstSemester = firstSemester;
            SecondSemester = secondSemester;
            ThirdSemester = thirdSemester;
        }


        public double FirstSemesterAverage()
        {
            return FirstSemester.Average();
        }
        public double SecondSemesterAverage()
        {
            return SecondSemester.Average();
        }

        public double ThirdSemesterAverage()
        {
            return ThirdSemester.Average();
        }
        public double YearlyGrade()
        {   
            double first = FirstSemesterAverage();
            double second = SecondSemesterAverage();
            double third = ThirdSemesterAverage();
            double YearlyGrade = (first + second + third) / 3;
            return YearlyGrade;
        }
    }
}
