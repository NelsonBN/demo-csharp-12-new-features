
var buffer = new Buffer<int>();
for (var i = 0; i < 10; i++)
{
    buffer[i] = i * i;
    Console.WriteLine($"buffer[{i}] = {buffer[i]}");
}


[System.Runtime.CompilerServices.InlineArray(10)]
public struct Buffer<T>
{
    private T _element0;
}