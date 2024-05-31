using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int einkauf;
        int betrag;
        int rueckgeld;
        
        Console.WriteLine("Wie viel hat der Einkauf gekostet?");
        einkauf = (int) inputValue();
        Console.WriteLine("Wieviel hast du gegeben?");
        betrag = (int) inputValue();
        if (betrag > einkauf)
        {
            int diff1;
            
            diff1 = betrag - einkauf;
            Console.WriteLine("Du erhälst " + diff1);
        }
        else
        {
            int diff2;
            
            diff2 = betrag - einkauf;
            Console.WriteLine("Es fehlen " + diff2);
        }
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
