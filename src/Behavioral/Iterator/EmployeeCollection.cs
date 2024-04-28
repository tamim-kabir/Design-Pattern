namespace Iterator;

internal class EmployeeCollection : IEmployeeCollection
{
    private List<Employee> listEmployees = new List<Employee>();
    public EmployeeIterator CreateIterator()
    {
        return new EmployeeIterator(this);
    }
    public int Count
    {
        get { return listEmployees.Count; }
    }
    public void AddEmployee(Employee employee)
    {
        listEmployees.Add(employee);
    }
    public Employee GetEmployee(int index)
    {
        return listEmployees[index];
    }
}
