using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        string text;
        int i;
        int number;
        
        Console.WriteLine("Trage Text ein");
        text = Console.ReadLine()
        Console.WriteLine("Trage eine Zahl ein");
        number = (int) inputValue();
        for (i = 0; i <= number; i++)
        {
            Console.Write(text);
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
