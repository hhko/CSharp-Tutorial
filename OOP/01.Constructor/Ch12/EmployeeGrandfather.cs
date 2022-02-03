using System;

namespace Ch12;

class EmployeeGrandfather
{
    int _id;
    string _address;
    string _name;

    public EmployeeGrandfather(int id, string name, string address)
    {
        _id = id;
        _name = name;
        _address = address;

        Console.WriteLine($"EmployeeGrandfather {_id}, {_name}, {_address}");
    }
}