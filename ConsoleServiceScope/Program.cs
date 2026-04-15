Console.WriteLine("Starter opp");


var dbContext = new MyDbContext(DbContextHelper.CreateBuilder().Options);

dbContext.Database.EnsureCreated();


dbContext.Add(new MyClass("Test"));
dbContext.SaveChanges();

var res = dbContext.MyClasses.ToList();

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

