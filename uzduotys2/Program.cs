class program
{
    public static void Main()
    {
        Console.WriteLine("Write 3 number : ");
        double number,numberOne,numberTwo;
        number = Convert.ToDouble(Console.ReadLine());
        numberOne = Convert.ToDouble(Console.ReadLine());
        numberTwo = Convert.ToDouble(Console.ReadLine());
        double sum = number + numberOne + numberTwo;
        double minus = number - numberTwo;
        double multiply = number * numberTwo;

        switch (number)
        {           
            case 1 :
                Console.WriteLine(sum);
                break;
            case 2:
                Console.WriteLine(minus);
                break;
            case 3: 
                Console.WriteLine(multiply);
                break;
        }
        Console.WriteLine("Pick an animal  : Dog; Cat; Rabbit; Parrot; Rat; ");
        string animal = Convert.ToString(Console.ReadLine());
        switch (animal)
        {
            case "Dog":
                Console.WriteLine("You picked a Dog ");
                break;
            case "Cat":
                Console.WriteLine("You picked a Cat ");
                break;
            case "Rabbit":
                Console.WriteLine("You picked a Rabbit ");
                break;
            case "Parrot":
                Console.WriteLine("You picked a Parrot ");
                break;
            case "Rat":
                Console.WriteLine("You picked a Rat ");
                break;
            default:
                Console.WriteLine("You didnt pick animal");
                break;
        }
        Console.ReadLine();
    }
}