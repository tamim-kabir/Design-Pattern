﻿namespace Adapter;

internal class EmployeeAdapter : ITarget
{
    public void ProcessCompanySalary(string[,] employeesArray)
    {
        BillingSystem billingSystem = new BillingSystem();
        string Id = string.Empty;
        string Name = string.Empty;
        string Designation = string.Empty;
        string Salary = string.Empty;
        List<Employee> listEmployee = new List<Employee>();
        for (int i = 0; i < employeesArray.GetLength(0); i++)
        {
            for (int j = 0; j < employeesArray.GetLength(1); j++)
            {
                if (j == 0)
                {
                    Id = employeesArray[i, j];
                }
                else if (j == 1)
                {
                    Name = employeesArray[i, j];
                }
                else if (j == 2)
                {
                    Designation = employeesArray[i, j];
                }
                else
                {
                    Salary = employeesArray[i, j];
                }
            }
            listEmployee.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
        }
        Console.WriteLine("Adapter converted Array of Employee to List of Employee");
        Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
        billingSystem.ProcessSalary(listEmployee);
    }
}
