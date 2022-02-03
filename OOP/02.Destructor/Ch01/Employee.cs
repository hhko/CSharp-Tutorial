using System;

namespace Ch01;

class Employee
{
    public Employee()
    {
        Console.WriteLine("Constructor");
    }

    ~Employee()
    {
        Console.WriteLine("Destructor");
    }
}
