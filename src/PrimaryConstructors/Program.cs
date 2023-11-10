var user = new User("John", 42);
Console.WriteLine($"Name: {user.Name} - Age: {user.Age}");

var car = new Car("Mustang", 1969);
car.Print();

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