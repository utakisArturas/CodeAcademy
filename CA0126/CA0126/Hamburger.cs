using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0126
{
    internal class Hamburger
    {
        public string Name;
        public string Meat;
        public double Price;
        public string BreadRollType;

        public string addition1Name;
        public double addition1Price;

        public string addition2Name;
        public double addition2Price;

        public string addition3Name;
        public double addition3Price;

        public string addition4Name;
        public double addition4Price;
        public Hamburger()
        {

        }

        public Hamburger(string name, string meat, double price, string breadRollType)
        {
            Name = name;
            Meat = meat;
            Price = price;
            BreadRollType = breadRollType;
        }
        public virtual void addHamburgerChoice1(String name, double price)
        {
            addition1Name = name;
            addition1Price = price;
        }

        public virtual void addHamburgerChoice2(String name, double price)
        {
            addition2Name = name;
            addition2Price = price;
        }

        public virtual void addHamburgerChoice3(String name, double price)
        {
            addition3Name = name;
            addition3Price = price;
        }

        public virtual void addHamburgerChoice4(String name, double price)
        {
            addition4Name = name;
            addition4Price = price;
        }
        public virtual double itemizeHamburger()
        {
            double hamburgerPrice = Price;
            if (addition1Name != null && addition1Price != 0)
            {
                hamburgerPrice += addition1Price;
            }

            if (addition2Name != null && addition2Price != 0)
            {
                hamburgerPrice += addition2Price;
            }

            if(addition3Name != null && addition3Price != 0)
            {
                hamburgerPrice += addition3Price;
            }
            if (addition4Name != null && addition4Price != 0)
            {
                hamburgerPrice += addition4Price;
            }
            return hamburgerPrice;

        }

    }

}

