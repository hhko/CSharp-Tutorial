using System;

namespace Ch05;

class Employee
{
    int _id;
    int _age;
    string _name;
    string _address;

    public Employee()
    {
        Console.WriteLine("ENTER EMPLOYEE DETAILS");

        Console.WriteLine("Enter the employee id");
        _id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the employee age");
        _age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the employee name");
        _name = Console.ReadLine();

        Console.WriteLine("Enter the employee address:");
        _address = Console.ReadLine();
    }

    // Case 1.
    // 복사 생성자 : 동잃한 상태를 갖는 객체를 생성한다.
    //
    public Employee(Employee previousEmployee)
    {
        _id = previousEmployee._id;
        _age = previousEmployee._age;
        _name = previousEmployee._name;
        _address = previousEmployee._address;
    }

    public void Display()
    {
        Console.WriteLine($"employee id is: {_id}");
        Console.WriteLine($"employee age is: {_age}");
        Console.WriteLine($"employee name is: {_name}");
        Console.WriteLine($"employee address is: {_address}");
    }
}
