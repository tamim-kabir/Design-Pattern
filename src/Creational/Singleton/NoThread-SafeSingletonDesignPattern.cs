namespace Singleton;

internal sealed class NoThread_SafeSingletonDesignPattern
{
    private static int Counter = 0;

    private static NoThread_SafeSingletonDesignPattern? Instance = null;

    public static NoThread_SafeSingletonDesignPattern GetInstance()
    {
        if (Instance == null)
        {
            Instance = new NoThread_SafeSingletonDesignPattern();
        }
        return Instance;
    }
    private NoThread_SafeSingletonDesignPattern()
    {
        Counter++;
        Console.WriteLine("Counter Value " + Counter.ToString());
    }
    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}
