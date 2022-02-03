using System;

namespace Ch07;

class Employee
{
    int _i;
    static int _j;

    public Employee()
    {
        _i= 100;
    }

    static Employee()
    {
        _j = 100;

        //
        // 정적 생성자는 정적 멤버 변수만 접근 가능하다.
        //
        //_i = 100;
    }

    //
    // 정적 생성자는 접근 제어자(public, ...)가 없어야 한다.
    //
    // public static Employee()
    // {
    // }

    //
    // 정적 생성자는 매개변수가 없어야 한다.
    // static Employee(int x)
    // {
    // }

    public void Display()
    {
        Console.WriteLine($"value of _i : {_i}");
        _i++;
        Console.WriteLine($"value of _j : {_j}");
        _j++;
    }
}
