﻿namespace Iterator;

internal class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }
}
