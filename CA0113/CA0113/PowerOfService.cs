using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0113
{
    internal class PowerOfService
    {
        public void CountPower(int number, int powerOff)
        {
            
            Console.WriteLine($"{number} power off {powerOff} = {Math.Pow(number, powerOff)}");
        }
    }
}
