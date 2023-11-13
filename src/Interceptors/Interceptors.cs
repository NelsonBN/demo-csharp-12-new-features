using System.Runtime.CompilerServices;

namespace Demo;

public static class Interceptors
{
    [InterceptsLocation(filePath: """C:\projects\my\Demos\demo-csharp-12-new-features\src\Interceptors\Program.cs""", line: 5, character: 5)]
    [InterceptsLocation(filePath: """C:\projects\my\Demos\demo-csharp-12-new-features\src\Interceptors\Program.cs""", line: 7, character: 5)]
    public static void InterceptDoSomething(this Foo obj, string value)
    {
        Console.WriteLine($"Hello Interception. The value is {value}");
    }

    [InterceptsLocation(filePath: """C:\projects\my\Demos\demo-csharp-12-new-features\src\Interceptors\Program.cs""", line: 8, character: 5)]
    public static void InterceptDoSomething2(this Foo obj, string value)
    {
        Console.WriteLine($"Hello Interception 2. The value is {value}");
    }
}
