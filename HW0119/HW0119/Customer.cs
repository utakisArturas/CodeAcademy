using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0119
{
    internal class Customer
    {
        public int Id;
        public string Name;

        public Customer()
        {
            this.Id = Id;
            this.Name = Name;
        }

        public void CustomerId(int Id, string Name )
        {
            Console.WriteLine($"Customer : {Id} {Name}");
        }
    }
}
