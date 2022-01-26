using System;

namespace HW01
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Arturas");
            var order = new Order();


            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            
        }
    }
}
