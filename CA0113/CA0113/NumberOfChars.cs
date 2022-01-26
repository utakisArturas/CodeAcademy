using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0113
{
    internal class NumberOfChars
    {
        public void CharCount(string x)
        {
            int numberOfLetters = x.Length;
            for (int i = 0; i < numberOfLetters; i++)
            {
                Console.Write("#");
            }
        }
    }
}
