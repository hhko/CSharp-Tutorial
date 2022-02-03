using System;

namespace Ch09;

class Employee
{
    int _id;

    public Employee()
    {
        _id = 10;
    }

    public Employee(int id)
    {
        _id = id;
    }

    public void Display()
    {
        Console.WriteLine($"employee _id is: {_id}");
    }
}
