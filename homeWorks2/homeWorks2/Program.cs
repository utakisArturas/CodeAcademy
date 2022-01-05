using System;

namespace homeWorks2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti teigiamą skaičių.
            //Ciklo pagalba šį skaičių išvesti mažėjimo tvarka iki kol jis pasieks 0. Pvz.:
            //5 4 3 2 1. Kiekvieną kartą išvesti skirtingose eilutėse.
            Console.WriteLine($"Enter positive number :");
            int numb = Convert.ToInt32(Console.ReadLine());
            while (numb >= 0)
            {
                Console.WriteLine(numb);
                numb--;
            }
            //Liepkite vartotojui įvesti neigiamą skaičių.
            //Ciklo pagalba šį skaičių išvesti didėjimo tvarka iki kol jis pasieks 0, taip pat išvesti 0. Pvz.:
            //-4 -3 -2 -1 0. Kiekvieną kartą išvesti toje pačioje eilutėje, skaičius atskiriant tarpais.
            Console.WriteLine($"Enter negative number : ");
            int negativeNumb = Convert.ToInt32(Console.ReadLine());
            while (negativeNumb <= 0)
            {
                Console.Write($"{negativeNumb} ");
                negativeNumb++;
            }
            Console.ReadLine();
            //Padarykite skaičiuotuvą. Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius.
            //Iš šių skaičių turi būti grąžinami visi sudėties, skirtumo, sandaugos ir dalmens atsakymai išvedant kartu ir atliekamus veiksmus. Pvz.:
            //5 + 4 = 9;  5 - 4 = 1; Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.
            Console.WriteLine("Calculator");
            char yesNo = 'y';

            while (yesNo == 'y')
            {
                Console.WriteLine("Enter 2 digits : ");
                double numb1, numb2;
                numb1 = Convert.ToDouble(Console.ReadLine());
                numb2 = Convert.ToDouble(Console.ReadLine());

                double sum, minus, multiply, divide;
                sum = numb1 + numb2;
                minus = numb1 - numb2;
                multiply = numb1 * numb2;
                divide = numb1 / numb2;
                Console.WriteLine("Choose operator : + - * / ");
                char calc = Convert.ToChar(Console.ReadLine());
                switch (calc)
                {
                    case '+':
                        Console.WriteLine($"{numb1} + {numb2} = {sum}");
                        break;
                    case '-':
                        Console.WriteLine($"{numb1} - {numb2} = {minus}");
                        break;
                    case '*':
                        Console.WriteLine($"{numb1} * {numb2} = {multiply}");
                        break;
                    case '/':
                        Console.WriteLine($"{numb1} / {numb2} = {divide}");
                        break;
                    default:
                        Console.WriteLine("Wrong operator.");
                        break;
                }
                Console.WriteLine("Do you wish to continue ? : y/n");
                yesNo = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
