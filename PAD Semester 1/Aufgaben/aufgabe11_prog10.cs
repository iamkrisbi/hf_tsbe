using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        string text;
        int result;
        
        Console.WriteLine("schreib einen Satz");
        text = Console.ReadLine()
        // for (Name = Start; Name <= End; Name += Step)
        // {
        // }
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
