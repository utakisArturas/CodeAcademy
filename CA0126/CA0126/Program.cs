using System;

namespace CA0126
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var burger = new Hamburger("Deluxe", "Chicken", 19.10, "Deluxe Bread");
            burger.addHamburgerChoice1("Tomato", 0.27);
            burger.addHamburgerChoice2("Lettuce", 0.75);
            burger.addHamburgerChoice3("Cheese", 1.13);
            Console.WriteLine($"Total Burger price is : {burger.itemizeHamburger()}");

            var deluxeBurger = new DeluxeBurger();
            deluxeBurger.addHamburgerChoice1("Cheese", 1.50);
            Console.WriteLine($"Total Deluxe burger price is : {deluxeBurger.itemizeHamburger()}");

            var healthyBurger = new HealthyBurger("Bacon", 50);
            healthyBurger.addHealthyAddition1("Egg", 5.00);
            healthyBurger.addHealthyAddition2("Ham", 5.00);
            Console.WriteLine($"Total Healthy burger price is : {healthyBurger.itemizeHamburger()}");



        }
    }
}
