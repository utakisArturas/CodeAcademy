using System;

namespace CA0113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NameCall call = new NameCall();
            call.CallName("Arturas");
            call.CallName("Arturas", 10);


            NumberOfChars numberOfChars = new NumberOfChars();
            numberOfChars.CharCount("Lietuva");
            Console.ReadLine();


            Kmi kmi = new Kmi();
            kmi.CoutBodyMass(85, 1.88);


            CountSpacesService countSpacesService = new CountSpacesService();
            countSpacesService.SpaceCount("This te xt ha ve 4 spa ces.");

            ArrayCountService arrayCountService = new ArrayCountService();
            arrayCountService.SumOfArary(new int[] { 1, 2, 3, });

            PowerOfService powerOfService = new PowerOfService();
            powerOfService.CountPower(2, 3);
            


        }
    }
}
