using Demo;

var foo = new Foo();

foo.DoSomething("Hello 1");
foo.DoSomething("Hello 2");
foo.DoSomething("Hello 3");
foo.DoSomething("Hello 3");

public class Foo
{
    public void DoSomething(string value)
    {
        Console.WriteLine($"Welcome to C# 12. The value is {value}");
    }
}
