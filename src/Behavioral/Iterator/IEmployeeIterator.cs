namespace Iterator;

internal interface IEmployeeIterator
{
    Employee First();
    Employee? Next();
    bool IsCompleted { get; }
}
