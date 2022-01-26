using System;

namespace HM0120
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var person = new Person(new DateTime(1992, 09, 11));
          Console.WriteLine(person.Age);
        }
    }
}
