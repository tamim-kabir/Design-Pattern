using Singleton;

var fromFirst = EagerLoadingSingletonDesignPattern.GetInstance();
fromFirst.PrintDetails("From First");

var fromSecond = EagerLoadingSingletonDesignPattern.GetInstance();
fromSecond.PrintDetails("From Second");

Console.ReadKey();
