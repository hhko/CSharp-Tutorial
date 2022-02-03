using System;

namespace Ch12;

class EmployeeFather : EmployeeGrandfather
{
    public EmployeeFather(int id, string name)
        : base(id, name, "MUMBAI")
    {
        Console.WriteLine($"EmployeeFather {id}, {name}");
    }
}