using System;

namespace HW0119
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var name =  person.Name = Convert.ToString(Console.ReadLine());
            var age =  person.Age = Convert.ToInt32(Console.ReadLine());

            person.NameCall(name,age);

            var customer = new Customer();
            var id =  customer.Id = 44;
            var CustomerName = person.Name;
            customer.CustomerId(id,CustomerName);
            

        }
    }
}
