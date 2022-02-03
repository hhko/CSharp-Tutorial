using System;

namespace Ch08;

public static class Employee
{
    //
    // 정적 클래스 : 정적 클래스에서는 정적 멤버 변수만 선언할 수 있다.
    //
    //int _i;
    static int _j;

    //
    // 정적 클래스 : 정적 클래스에서는 인스턴스 생성자를 포함할 수 없다.
    //
    //public Employee()
    //{
    //    _i= 100;
    //}

    static Employee()
    {
        _j = 100;
    }

    public static void Display()
    {
        Console.WriteLine($"value of _j : {_j}");
        _j++;
    }
}
