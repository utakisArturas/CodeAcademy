class program
{
    public static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        
        for(int i = 0; i<15; i++)
        {
            if(i%2 == 0)
            {
                Console.Write (i + " ");
            }
        }
        for(int i = 1;i<20; i++)
        {
            if(i%1 == 0 && i%3 == 0)
            {
                Console.Write("[{0}]", i);
            }
        }
        Console.WriteLine();
        Console.WriteLine("Iveskite reziu pradzia : ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Iveskite reziu pabaiga : ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        if (number1 < number2)
        {
            for (double i = number1; i <= number2; i++)
            {
                double kvad = Convert.ToDouble(i * i);
                Console.WriteLine("{0} {1} ",i,kvad);
            }
        }
        else
        {
            Console.WriteLine("Neteisingi reziai!");
        }
        Console.WriteLine("Iveskite reziu pradzia : ");
        int numb1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Iveskite reziu pabaiga : ");
        int numb2 = Convert.ToInt32(Console.ReadLine());
        if (numb1 < numb2)
        {
            for(int i = numb1; i <= numb2; i++)
            {
                if(i % 2 == 0 || i % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
            Console.ReadLine();
    }
}