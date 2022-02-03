using System;

namespace Ch04;

class Employee
{
    int _id;
    int _age;
    string _address;
    string _name;

    //
    // 사용자 정의 생성자
    //
    public Employee(int id, int age, string name, string address)
    {
        _id = id;
        _age = age;
        _name = name;
        _address = address;
    }

    public void Display()
    {
        Console.WriteLine($"employee id is: {_id}");
        Console.WriteLine($"employee age is: {_age}");
        Console.WriteLine($"employee name is: {_name}");
        Console.WriteLine($"employee address is: {_address}");
    }
}
