using System;

namespace Ch01;

class Program
{
    Program()
    {
        Console.WriteLine("This is Constructor method");
    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        Console.WriteLine("This is Main method");
    }
}
