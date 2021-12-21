class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Suskaičiuoti kiek duonos kepalų kepykla sugebės iškepti per dieną, ar spės įgyvendinti visus dienos užsakymus");
        double workHours = 8;
        Console.WriteLine("Kiek darbuotojas gali iškepti kepalų per valandą : ?");
        double duonuoKepalai = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Kiek darbuotojų turi kepykla : ? ");
        double gamyklosDdarbuotojai = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Vieno kepalo savikaina : ?");
        double savikaina = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Vieno kepalo pardavimo kaina : ? ");
        double pardavimoKaina = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Kiek kepykla turi tą dieną iškepti kepalų (užsakymai) : ? ");
        double uzsakymai = Convert.ToDouble(Console.ReadLine());

        double iskeptuKepalu = workHours *  gamyklosDdarbuotojai * duonuoKepalai;
        double iskeptuSavikaina = iskeptuKepalu * savikaina;
        double iskeptuPajamos = iskeptuKepalu * pardavimoKaina;
        double iskeptuPelnas = iskeptuPajamos - iskeptuSavikaina;
        Console.WriteLine("kepykla per vieną darbo dieną spės iškepti duonos kepalų : {0}",iskeptuKepalu);
        Console.WriteLine("iškeptš duonos kepalų savikaina : {0}", iskeptuSavikaina);
        Console.WriteLine("Gautos pajamos iš pardavimų : {0}",iskeptuPajamos);
        Console.WriteLine("Pelnas : {0}", iskeptuPelnas);

        if (uzsakymai > iskeptuKepalu)
        {
            double skirtumas = uzsakymai - iskeptuKepalu;
            Console.WriteLine("Šiandien nepėsite iškepti : {0} kepalų duonos.",skirtumas);
        }
        else
        {
            Console.WriteLine("Užsakymai bus įvykdyti.");
        }
        Console.ReadLine();
    }
}