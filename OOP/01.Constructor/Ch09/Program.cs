using System;

namespace Ch09;

class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee();
        e1.Display();
        Console.WriteLine();

        Employee e2 = new Employee(20);
        e2.Display();
    }
}