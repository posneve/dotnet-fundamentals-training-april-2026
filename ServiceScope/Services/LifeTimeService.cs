namespace ServiceScope.Services;

public class LifeTimeService
{
    private readonly string _id = IdGenerator.Generate();
    private readonly string _createdAt = DateTime.UtcNow.ToString("O");
    private int _usageCount;
    public virtual string Name { get; set; } = "Initial";

    public override string ToString()
    {
        return "<div style='border: 1px solid black; padding: 10px; margin: 10px;'>" +
               "<table>" +
               $"<tr><td>ID:</td><td><b>{_id}</b></td></tr>" +
               $"<tr><td>Name:</td><td>{Name}</td></tr>" +
               $"<tr><td>Usage count:</td><td>{++ _usageCount}</td></tr>" +
               $"<tr><td>Created at:</td><td>{_createdAt}</td></tr>" +
               "</table>" +
               "</div>";
    }


    public void WriteMessage()
    {
        Console.WriteLine($"My name is {Name}");
    }
}

public class SingletonLifeTimeService(LifeTimeService lifeTime) : LifeTimeService
{
    public override string Name { get; set; } = "Singleton";
}
