﻿namespace Observer;

internal class Subject : ISubject
{
    private List<IObserver> observers = new List<IObserver>();

    private string ProductName { get; set; }
    private int ProductPrice { get; set; }
    private string Availability { get; set; }

    public Subject(string productName, int productPrice, string availability)
    {
        ProductName = productName;
        ProductPrice = productPrice;
        Availability = availability;
    }
    //The following Method is going to return the State of the Product
    public string GetAvailability()
    {
        return Availability;
    }
    //The following Method is going to set the State of the Product
    public void SetAvailability(string availability)
    {
        this.Availability = availability;
        Console.WriteLine("Availability changed from Out of Stock to Available.");
        NotifyObservers();
    }
    // The observer will register with the Product using the following method
    public void RegisterObserver(IObserver observer)
    {
        Console.WriteLine("Observer Added : " + ((ObserverClass)observer).UserName);
        observers.Add(observer);
    }

    // The observer will unregister from the Product using the following method
    public void RemoveObserver(IObserver observer)
    {
        Console.WriteLine("Observer Removed : " + ((ObserverClass)observer).UserName);
        observers.Remove(observer);
    }
    // The following Method will be sent notifications to all observers
    public void NotifyObservers()
    {
        Console.WriteLine("Product Name :"
                        + ProductName + ", product Price : "
                        + ProductPrice + " is Now available. So, notifying all Registered users ");
        Console.WriteLine();
        foreach (IObserver observer in observers)
        {
            //By Calling the Update method, we are sending notifications to observers
            observer.Update(Availability);
        }
    }
}
