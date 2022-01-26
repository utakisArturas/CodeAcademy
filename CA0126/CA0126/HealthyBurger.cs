using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0126
{
    internal class HealthyBurger : Hamburger
    {
        public String healthyExtra1Name;

        public double healthyExtra1Price;

        public String healthyExtra2Name;

        public double healthyExtra2Price;

        public HealthyBurger()
        {

        }
        public HealthyBurger(string meat, double price) : base("Healthy", "Lamb", 50.00, "WholeGrain bun")
        {

        }

        public void addHealthyAddition1(String name, double price)
        {
            healthyExtra1Name = name;
            healthyExtra1Price = price;
        }

        public void addHealthyAddition2(String name, double price)
        {
            healthyExtra2Name = name;
            healthyExtra2Price = price;
        }
        public override double itemizeHamburger()
        {
            double hamburgerPrice = base.itemizeHamburger();
            if (this.healthyExtra1Name != null)
            {
                hamburgerPrice += this.healthyExtra1Price;
            }
            if (this.healthyExtra2Name != null)
            {
                hamburgerPrice += this.healthyExtra1Price;
            }
            return hamburgerPrice;
        }
    }
}
