static void Main (string [] args)
{
    List<string> namenListe = new List<string> ();
    string weiter;

    //Eingabe
    do {
        Console.Write("Bitte Name eingeben");
        string name = Console.ReadLine ();
        namenListe.Add (name);
        Console.WriteLine ("Weitere Eingabe(j/n)?");
        weiter = Console.ReadLine ();
    } while (weiter != "n");
    
    // Ausgabe

    Console.WriteLine ("Es sind folgende Namen erfasst worden:");
    foreach (string name in namenListe) {
        Console.WriteLine (name);
    }
}
    