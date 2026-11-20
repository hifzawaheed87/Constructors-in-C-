using System;

//  Default constructor: takes no parameters
//  called when an object is created
//  provided by the compiler if no constructor is defined in the class
class Default
{
    public Default()
    {
        Console.WriteLine("Hello World");
    }
}

class Car
{
    public Car()
    {
        Console.WriteLine("Car is created");
    }
}
class Program
{
    static void Main()
    // {
    //     Default obj = new Default();
    // }
    {
        Car o1 = new Car();
    }
}

