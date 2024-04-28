namespace Proxy;

internal class SharedFolder: ISharedFolder
{
    public void PerformRWOperations()
    {
        Console.WriteLine("Performing Read Write operation on the Shared Folder");
    }
}
