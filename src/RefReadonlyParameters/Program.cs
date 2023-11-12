var x = 11;

Sum1(ref x);
Console.WriteLine(x);


var y = 21;
Sum2(ref y);


static void Sum1(ref int x)
{
    x += 1;
}

static void Sum2(ref readonly int intput)
{
    Console.WriteLine(intput);
}