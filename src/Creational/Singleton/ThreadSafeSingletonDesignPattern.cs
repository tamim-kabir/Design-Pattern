namespace Singleton;
internal sealed class ThreadSafeSingletonDesignPattern
{
    private static int Counter = 0;
    private static ThreadSafeSingletonDesignPattern? Instance = null;
    private static readonly object InstanceLock = new object();
    public static ThreadSafeSingletonDesignPattern GetInstance()
    {
        //Double Check because of the thread-Safety
        if (Instance == null)
        {
            //As long as one thread locks the resource, no other thread can access the resource
            lock (InstanceLock)
            {
                if (Instance == null)
                {
                    Instance = new ThreadSafeSingletonDesignPattern();
                }
            }
        }
        return Instance;
    }

    private ThreadSafeSingletonDesignPattern()
    {
        Counter++;
        Console.WriteLine("Counter Value " + Counter.ToString());
    }
    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}
