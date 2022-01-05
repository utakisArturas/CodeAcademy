using System;

namespace homeWorks1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti teigiamą skaičių.
            //Ciklo pagalba šį skaičių išvesti mažėjimo tvarka iki kol jis pasieks 0. Pvz.
            //: 5 4 3 2 1. Kiekvieną kartą išvesti skirtingose eilutėse.
            Console.WriteLine("Enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                Console.WriteLine(number);
                number--;
            }
            //Liepkite vartotojui įvesti neigiamą skaičių.
            //Ciklo pagalba šį skaičių išvesti didėjimo tvarka iki kol jis pasieks 0, taip pat išvesti 0. Pvz.
            //: -4 -3 -2 -1 0. Kiekvieną kartą išvesti toje pačioje eilutėje, skaičius atskiriant tarpais.
            Console.WriteLine("Enter negative number : ");
            int negativeNumber = Convert.ToInt32(Console.ReadLine());
            while(negativeNumber <= 0)
            {
                Console.Write($"{negativeNumber}  ");
                negativeNumber++;
            }
            Console.WriteLine();
            //Padarykite skaičiuotuvą. Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius.
            //Iš šių skaičių turi būti grąžinami visi sudėties, skirtumo, sandaugos ir dalmens atsakymai išvedant kartu ir atliekamus veiksmus. Pvz.:
            //            5 + 4 = 9    5 - 4 = 1   Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.
            
            string resume = "y";
            while(resume == "y")
            {
                Console.WriteLine("Enter 2 numbers :");
                int numb1 = Convert.ToInt32(Console.ReadLine());
                int numb2 = Convert.ToInt32(Console.ReadLine());
                int sum, minus, multiply, division;
                sum = numb1 + numb2;
                minus = numb1 - numb2;
                multiply = numb1 * numb2;
                division = numb1 / numb2;
                Console.WriteLine($"{numb1} + {numb2} = {sum}");
                Console.WriteLine($"{numb1} - {numb2} = {minus}");
                Console.WriteLine($"{numb1} * {numb2} = {multiply}");
                Console.WriteLine($"{numb1} / {numb2} = {division}");
                Console.WriteLine("Resume ? : y/n");
                resume = Convert.ToString(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
