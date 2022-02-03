using System;

namespace Ch02;

class Employee
{
    int _id;
    int _age;
    string _name;
    string _address;

    //
    // 시스템 정의 기본 생성자
    // - 직접 생성자 구현이 없으면 기본 생성자를 제공한다.
    // - 객체가 생성될 때 멤버 변수 값은 기본 값으로 초기화된다(의미 있는 값으로 초기화할 수 없다)
    //

    public void Display()
    {
        Console.WriteLine($"employee id is: {_id}");
        Console.WriteLine($"employee age is: {_age}");
        Console.WriteLine($"employee name is: {_name}");
        Console.WriteLine($"employee address is: {_address}");
    }
}
