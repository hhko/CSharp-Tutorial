using System;

namespace Ch07;

class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee();
        e1.Display();
        e1.Display();
        Console.WriteLine();

        Employee e2 = new Employee();
        e2.Display();
        e2.Display();
    }
}