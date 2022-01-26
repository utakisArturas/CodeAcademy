using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM0120
{
    internal class Person
    {
        public DateTime Birthdate { get; private set; }
        public string UserName { get; set; }

        public Person(DateTime birthdate)
        {
            Birthdate = Birthdate;
        }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

    }
}
