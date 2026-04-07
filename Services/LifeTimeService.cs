namespace ServiceScope.Services;

public class LifeTimeService: ISingletonService
{
    private readonly Guid _instanceId = Guid.NewGuid();
    private readonly string _createdAt = DateTime.UtcNow.ToString("O");
    private int _usageCount;
    public string Name { get; set; } = "Init";

    public override string ToString()
    {
        return "<div>" +
               "<ul>" +
               $"<li>Name: {Name}</li>" +
               $"<li>InstanceId: {_instanceId}</li>" +
               $"<li>UsageCount: {++ _usageCount}</li>" +
               $"<li>CreatedAt: {_createdAt}</li>" +
               "</ul>" +
               "</div>";
    }
}

