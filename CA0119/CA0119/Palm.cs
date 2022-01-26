using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0119
{
    internal class Palm
    {
        public int Age;
        public int NumberOfFruits;
        public Palm()
        {
            this.Age = 0;
            this.NumberOfFruits = 0;
        }
        public void AddOneMonthToAge(int month)
        {
            var age = Age + month;
            if (age >= 5 && age < 12)
            {
                NumberOfFruits = age * 3;
            }
            else
            {
                age = 0;
            }
        }

    }

}
