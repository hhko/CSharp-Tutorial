using System;

namespace Ch03;

class Employee
{
    int _id;
    int _age;
    string _name;
    string _address;

    //
    // 사용자 정의 기본 생성자 : 객체가 생성될 때 멤버 변수 값을 의미 있는 값으로 초기화 시킬 수 있다.
    //
    public Employee()
    {
        _id = 100;
        _age = 300;
        _name = "Pranaya";
        _address = "MUMBAI";
    }

    public void Display()
    {
        Console.WriteLine($"employee id is: {_id}");
        Console.WriteLine($"employee age is: {_age}");
        Console.WriteLine($"employee name is: {_name}");
        Console.WriteLine($"employee address is: {_address}");
    }
}
