using Iterator;

EmployeeCollection collection = new ();
collection.AddEmployee(new ("Mr. X", 100));
collection.AddEmployee(new ("Mr. A", 101));
collection.AddEmployee(new ("Mr. Z", 102));
collection.AddEmployee(new ("Mr. R", 103));
collection.AddEmployee(new ("Mr. M", 104));
collection.AddEmployee(new ("Mr. P", 105));

var iterator = collection.CreateIterator();
Console.WriteLine("Iterating over collection:");

for (var emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
{
    Console.WriteLine($"Id : {emp?.Id} & Name : {emp?.Name}");
}
Console.Read();