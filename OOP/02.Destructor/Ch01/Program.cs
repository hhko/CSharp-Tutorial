using System;

namespace Ch01;

class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee();
        e1 = null;

        Employee e2 = new Employee();
        e2 = null;

        Console.ReadKey();
    }
}