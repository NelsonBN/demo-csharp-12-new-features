// Example of primary constructors with classes and structs
using Microsoft.Extensions.DependencyInjection;

var user = new User("John", 42);
Console.WriteLine($"Name: {user.Name} - Age: {user.Age}");

var car = new Car("Mustang", 1969);
car.Print();

var person = new Person(Guid.NewGuid(), "John", 42);
person.Print();


// Example of primary constructors with Dependency Injection
var services = new ServiceCollection();
services.AddSingleton<MyService>();
services.AddSingleton<DateFormatter>();

var provider = services.BuildServiceProvider();

var myService = provider.GetRequiredService<MyService>();
myService.Run();



public class User(string Name, int Age)
{
    public string Name { get; } = Name;
    public int Age { get; } = Age;
}

public class Car(string Model, int Year)
{
    public void Print()
    {
        Console.WriteLine($"Model: {Model} - Year: {Year}");
    }
}

public struct Person(Guid Id, string Name, int Age)
{
    public void Print()
    {
        Console.WriteLine($"Id: {Id} - Name: {Name} - Age: {Age}");
    }
}

// Be careful because the properties in the primary constructor aren't readonly (They are mutable)
public class MyService(DateFormatter Formatter)
{
    public void Run()
    {
        Console.WriteLine($"Today is {Formatter.Format(DateTime.Now)}");
    }
}

public class DateFormatter()
{
    public string Format(DateTime date)
    {
        return date.ToString("dd/MM/yyyy");
    }
}