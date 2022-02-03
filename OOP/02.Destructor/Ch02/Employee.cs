using System;

namespace Ch02;

// class Employee : IDisposable
// {
//     public Employee()
//     {
//         Console.WriteLine("Constructor");
//     }

//     ~Employee()
//     {
//         Console.WriteLine("Destructor");
//     }

//     public void Dispose()
//     {
//         Console.WriteLine("Dispose");
//         GC.SuppressFinalize(this);
//     }
// }

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
