using System;
// copy constructor: takes an object of the same class as a parameter
// called when an object is created
// provided by the programmer if a constructor is defined in the class
class Copy
{
    public string city;
    public int id;
    public Copy(string c, int i)
    {
        city = c;
        id = i;
    }
    public Copy(Copy cop)
    {
        city = cop.city;
        id = cop.id;
    }
}

class Book
{
    public string title;
    public string author;
    public Book(string t, string a)
    {
        title = t;
        author = a;
    }
    public Book(Book b)
    {
        title = b.title;
        author = b.author;
    }
}
class Program2
{
    static void Main()
    // {
    //     Copy C1 = new Copy("lhr",456);
    //     Copy C2 = new Copy(C1);
    //     Console.WriteLine("City : " + C2.city);
    //     Console.WriteLine("Id : " + C2.id);
    // }
    {
        Book b1 = new Book("islam","ali");
        Book b2 = new Book(b1);
        Console.WriteLine("title : " + b2.title);
        Console.WriteLine("Author :" + b2.author);
    }
}