using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0113
{
    internal class ArrayCountService
    {
        public void SumOfArary(int[] array)
        {
            int sum = array.Sum();
            Console.WriteLine($"Sum of array is : {sum}");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
