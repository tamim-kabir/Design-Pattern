namespace Iterator;

internal class EmployeeIterator(EmployeeCollection collection) : IEmployeeIterator
{
    private EmployeeCollection Collection => collection;
    private int Current = 0;
    private readonly int Step = 1;
    public Employee First()
    {
        Current = 0;
        return Collection.GetEmployee(Current);
    }
    public Employee? Next()
    {
        //Increase the Current Index Position by step (Step = 1), 
        //to access the Next Element from the collection
        Current += Step;
        if (!IsCompleted)
        {
            return Collection.GetEmployee(Current);
        }
        else
        {
            return null;
        }
    }
    // Check whether the iteration is complete
    public bool IsCompleted
    {
        //When Current >= Collection.Count, means we have accessed all the elements
        get { return Current >= Collection.Count; }
    }
}
