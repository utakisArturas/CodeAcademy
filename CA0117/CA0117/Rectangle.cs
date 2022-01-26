using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0117
{
    internal struct Rectangle
    {
        public int lenght;
        public int width;
        public Rectangle(int lenght, int width)
        {
            this.lenght = lenght;
            this.width = width;
        }
        public int Area(int lenght, int width)
        {
            return lenght * width;  
        }
    }
}
