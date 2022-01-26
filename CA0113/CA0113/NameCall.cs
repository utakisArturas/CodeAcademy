using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0113
{
    internal class NameCall
    {
        public  void CallName(string x)
        {
            Console.WriteLine($"Hey my name is :{x} :) ");
        }
        public   void CallName(string x,int y)
        {
            for (int i = 0; i < y; i++)
            {
                Console.WriteLine($"Hey my name is : {x} ");
            }
        }
    }
}
