using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0117
{
    internal struct Student
    {
        public String ID;
        public Boolean Passed;
        public List<string> Students;

        public Student(string iD, bool passed, List<string> students)
        {
            ID = iD;
            Passed = passed;
            Students = students;
        }
        
    }
}
