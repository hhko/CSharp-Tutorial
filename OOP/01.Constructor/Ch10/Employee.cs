using System;

namespace Ch10;

class Employee
{
    int _id;

    //
    // Private 생성자 : 클래스 외부에서 생성자를 호출할 수 없다.
    // 
    private Employee(int id)
    {
        _id = id;
    }

    public static Employee CreateWithId(int id)
    {
        return new Employee(id);
    }

    public void Display()
    {
        Console.WriteLine($"employee id is: {_id}");
    }
}
