
var buffer = new Buffer();
for (var i = 0; i < 10; i++)
{
    buffer[i] = i * i;
    Console.WriteLine($"buffer[{i}] = {buffer[i]}");
}


[System.Runtime.CompilerServices.InlineArray(10)]
public struct Buffer
{
    private int _element0;
}