class program
{
    public static void Main()
    {
        Console.WriteLine("Iveskite tris sveikuosius skaicius ; ");
        int pirmasSkaicius, antrasSkaicius, treciasSkaicius;
        pirmasSkaicius = Convert.ToInt32(Console.ReadLine());
        antrasSkaicius = Convert.ToInt32(Console.ReadLine());
        treciasSkaicius = Convert.ToInt32(Console.ReadLine());

        if (pirmasSkaicius == antrasSkaicius)
        {
            Console.WriteLine("pirmas skaicius: {0} ir antras skaicius: {1} yra lygus.", pirmasSkaicius, antrasSkaicius);
        }
        else
        {
            Console.WriteLine("Skaiciai nevienodi. {0} != {1}.", pirmasSkaicius, antrasSkaicius);
        }
        Console.ReadLine();
        /*
         * 
         * 
         */

        if (antrasSkaicius == treciasSkaicius)
        {
            Console.WriteLine("antras skaicius:{0} ir trecias skaicius:{1} yra lygus.", antrasSkaicius, treciasSkaicius);
        }
        else
        {
            Console.WriteLine("Skaiciai nevienodi. {0} != {1}", antrasSkaicius, treciasSkaicius);
        }
        Console.ReadLine();
        /*
         * 
         * 
         */
        if(pirmasSkaicius > antrasSkaicius)
        {
            Console.WriteLine("Pirmas skaicius: {0} yra didesnis uz antra: {1} skaiciu.",pirmasSkaicius,antrasSkaicius);
        }
        else
        {
            Console.WriteLine("Pirmas skaicius: {0} nera didesnis uz antra: {1} skaiciu.",pirmasSkaicius,antrasSkaicius);
        }
        Console.ReadLine();
        /*
         * 
         * 
         */
        if (antrasSkaicius > treciasSkaicius * 2)
        {
            Console.WriteLine("Antras skaicius: {0} yra didesnis uz trecia: {1} skaiciu kart 2.",antrasSkaicius,treciasSkaicius);
        }
        else
        {
            Console.WriteLine("Antras skaicius: {0} nera didesnis uz trecia skaiciu: {1} kart 2.",antrasSkaicius,treciasSkaicius);
        }
        Console.ReadLine();
        /*
         * 
         * 
         */

        if(antrasSkaicius%2 ==0)
        {
            Console.WriteLine("Antras skaicius: {0} yra lyginis.",antrasSkaicius);
        }
        else
        {
            Console.WriteLine("Skaicius nera lyginis.");
        }
        Console.ReadLine();
        /*
        * 
        * 
        */
        if (treciasSkaicius % 2 != 0)
        {
            Console.WriteLine("Trecias skaicius: {0} yra nelyginis.", treciasSkaicius);
        }
        else
        {
            Console.WriteLine("Skaicius yra lyginis: {0}.", treciasSkaicius);
        }
        Console.ReadLine();
        /*
        * 
        * 
        */
        Console.WriteLine("Iveskite savo amziu : ");
        int amzius = Convert.ToInt32(Console.ReadLine());
        if(amzius > 18)
        {
            Console.WriteLine("Jus galite balsuoti.");
        }
        else
        {
            Console.WriteLine("Jus dar per jaunas balsuoti.");
        }
        Console.WriteLine("Iveskite bet koki teigiama skaiciu : ");
        int randomNumber = Convert.ToInt32(Console.ReadLine());
        if(randomNumber > 0)
        {
            Console.Write("Sveikinam, skaicius teigiamas!");
        }
        else
        {
            Console.WriteLine("Ivedete neigiama skaiciu ! {0}",randomNumber);
        }
        Console.ReadLine();
        /*
        * 
        * 
        */
        if(randomNumber%4 == 0)
        {
            Console.WriteLine("Sveikinam, skaiciu dalinasi is 4.");
        }
        else
        {
            Console.WriteLine("Skaicius nesidalina is 4. Jusu skaicius yra : {0}",randomNumber);
        }
        Console.ReadLine();
        /*
        * 
        * 
        */
        Console.WriteLine("Iveskite savo 3 pazymius :");
        int pazimys1, pazimys2, pazimys3;
        pazimys1 = Convert.ToInt32(Console.ReadLine());
        pazimys2 = Convert.ToInt32(Console.ReadLine());
        pazimys3 = Convert.ToInt32(Console.ReadLine());

        double vidurkis = (pazimys1 + pazimys2 + pazimys3) / 3;
        Convert.ToDouble(vidurkis);
        if(vidurkis >= 5)
        {
            Console.WriteLine("Jusu pazymys teigiamas! {0}", vidurkis);
        }
        else
        {
            Console.WriteLine("Jusu pazimys neigiamas! {0}", vidurkis);
        }
        Console.ReadLine();
        /*
        * 
        * 
        */
        Console.WriteLine("Iveskite skaiciu : ");
        double randomNumber2 = Convert.ToDouble(Console.ReadLine());
        if(randomNumber2%5 == 0)
        {
            Console.WriteLine( randomNumber2 * 1);
            Console.WriteLine(randomNumber2 * 2);
            Console.WriteLine(randomNumber2 * 3);
            Console.WriteLine(randomNumber2 * 4);
            Console.WriteLine(randomNumber2 * 5);
        }
        Console.ReadLine();
        if(randomNumber2%2 == 0)
        {
            Console.WriteLine("Jusu skaiciu penktuoju laipsniu : " + randomNumber2 * randomNumber2 * randomNumber2 * randomNumber2 * randomNumber2);
        }
        Console.ReadLine();
        if(randomNumber2%4 == 0)
        {
            Double naujasNumber = Convert.ToDouble(Console.ReadLine());
            double sandauga = randomNumber2 * naujasNumber;
            double suma = randomNumber2 + naujasNumber;
            Console.WriteLine("Skaiciu suma = {0}.",suma);
            Console.WriteLine("Skaiciu sandauga = {0}",sandauga);
        }
        else
        {
            Console.WriteLine("Jusu skaicius nesidalina is 4. Jusu skaicius : {0}", randomNumber2);
        }
        Console.ReadLine();
        /*
        * 
        * 
        */

    }
}