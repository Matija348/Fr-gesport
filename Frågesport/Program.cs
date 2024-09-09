{
    
    {
        // Håller reda på rätta svar
        int poäng = 0;

        // Fråga 1
        Console.WriteLine("Fråga 1: Vilken är Sveriges huvudstad?");
        Console.WriteLine("1: Malmö");
        Console.WriteLine("2: Göteborg");
        Console.WriteLine("3: Stockholm");
        string svar1 = Console.ReadLine();

        if (svar1 == "3")
        {
            Console.WriteLine("Rätt!");
            poäng++;
        }
        else
        {
            Console.WriteLine("Fel! Rätt svar är 3: Stockholm.");
        }
// Fråga 2
        Console.WriteLine("\nFråga 2: Vilket är det största djuret på jorden?");
        Console.WriteLine("1: Elefant");
        Console.WriteLine("2: Blåval");
        Console.WriteLine("3: Krokodil");
        string svar2 = Console.ReadLine();

        if (svar2 == "2")
        {
            Console.WriteLine("Rätt!");
            poäng++;
        }
        else
        {
            Console.WriteLine("Fel! Rätt svar är 2: Blåval.");
        }



