var addWithDefault = (int addTo = 2) => addTo + 1;

Console.WriteLine($"Add {addWithDefault(5)}");
Console.WriteLine($"Add with default {addWithDefault()}");


var counter = (params int[] xs) => xs.Length;

Console.WriteLine($"Counter {counter()}");
Console.WriteLine($"Counter {counter(1, 2, 3)}");
Console.WriteLine($"Counter {counter(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)}");