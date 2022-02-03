using System;

namespace Ch10;

class Program
{
    static void Main(string[] args)
    {
        //
        // 직접 객체를 생성할 수 없다.
        //Employee e1 = new Employee(10);
        //
        Employee e1 = Employee.CreateWithId(10);
        e1.Display();
    }
}