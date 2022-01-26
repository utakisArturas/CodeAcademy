using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0126
{
    internal class DeluxeBurger :Hamburger
    {
        public DeluxeBurger() : base("Deluxe burger","Beef",19.10,"Deluxe Bread")  
        {
            addHamburgerChoice1("Fries",3.50);
            addHamburgerChoice2("Pepsi", 2.50);
        }
        public override void addHamburgerChoice1(string name, double price)
        {
            Console.WriteLine($"Cannot not add additional items to a deluxe burger");
        }
        public override void addHamburgerChoice2(string name, double price)
        {
            Console.WriteLine($"Cannot not add additional items to a deluxe burger");
        }
        public override void addHamburgerChoice3(string name, double price)
        {
            Console.WriteLine($"Cannot not add additional items to a deluxe burger");
        }
        public override void addHamburgerChoice4(string name, double price)
        {
            Console.WriteLine($"Cannot not add additional items to a deluxe burger");
        }

    }
}
