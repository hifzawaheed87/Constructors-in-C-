using System;
//  parameterized constructor: takes parameters
//  called when an object is created
//  provided by the programmer if a constructor is defined in the class
class Parameterized
{
    public string name;
    public int age;
    public Parameterized(string n,int a)
    {
        name = n;
        age = a;
    }
}

class Employee
{
    public string naam;
    public int salary;
    public Employee(string m,int s)
    {
        naam = m;
        salary =s;
    }
}
class Program1
{
    static void Main()
    // {
    //     Parameterized obj1 = new Parameterized("Ali", 20);
    //     Console.WriteLine("Name : " + obj1.name);
    //     Console.WriteLine("Age : " + obj1.age); 
    // }   
    {
        Employee e1 = new Employee("ahmad",70000);
        Console.WriteLine("Name : " + e1.naam);
        Console.WriteLine("Salary : " + e1.salary);
    }
}