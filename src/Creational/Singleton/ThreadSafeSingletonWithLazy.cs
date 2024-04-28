namespace Singleton;

internal sealed class ThreadSafeSingletonWithLazy
{
    private static int Counter = 0;

    private static readonly Lazy<ThreadSafeSingletonWithLazy> _instance = new Lazy<ThreadSafeSingletonWithLazy>(() => new ThreadSafeSingletonWithLazy());

    private ThreadSafeSingletonWithLazy()
    {
        Counter++;
        Console.WriteLine("Counter Value " + Counter.ToString());
    }
    public static ThreadSafeSingletonWithLazy GetInstance()
    {
        return _instance.Value;
    }
    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}
