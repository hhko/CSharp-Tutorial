using System;

namespace Ch04;

class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee(100, 30, "Pranaya", "Mumbai");
        e1.Display();
        Console.WriteLine();

        Employee e2 = new Employee(101, 28, "Rout", "BBSR");
        e2.Display();
    }
}