namespace Singleton;

internal class EagerLoadingSingletonDesignPattern
{
    private static int Counter = 0;
    private static readonly EagerLoadingSingletonDesignPattern singleInstance = new EagerLoadingSingletonDesignPattern();

    public static EagerLoadingSingletonDesignPattern GetInstance()
    {
        return singleInstance;
    }
    private EagerLoadingSingletonDesignPattern()
    {
        Counter++;
        Console.WriteLine("Counter Value " + Counter.ToString());
    }

    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}
