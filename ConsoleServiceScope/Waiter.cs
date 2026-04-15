namespace ConsoleServiceScope;

public class Waiter
{
    public static async Task<int> WaitTask(int taskNo, int waitMs = 100)
    {
        return await WaitInternalTask(taskNo, waitMs);
        
    }
    private static async Task<int> WaitInternalTask(int taskNo, int waitMs)
    {
        WriteLine($"Task number started {taskNo}");
        await Task.Delay(waitMs);
        WriteLine($"Task number finished {taskNo}, waited {waitMs} ms");

        return await Task.FromResult(taskNo);
    }


    private static void WriteLine(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    
    
    private static void ThrowException(int level)
    {
        if (level == 0) 
            throw new Exception("Failed");
        ThrowException(--level);
    }
}