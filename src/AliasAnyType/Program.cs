using Currency = (string Symble, double Value);

var ccy = new Currency("EUR", 9.57);

Console.WriteLine($"Currency: {ccy.Symble} Value: {ccy.Value}");

(var symble, var value) = ccy;
Console.WriteLine($"Currency: {symble} Value: {value}");

var shape = new Shape(100, 200);
Console.WriteLine($"Shape: {shape.Width} x {shape.Height}");