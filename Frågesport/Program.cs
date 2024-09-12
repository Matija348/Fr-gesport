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

// Fråga 3
        Console.WriteLine("\nFråga 3: Vad heter Sveriges kung?");
        Console.WriteLine("1: Carl XVI Gustaf");
        Console.WriteLine("2: Carl XII");
        Console.WriteLine("3: Carl IX");
        string svar3 = Console.ReadLine();

        if (svar3 == "1")
        {
            Console.WriteLine("Rätt!");
            poäng++;
        }
        else
        {
            Console.WriteLine("Fel! Rätt svar är 1: Carl XVI Gustaf.");
        }

        // Resultat
        Console.WriteLine($"\nDu fick {poäng} av 3 rätt!");

        // Anpassat meddelande beroende på poäng
        if (poäng == 3)
        {
            Console.WriteLine("Perfekt! Du fick alla rätt!");
        }
        else if (poäng == 2)
        {
            Console.WriteLine("Bra jobbat! Du fick 2 av 3 rätt.");
        }
        else if (poäng == 1)
        {
            Console.WriteLine("Inte dåligt! Du fick 1 av 3 rätt.");
        }
        else
        {
            Console.WriteLine("Bättre lycka nästa gång! Du fick inga rätt.");
        }
    }
}

Console.ReadLine();