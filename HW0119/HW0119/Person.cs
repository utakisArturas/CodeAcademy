using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0119
{
    internal class Person
    {
        public string Name;
        public int Age;


        public void NameCall(string Name, int Age)
        {
            Console.WriteLine($"Hi my name is : {Name} and my age is {Age}");
        }


    }

}
