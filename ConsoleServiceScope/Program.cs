Console.WriteLine("Starter opp");


// myClass.WriteName();

//Console.WriteLine($"Antall klasser {classes.Count()}");


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("-- Ferdig :-) \nTrykk en tast\n-- ** --");
Console.ReadLine();


public class MyClass(string name = "Init")
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = name;

    public void WriteName()
    {
        Console.WriteLine(Name);
    }
}

