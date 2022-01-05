using System;
using System.Collections.Generic;
namespace CodeAcademy0104
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Console.Write("Enter text : ");
            string oldText = Console.ReadLine();
            string newText = string.Empty;
            for (int i = oldText.Length - 1; i >= 0; i--)
            {
                newText += oldText[i];
            }
            Console.Write($"Text backwards : {newText} ");

            Console.ReadLine();
     
        }
    }
}
