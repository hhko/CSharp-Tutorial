using System;

namespace Ch12;

class Employee : EmployeeFather
{
    public Employee(int id)
        : base(id, "Pranaya")
    {
        Console.WriteLine($"Employee {id}");
    }
}
