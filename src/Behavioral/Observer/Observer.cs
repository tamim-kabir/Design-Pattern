using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer;

internal class ObserverClass:IObserver
{
    public string UserName { get; set; }

    public ObserverClass(string userName)
    {
        UserName = userName;
    }

    public void AddSubscriber(ISubject subject)
    {
        subject.RegisterObserver(this);
    }

    public void RemoveSubscriber(ISubject subject)
    {
        subject.RemoveObserver(this);
    }
    public void Update(string availabiliy)
    {
        Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Amazon");
    }
}
